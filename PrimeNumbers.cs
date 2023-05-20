using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class PrimeNumbers
    {
        public static void PrimeNum()
        {
            int a, n;
            int mn = 0;
            int mx = 1000;
            Console.Write("Prime numbers of range: {0} to {1}\n", mn, mx);

            for (n = mn; n <= mx; n++)
            {
                //Extract prime number to given range, a or flag
                //loop the iteration for sqrt(n) times
                a = 0;
                for (int i = 2; i <= (int)Math.Sqrt(n); i++)
                {
                    if ((n % i) == 0)
                    {
                        a++;
                        break;
                    }
                }
                if (a == 0 && n != 1)
                {
                    Console.Write("{0} ", n);
                }
            }
        }
    }
}
