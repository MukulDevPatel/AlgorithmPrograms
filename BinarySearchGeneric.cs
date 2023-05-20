using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmGenerics
{
    public class BinarySearchGeneric
    {
        public static void WordSearch()
        {
            // Read the list of words from a file
            List<string> wordList = ReadWordListFromFile(@"D:\BridgeLabz Second batch\AlgorithmPrograms\File.txt");

            // Prompt the user to enter a word to search
            Console.Write("Enter a word to search: ");
            string searchWord = Console.ReadLine();

            // Sort the word list
            wordList.Sort();

            // Perform binary search
            bool isWordFound = BinarySearch(wordList, searchWord);

            // Print the result
            if (isWordFound)
            {
                Console.WriteLine("The word was found in the list.");
            }
            else
            {
                Console.WriteLine("The word was not found in the list.");
            }
        }

        static List<string> ReadWordListFromFile(string filePath)
        {
            string fileContent = File.ReadAllText(filePath);
            string[] words = fileContent.Split(' ');

            return new List<string>(words);
        }

        static bool BinarySearch(List<string> wordList, string searchWord)
        {
            int left = 0;
            int right = wordList.Count - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                int comparisonResult = string.Compare(wordList[mid], searchWord);

                if (comparisonResult == 0)
                {
                    return true; // Word found
                }
                else if (comparisonResult < 0)
                {
                    left = mid + 1; // Search in the right half
                }
                else
                {
                    right = mid - 1; // Search in the left half
                }
            }

            return false; // Word not found
        }
    }
}
