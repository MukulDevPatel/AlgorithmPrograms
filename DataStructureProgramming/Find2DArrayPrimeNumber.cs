using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms.DataStructureProgramming
{
    public class Find2DArrayPrimeNumber
    {
        public static void GetPrimeNum()
        {
            int rangeSize = 100; // Size of each range
            int numRanges = 11; // Number of ranges

            int[,] primeArray = new int[numRanges, rangeSize]; // 2D array to store prime numbers

            int startNum = 0;
            int endNum = rangeSize;

            for (int i = 0; i < numRanges; i++)
            {
                int primeCount = 0; // Number of prime numbers in the current range

                for (int num = startNum; num < endNum; num++)
                {
                    if (IsPrime(num))
                    {
                        primeArray[i, primeCount] = num; // Store the prime number in the array
                        primeCount++;
                    }
                }

                startNum = endNum;
                endNum += rangeSize;
            }

            // Print the prime numbers in the 2D array
            for (int i = 0; i < numRanges; i++)
            {
                Console.Write($"Range {i}: ");
                for (int j = 0; j < rangeSize; j++)
                {
                    if (primeArray[i, j] != 0)
                        Console.Write(primeArray[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        // Function to check if a number is prime
        static bool IsPrime(int number)
        {
            if (number < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    }
}
