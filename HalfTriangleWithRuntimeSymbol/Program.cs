using System;

namespace PritingShapesWithRuntimeSympol
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Respective Rows");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("EnterSympol");
            string sympol = Console.ReadLine();
            for (int i = 0; i < number; ++i)
            {
                for (int j = 0; j <= i; ++j)
                {
                    Console.Write(sympol);
                }
                Console.WriteLine();

            }
        }
    }
}