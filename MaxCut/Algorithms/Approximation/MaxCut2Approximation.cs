using System.Linq;
using MaxCut.DataTypes;

namespace MaxCut.Algorithms.Approximation
{
    internal class MaxCut2Approximation : MaxCutAlgorithm
    {
        /*
         *
         * 
         */

        public override int MaxCut()
        {
            var currentCut = 0;
            var set = new Set<int>();

            var setPrime = new Set<int>(Enumerable.Range(0, InputGraph.N));

            var any = true;
            while (any)
            {
                any = false;

                foreach (var v in setPrime)
                {
                    var candidateCut = InputGraph.CutSize(set + v, setPrime - v);

                    if (candidateCut <= currentCut) continue;

                    currentCut = candidateCut;
                    set.Add(setPrime.Remove(v));
                    any = true;
                    break;
                }

                if (any) continue;
                foreach (var v in set)
                {
                    var candidateCut = InputGraph.CutSize(set - v, setPrime + v);

                    if (candidateCut <= currentCut) continue;

                    currentCut = candidateCut;
                    setPrime.Add(set.Remove(v));
                    any = true;
                    break;
                }
            }

            OutputSet = set;
            CutSize = currentCut;
            return currentCut;
        }
    }
}