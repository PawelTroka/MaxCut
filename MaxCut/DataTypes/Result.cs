namespace MaxCut.DataTypes
{
    internal class Result
    {
        public Graph Graph { get; set; }
        public int ApproximationCutSize { get; set; }
        public Set<int> ApproximationSet { get; set; }
        public int ExactCutSize { get; set; }
        public Set<int> ExactSet { get; set; }
    }
}