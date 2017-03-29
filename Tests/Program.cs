using System;
using FMI = Functional.Mathematic.Integer;
using System.Collections.Generic;

namespace Tests
{
    class Program
    {
        static void Print(string output)
        {
            Console.WriteLine(output);
        }

        static void TestIntegerMod()
        {
            List<(int aValue, int Result)> testValues = new List<(int aValue, int Result)>
            {
                (-3, 23), (-2, 24), (-1, 25), (0, 0), (1, 1), (2, 2), (3, 3)
            };
            const int n = 26;
            testValues.ForEach(tuple => {
                Print($"Testing Mathematic.Integer.mod({tuple.aValue}, {n}) == {tuple.Result} - {FMI.mod(tuple.aValue, n) == tuple.Result}");
            });
        }

        public static void TestIntegerRem()
        {
            List<(int aValue, int Result)> testValues = new List<(int aValue, int Result)>
            {
                (-3, -3), (-2, -2), (-1, -1), (0, 0), (1, 1), (2, 2), (3, 3)
            };
            const int n = 26;
            testValues.ForEach(tuple => {
                Print($"Testing Mathematic.Integer.rem({tuple.aValue}, {n}) == {tuple.Result} - {FMI.rem(tuple.aValue, n) == tuple.Result}");
            });
        }

        static void Main(string[] args)
        {
            // Allow detection of failure, currently you actually need to look at the output.
            TestIntegerMod();
            TestIntegerRem();

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
