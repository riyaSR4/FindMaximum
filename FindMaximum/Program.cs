using System;

namespace FindMaximum
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericsMethod generics = new GenericsMethod();
            Console.WriteLine("Enter the limit of array:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ehter the datatype of input:\n 1.Integer\n 2.Float\n 3.String\n 4.Exit");
            bool flag = true;
            while (flag)
            {
                int choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        int[] intarray = new int[n];
                        for(int i=0; i<n; i++)
                        {
                            intarray[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        generics.FindMax<int>(intarray);
                        break;
                    case 2:
                        float[] floatarray = new float[n];
                        for (int i = 0; i < n; i++)
                        {
                            floatarray[i] = Convert.ToSingle(Console.ReadLine());
                        }
                        generics.FindMax<float>(floatarray);
                        break;
                    case 3:
                        string[] stringarray = new string[n];
                        for (int i = 0; i < n; i++)
                        {
                            stringarray[i] = Console.ReadLine();
                        }
                        generics.FindMax<string>(stringarray);
                        break;
                    case 4:
                        flag = false;
                        break;
                    default:
                        break;
                }
            }
        }
       
    }
}