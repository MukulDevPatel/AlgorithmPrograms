using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class InsertionSort
    {
        public static void InsertSort()
        {
            Console.WriteLine("Enter a list of words (separated by spaces):");
            string input = Console.ReadLine();

            // Split the input string into an array of words
            string[] words = input.Split(' ');

            // Sort the words using insertion sort
            Sorting(words);

            // Print the sorted list
            Console.WriteLine("Sorted List:");
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
        public static void Sorting(string[] arr)
        {
            int n = arr.Length;

            for (int i = 1; i < n; i++)
            {
                string key = arr[i];
                int j = i - 1;

                // Move elements greater than the key to one position ahead
                while (j >= 0 && arr[j].CompareTo(key) > 0)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }

                arr[j + 1] = key;
            }
        }
    }
}
