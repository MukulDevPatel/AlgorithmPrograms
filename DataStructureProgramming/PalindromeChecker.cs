using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms.DataStructureProgramming
{
    public class PalindromeChecker
    {
        public static void CheckerExecute()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            if (IsPalindrome(input))
            {
                Console.WriteLine("The string is a palindrome.");
            }
            else
            {
                Console.WriteLine("The string is not a palindrome.");
            }
        }
        public static bool IsPalindrome(string input)
        {
            // Create a deque to store the characters
            var deque = new Deque<char>();

            // Add each character from the string to the rear of the deque
            foreach (char c in input)
            {
                deque.AddRear(c);
            }

            // Compare characters from both ends of the deque
            while (deque.Size() > 1)
            {
                if (deque.RemoveFront() != deque.RemoveRear())
                {
                    return false; // Characters don't match, not a palindrome
                }
            }

            return true; // All characters matched, it's a palindrome
        }
    }
    public class Deque<T>
    {
        private LinkedList<T> items;

        public Deque()
        {
            items = new LinkedList<T>();
        }

        public void AddFront(T item)
        {
            items.AddFirst(item);
        }

        public void AddRear(T item)
        {
            items.AddLast(item);
        }

        public T RemoveFront()
        {
            if (items.Count == 0)
                throw new InvalidOperationException("Deque is empty");

            T item = items.First.Value;
            items.RemoveFirst();
            return item;
        }

        public T RemoveRear()
        {
            if (items.Count == 0)
                throw new InvalidOperationException("Deque is empty");

            T item = items.Last.Value;
            items.RemoveLast();
            return item;
        }

        public int Size()
        {
            return items.Count;
        }
    }
}
