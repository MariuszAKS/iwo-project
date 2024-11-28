namespace IWO
{
    public partial class Form1 : Form
    {
        private int populationSize = 0;
        private int maxPopulationSize = 0;

        private int generationId = 0;
        private int maxGeneration = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_StartSimulation_Click(object sender, EventArgs e)
        {
            ClearErrorMessages();

            InitiateValues();
        }

        private bool InitiateValues()
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

            return !errorOccured;
        }

        private void InitiatePopulation()
        {
            for (int i = 0; i < populationSize; i++)
            {
                ;
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
    }
}
