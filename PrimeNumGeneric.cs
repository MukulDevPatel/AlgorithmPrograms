using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmGenerics
{
    public class PrimeNumGeneric
    {
        public static void PrimeNum()
        {
            List<int> primeNumbers = FindPrimeNumbers(0, 1000);

            Console.WriteLine("Prime Numbers in the range of 0 - 1000:");
            foreach (int number in primeNumbers)
            {
                Console.Write(number+", ");
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
    }
}
