using System;

namespace PritingShapesWithRuntimeSympol
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Respective Rows");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("EnterSympol");
            String Sympol = Console.ReadLine();
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j <= i; ++j)
                {
                    Console.Write(Sympol);
                }
                Console.WriteLine();

            }
        }
    }
}