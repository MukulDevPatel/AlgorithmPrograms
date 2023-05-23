
using AlgorithmPrograms.DataStructureProgramming;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Data Structure Programming");

        Console.WriteLine("Search word from the file");

        LinkedList wordList = new LinkedList();
        string fileName = "D:\\BridgeLabz Second batch\\AlgorithmPrograms\\DataStructureProgramming\\WordFile.txt";

        // Read the text from a file and split it into words
        //string[] text = File.ReadAllText(fileName).Split(' ');
        string[] words = File.ReadAllText(fileName).Split(new char[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

        // Create the linked list
        foreach (string word in words)
        {
            wordList.AddWord(word);
        }

        // Take user input to search a word
        Console.Write("Enter a word to search: ");
        string searchWord = Console.ReadLine();

        // Search the word in the list and perform necessary operations
        if (wordList.SearchWord(searchWord))
        {
            Console.Write("Word found in the list: ");
            wordList.RemoveWord(searchWord);
        }
        else
        {
            Console.Write("Word not found in the list: ");
            wordList.AddWord(searchWord);
        }

        // Save the list into a file
        wordList.SaveToFile(fileName);
        wordList.Print();
    }
}