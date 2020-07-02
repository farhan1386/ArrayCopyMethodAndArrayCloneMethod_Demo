using System;

namespace ArrayCopyMethodAndArrayCloneMethod_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = new int[10] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

            foreach (var item in Numbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Using Copy to Method ");

            int[] Number2 = new int[10];
            Numbers.CopyTo(Number2, 0);
            foreach (var item in Number2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Using Clone to Method ");
            int[] Number3 = (int[])Numbers.Clone();
            foreach (var item in Number3)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
