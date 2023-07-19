
namespace string_task__3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string: ");
            string words = Console.ReadLine();

            int maxWords = 0;

            string[] arrayWord = words.Split(' ');

            string longestWord = "";

            foreach (string word in arrayWord)
            {
                if (word.Length > maxWords)
                {
                    maxWords = word.Length;
                    longestWord = word;
                }
            }
            Console.WriteLine($"Result: Longest word {longestWord} out of {maxWords} letters ");
        }
    }
}