using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximum
{
    public class GenericsMethod
    {
        public void FindMax<T>(T a, T b, T c)
        {
            Comparer<T> comparer = Comparer<T>.Default;
            if (comparer.Compare(a, b) >= 0 && comparer.Compare(a, c) >= 0)
            {
                Console.WriteLine(a + " is max");
            }

            if (comparer.Compare(b, a) >= 0 && comparer.Compare(b, c) >= 0)
            {
                Console.WriteLine(b + " is max");
            }

            if (comparer.Compare(c, a) >= 0 && comparer.Compare(c, b) >= 0)
            {
                Console.WriteLine(c + " is max");
            }
        }
    }
}
