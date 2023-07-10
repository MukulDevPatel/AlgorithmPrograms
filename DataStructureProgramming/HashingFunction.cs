using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms.DataStructureProgramming
{
    public class HashingFunction
    {
        private const int NumberOfSlots = 10;
        private LinkedList<int>[] slots;

        public HashingFunction()
        {
            slots = new LinkedList<int>[NumberOfSlots];
            for (int i = 0; i < NumberOfSlots; i++)
            {
                slots[i] = new LinkedList<int>();
            }
        }

        private int GetSlotNumber(int number)
        {
            return number % NumberOfSlots;
        }

        public void InsertNumber(int number)
        {
            int slotNumber = GetSlotNumber(number);
            slots[slotNumber].AddLast(number);
        }

        public bool SearchNumber(int number)
        {
            int slotNumber = GetSlotNumber(number);
            return slots[slotNumber].Contains(number);
        }

        public void SaveToFile(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                for (int i = 0; i < NumberOfSlots; i++)
                {
                    foreach (int number in slots[i])
                    {
                        writer.WriteLine(number);
                    }
                }
            }
        }
        public static void HashingCheck()
        {
            HashingFunction hashingFunction = new HashingFunction();

            // Read numbers from a file and insert into the hashing function
            string filePath = @"D:\BridgeLabz Second batch\AlgorithmPrograms\DataStructureProgramming\HashingFile.txt";
            string[] numbersFromFile = File.ReadAllLines(filePath);
            foreach (string numberStr in numbersFromFile)
            {
                int number = int.Parse(numberStr);
                hashingFunction.InsertNumber(number);
            }

            // Take user input to search for a number
            Console.Write("Enter a number to search: ");
            int searchNumber = int.Parse(Console.ReadLine());

            bool found = hashingFunction.SearchNumber(searchNumber);
            if (found)
            {
                Console.WriteLine("Number found!");
            }
            else
            {
                Console.WriteLine("Number not found.");
                hashingFunction.InsertNumber(searchNumber);
            }

            // Save the numbers to a file
            string outputFilePath = @"D:\BridgeLabz Second batch\AlgorithmPrograms\DataStructureProgramming\HashingFile2.txt";
            hashingFunction.SaveToFile(outputFilePath);

            Console.WriteLine("Numbers saved to file: " + outputFilePath);
        }
    }
}
