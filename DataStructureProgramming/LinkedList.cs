using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms.DataStructureProgramming
{
    public class LinkedList
    {
        private Nodes head;

        //For add any word in the list
        public void AddWord(string word)
        {
            if (head == null)
            {
                head = new Nodes(word);
            }
            else
            {
                Nodes current = head;
                while (current.Next != null)
                {
                    if (current.Value.Equals(word))
                    {
                        RemoveWord(word);
                        return;
                    }
                    current = current.Next;
                }

                if (current.Value.Equals(word))
                {
                    RemoveWord(word);
                    return;
                }

                current.Next = new Nodes(word);
            }
        }

        //For remove the word from the list, if that is exixt
        public void RemoveWord(string word)
        {
            if (head == null)
                return;

            if (head.Value.Equals(word))
            {
                head = head.Next;
                return;
            }

            Nodes current = head;
            while (current.Next != null)
            {
                if (current.Next.Value.Equals(word))
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
                Nodes current = head;
                while (current != null)
                {
                    writer.WriteLine(current.Value);
                    current = current.Next;
                }
            }
        }

        //This will give result in boolean form (true or false)
        public bool SearchWord(string word)
        {
            Nodes current = head;
            while (current != null)
            {
                if (current.Value.Equals(word))
                    return true;

                current = current.Next;
            }
            return false;
        }

        //This is display the result
        public void Print()
        {
            Nodes current = head;
            while (current != null)
            {
                Console.Write(current.Value + " ");
                current = current.Next;
            }
        }
    }
}
