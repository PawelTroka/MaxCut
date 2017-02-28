using System;
using System.ComponentModel;
using System.Windows.Forms;
using MaxCut.DataTypes;

namespace MaxCut
{
    public partial class Gui : Form
    {
        private readonly AlgorithmsTester _tester;
        private BackgroundWorker _worker;

        public Gui()
        {
            _tester = new AlgorithmsTester();
            InitializeComponent();

            testGraphsSizeDataGridView.Rows.Add(6);

            for (var i = 0; i < 6; i++)
                testGraphsSizeDataGridView[0, i].Value = 10 + 10*i;
        }

        private void DisableButtons()
        {
            exportAsPdfButton.Enabled = generateGraphsButton.Enabled = runTestsButton.Enabled = false;
        }

        private void EnableButtons()
        {
            exportAsPdfButton.Enabled = generateGraphsButton.Enabled = runTestsButton.Enabled = true;
        }

        private void generateGraphsButton_Click(object sender, EventArgs e)
        {
            DisableButtons();
            progressBar1.Style = ProgressBarStyle.Marquee;

            _worker = new BackgroundWorker();
            _worker.DoWork += _tester.GenerateGraphs;


            _worker.RunWorkerCompleted += (os, ev) =>
            {
                listBox1.Items.Clear();

                if (_tester.Graphs != null)
                    listBox1.Items.AddRange(_tester.Graphs.ToArray());

                EnableButtons();
                progressBar1.Style = ProgressBarStyle.Blocks;
                progressBar1.Value = 100;
            };

            _worker.RunWorkerAsync(testGraphsSizeDataGridView.Rows);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var g = listBox1.SelectedItem as Graph;
            if (g != null)
            {
                graphDataGridView.Rows.Clear();
                graphDataGridView.Columns.Clear();

                for (var i = 0; i < g.N; i++)
                {
                    graphDataGridView.Columns.Add(i.ToString(), i.ToString());
                    graphDataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }

                graphDataGridView.Rows.Add(g.N);

                for (var i = 0; i < g.N; i++)
                    for (var j = 0; j < g.N; j++)
                    {
                        graphDataGridView[i, j].Value = g[i, j];
                    }
            }
        }

        private void runTestsButton_Click(object sender, EventArgs e)
        {
            DisableButtons();
            resultsDataGridView.Rows.Clear();
            performanceResultsDataGridView.Rows.Clear();

            progressBar1.Style = ProgressBarStyle.Blocks;

            _worker = new BackgroundWorker {WorkerReportsProgress = true};


            _worker.DoWork += _tester.Test;

            _worker.ProgressChanged += (os, ev) => { progressBar1.Value = ev.ProgressPercentage; };

            _worker.RunWorkerCompleted += (os, ev) =>
            {
                chart1.Series.Clear();
                if (_tester.TestExactAlgorithm)
                    chart1.Series.Add("Exact Algorithm");
                if (_tester.TestApproximatedAlgorithm)
                    chart1.Series.Add("2-approximation Algorithm");

                foreach (var timeValue in _tester.TimeValues)
                {
                    performanceResultsDataGridView.Rows.Add(timeValue.N, timeValue.ApproximationAlgorithmTime,
                        timeValue.ExactAlgorithmTime);
                    if (_tester.TestExactAlgorithm)
                        chart1.Series["Exact Algorithm"].Points.AddXY(timeValue.N, timeValue.ExactAlgorithmTime);
                    if (_tester.TestApproximatedAlgorithm)
                        chart1.Series["2-approximation Algorithm"].Points.AddXY(timeValue.N, timeValue.ApproximationAlgorithmTime);
                }

                foreach (var resultValue in _tester.ResultValues)
                {
                    resultsDataGridView.Rows.Add(resultValue.Graph, resultValue.ApproximationCutSize,
                        resultValue.ApproximationSet, resultValue.ExactCutSize, resultValue.ExactSet);
                }

                EnableButtons();
                progressBar1.Style = ProgressBarStyle.Blocks;
                progressBar1.Value = 100;
            };

            _worker.RunWorkerAsync(iterationsPerTestNumericUpDown.Value);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Utility.Seed = (int) numericUpDown1.Value;
        }

        private void testExactAlgorithmCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _tester.TestExactAlgorithm = testExactAlgorithmCheckBox.Checked;
        }

        private void testApproximatedAlgorithmCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _tester.TestApproximatedAlgorithm = testApproximatedAlgorithmCheckBox.Checked;
        }
    }
}