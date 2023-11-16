namespace _02._Repeat_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            string outputString = "";
            
            foreach (string word in words)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    outputString += word;
                }


            }
            Console.WriteLine(outputString);

        }
    }
}