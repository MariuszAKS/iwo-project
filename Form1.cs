using System.Diagnostics;
using System.Numerics;
using Timer = System.Windows.Forms.Timer;
using System.Xml.Linq;

namespace IWO
{
    enum StartPopulationArrangement {
        Random, Center, Corners, Grid
    }

    public partial class Form1 : Form
    {
        class Weed : IComparable<Weed>
        {
            public Vector2 position = new(0, 0);
            public double fitness = 0;

            public int CompareTo(Weed? obj)
            {
                return fitness.CompareTo(obj?.fitness);
            }
        }

        private StartPopulationArrangement arrangement = StartPopulationArrangement.Random;

        private int initialPopulationSize = 0;
        private int maxPopulationSize = 0;

        private int currentGenerationId = 0;
        private int maxGenerationId = 0;

        private int seedMin = 0, seedMax = 0;

        private TestFunction testFunction = new();
        private List<Weed> currentWeedPopulation = [];

        private double best_fitness, worst_fitness;

        private Timer simulationTimer = new();

        // Variables for calculating new weed's position
        private int n = 2; // here to decide how fast sigma tends to 0 (higher = faster, 1 = linear, n<1 = faster near end, n>1 = slower near end, n=0 doesn't change, n<0 = goes to infinity)
        private float sigmaInit = 1.0f;
        private float sigmaFinal = 0.001f;
        private float initialOffspringMaxDistance;

        // Variables for displaying results
        private Vector2 positionOnScreenModifier;
        private Bitmap populationBitmap;
        private Graphics populationGraphics;
        private Pen populationPen;
        private Pen populationEraser;
        private Color populationColor = Color.DarkGreen;

        private Bitmap fitnessBitmap;
        private Graphics fitnessGraphics;
        private Pen fitnessPen;
        private Color fitnessColor = Color.Black;



        public Form1()
        {
            InitializeComponent();

            PrepareGraphics();
            GetInitialValuesFromUI();
            PopulateComboBoxes();
        }

        private void PrepareGraphics()
        {
            populationBitmap = new Bitmap(picB_populationSpace.Width, picB_populationSpace.Height);
            populationGraphics = Graphics.FromImage(populationBitmap);
            populationPen = new Pen(populationColor, 2);

            picB_populationSpace.Image = populationBitmap;

            positionOnScreenModifier.Y = picB_populationSpace.Height / (testFunction.Height);
            positionOnScreenModifier.X = picB_populationSpace.Width / (testFunction.Width);
        }

        private void GetInitialValuesFromUI() // It's here to update values in code by values set up in editor (before running the app)
        {
            numUD_initialPopulationSize_ValueChanged(numUD_initialPopulationSize, EventArgs.Empty);
            numUD_maxPopulationSize_ValueChanged(numUD_maxPopulationSize, EventArgs.Empty);
            numUD_generationsCount_ValueChanged(numUD_generationsCount, EventArgs.Empty);
            numUD_seedMin_ValueChanged(numUD_seedMin, EventArgs.Empty);
            numUD_seedMax_ValueChanged(numUD_seedMax, EventArgs.Empty);
        }

        private void PopulateComboBoxes()
        {
            foreach (StartPopulationArrangement arr in Enum.GetValues(typeof(StartPopulationArrangement)))
            {
                cmbBox_initialPopulationArrangement.Items.Add(arr.ToString());
            }
            foreach (TestFunctionEnum tst in Enum.GetValues(typeof(TestFunctionEnum)))
            {
                cmbBox_testFunction.Items.Add(tst.ToString());
            }

            cmbBox_initialPopulationArrangement.SelectedIndex = 0;
            cmbBox_testFunction.SelectedIndex = 0;
        }

        

        private void numUD_initialPopulationSize_ValueChanged(object sender, EventArgs e)
        {
            initialPopulationSize = (int)numUD_initialPopulationSize.Value;
            InitiatePopulation();
        }

        private void numUD_maxPopulationSize_ValueChanged(object sender, EventArgs e)
        {
            maxPopulationSize = (int)numUD_maxPopulationSize.Value;
        }

        private void numUD_generationsCount_ValueChanged(object sender, EventArgs e)
        {
            maxGenerationId = (int)numUD_generationsCount.Value;
        }

        private void numUD_seedMin_ValueChanged(object sender, EventArgs e)
        {
            seedMin = (int)numUD_seedMin.Value;

            if (seedMin > seedMax)
            {
                numUD_seedMax.Value = seedMin;
            }
        }

        private void numUD_seedMax_ValueChanged(object sender, EventArgs e)
        {
            seedMax = (int)numUD_seedMax.Value;

            if (seedMax < seedMin)
            {
                numUD_seedMin.Value = seedMax;
            }
        }



        private void cmbBox_testFunction_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTestFunction();
            InitiatePopulation();
        }

        private void cmbBox_initialPopulationArrangement_SelectedIndexChanged(object sender, EventArgs e)
        {
            arrangement = (StartPopulationArrangement)cmbBox_initialPopulationArrangement.SelectedIndex;
            InitiatePopulation();
        }

        private void btn_repopulate_Click(object sender, EventArgs e)
        {
            InitiatePopulation();
        }

        private void UpdateTestFunction()
        {
            testFunction.ChangeTestFunction((TestFunctionEnum)cmbBox_testFunction.SelectedIndex);

            positionOnScreenModifier.Y = picB_populationSpace.Height / (testFunction.Height);
            positionOnScreenModifier.X = picB_populationSpace.Width / (testFunction.Width);

            lbl_bordersX.Text = $"< {testFunction.MinX} ; {testFunction.MaxX} >";
            lbl_bordersY.Text = $"< {testFunction.MinY} ; {testFunction.MaxY} >";
            lbl_minPositions.Text = "";
            lbl_minValue.Text = $"{testFunction.GlobalMinValue}";

            foreach (Vector2 pos in testFunction.GlobalMinPositions)
            {
                lbl_minPositions.Text += $"( {pos.X} ; {pos.Y} ) \n";
            }

            initialOffspringMaxDistance = Math.Min(testFunction.Height, testFunction.Width) * 0.25f; // initially max potendial distance is 1/4 of smaller dimension
        }

        private void InitiatePopulation()
        {
            ClearPopulationDisplay();
            currentWeedPopulation.Clear();

            Random rng = new();
            int i = 0;

            float center_x = testFunction.MinX + testFunction.Width / 2;
            float center_y = testFunction.MinY + testFunction.Height / 2;

            for (i = 0; i < initialPopulationSize; i++)
            {
                currentWeedPopulation.Add(new Weed());
            }

            switch (arrangement)
            {
                case StartPopulationArrangement.Random:
                    for (i = 0; i < initialPopulationSize; i++)
                    {
                        float x = rng.NextSingle() * testFunction.Width + testFunction.MinX;
                        float y = rng.NextSingle() * testFunction.Height + testFunction.MinY;

                        currentWeedPopulation[i].position = new Vector2(x, y);
                        currentWeedPopulation[i].fitness = testFunction.calculateValueHandler(x, y);
                    }
                    break;
                case StartPopulationArrangement.Center:
                    for (i = 0; i < initialPopulationSize; i++)
                    {
                        float x = center_x + rng.NextSingle() * (testFunction.Width / 4) - (testFunction.Width / 8);
                        float y = center_y + rng.NextSingle() * (testFunction.Height / 4) - (testFunction.Height / 8);

                        currentWeedPopulation[i].position = new Vector2(x, y);
                        currentWeedPopulation[i].fitness = testFunction.calculateValueHandler(x, y);
                    }
                    break;
                case StartPopulationArrangement.Corners:
                    for (i = 0; i < initialPopulationSize; i++)
                    {
                        float x = rng.NextSingle() * (testFunction.Width / 4);
                        float y = rng.NextSingle() * (testFunction.Height / 4);

                        x = x < testFunction.Width / 8 ? testFunction.MinX + x : x = testFunction.MaxX - x + testFunction.Width / 8;
                        y = y < testFunction.Height / 8 ? testFunction.MinY + y : y = testFunction.MaxY - y + testFunction.Height / 8;

                        currentWeedPopulation[i].position = new Vector2(x, y);
                        currentWeedPopulation[i].fitness = testFunction.calculateValueHandler(x, y);
                    }
                    break;
                case StartPopulationArrangement.Grid:
                    int side_count = (int)Math.Sqrt(initialPopulationSize);
                    int all_count = side_count * side_count;
                    float gap_horizontal = testFunction.Width / (side_count + 1);
                    float gap_vertical = testFunction.Height / (side_count + 1);

                    i = 0;
                    int ix = 0, iy = 0;

                    while (i < all_count)
                    {
                        if (ix == side_count)
                        {
                            ix = 0;
                            iy++;
                        }

                        float x = testFunction.MinX + gap_horizontal * (ix + 1);
                        float y = testFunction.MinY + gap_vertical * (iy + 1);

                        currentWeedPopulation[i].position = new Vector2(x, y);
                        currentWeedPopulation[i].fitness = testFunction.calculateValueHandler(x, y);

                        ix++;
                        i++;
                    }
                    while (i < initialPopulationSize)
                    {
                        float x = rng.NextSingle() * testFunction.Width + testFunction.MinX;
                        float y = rng.NextSingle() * testFunction.Height + testFunction.MinY;

                        currentWeedPopulation[i].position = new Vector2(x, y);
                        currentWeedPopulation[i].fitness = testFunction.calculateValueHandler(x, y);

                        i++;
                    }
                    break;
            }

            if (currentWeedPopulation.Count > 1)
            {
                currentWeedPopulation.Sort();
                best_fitness = currentWeedPopulation[0].fitness;
                worst_fitness = currentWeedPopulation[initialPopulationSize - 1].fitness;
            }

            UpdatePopulationDisplay();
        }



        private void btn_StartSimulation_Click(object sender, EventArgs e)
        {
            ClearErrorMessages();

            if (CheckStartingConditions())
            {
                currentGenerationId = 0;
                simulationTimer.Interval = 100;
                simulationTimer.Tick += (sender, args) =>
                {
                    if (currentGenerationId < maxGenerationId)
                    {
                        currentGenerationId++;

                        ClearPopulationDisplay();
                        SimulationStep();
                        UpdatePopulationDisplay();
                    }
                    else
                    {
                        simulationTimer.Stop();
                    }
                };

                simulationTimer.Start();
            }
        }

        private bool CheckStartingConditions()
        {
            bool errorOccured = false;

            if (initialPopulationSize == 0)
            {
                AddErrorMessage("Population must be bigger than 0");
                errorOccured = true;
            }
            if (maxPopulationSize == 0)
            {
                AddErrorMessage("Max Population must be bigger than 0");
                errorOccured = true;
            }

            arrangement = (StartPopulationArrangement)cmbBox_initialPopulationArrangement.SelectedIndex;

            if (cmbBox_initialPopulationArrangement.SelectedIndex == -1)
            {
                AddErrorMessage("Initial Population Arrangement not set");
                errorOccured = true;
            }
            if (cmbBox_testFunction.SelectedIndex == -1)
            {
                AddErrorMessage("Test Function not set");
                errorOccured = true;
            }

            return !errorOccured;
        }

        private void AddErrorMessage(string message)
        {
            listB_errorMessages.BeginUpdate();
            listB_errorMessages.Items.Add(message);
            listB_errorMessages.EndUpdate();
        }

        private void ClearErrorMessages()
        {
            listB_errorMessages.Items.Clear();
        }

        private void SimulationStep()
        {
            Random rng = new();
            List<Weed> newOffspring = [];

            foreach (Weed weed in currentWeedPopulation)
            {
                int seeds = CalculateAmountOfSeeds(weed);
                float currentSigma = CalculateCurrentSigma(); // sigma is to make new offspring appear closer to parents as time goes on
                float currentMaxDistance = initialOffspringMaxDistance * currentSigma;
                Debug.WriteLine($"{currentSigma} {currentMaxDistance}");

                for (int i = 0; i < seeds; i++)
                {
                    // Places offspring in circle around parent
                    float shiftX = (rng.NextSingle() * 2 - 1) * currentMaxDistance;
                    float shiftY = (rng.NextSingle() * 2 - 1) * MathF.Sqrt(MathF.Pow(currentMaxDistance, 2) - shiftX * shiftX);

                    // Here to make sure we don't go outside the function's space
                    shiftX = Math.Min(Math.Max(weed.position.X + shiftX, testFunction.MinX), testFunction.MaxX);
                    shiftY = Math.Min(Math.Max(weed.position.Y + shiftY, testFunction.MinY), testFunction.MaxY);

                    Weed newWeed = new();
                    newWeed.position = new(shiftX, shiftY);
                    newWeed.fitness = testFunction.calculateValueHandler(shiftX, shiftY);

                    newOffspring.Add(newWeed);
                }
            }

            currentWeedPopulation.AddRange(newOffspring);
            currentWeedPopulation.Sort();
            best_fitness = currentWeedPopulation[0].fitness;
            worst_fitness = currentWeedPopulation[currentWeedPopulation.Count - 1].fitness;

            CutPopulation();
        }

        private int CalculateAmountOfSeeds(Weed weed)
        {
            return (int)((seedMax * (worst_fitness - weed.fitness) + seedMin * (weed.fitness - best_fitness)) / (worst_fitness - best_fitness));
        }

        private float CalculateCurrentSigma()
        {
            return MathF.Pow(((maxGenerationId - currentGenerationId) / (float)maxGenerationId), n) * (sigmaInit - sigmaFinal) + sigmaFinal;
        }

        private void CutPopulation()
        {
            int amountToCut = currentWeedPopulation.Count - maxPopulationSize;
            int x = currentWeedPopulation.Count - 1;

            for (int i = 0; i < amountToCut; i++)
            {
                currentWeedPopulation.RemoveAt(x - i);
            }
        }



        private void ClearPopulationDisplay()
        {
            populationGraphics.Clear(Color.White);
            //foreach (Weed weed in currentWeedPopulation)
            //{
            //    int ellipseStartX = (int)((weed.position.X - testFunction.MinX) * positionOnScreenModifier.X) - 1;
            //    int ellipseStartY = (int)((weed.position.Y - testFunction.MinY) * positionOnScreenModifier.Y) - 1;

            //    populationGraphics.DrawEllipse(populationEraser, ellipseStartX, ellipseStartY, 2, 2);
            //}
        }

        private void UpdatePopulationDisplay()
        {
            foreach (Weed weed in currentWeedPopulation)
            {
                int ellipseStartX = (int)((weed.position.X - testFunction.MinX) * positionOnScreenModifier.X) - 1;
                int ellipseStartY = (int)((weed.position.Y - testFunction.MinY) * positionOnScreenModifier.Y) - 1;

                populationGraphics.DrawEllipse(populationPen, ellipseStartX, ellipseStartY, 2, 2);
            }

            picB_populationSpace.Refresh();
        }
    }
}
