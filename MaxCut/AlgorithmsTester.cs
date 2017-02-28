using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using MaxCut.Algorithms.Approximation;
using MaxCut.Algorithms.Exact;
using MaxCut.DataTypes;

namespace MaxCut
{
    internal class AlgorithmsTester
    {
        public AlgorithmsTester()
        {
            TimeValues = new List<TimePoint>();
            ResultValues = new List<Result>();
            TestApproximatedAlgorithm = true;
        }

        public bool TestApproximatedAlgorithm { get; set; }
        public bool TestExactAlgorithm { get; set; }
        public List<Result> ResultValues { get; private set; }
        public List<TimePoint> TimeValues { get; private set; }
        public List<Graph> Graphs { get; private set; }

        public void GenerateGraphs(object sender, DoWorkEventArgs eventArgs)
        {
            Graphs = new List<Graph>();

            var rows = eventArgs.Argument as DataGridViewRowCollection;

            if (rows == null) return;

            for (var i = 0; i < rows.Count; i++)
            {
                var row = rows[i].Cells[0];
                if (row.Value == null)
                    continue;
                int n;
                if (int.TryParse(row.Value.ToString(), out n))
                {
                    Graphs.Add(new Graph(n));
                }
            }
        }

        public void Test(object sender, DoWorkEventArgs eventArgs)
        {
            var approxAlgorithm = new MaxCut2Approximation();
            var exactAlgorithm = new MaxCutExact();
            TimeValues.Clear();
            ResultValues.Clear();

            var bw = sender as BackgroundWorker;

            var iterationsPerTest = (decimal) eventArgs.Argument;

            if (bw == null)
                return;

            var counter = 0.0;
            var currentProgress = 0;

            var calculationsCount = (double) (Graphs.Count*iterationsPerTest);


            var sw = new Stopwatch();

            foreach (var g in Graphs)
            {
                TimeValues.Add(new TimePoint {N = g.N});
                ResultValues.Add(new Result {Graph = g});

                approxAlgorithm.InputGraph = g;
                exactAlgorithm.InputGraph = g;

                var sumOfTimesForExact = 0.0;
                var sumOfTimesForApprox = 0.0;


                for (var j = 0; j < iterationsPerTest; j++)
                {
                    if (TestExactAlgorithm)
                    {
                        sw.Restart();
                        //DO WORK EXACT ALGORITHM
                        exactAlgorithm.MaxCut();
                        //
                        sw.Stop();
                    }
                    ResultValues.Last().ExactCutSize = exactAlgorithm.CutSize;
                    ResultValues.Last().ExactSet = exactAlgorithm.OutputSet;

                    if (TestExactAlgorithm)
                        sumOfTimesForExact += sw.Elapsed.TotalMilliseconds;

                    if (TestApproximatedAlgorithm)
                    {
                        sw.Restart();
                        //DO WORK APPROX ALGORITHM
                        approxAlgorithm.MaxCut();
                        //
                        sw.Stop();
                    }
                    ResultValues.Last().ApproximationCutSize = approxAlgorithm.CutSize;
                    ResultValues.Last().ApproximationSet = approxAlgorithm.OutputSet;

                    if (TestApproximatedAlgorithm)
                        sumOfTimesForApprox += sw.Elapsed.TotalMilliseconds;

                    counter++;
                    var lastProgress = currentProgress;
                    currentProgress = (int) (100.0*(counter/calculationsCount));
                    if (currentProgress != lastProgress)
                        bw.ReportProgress(currentProgress);
                }

                TimeValues.Last().ApproximationAlgorithmTime = sumOfTimesForApprox/
                                                               (double) iterationsPerTest;

                TimeValues.Last().ExactAlgorithmTime = sumOfTimesForExact/
                                                       (double) iterationsPerTest;
            }
        }
    }
}