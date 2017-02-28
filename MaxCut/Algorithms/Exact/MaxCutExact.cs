using System.Linq;
using MaxCut.DataTypes;

namespace MaxCut.Algorithms.Exact
{
    internal class MaxCutExact : MaxCutAlgorithm
    {
        public override int MaxCut()
        {
            // Thread.Sleep(InputGraph.N*2);
            //throw new NotImplementedException();
            //return Utility.Random(0, InputGraph.N);

            //brute force instead of branch and bound cause I dont know how:

            var optimalCut = 0;
            Set<int> optimalSet = null;

            //var setPrime = new Set<int>();

            var set = new Set<int>(Enumerable.Range(0, InputGraph.N));

            for (var removeIndicesCount = 1; removeIndicesCount < InputGraph.N; removeIndicesCount++)
            {
                var possibleSets = set.Combinations(removeIndicesCount); //takes most time

                foreach (var possibleSet in possibleSets)
                {
                    var currentSetPrime = new Set<int>(possibleSet);
                    var currentSet = new Set<int>(Enumerable.Range(0, InputGraph.N).Except(currentSetPrime));
                    var currentCut = InputGraph.CutSize(currentSet, currentSetPrime);

                    if (currentCut > optimalCut)
                    {
                        optimalCut = currentCut;
                        optimalSet = currentSet;
                    }
                }
            }


            OutputSet = optimalSet;
            CutSize = optimalCut;
            return optimalCut;
        }
    }
}