using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmGenerics
{
    public class InsertionGeneric
    {
        public static void Sorting()
        {
            // Read the list of words
            Console.WriteLine("Enter a list of words (comma-separated):");
            string input = Console.ReadLine();
            string[] words = input.Split(',');

            // Sort the words using insertion sort
            InsertionSort(words);

            // Print the sorted list
            Console.WriteLine("Sorted List:");
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }

        static void InsertionSort<T>(T[] array) where T : IComparable<T>
        {
            for (int i = 1; i < array.Length; i++)
            {
                T key = array[i];
                int j = i - 1;

                while (j >= 0 && array[j].CompareTo(key) > 0)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }

                array[j + 1] = key;
            }
        }
    }
}
