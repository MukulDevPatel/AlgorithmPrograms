using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class Anagram
    {
        public static void CheckAnagram()
        {
            Console.WriteLine("Enter words to check for anagram");
            Console.Write("Enter first word: ");
            string word1 = Console.ReadLine();
            Console.Write("Enter second word: ");
            string word2 = Console.ReadLine();
            if (word1.Length != word2.Length)
                Console.WriteLine("given words are not anagram");
            else
            {
                word1 = word1.ToLower().Replace(" ", "");
                word2 = word2.ToLower().Replace(" ", "");

                char[] result1 = word1.ToCharArray();
                Array.Sort(result1);

                char[] result2 = word2.ToCharArray();
                Array.Sort(result2);

                string word1Sorted = new string(result1);
                string word2Sorted = new string(result2);

                if (word1Sorted == word2Sorted)
                { Console.WriteLine("Anagram"); }
                else
                { Console.WriteLine("Not an anagram"); }
            }
        }
    }
}
