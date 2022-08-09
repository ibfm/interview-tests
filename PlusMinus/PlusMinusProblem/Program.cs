using System;
using System.Collections.Generic;
using System.Linq;

namespace PlusMinusProblem
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

            }

        }
    }
}
