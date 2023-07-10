using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms.DataStructureProgramming
{
    public class AnagramInReverseOrder
    {
        public static void ReverseAnagram()
        {
            LinkedList<string> anagramList = new LinkedList<string>();

            for (int number = 0; number <= 1000; number++)
            {
                if (IsPrime(number))
                {
                    string numberString = number.ToString();
                    string sortedNumberString = SortString(numberString);

                    if (anagramList.Contains(sortedNumberString))
                    {
                        anagramList.AddLast(numberString);
                    }
                    else
                    {
                        LinkedListNode<string> node = anagramList.Find(sortedNumberString);
                        if (node != null)
                        {
                            anagramList.AddAfter(node, numberString);
                        }
                        else
                        {
                            anagramList.AddFirst(numberString);
                        }
                    }
                }
            }

            Console.WriteLine("Anagrams in reverse order:\n");

            while (anagramList.Last != null)
            {
                Console.Write(anagramList.Last.Value+" ");
                anagramList.RemoveLast();
            }
        }

        static bool IsPrime(int number)
        {
            if (number < 2)
                return false;

            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

        static string SortString(string input)
        {
            char[] characters = input.ToCharArray();
            Array.Sort(characters);
            return new string(characters);
        }
    }
}
