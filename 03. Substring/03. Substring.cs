namespace _03._Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string wordToRemove = Console.ReadLine();
            string text = Console.ReadLine();

            while(text.Contains(wordToRemove)) 
            {
            
                int indexOfWordsToRemove = text.IndexOf(wordToRemove);
                text = text.Remove(indexOfWordsToRemove, wordToRemove.Length);
            
            }
            Console.WriteLine(text);
            
        }
    }
}