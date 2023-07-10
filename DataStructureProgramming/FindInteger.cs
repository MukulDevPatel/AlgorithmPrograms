using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms.DataStructureProgramming
{
    public class FindInteger
    {
        public static void Execute()
        {
            LinkedList<int> numbersList = new LinkedList<int>();

            // Read numbers from file and arrange in ascending order
            string filePath = @"D:\BridgeLabz Second batch\AlgorithmPrograms\DataStructureProgramming\IntegerFile.txt";
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                int number = int.Parse(line);
                InsertInOrder(numbersList, number);
            }

            Console.WriteLine("Enter a number:");
            int userInput = int.Parse(Console.ReadLine());

            // Check if number exists in the list
            LinkedListNode<int> node = numbersList.Find(userInput);
            if (node != null)
            {
                // Remove number from the list if found
                numbersList.Remove(node);
                Console.WriteLine("Number found and removed from the list.");
            }
            else
            {
                // Insert number in the appropriate position
                InsertInOrder(numbersList, userInput);
                Console.WriteLine("Number inserted in the appropriate position.");
            }

            // Write the updated list of numbers to file
            WriteNumbersToFile(numbersList, filePath);

            Console.WriteLine("Numbers written to file.");
        }

        static void InsertInOrder(LinkedList<int> list, int number)
        {
            if (list.Count == 0 || number < list.First.Value)
            {
                list.AddFirst(number);
                return;
            }

            LinkedListNode<int> current = list.First;
            while (current.Next != null && current.Next.Value < number)
            {
                current = current.Next;
            }

            list.AddAfter(current, number);
        }

        static void WriteNumbersToFile(LinkedList<int> list, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (int number in list)
                {
                    writer.WriteLine(number);
                }
            }
        }
    }
}
