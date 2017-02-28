using MaxCut.DataTypes;

namespace MaxCut.Algorithms
{
    internal abstract class MaxCutAlgorithm
    {
        public Graph InputGraph { get; set; }
        public Set<int> OutputSet { get; protected set; }
        public int CutSize { get; protected set; }
        public abstract int MaxCut();
    }
}