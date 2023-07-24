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
                T max = a;
                PrintMax(max);
            }

            if (comparer.Compare(b, a) >= 0 && comparer.Compare(b, c) >= 0)
            {
                T max = b;
                PrintMax(max);
            }

            if (comparer.Compare(c, a) >= 0 && comparer.Compare(c, b) >= 0)
            { 
                T max = c;
                PrintMax(max);
            }
        }
        public void PrintMax<T>(T max)
        {
            Console.WriteLine("Maximum value: " + max);
        }
    }
}
