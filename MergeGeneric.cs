using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmGenerics
{
    public class MergeGeneric
    {
        public static void MergeSort()
        {
            // Read the list of strings
            Console.WriteLine("Enter a list of strings (comma-separated):");
            string input = Console.ReadLine();
            string[] words = input.Split(' ');

            // Sort the strings using merge sort
            MergeSort(words);

            // Print the sorted list
            Console.WriteLine("Sorted List:");
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }

        static void MergeSort<T>(T[] arr) where T : IComparable<T>
        {
            if (arr.Length <= 1)
                return;

            int mid = arr.Length / 2;
            T[] left = new T[mid];
            T[] right = new T[arr.Length - mid];

            Array.Copy(arr, 0, left, 0, mid);
            Array.Copy(arr, mid, right, 0, arr.Length - mid);

            MergeSort(left);
            MergeSort(right);

            Merge(arr, left, right);
        }

        static void Merge<T>(T[] arr, T[] left, T[] right) where T : IComparable<T>
        {
            int i = 0, j = 0, k = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i].CompareTo(right[j]) <= 0)
                    arr[k++] = left[i++];
                else
                    arr[k++] = right[j++];
            }

            while (i < left.Length)
                arr[k++] = left[i++];

            while (j < right.Length)
                arr[k++] = right[j++];
        }
    }
}
