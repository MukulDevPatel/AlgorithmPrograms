using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmGenerics
{
    public class AnagramPalindromeGeneric
    {
        public static void FindAnaPalinrome()
        {
            List<int> primeNumbers = FindPrimeNumbers(0, 1000);
            List<int> anagramPrimes = FindAnagramPrimes(primeNumbers);
            List<int> palindromePrimes = FindPalindromePrimes(primeNumbers);

            Console.WriteLine("Prime Numbers in the range of 0 - 1000:");
            foreach (int number in primeNumbers)
            {
                Console.Write(number + ", ");
            }

            Console.WriteLine("\nAnagram Prime Numbers:");
            foreach (int number in anagramPrimes)
            {
                Console.Write(number + ", ");
            }

            Console.WriteLine("\nPalindrome Prime Numbers:");
            foreach (int number in palindromePrimes)
            {
                Console.Write(number + ", ");
            }
        }

        static List<int> FindPrimeNumbers<T>(T start, T end) where T : IComparable<T>, IEquatable<T>
        {
            int startNumber = Convert.ToInt32(start);
            int endNumber = Convert.ToInt32(end);

            List<int> primes = new List<int>();

            for (int number = startNumber; number <= endNumber; number++)
            {
                if (IsPrime(number))
                {
                    primes.Add(number);
                }
            }

            return primes;
        }

        static bool IsPrime(int number)
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

        static List<int> FindAnagramPrimes(List<int> primeNumbers)
        {
            List<int> anagramPrimes = new List<int>();

            foreach (int number in primeNumbers)
            {
                if (IsAnagramPrime(number))
                {
                    anagramPrimes.Add(number);
                }
            }

            return anagramPrimes;
        }

        static bool IsAnagramPrime(int number)
        {
            char[] digits = number.ToString().ToCharArray();
            Array.Sort(digits);

            string sortedNumber = new string(digits);
            int sortedInt = int.Parse(sortedNumber);

            return sortedInt == number && IsPrime(number);
        }

        static List<int> FindPalindromePrimes(List<int> primeNumbers)
        {
            List<int> palindromePrimes = new List<int>();

            foreach (int number in primeNumbers)
            {
                if (IsPalindromePrime(number))
                {
                    palindromePrimes.Add(number);
                }
            }

            return palindromePrimes;
        }

        static bool IsPalindromePrime(int number)
        {
            string numString = number.ToString();
            int length = numString.Length;

            for (int i = 0; i < length / 2; i++)
            {
                if (numString[i] != numString[length - i - 1])
                {
                    return false;
                }
            }

            return IsPrime(number);
        }
    }
}
