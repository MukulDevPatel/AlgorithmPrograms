using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmGenerics
{
    public class AnagramGeneric
    {
        public static void Anagram()
        {
            // Read the two strings
            Console.Write("Enter the first string: ");
            string str1 = Console.ReadLine();

            Console.Write("Enter the second string: ");
            string str2 = Console.ReadLine();

            // Check if the strings are anagrams
            bool areAnagrams = CheckAnagram(str1, str2);

            // Print the result
            if (areAnagrams)
            {
                Console.WriteLine("The two strings are anagrams.");
            }
            else
            {
                Console.WriteLine("The two strings are not anagrams.");
            }
        }

        static bool CheckAnagram<T>(T str1, T str2) where T : IEnumerable<char>
        {
            // Convert the strings to character arrays
            char[] charArray1 = new List<char>(str1).ToArray();
            char[] charArray2 = new List<char>(str2).ToArray();

            // Sort the character arrays
            Array.Sort(charArray1);
            Array.Sort(charArray2);

            // Convert the character arrays back to strings
            string sortedStr1 = new string(charArray1);
            string sortedStr2 = new string(charArray2);

            // Compare the sorted strings
            return sortedStr1.Equals(sortedStr2);
        }
    }
}
