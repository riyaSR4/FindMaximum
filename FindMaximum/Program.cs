using System;

namespace FindMaximum
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation operation = new Operation();
            operation.FindMax(1, 2, 3);
            operation.FindMax(1.2f, 1.6f, 1.1f);
            operation.FindMax("a", "b", "c");

            GenericsMethod generics = new GenericsMethod();
            Console.WriteLine("Generics method:");
            generics.FindMax<int>(1, 2, 3);
            generics.FindMax<float>(1.2f, 1.6f, 1.1f);
            generics.FindMax<string>("a", "b", "c");
        }
       
    }
}