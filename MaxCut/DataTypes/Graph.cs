using System.Collections.Generic;

namespace MaxCut.DataTypes
{
    internal class Graph
    {
        private readonly int[,] _values;

        public Graph(int n)
        {
            N = n;
            M = 0;
            _values = new int[N, N];

            for (var i = 0; i < N; i++)
                for (var j = i + 1; j < N; j++)
                {
                    _values[j, i] = _values[i, j] = Utility.Random(0, 1);
                    //_values[i, j] = Utility.Random(0, 1);
                    M += _values[i, j];
                }
        }

        public Graph(int n, int initialValue)
        {
            N = n;
            M = 0;
            _values = new int[N, N];

            for (var i = 0; i < N; i++)
                for (var j = i + 1; j < N; j++)
                {
                    _values[j, i] = _values[i, j] = initialValue;
                    M += initialValue;
                }
        }

        public int N { get; private set; }
        public int M { get; private set; }

        public int this[int i, int j]
        {
            get { return _values[i, j]; }
            //set { _values[i, j] = value; }
        }

        public int CutSize(List<int> set)
        {
            var size = 0;
            foreach (var i in set)
            {
                for (var j = 0; j < N; j++)
                    if (!set.Contains(j))
                        size += this[i, j];
            }
            return size;
        }

        public int CutSize(List<int> set, List<int> setPrime)
        {
            var size = 0;
            foreach (var i in set)
            {
                foreach (var j in setPrime)
                {
                    size += this[i, j];
                }
            }
            return size;
        }

        public override string ToString()
        {
            return "G(|V|=" + N + ", |E|=" + M + ")";
        }
    }
}