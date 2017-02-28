namespace MaxCut
{
    partial class Gui
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.performanceResultsDataGridView = new System.Windows.Forms.DataGridView();
            this.sizeofGraph = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeFor2approx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeOfExactAlgoritm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.resultsDataGridView = new System.Windows.Forms.DataGridView();
            this.GraphColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.graphDataGridView = new System.Windows.Forms.DataGridView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.testApproximatedAlgorithmCheckBox = new System.Windows.Forms.CheckBox();
            this.testExactAlgorithmCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.iterationsPerTestNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.testGraphsSizeDataGridView = new System.Windows.Forms.DataGridView();
            this.graphSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.exportAsPdfButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.runTestsButton = new System.Windows.Forms.Button();
            this.generateGraphsButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.performanceResultsDataGridView)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graphDataGridView)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iterationsPerTestNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testGraphsSizeDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(724, 547);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chart1);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabPage1.Size = new System.Drawing.Size(716, 509);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Chart";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea2.AxisX.Title = "N";
            chartArea2.AxisY.Title = "Time [ms]";
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(5, 6);
            this.chart1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(706, 497);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.performanceResultsDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabPage2.Size = new System.Drawing.Size(716, 509);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Performance results";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // performanceResultsDataGridView
            // 
            this.performanceResultsDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.performanceResultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.performanceResultsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sizeofGraph,
            this.timeFor2approx,
            this.timeOfExactAlgoritm});
            this.performanceResultsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.performanceResultsDataGridView.Location = new System.Drawing.Point(5, 6);
            this.performanceResultsDataGridView.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.performanceResultsDataGridView.Name = "performanceResultsDataGridView";
            this.performanceResultsDataGridView.ReadOnly = true;
            this.performanceResultsDataGridView.Size = new System.Drawing.Size(706, 497);
            this.performanceResultsDataGridView.TabIndex = 0;
            // 
            // sizeofGraph
            // 
            this.sizeofGraph.HeaderText = "N";
            this.sizeofGraph.Name = "sizeofGraph";
            this.sizeofGraph.ReadOnly = true;
            // 
            // timeFor2approx
            // 
            this.timeFor2approx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.timeFor2approx.HeaderText = "Time of 2-approximation algorithm";
            this.timeFor2approx.Name = "timeFor2approx";
            this.timeFor2approx.ReadOnly = true;
            // 
            // timeOfExactAlgoritm
            // 
            this.timeOfExactAlgoritm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.timeOfExactAlgoritm.HeaderText = "Time of exact algorithm";
            this.timeOfExactAlgoritm.Name = "timeOfExactAlgoritm";
            this.timeOfExactAlgoritm.ReadOnly = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.resultsDataGridView);
            this.tabPage5.Location = new System.Drawing.Point(4, 34);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(716, 509);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Results";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // resultsDataGridView
            // 
            this.resultsDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.resultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GraphColumn,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.resultsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.resultsDataGridView.Name = "resultsDataGridView";
            this.resultsDataGridView.ReadOnly = true;
            this.resultsDataGridView.Size = new System.Drawing.Size(716, 509);
            this.resultsDataGridView.TabIndex = 0;
            // 
            // GraphColumn
            // 
            this.GraphColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GraphColumn.HeaderText = "Graph";
            this.GraphColumn.Name = "GraphColumn";
            this.GraphColumn.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "2-approximation cut size";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "2-approximation set";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Exact cut size";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Exact set";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.graphDataGridView);
            this.tabPage3.Controls.Add(this.listBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(716, 509);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Generated graphs";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // graphDataGridView
            // 
            this.graphDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.graphDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.graphDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphDataGridView.Location = new System.Drawing.Point(182, 0);
            this.graphDataGridView.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.graphDataGridView.Name = "graphDataGridView";
            this.graphDataGridView.ReadOnly = true;
            this.graphDataGridView.Size = new System.Drawing.Size(534, 509);
            this.graphDataGridView.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(182, 509);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.testApproximatedAlgorithmCheckBox);
            this.tabPage4.Controls.Add(this.testExactAlgorithmCheckBox);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.iterationsPerTestNumericUpDown);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.numericUpDown1);
            this.tabPage4.Controls.Add(this.testGraphsSizeDataGridView);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(716, 509);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Options";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // testApproximatedAlgorithmCheckBox
            // 
            this.testApproximatedAlgorithmCheckBox.AutoSize = true;
            this.testApproximatedAlgorithmCheckBox.Checked = true;
            this.testApproximatedAlgorithmCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.testApproximatedAlgorithmCheckBox.Location = new System.Drawing.Point(312, 271);
            this.testApproximatedAlgorithmCheckBox.Name = "testApproximatedAlgorithmCheckBox";
            this.testApproximatedAlgorithmCheckBox.Size = new System.Drawing.Size(303, 29);
            this.testApproximatedAlgorithmCheckBox.TabIndex = 7;
            this.testApproximatedAlgorithmCheckBox.Text = "Test approximated algorithm";
            this.testApproximatedAlgorithmCheckBox.UseVisualStyleBackColor = true;
            this.testApproximatedAlgorithmCheckBox.CheckedChanged += new System.EventHandler(this.testApproximatedAlgorithmCheckBox_CheckedChanged);
            // 
            // testExactAlgorithmCheckBox
            // 
            this.testExactAlgorithmCheckBox.AutoSize = true;
            this.testExactAlgorithmCheckBox.Location = new System.Drawing.Point(312, 236);
            this.testExactAlgorithmCheckBox.Name = "testExactAlgorithmCheckBox";
            this.testExactAlgorithmCheckBox.Size = new System.Drawing.Size(225, 29);
            this.testExactAlgorithmCheckBox.TabIndex = 6;
            this.testExactAlgorithmCheckBox.Text = "Test exact algorithm";
            this.testExactAlgorithmCheckBox.UseVisualStyleBackColor = true;
            this.testExactAlgorithmCheckBox.CheckedChanged += new System.EventHandler(this.testExactAlgorithmCheckBox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 149);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number of iterations per test =";
            // 
            // iterationsPerTestNumericUpDown
            // 
            this.iterationsPerTestNumericUpDown.Location = new System.Drawing.Point(603, 145);
            this.iterationsPerTestNumericUpDown.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.iterationsPerTestNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.iterationsPerTestNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.iterationsPerTestNumericUpDown.Name = "iterationsPerTestNumericUpDown";
            this.iterationsPerTestNumericUpDown.Size = new System.Drawing.Size(100, 31);
            this.iterationsPerTestNumericUpDown.TabIndex = 2;
            this.iterationsPerTestNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seed =";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(400, 60);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(196, 31);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            149063626,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // testGraphsSizeDataGridView
            // 
            this.testGraphsSizeDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.testGraphsSizeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.testGraphsSizeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.graphSize});
            this.testGraphsSizeDataGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.testGraphsSizeDataGridView.Location = new System.Drawing.Point(0, 31);
            this.testGraphsSizeDataGridView.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.testGraphsSizeDataGridView.Name = "testGraphsSizeDataGridView";
            this.testGraphsSizeDataGridView.Size = new System.Drawing.Size(285, 478);
            this.testGraphsSizeDataGridView.TabIndex = 4;
            // 
            // graphSize
            // 
            this.graphSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.graphSize.HeaderText = "G(E,V) :  |V| = ";
            this.graphSize.Name = "graphSize";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Graphs to test:";
            // 
            // exportAsPdfButton
            // 
            this.exportAsPdfButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.exportAsPdfButton.Location = new System.Drawing.Point(483, 0);
            this.exportAsPdfButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.exportAsPdfButton.Name = "exportAsPdfButton";
            this.exportAsPdfButton.Size = new System.Drawing.Size(241, 58);
            this.exportAsPdfButton.TabIndex = 1;
            this.exportAsPdfButton.Text = "3. Export as pdf";
            this.exportAsPdfButton.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 547);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.progressBar1.MarqueeAnimationSpeed = 1;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(724, 44);
            this.progressBar1.Step = 33;
            this.progressBar1.TabIndex = 2;
            // 
            // runTestsButton
            // 
            this.runTestsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.runTestsButton.Location = new System.Drawing.Point(241, 0);
            this.runTestsButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.runTestsButton.Name = "runTestsButton";
            this.runTestsButton.Size = new System.Drawing.Size(242, 58);
            this.runTestsButton.TabIndex = 3;
            this.runTestsButton.Text = "2. Run tests";
            this.runTestsButton.UseVisualStyleBackColor = true;
            this.runTestsButton.Click += new System.EventHandler(this.runTestsButton_Click);
            // 
            // generateGraphsButton
            // 
            this.generateGraphsButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.generateGraphsButton.Location = new System.Drawing.Point(0, 0);
            this.generateGraphsButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.generateGraphsButton.Name = "generateGraphsButton";
            this.generateGraphsButton.Size = new System.Drawing.Size(241, 58);
            this.generateGraphsButton.TabIndex = 4;
            this.generateGraphsButton.Text = "1. Generate graphs";
            this.generateGraphsButton.UseVisualStyleBackColor = true;
            this.generateGraphsButton.Click += new System.EventHandler(this.generateGraphsButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.runTestsButton);
            this.panel1.Controls.Add(this.generateGraphsButton);
            this.panel1.Controls.Add(this.exportAsPdfButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 591);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(724, 58);
            this.panel1.TabIndex = 5;
            // 
            // Gui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 649);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Gui";
            this.Text = "Max-Cut Problem  © Pawel Troka";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.performanceResultsDataGridView)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.graphDataGridView)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iterationsPerTestNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testGraphsSizeDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button exportAsPdfButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button runTestsButton;
        private System.Windows.Forms.Button generateGraphsButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView performanceResultsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeofGraph;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeFor2approx;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeOfExactAlgoritm;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView graphDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown iterationsPerTestNumericUpDown;
        private System.Windows.Forms.DataGridView testGraphsSizeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn graphSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView resultsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn GraphColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.CheckBox testApproximatedAlgorithmCheckBox;
        private System.Windows.Forms.CheckBox testExactAlgorithmCheckBox;
    }
}

