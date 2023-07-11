using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }

        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }

    public class Queue
    {
        private Node front;
        private Node rear;

        public Queue()
        {
            front = null;
            rear = null;
        }

        public void Enqueue(int data)
        {
            Node newNode = new Node(data);

            if (rear == null)
            {
                front = newNode;
                rear = newNode;
            }
            else
            {
                rear.Next = newNode;
                rear = newNode;
            }
        }

        public int Dequeue()
        {
            if (front == null)
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            int data = front.Data;
            front = front.Next;

            if (front == null)
            {
                rear = null;
            }

            return data;
        }

        public bool IsEmpty()
        {
            return front == null;
        }
    }
    public class PrimeAnagramNumbersUsingQueue
    {
        public static bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static bool AreAnagrams(int number1, int number2)
        {
            char[] num1 = number1.ToString().ToCharArray();
            char[] num2 = number2.ToString().ToCharArray();

            Array.Sort(num1);
            Array.Sort(num2);

            return new string(num1) == new string(num2);
        }

        public static void Execute()
        {
            Queue primeAnagramQueue = new Queue();

            for (int i = 0; i <= 1000; i++)
            {
                if (IsPrime(i))
                {
                    for (int j = i + 1; j <= 1000; j++)
                    {
                        if (IsPrime(j) && AreAnagrams(i, j))
                        {
                            primeAnagramQueue.Enqueue(i);
                            primeAnagramQueue.Enqueue(j);
                        }
                    }
                }
            }

            Console.WriteLine("Prime numbers that are anagrams:");
            while (!primeAnagramQueue.IsEmpty())
            {
                int prime1 = primeAnagramQueue.Dequeue();
                int prime2 = primeAnagramQueue.Dequeue();
                Console.WriteLine($"{prime1} and {prime2}");
            }
        }
    }
}
