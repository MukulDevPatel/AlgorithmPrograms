using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class BubbleSort
    {
        public static void Sorting()
        {
            Console.WriteLine("Enter the integers (separated by spaces):");
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');

            // Split the input number into an array of words
            int[] arr = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                arr[i] = int.Parse(numbers[i]);
            }

            // Sort the words using Bubble sort
            SortAlgorithm(arr);

            // Print the sorted list
            Console.WriteLine("Sorted list:");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
        }
        static void SortAlgorithm(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // Swap arr[j] and arr[j+1]
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
    }
}
