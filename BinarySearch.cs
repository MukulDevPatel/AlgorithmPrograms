using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class BinarySearch
    {
        public static void SearchWord(string filePath)
        {
            // Read the list of words from the file
            string[] words = File.ReadAllText(filePath).Split(' ');

            // Sort the word list
            Array.Sort(words);

            // Prompt the user to enter a word to search
            Console.Write("Enter a word to search: ");
            string searchWord = Console.ReadLine();

            // Perform binary search
            int index = Array.BinarySearch(words, searchWord);

            // Print the result
            if (index >= 0)
            {
                Console.WriteLine("The word '{0}' is found in the list.", searchWord);
            }
            else
            {
                Console.WriteLine("The word '{0}' is not found in the list.", searchWord);
            }
        }
    }
}
