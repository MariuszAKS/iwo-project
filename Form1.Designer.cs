namespace IWO
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            numUD_initialPopulationSize = new NumericUpDown();
            numUD_maxPopulationSize = new NumericUpDown();
            btn_StartSimulation = new Button();
            chkB_stepVisualization = new CheckBox();
            numUD_generationsCount = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            listB_errorMessages = new ListBox();
            picB_populationSpace = new PictureBox();
            picB_bestFitnessChart = new PictureBox();
            cmbBox_testFunction = new ComboBox();
            cmbBox_initialPopulationArrangement = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)numUD_initialPopulationSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUD_maxPopulationSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUD_generationsCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picB_populationSpace).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picB_bestFitnessChart).BeginInit();
            SuspendLayout();
            // 
            // numUD_initialPopulationSize
            // 
            numUD_initialPopulationSize.Location = new Point(139, 12);
            numUD_initialPopulationSize.Name = "numUD_initialPopulationSize";
            numUD_initialPopulationSize.Size = new Size(120, 23);
            numUD_initialPopulationSize.TabIndex = 0;
            // 
            // numUD_maxPopulationSize
            // 
            numUD_maxPopulationSize.Location = new Point(139, 35);
            numUD_maxPopulationSize.Name = "numUD_maxPopulationSize";
            numUD_maxPopulationSize.Size = new Size(120, 23);
            numUD_maxPopulationSize.TabIndex = 1;
            // 
            // btn_StartSimulation
            // 
            btn_StartSimulation.Location = new Point(552, 718);
            btn_StartSimulation.Name = "btn_StartSimulation";
            btn_StartSimulation.Size = new Size(145, 31);
            btn_StartSimulation.TabIndex = 2;
            btn_StartSimulation.Text = "Start";
            btn_StartSimulation.UseVisualStyleBackColor = true;
            btn_StartSimulation.Click += btn_StartSimulation_Click;
            // 
            // chkB_stepVisualization
            // 
            chkB_stepVisualization.AutoSize = true;
            chkB_stepVisualization.Location = new Point(80, 466);
            chkB_stepVisualization.Name = "chkB_stepVisualization";
            chkB_stepVisualization.Size = new Size(131, 19);
            chkB_stepVisualization.TabIndex = 3;
            chkB_stepVisualization.Text = "Fitness Visualization";
            chkB_stepVisualization.UseVisualStyleBackColor = true;
            // 
            // numUD_generationsCount
            // 
            numUD_generationsCount.Location = new Point(139, 64);
            numUD_generationsCount.Name = "numUD_generationsCount";
            numUD_generationsCount.Size = new Size(120, 23);
            numUD_generationsCount.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 5;
            label1.Text = "Initial Population Size";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 37);
            label2.Name = "label2";
            label2.Size = new Size(114, 15);
            label2.TabIndex = 6;
            label2.Text = "Max Population Size";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 66);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 7;
            label3.Text = "Generations Count";
            // 
            // listB_errorMessages
            // 
            listB_errorMessages.FormattingEnabled = true;
            listB_errorMessages.ItemHeight = 15;
            listB_errorMessages.Location = new Point(703, 715);
            listB_errorMessages.Name = "listB_errorMessages";
            listB_errorMessages.Size = new Size(549, 34);
            listB_errorMessages.TabIndex = 9;
            // 
            // picB_populationSpace
            // 
            picB_populationSpace.Location = new Point(552, 12);
            picB_populationSpace.Name = "picB_populationSpace";
            picB_populationSpace.Size = new Size(700, 700);
            picB_populationSpace.TabIndex = 10;
            picB_populationSpace.TabStop = false;
            // 
            // picB_bestFitnessChart
            // 
            picB_bestFitnessChart.Location = new Point(12, 512);
            picB_bestFitnessChart.Name = "picB_bestFitnessChart";
            picB_bestFitnessChart.Size = new Size(500, 200);
            picB_bestFitnessChart.TabIndex = 11;
            picB_bestFitnessChart.TabStop = false;
            // 
            // cmbBox_testFunction
            // 
            cmbBox_testFunction.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBox_testFunction.FormattingEnabled = true;
            cmbBox_testFunction.Location = new Point(139, 122);
            cmbBox_testFunction.Name = "cmbBox_testFunction";
            cmbBox_testFunction.Size = new Size(120, 23);
            cmbBox_testFunction.TabIndex = 12;
            // 
            // cmbBox_initialPopulationArrangement
            // 
            cmbBox_initialPopulationArrangement.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBox_initialPopulationArrangement.FormattingEnabled = true;
            cmbBox_initialPopulationArrangement.Location = new Point(139, 93);
            cmbBox_initialPopulationArrangement.Name = "cmbBox_initialPopulationArrangement";
            cmbBox_initialPopulationArrangement.Size = new Size(120, 23);
            cmbBox_initialPopulationArrangement.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 96);
            label4.Name = "label4";
            label4.Size = new Size(121, 15);
            label4.TabIndex = 14;
            label4.Text = "Init Pop Arrangement";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(57, 125);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 15;
            label5.Text = "Test function";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 761);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(cmbBox_initialPopulationArrangement);
            Controls.Add(cmbBox_testFunction);
            Controls.Add(picB_bestFitnessChart);
            Controls.Add(picB_populationSpace);
            Controls.Add(listB_errorMessages);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numUD_generationsCount);
            Controls.Add(chkB_stepVisualization);
            Controls.Add(btn_StartSimulation);
            Controls.Add(numUD_maxPopulationSize);
            Controls.Add(numUD_initialPopulationSize);
            Name = "Form1";
            Text = "Invasive Weed Optimization";
            ((System.ComponentModel.ISupportInitialize)numUD_initialPopulationSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUD_maxPopulationSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUD_generationsCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)picB_populationSpace).EndInit();
            ((System.ComponentModel.ISupportInitialize)picB_bestFitnessChart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numUD_initialPopulationSize;
        private NumericUpDown numUD_maxPopulationSize;
        private Button btn_StartSimulation;
        private CheckBox chkB_stepVisualization;
        private NumericUpDown numUD_generationsCount;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox listB_errorMessages;
        private PictureBox picB_populationSpace;
        private PictureBox picB_bestFitnessChart;
        private ComboBox cmbBox_testFunction;
        private ComboBox cmbBox_initialPopulationArrangement;
        private Label label4;
        private Label label5;
    }
}
