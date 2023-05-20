using AlgorithmGenerics;

namespace AlgorithmPrograms
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Algorithm Programs");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nChoose an option to execute\n1.BinarySearchGeneric\n2.InsertionGeneric\n3.BubbleGeneric\n4.MergeGeneric\n5.AnagramGeneric\n6.PrimeNumGeneric\n7.AnagramPalindromeGeneric  \n.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        BinarySearchGeneric.WordSearch();
                        break;
                    case 2:
                        InsertionGeneric.Sorting();
                        break;
                    case 3:
                        BubbleGeneric.BubbleSort();
                        break;
                    case 4:
                        MergeGeneric.MergeSort();
                        break;
                    case 5:
                        AnagramGeneric.Anagram();
                        break;
                    case 6:
                        PrimeNumGeneric.PrimeNum();
                        break;
                    case 7:
                        AnagramPalindromeGeneric.FindAnaPalinrome();
                        break;
                    case 8:
                        flag = false;
                        break;
                }
            }
        }
    }
}
