using System.Numerics;
using System.Xml.Linq;

namespace IWO
{
    enum StartPopulationArrangement {
        Random, Center, Borders, Grid
    }

    public delegate double CalculateValue(float x, float y);

    public partial class Form1 : Form
    {
        private StartPopulationArrangement arrangement = StartPopulationArrangement.Random;
        private TestFunction testFunction = TestFunction.Rastrigin;

        private int populationSize = 0;
        private int maxPopulationSize = 0;

        private int generationId = 0;
        private int maxGeneration = 0;

        private float min_x = RastriginFunction.min_x, max_x = RastriginFunction.max_x;
        private float min_y = RastriginFunction.min_y, max_y = RastriginFunction.max_y;
        private Vector2[] global_min_positions = RastriginFunction.global_min_positions;
        private double global_min_value = RastriginFunction.global_min_value;

        CalculateValue calculateValueHandler = RastriginFunction.CalculateValue;

        Weed[] weedPopulation;

        public Form1()
        {
            InitializeComponent();

            PopulateComboBoxes();
        }

        private void PopulateComboBoxes()
        {
            foreach (StartPopulationArrangement arr in Enum.GetValues(typeof(StartPopulationArrangement)))
            {
                cmbBox_initialPopulationArrangement.Items.Add(arr.ToString());
            }
            foreach (TestFunction tst in Enum.GetValues(typeof(TestFunction)))
            {
                cmbBox_testFunction.Items.Add(tst.ToString());
            }

            cmbBox_initialPopulationArrangement.SelectedIndex = 0;
            cmbBox_testFunction.SelectedIndex = 0;
        }


        private void btn_StartSimulation_Click(object sender, EventArgs e)
        {
            ClearErrorMessages();

            if (GetValuesFromUI())
            {
                // Start simulation
            }
        }

        private bool GetValuesFromUI()
        {
            bool errorOccured = false;

            populationSize = (int)numUD_initialPopulationSize.Value;
            maxPopulationSize = (int)numUD_maxPopulationSize.Value;

            generationId = 0;
            maxGeneration = (int)numUD_generationsCount.Value;

            if (populationSize == 0)
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
            testFunction = (TestFunction)cmbBox_testFunction.SelectedIndex;

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

        private void GetTestFunctionValues()
        {
            switch (testFunction)
            {
                case TestFunction.Rastrigin:
                    min_x = RastriginFunction.min_x;
                    max_x = RastriginFunction.max_x;
                    min_y = RastriginFunction.min_y;
                    max_y = RastriginFunction.max_y;
                    global_min_positions = RastriginFunction.global_min_positions;
                    global_min_value = RastriginFunction.global_min_value;
                    calculateValueHandler = RastriginFunction.CalculateValue;
                    break;
                case TestFunction.Ackley:
                    min_x = AckleyFunction.min_x;
                    max_x = AckleyFunction.max_x;
                    min_y = AckleyFunction.min_y;
                    max_y = AckleyFunction.max_y;
                    global_min_positions = AckleyFunction.global_min_positions;
                    global_min_value = AckleyFunction.global_min_value;
                    calculateValueHandler = AckleyFunction.CalculateValue;
                    break;
                case TestFunction.Sphere:
                    min_x = SphereFunction.min_x;
                    max_x = SphereFunction.max_x;
                    min_y = SphereFunction.min_y;
                    max_y = SphereFunction.max_y;
                    global_min_positions = SphereFunction.global_min_positions;
                    global_min_value = SphereFunction.global_min_value;
                    calculateValueHandler = SphereFunction.CalculateValue;
                    break;
                case TestFunction.Rosenbrock:
                    min_x = RosenbrockFunction.min_x;
                    max_x = RosenbrockFunction.max_x;
                    min_y = RosenbrockFunction.min_y;
                    max_y = RosenbrockFunction.max_y;
                    global_min_positions = RosenbrockFunction.global_min_positions;
                    global_min_value = RosenbrockFunction.global_min_value;
                    calculateValueHandler = RosenbrockFunction.CalculateValue;
                    break;
                case TestFunction.Beale:
                    min_x = BealeFunction.min_x;
                    max_x = BealeFunction.max_x;
                    min_y = BealeFunction.min_y;
                    max_y = BealeFunction.max_y;
                    global_min_positions = BealeFunction.global_min_positions;
                    global_min_value = BealeFunction.global_min_value;
                    calculateValueHandler = BealeFunction.CalculateValue;
                    break;
                case TestFunction.Goldstein_Price:
                    min_x = GoldsteinPriceFunction.min_x;
                    max_x = GoldsteinPriceFunction.max_x;
                    min_y = GoldsteinPriceFunction.min_y;
                    max_y = GoldsteinPriceFunction.max_y;
                    global_min_positions = GoldsteinPriceFunction.global_min_positions;
                    global_min_value = GoldsteinPriceFunction.global_min_value;
                    calculateValueHandler = GoldsteinPriceFunction.CalculateValue;
                    break;
                case TestFunction.Bukin_N6:
                    min_x = BukinN6Function.min_x;
                    max_x = BukinN6Function.max_x;
                    min_y = BukinN6Function.min_y;
                    max_y = BukinN6Function.max_y;
                    global_min_positions = BukinN6Function.global_min_positions;
                    global_min_value = BukinN6Function.global_min_value;
                    calculateValueHandler = BukinN6Function.CalculateValue;
                    break;
                case TestFunction.Matyas:
                    min_x = MatyasFunction.min_x;
                    max_x = MatyasFunction.max_x;
                    min_y = MatyasFunction.min_y;
                    max_y = MatyasFunction.max_y;
                    global_min_positions = MatyasFunction.global_min_positions;
                    global_min_value = MatyasFunction.global_min_value;
                    calculateValueHandler = MatyasFunction.CalculateValue;
                    break;
                case TestFunction.Levi_N13:
                    min_x = LeviN13Function.min_x;
                    max_x = LeviN13Function.max_x;
                    min_y = LeviN13Function.min_y;
                    max_y = LeviN13Function.max_y;
                    global_min_positions = LeviN13Function.global_min_positions;
                    global_min_value = LeviN13Function.global_min_value;
                    calculateValueHandler = LeviN13Function.CalculateValue;
                    break;
                case TestFunction.Griewank:
                    min_x = GriewankFunction.min_x;
                    max_x = GriewankFunction.max_x;
                    min_y = GriewankFunction.min_y;
                    max_y = GriewankFunction.max_y;
                    global_min_positions = GriewankFunction.global_min_positions;
                    global_min_value = GriewankFunction.global_min_value;
                    calculateValueHandler = GriewankFunction.CalculateValue;
                    break;
                case TestFunction.Himmerblaus:
                    min_x = HimmelblausFunction.min_x;
                    max_x = HimmelblausFunction.max_x;
                    min_y = HimmelblausFunction.min_y;
                    max_y = HimmelblausFunction.max_y;
                    global_min_positions = HimmelblausFunction.global_min_positions;
                    global_min_value = HimmelblausFunction.global_min_value;
                    calculateValueHandler = HimmelblausFunction.CalculateValue;
                    break;
                case TestFunction.Three_Hump_Camel:
                    min_x = ThreeHumpCamelFunction.min_x;
                    max_x = ThreeHumpCamelFunction.max_x;
                    min_y = ThreeHumpCamelFunction.min_y;
                    max_y = ThreeHumpCamelFunction.max_y;
                    global_min_positions = ThreeHumpCamelFunction.global_min_positions;
                    global_min_value = ThreeHumpCamelFunction.global_min_value;
                    calculateValueHandler = ThreeHumpCamelFunction.CalculateValue;
                    break;
                case TestFunction.Easom:
                    min_x = EasomFunction.min_x;
                    max_x = EasomFunction.max_x;
                    min_y = EasomFunction.min_y;
                    max_y = EasomFunction.max_y;
                    global_min_positions = EasomFunction.global_min_positions;
                    global_min_value = EasomFunction.global_min_value;
                    calculateValueHandler = EasomFunction.CalculateValue;
                    break;
                case TestFunction.Cross_In_Tray:
                    min_x = CrossInTrayFunction.min_x;
                    max_x = CrossInTrayFunction.max_x;
                    min_y = CrossInTrayFunction.min_y;
                    max_y = CrossInTrayFunction.max_y;
                    global_min_positions = CrossInTrayFunction.global_min_positions;
                    global_min_value = CrossInTrayFunction.global_min_value;
                    calculateValueHandler = CrossInTrayFunction.CalculateValue;
                    break;
                case TestFunction.Eggholder:
                    min_x = EggholderFunction.min_x;
                    max_x = EggholderFunction.max_x;
                    min_y = EggholderFunction.min_y;
                    max_y = EggholderFunction.max_y;
                    global_min_positions = EggholderFunction.global_min_positions;
                    global_min_value = EggholderFunction.global_min_value;
                    calculateValueHandler = EggholderFunction.CalculateValue;
                    break;
                case TestFunction.Holder_Table:
                    min_x = HolderTableFunction.min_x;
                    max_x = HolderTableFunction.max_x;
                    min_y = HolderTableFunction.min_y;
                    max_y = HolderTableFunction.max_y;
                    global_min_positions = HolderTableFunction.global_min_positions;
                    global_min_value = HolderTableFunction.global_min_value;
                    calculateValueHandler = HolderTableFunction.CalculateValue;
                    break;
                case TestFunction.McCormick:
                    min_x = McCormickFunction.min_x;
                    max_x = McCormickFunction.max_x;
                    min_y = McCormickFunction.min_y;
                    max_y = McCormickFunction.max_y;
                    global_min_positions = McCormickFunction.global_min_positions;
                    global_min_value = McCormickFunction.global_min_value;
                    calculateValueHandler = McCormickFunction.CalculateValue;
                    break;
                case TestFunction.Schaffer_N2:
                    min_x = SchafferN2Function.min_x;
                    max_x = SchafferN2Function.max_x;
                    min_y = SchafferN2Function.min_y;
                    max_y = SchafferN2Function.max_y;
                    global_min_positions = SchafferN2Function.global_min_positions;
                    global_min_value = SchafferN2Function.global_min_value;
                    calculateValueHandler = SchafferN2Function.CalculateValue;
                    break;
                case TestFunction.Schaffer_N4:
                    min_x = SchafferN4Function.min_x;
                    max_x = SchafferN4Function.max_x;
                    min_y = SchafferN4Function.min_y;
                    max_y = SchafferN4Function.max_y;
                    global_min_positions = SchafferN4Function.global_min_positions;
                    global_min_value = SchafferN4Function.global_min_value;
                    calculateValueHandler = SchafferN4Function.CalculateValue;
                    break;
            }
        }

        private void InitiatePopulation()
        {
            weedPopulation = new Weed[populationSize];

            Random rng = new Random();
            int i = 0;

            float width = max_x - min_x;
            float height = max_y - min_y;
            float center_x = min_x + width / 2;
            float center_y = min_y + height / 2;

            switch (arrangement)
            {
                case StartPopulationArrangement.Random:
                    for (i = 0; i < populationSize; i++)
                    {
                        float x = (float)rng.NextDouble() * width + min_x;
                        float y = (float)rng.NextDouble() * height + min_y;

                        weedPopulation[i].position = new Vector2(x, y);
                        weedPopulation[i].value = calculateValueHandler(x, y);
                    }
                    break;
                case StartPopulationArrangement.Center:
                    for (i = 0; i < populationSize; i++)
                    {
                        float x = center_x + (float)rng.NextDouble() * (width / 4) - (width / 8);
                        float y = center_y + (float)rng.NextDouble() * (height / 4) - (height / 8);

                        weedPopulation[i].position = new Vector2(x, y);
                        weedPopulation[i].value = calculateValueHandler(x, y);
                    }
                    break;
                case StartPopulationArrangement.Borders:
                    for (i = 0; i < populationSize; i++)
                    {
                        float x = (float)rng.NextDouble() * (width / 4);
                        float y = (float)rng.NextDouble() * (height / 4);

                        x = x < width / 8 ? min_x + x : x = max_x - x + width / 8;
                        y = y < height / 8 ? min_y + y : y = max_y - y + height / 8;

                        weedPopulation[i].position = new Vector2(x, y);
                        weedPopulation[i].value = calculateValueHandler(x, y);
                    }
                    break;
                case StartPopulationArrangement.Grid:
                    int side_count = (int)Math.Sqrt(populationSize);
                    int all_count = side_count * side_count;
                    float gap_horizontal = width / (side_count + 1);
                    float gap_vertical = height / (side_count + 1);

                    i = 0;
                    int ix = 0, iy = 0;

                    while (i < all_count)
                    {
                        if (ix == side_count)
                        {
                            ix = 0;
                            iy++;
                        }

                        float x = gap_horizontal * (ix + 1);
                        float y = gap_vertical * (iy + 1);

                        weedPopulation[i].position = new Vector2(x, y);
                        weedPopulation[i].value = calculateValueHandler(x, y);

                        ix++;
                        i++;
                    }
                    while (i < populationSize)
                    {
                        float x = (float)rng.NextDouble() * width + min_x;
                        float y = (float)rng.NextDouble() * height + min_y;

                        weedPopulation[i].position = new Vector2(x, y);
                        weedPopulation[i].value = calculateValueHandler(x, y);
                    }
                    break;
            }
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

        class Weed
        {
            public Vector2 position;
            public double value;
        }
    }
}
