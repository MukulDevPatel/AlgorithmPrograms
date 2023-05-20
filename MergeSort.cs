using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class MergeSort
    {
        public static void MergeSorting()
        {
            List<string> list = new List<string> { "apple", "orange", "banana", "grape", "kiwi" };

            Console.WriteLine("Before sorting:");
            PrintList(list);

            // Perform Merge Sort
            List<string> sortedList = MergeSortList(list);

            Console.WriteLine("\nAfter sorting:");
            PrintList(sortedList);
        }

        public static List<string> MergeSortList(List<string> list)
        {
            if (list.Count <= 1)
            {
                return list;
            }

            int mid = list.Count / 2;
            List<string> left = new List<string>();
            List<string> right = new List<string>();

            for (int i = 0; i < mid; i++)
            {
                left.Add(list[i]);
            }

            for (int i = mid; i < list.Count; i++)
            {
                right.Add(list[i]);
            }

            left = MergeSortList(left);
            right = MergeSortList(right);

            return Merge(left, right);
        }

        public static List<string> Merge(List<string> left, List<string> right)
        {
            List<string> mergedList = new List<string>();

            while (left.Count > 0 && right.Count > 0)
            {
                if (String.Compare(left[0], right[0], StringComparison.Ordinal) <= 0)
                {
                    mergedList.Add(left[0]);
                    left.RemoveAt(0);
                }
                else
                {
                    mergedList.Add(right[0]);
                    right.RemoveAt(0);
                }
            }

            while (left.Count > 0)
            {
                mergedList.Add(left[0]);
                left.RemoveAt(0);
            }

            while (right.Count > 0)
            {
                mergedList.Add(right[0]);
                right.RemoveAt(0);
            }

            return mergedList;
        }

        public static void PrintList(List<string> list)
        {
            foreach (string item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
