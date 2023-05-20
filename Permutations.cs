using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class Permutations
    {
        public static void Permute(string str, int start, int end)
        {
            if (start == end)
            {
                Console.WriteLine(str);
            }
            else
            {
                //Recursive the string 
                for (int i = start; i <= end; i++)
                {
                    str = Swap(str, start, i);
                    Permute(str, start + 1, end);
                    str = Swap(str, start, i);
                }
            }
        }

        //Swap the each letter and and give output in rearrange string
        public static string Swap(string a, int i, int j)
        {
            char temp;
            char[] charArray = a.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;
        }

        // Iterator method is PermuteExecute and show the execution  
        public static void PermuteExecute()
        {
            Console.Write("Enter a string value: ");
            string str = Convert.ToString(Console.ReadLine());
            int n = str.Length;
            Permute(str, 0, n - 1);
        }
    }
}
