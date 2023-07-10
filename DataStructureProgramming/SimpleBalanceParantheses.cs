using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms.DataStructureProgramming
{
    public class SimpleBalanceParantheses
    {
        public static void Execute()
        {
            string input = "(5+6)*(7+8)/(4+3)(5+6)*(7+8)/(4+3)";
            bool isBalanced = IsBalanced(input);

            Console.WriteLine("Arithmetic Expression is balanced: " + isBalanced);
        }

        public static bool IsBalanced(string expression)
        {
            Stack stack = new Stack();

            foreach (char ch in expression)
            {
                if (ch == '(')
                {
                    stack.Push(ch);
                }
                else if (ch == ')')
                {
                    if (stack.IsEmpty())
                    {
                        return false; // Unbalanced if stack is empty
                    }
                    stack.Pop();
                }
            }

            return stack.IsEmpty();
        }
    }

    public class Stack
    {
        private List<char> stack;

        public Stack()
        {
            stack = new List<char>();
        }

        public void Push(char item)
        {
            stack.Add(item);
        }

        public char Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty");
            }

            int lastIndex = stack.Count - 1;
            char item = stack[lastIndex];
            stack.RemoveAt(lastIndex);
            return item;
        }

        public char Peak()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty");
            }

            return stack[stack.Count - 1];
        }

        public bool IsEmpty()
        {
            return stack.Count == 0;
        }

        public int Size()
        {
            return stack.Count;
        }
    }
}
