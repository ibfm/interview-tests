using System;
using System.Collections.Generic;
using System.Linq;

namespace PlusMinusSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ')
                .ToList()
                .Select(arrTemp => Convert.ToInt32(arrTemp))
                .ToList();

            Result.plusMinus(arr);
        }
        class Result
        {

            /*
             * Complete the 'plusMinus' function below.
             *
             * The function accepts INTEGER_ARRAY arr as parameter.
             */

            public static void plusMinus(List<int> arr)
            {
                decimal positives = arr.Where(x => x > 0).Count();
                decimal positiveRatios = positives / arr.Count;
                Console.WriteLine(positiveRatios.ToString("N6"));

                decimal negatives = arr.Where(x => x < 0).Count();
                decimal negativeRatios = negatives / arr.Count;
                Console.WriteLine(negativeRatios.ToString("N6"));

                decimal zeros = arr.Where(x => x == 0).Count();
                decimal zeroRatios = zeros / arr.Count;
                Console.WriteLine(zeroRatios.ToString("N6"));
            }

        }
    }
}
