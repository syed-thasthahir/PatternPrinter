using System;

namespace PrintingShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Respective Rows");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Symbol");
            string symbol1 = Console.ReadLine();
            Console.WriteLine("Enter The Symbol");
            string symbol2 = Console.ReadLine();
            for (int i = 1; i <= number; ++i)
            {
                for (int j = 1; j <= i; ++j)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(symbol1);
                    }
                    else
                    {
                        Console.Write(symbol2);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
