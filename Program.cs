using System;

namespace ExemplosValueTypesEReferencesTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // int, float, double, bool, char...
            int x = 10;
            Console.WriteLine(x);
            SumTwo(x);
            Console.WriteLine(x);
            Console.ReadKey();
        }

        static void SumTwo(int number)
        {
            number += 2;
        }
    }
}
