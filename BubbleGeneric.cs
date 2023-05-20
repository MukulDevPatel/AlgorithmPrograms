using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmGenerics
{
    public class BubbleGeneric
    {
        public static void BubbleSort()
        {
            // Read the list of integers
            Console.WriteLine("Enter a list of integers (comma-separated):");
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');


            int[] array = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                array[i] = int.Parse(numbers[i]);
            }

            // Sort the integers using bubble sort
            BubbleSort(array);

            // Print the sorted list
            Console.WriteLine("Sorted List:");
            foreach (int num in array)
            {
                Console.WriteLine(num);
            }
        }

        static void BubbleSort<T>(T[] arr) where T : IComparable<T>
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) > 0)
                    {
                        // Swap elements arr[j] and arr[j + 1]
                        T temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
    }
}
