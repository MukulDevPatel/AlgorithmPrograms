using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms.DataStructureProgramming
{
    public class PrimeAnagramNumber
    {
        public static void CheckAnagramPrimeNum()
        {
            // Define the range
            int start = 0;
            int end = 1000;

            // Find prime numbers
            List<int> primes = FindPrimes(start, end);

            // Find anagrams among the prime numbers
            List<int> anagramPrimes = FindAnagramPrimes(primes);

            // Separate anagram and non-anagram numbers
            List<int> nonAnagramPrimes = primes.Except(anagramPrimes).ToList();

            // Store the prime numbers and their anagram status in a 2D array
            int[][] primeArrays = new int[10][];
            for (int i = 0; i < primeArrays.Length; i++)
            {
                List<int> primesInRange = primes.Where(p => p >= i * 100 && p < (i + 1) * 100).ToList();
                primeArrays[i] = primesInRange.ToArray();
            }

            // Print the prime numbers and their anagram status
            Console.WriteLine("Prime numbers and their anagram status:");
            for (int i = 0; i < primeArrays.Length; i++)
            {
                Console.Write($"\nRange {i * 100}-{(i + 1) * 100 - 1}: \n");
                foreach (int prime in primeArrays[i])
                {
                    bool isAnagram = anagramPrimes.Contains(prime);
                    Console.Write($"{prime} ({(isAnagram ? "Anagram" : "Non-Anagram")}) ");
                }
                Console.WriteLine();
            }

            // Print the numbers that are anagrams and non-anagrams
            Console.WriteLine("\nNumbers that are anagrams:");
            foreach (int prime in anagramPrimes)
            {
                Console.Write(prime + " ");
            }

            Console.WriteLine("\n\nNumbers that are not anagrams:");
            foreach (int prime in nonAnagramPrimes)
            {
                Console.Write(prime + " ");
            }
        }

        public static List<int> FindPrimes(int start, int end)
        {
            List<int> primes = new List<int>();

            for (int number = start; number <= end; number++)
            {
                if (IsPrime(number))
                {
                    primes.Add(number);
                }
            }

            return primes;
        }

        public static bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }

            for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
            {
                if (number % divisor == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static List<int> FindAnagramPrimes(List<int> primes)
        {
            List<int> anagramPrimes = new List<int>();

            foreach (int prime in primes)
            {
                string primeString = prime.ToString();
                char[] primeDigits = primeString.ToCharArray();
                Array.Sort(primeDigits);

                bool isAnagramPrime = true;

                foreach (int otherPrime in primes)
                {
                    if (prime != otherPrime)
                    {
                        string otherPrimeString = otherPrime.ToString();
                        if (primeString.Length != otherPrimeString.Length)
                        {
                            continue;
                        }

                        char[] otherPrimeDigits = otherPrimeString.ToCharArray();
                        Array.Sort(otherPrimeDigits);

                        bool isAnagram = true;
                        for (int i = 0; i < primeDigits.Length; i++)
                        {
                            if (primeDigits[i] != otherPrimeDigits[i])
                            {
                                isAnagram = false;
                                break;
                            }
                        }

                        if (isAnagram)
                        {
                            isAnagramPrime = false;
                            break;
                        }
                    }
                }

                if (isAnagramPrime)
                {
                    anagramPrimes.Add(prime);
                }
            }

            return anagramPrimes;
        }
    }
}
