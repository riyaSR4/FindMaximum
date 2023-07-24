using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximum
{
    public class GenericsMethod
    {
        public void FindMax<T>(T[] ar)
        {
            Array.Sort(ar);
            PrintMax(ar.Max());
        }
        public void PrintMax<T>(T max)
        {
            Console.WriteLine("Maximum value: " + max);
        }
    }
}
