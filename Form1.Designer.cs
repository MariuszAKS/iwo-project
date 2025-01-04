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
            lbl_bordersX = new Label();
            lbl_bordersY = new Label();
            label6 = new Label();
            label7 = new Label();
            lbl_minPositions = new Label();
            label8 = new Label();
            lbl_minValue = new Label();
            btn_repopulate = new Button();
            label9 = new Label();
            numUD_seedMin = new NumericUpDown();
            numUD_seedMax = new NumericUpDown();
            btn_step = new Button();
            txtB_simulationProgress = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numUD_initialPopulationSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUD_maxPopulationSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUD_generationsCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picB_populationSpace).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picB_bestFitnessChart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUD_seedMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUD_seedMax).BeginInit();
            SuspendLayout();
            // 
            // numUD_initialPopulationSize
            // 
            numUD_initialPopulationSize.Location = new Point(139, 12);
            numUD_initialPopulationSize.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numUD_initialPopulationSize.Name = "numUD_initialPopulationSize";
            numUD_initialPopulationSize.Size = new Size(120, 23);
            numUD_initialPopulationSize.TabIndex = 0;
            numUD_initialPopulationSize.Value = new decimal(new int[] { 100, 0, 0, 0 });
            numUD_initialPopulationSize.ValueChanged += numUD_initialPopulationSize_ValueChanged;
            // 
            // numUD_maxPopulationSize
            // 
            numUD_maxPopulationSize.Location = new Point(139, 35);
            numUD_maxPopulationSize.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numUD_maxPopulationSize.Name = "numUD_maxPopulationSize";
            numUD_maxPopulationSize.Size = new Size(120, 23);
            numUD_maxPopulationSize.TabIndex = 1;
            numUD_maxPopulationSize.Value = new decimal(new int[] { 100, 0, 0, 0 });
            numUD_maxPopulationSize.ValueChanged += numUD_maxPopulationSize_ValueChanged;
            // 
            // btn_StartSimulation
            // 
            btn_StartSimulation.Location = new Point(552, 718);
            btn_StartSimulation.Name = "btn_StartSimulation";
            btn_StartSimulation.Size = new Size(105, 31);
            btn_StartSimulation.TabIndex = 2;
            btn_StartSimulation.Text = "Start/Pause";
            btn_StartSimulation.UseVisualStyleBackColor = true;
            btn_StartSimulation.Click += btn_StartSimulation_Click;
            // 
            // numUD_generationsCount
            // 
            numUD_generationsCount.Location = new Point(139, 64);
            numUD_generationsCount.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numUD_generationsCount.Name = "numUD_generationsCount";
            numUD_generationsCount.Size = new Size(120, 23);
            numUD_generationsCount.TabIndex = 4;
            numUD_generationsCount.Value = new decimal(new int[] { 100, 0, 0, 0 });
            numUD_generationsCount.ValueChanged += numUD_generationsCount_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 14);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 5;
            label1.Text = "Initial Population Size";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 37);
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
            listB_errorMessages.Location = new Point(854, 715);
            listB_errorMessages.Name = "listB_errorMessages";
            listB_errorMessages.Size = new Size(398, 34);
            listB_errorMessages.TabIndex = 9;
            // 
            // picB_populationSpace
            // 
            picB_populationSpace.BackColor = Color.White;
            picB_populationSpace.Location = new Point(552, 12);
            picB_populationSpace.Name = "picB_populationSpace";
            picB_populationSpace.Size = new Size(700, 700);
            picB_populationSpace.TabIndex = 10;
            picB_populationSpace.TabStop = false;
            // 
            // picB_bestFitnessChart
            // 
            picB_bestFitnessChart.BackColor = Color.White;
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
            cmbBox_testFunction.Location = new Point(139, 151);
            cmbBox_testFunction.Name = "cmbBox_testFunction";
            cmbBox_testFunction.Size = new Size(120, 23);
            cmbBox_testFunction.TabIndex = 12;
            cmbBox_testFunction.SelectedIndexChanged += cmbBox_testFunction_SelectedIndexChanged;
            // 
            // cmbBox_initialPopulationArrangement
            // 
            cmbBox_initialPopulationArrangement.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBox_initialPopulationArrangement.FormattingEnabled = true;
            cmbBox_initialPopulationArrangement.Location = new Point(139, 122);
            cmbBox_initialPopulationArrangement.Name = "cmbBox_initialPopulationArrangement";
            cmbBox_initialPopulationArrangement.Size = new Size(120, 23);
            cmbBox_initialPopulationArrangement.TabIndex = 13;
            cmbBox_initialPopulationArrangement.SelectedIndexChanged += cmbBox_initialPopulationArrangement_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 125);
            label4.Name = "label4";
            label4.Size = new Size(121, 15);
            label4.TabIndex = 14;
            label4.Text = "Init Pop Arrangement";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(58, 154);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 15;
            label5.Text = "Test function";
            // 
            // lbl_bordersX
            // 
            lbl_bordersX.AutoSize = true;
            lbl_bordersX.Location = new Point(321, 14);
            lbl_bordersX.Name = "lbl_bordersX";
            lbl_bordersX.Size = new Size(61, 15);
            lbl_bordersX.TabIndex = 16;
            lbl_bordersX.Text = "X: < _ ; _ >";
            // 
            // lbl_bordersY
            // 
            lbl_bordersY.AutoSize = true;
            lbl_bordersY.Location = new Point(321, 29);
            lbl_bordersY.Name = "lbl_bordersY";
            lbl_bordersY.Size = new Size(61, 15);
            lbl_bordersY.TabIndex = 17;
            lbl_bordersY.Text = "Y: < _ ; _ >";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(265, 14);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 18;
            label6.Text = "Borders:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(265, 66);
            label7.Name = "label7";
            label7.Size = new Size(119, 15);
            label7.TabIndex = 19;
            label7.Text = "Global min positions:";
            // 
            // lbl_minPositions
            // 
            lbl_minPositions.AutoSize = true;
            lbl_minPositions.Location = new Point(390, 66);
            lbl_minPositions.Name = "lbl_minPositions";
            lbl_minPositions.Size = new Size(42, 15);
            lbl_minPositions.TabIndex = 20;
            lbl_minPositions.Text = "( x ; y )";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(265, 51);
            label8.Name = "label8";
            label8.Size = new Size(99, 15);
            label8.TabIndex = 21;
            label8.Text = "Global min value:";
            // 
            // lbl_minValue
            // 
            lbl_minValue.AutoSize = true;
            lbl_minValue.Location = new Point(370, 51);
            lbl_minValue.Name = "lbl_minValue";
            lbl_minValue.Size = new Size(12, 15);
            lbl_minValue.TabIndex = 22;
            lbl_minValue.Text = "_";
            // 
            // btn_repopulate
            // 
            btn_repopulate.Location = new Point(265, 122);
            btn_repopulate.Name = "btn_repopulate";
            btn_repopulate.Size = new Size(76, 23);
            btn_repopulate.TabIndex = 23;
            btn_repopulate.Text = "Repopulate";
            btn_repopulate.UseVisualStyleBackColor = true;
            btn_repopulate.Click += btn_repopulate_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(35, 95);
            label9.Name = "label9";
            label9.Size = new Size(98, 15);
            label9.TabIndex = 24;
            label9.Text = "Seeds (Min, Max)";
            // 
            // numUD_seedMin
            // 
            numUD_seedMin.Location = new Point(139, 93);
            numUD_seedMin.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numUD_seedMin.Name = "numUD_seedMin";
            numUD_seedMin.Size = new Size(120, 23);
            numUD_seedMin.TabIndex = 25;
            numUD_seedMin.ValueChanged += numUD_seedMin_ValueChanged;
            // 
            // numUD_seedMax
            // 
            numUD_seedMax.Location = new Point(265, 93);
            numUD_seedMax.Name = "numUD_seedMax";
            numUD_seedMax.Size = new Size(120, 23);
            numUD_seedMax.TabIndex = 26;
            numUD_seedMax.Value = new decimal(new int[] { 2, 0, 0, 0 });
            numUD_seedMax.ValueChanged += numUD_seedMax_ValueChanged;
            // 
            // btn_step
            // 
            btn_step.Location = new Point(663, 718);
            btn_step.Name = "btn_step";
            btn_step.Size = new Size(105, 31);
            btn_step.TabIndex = 27;
            btn_step.Text = "Simulation Step";
            btn_step.UseVisualStyleBackColor = true;
            btn_step.Click += btn_step_Click;
            // 
            // txtB_simulationProgress
            // 
            txtB_simulationProgress.Location = new Point(774, 723);
            txtB_simulationProgress.Name = "txtB_simulationProgress";
            txtB_simulationProgress.ReadOnly = true;
            txtB_simulationProgress.Size = new Size(74, 23);
            txtB_simulationProgress.TabIndex = 29;
            txtB_simulationProgress.Text = "99/100";
            txtB_simulationProgress.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 761);
            Controls.Add(txtB_simulationProgress);
            Controls.Add(btn_step);
            Controls.Add(numUD_seedMax);
            Controls.Add(numUD_seedMin);
            Controls.Add(label9);
            Controls.Add(btn_repopulate);
            Controls.Add(lbl_minValue);
            Controls.Add(label8);
            Controls.Add(lbl_minPositions);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(lbl_bordersY);
            Controls.Add(lbl_bordersX);
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
            ((System.ComponentModel.ISupportInitialize)numUD_seedMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUD_seedMax).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numUD_initialPopulationSize;
        private NumericUpDown numUD_maxPopulationSize;
        private Button btn_StartSimulation;
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
        private Label lbl_bordersX;
        private Label lbl_bordersY;
        private Label label6;
        private Label label7;
        private Label lbl_minPositions;
        private Label label8;
        private Label lbl_minValue;
        private Button btn_repopulate;
        private Label label9;
        private NumericUpDown numUD_seedMin;
        private NumericUpDown numUD_seedMax;
        private Button btn_step;
        private TextBox txtB_simulationProgress;
    }
}
