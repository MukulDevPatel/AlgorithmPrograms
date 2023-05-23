using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms.DataStructureProgramming
{
    public class LinkedList
    {
        private Node head;

        //For add any word in the list
        public void AddWord(string word)
        {
            if (head == null)
            {
                head = new Node(word);
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    if (current.Data.Equals(word))
                    {
                        RemoveWord(word);
                        return;
                    }
                    current = current.Next;
                }

                if (current.Data.Equals(word))
                {
                    RemoveWord(word);
                    return;
                }

                current.Next = new Node(word);
            }
        }

        //For remove the word from the list, if that is exixt
        public void RemoveWord(string word)
        {
            if (head == null)
                return;

            if (head.Data.Equals(word))
            {
                head = head.Next;
                return;
            }

            Node current = head;
            while (current.Next != null)
            {
                if (current.Next.Data.Equals(word))
                {
                    current.Next = current.Next.Next;
                    return;
                }
                current = current.Next;
            }
        }

        //Final result save in the file
        public void SaveToFile(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                Node current = head;
                while (current != null)
                {
                    writer.WriteLine(current.Data);
                    current = current.Next;
                }
            }
        }

        //This will give result in boolean form (true or false)
        public bool SearchWord(string word)
        {
            Node current = head;
            while (current != null)
            {
                if (current.Data.Equals(word))
                    return true;

                current = current.Next;
            }
            return false;
        }

        //This is display the result
        public void Print()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
        }
    }
}
