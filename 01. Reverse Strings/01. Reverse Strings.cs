
namespace _01._Reverse_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "end")
            {
               
                
                string output = "";

                for (int i = input.Length - 1; i >= 0; i--)
                {
                    output += input[i];

                }
                Console.WriteLine(input + " = " + output);
                input = Console.ReadLine();
            }



        }
    }
}