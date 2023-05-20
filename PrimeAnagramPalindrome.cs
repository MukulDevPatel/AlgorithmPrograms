using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class PrimeAnagramPalindrome
    {
        public static void CheckAnagramPalindrome()
        {
            List<int> primes = FindPrimes(0, 1000);
            List<int> anagramPrimes = FindAnagramPrimes(primes);
            List<int> palindromePrimes = FindPalindromePrimes(primes);

            Console.WriteLine("Prime Numbers:");
            Console.WriteLine(string.Join(", ", primes));

            Console.WriteLine("\nAnagram Prime Numbers:");
            Console.WriteLine(string.Join(", ", anagramPrimes));

            Console.WriteLine("\nPalindrome Prime Numbers:");
            Console.WriteLine(string.Join(", ", palindromePrimes));
        }

        // Method to check if a number is prime
        public static bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        // Method to find prime numbers in a range
        public static List<int> FindPrimes(int start, int end)
        {
            List<int> primes = new List<int>();

            for (int i = start; i <= end; i++)
            {
                if (IsPrime(i))
                {
                    primes.Add(i);
                }
            }

            return primes;
        }

        // Method to check if two numbers are anagrams
        public static bool AreAnagrams(int number1, int number2)
        {
            char[] digits1 = number1.ToString().ToCharArray();
            char[] digits2 = number2.ToString().ToCharArray();

            Array.Sort(digits1);
            Array.Sort(digits2);

            return new string(digits1) == new string(digits2);
        }

        // Method to find prime numbers that are anagrams
        public static List<int> FindAnagramPrimes(List<int> primes)
        {
            List<int> anagramPrimes = new List<int>();

            for (int i = 0; i < primes.Count; i++)
            {
                for (int j = i + 1; j < primes.Count; j++)
                {
                    if (AreAnagrams(primes[i], primes[j]))
                    {
                        anagramPrimes.Add(primes[i]);
                    }
                }
            }

            return anagramPrimes;
        }

        // Method to check if a number is a palindrome
        public static bool IsPalindrome(int number)
        {
            string numberString = number.ToString();
            int left = 0;
            int right = numberString.Length - 1;

            while (left < right)
            {
                if (numberString[left] != numberString[right])
                {
                    return false;
                }

                left++;
                right--;
            }

            return true;
        }

        // Method to find prime numbers that are palindromes
        public static List<int> FindPalindromePrimes(List<int> primes)
        {
            List<int> palindromePrimes = new List<int>();

            foreach (int prime in primes)
            {
                if (IsPalindrome(prime))
                {
                    palindromePrimes.Add(prime);
                }
            }

            return palindromePrimes;
        }
    }
}
