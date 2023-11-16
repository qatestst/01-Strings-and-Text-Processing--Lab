using System.Text;

namespace Exercises___My
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder demoString = new StringBuilder();
            while (input != "end")
            { 
                demoString.Append(input);
            
                input = Console.ReadLine();
            }
           
            StringBuilder demoString2 = new StringBuilder();

            for (int i = demoString.Length-1;  i >= 0; i--)
            {
                char c = demoString[i];
                demoString2.Append(c);
            }

            Console.WriteLine(demoString2);
            demoString2.Insert(9, " This text is inserted ");
            demoString2.Insert(0, " This text is inserted ");
            demoString2.Insert(5, "This text is inserted ");
            Console.WriteLine(demoString2);
        }
    }
}