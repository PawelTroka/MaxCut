using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaxCut.DataTypes
{
    internal class Set<T> : List<T>
    {
        public Set()
        {
        }

        public Set(IEnumerable<T> set) : base(set)
        {
        }

        public static Set<T> operator +(Set<T> b, T c)
        {
            var newSet = new Set<T>(b) {c};
            return newSet;
        }

        public static Set<T> operator -(Set<T> b, T c)
        {
            var newSet = new Set<T>(b);
            newSet.Remove(c);
            return newSet;
        }

        public T Remove(T item)
        {
            return (base.Remove(item)) ? item : default(T);
        }

        public T RemoveAt(int index)
        {
            var item = this[index];
            base.RemoveAt(index);

            return item;
        }

        public override string ToString()
        {
            var sb = new StringBuilder("{");
            for (var i = 0; i < Count; i++)
            {
                sb.AppendFormat(i == Count - 1 ? "{0}" : "{0}, ", this[i]);
            }
            sb.Append("}");
            return sb.ToString();
        }

        public IEnumerable<IEnumerable<T>> Combinations(int k)
        {
            return k == 0
                ? new[] {new T[0]}
                : this.SelectMany((e, i) =>
                    this.Skip(i + 1).Combinations(k - 1).Select(c => (new[] {e}).Concat(c)));
        }
    }

    public static class EnumerableExtension
    {
        public static IEnumerable<IEnumerable<T>> Combinations<T>(this IEnumerable<T> elements, int k)
        {
            return k == 0
                ? new[] {new T[0]}
                : elements.SelectMany((e, i) =>
                    elements.Skip(i + 1).Combinations(k - 1).Select(c => (new[] {e}).Concat(c)));
        }
    }
}