using System;

namespace pattern
{
    class Program
    {
        static void Main(string[] args)
        {
             for (int row = 8; row >= 1; --row)
            {
            for (int col = 1; col <= row; ++col)
            {
               System.Console.Write("*");
            }
            
            System.Console.WriteLine();
            }
        //     Console.WriteLine("Hello World!");
        //    string Age = Console.ReadLine();
           //int Ages= 1 + Age;
            //Console.WriteLine(Age);
            

        }
    }
}
