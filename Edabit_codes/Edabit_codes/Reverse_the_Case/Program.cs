using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_the_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add a text!");
            string testText=Console.ReadLine();

            Console.WriteLine(ReverseCase(testText));

            Console.ReadLine();
        }

        static string ReverseCase(string text)
        {
            string reversedText = "";

            for (int i = 0; i < text.Length; i++)
            {

                if (char.IsUpper(text[i]))
                {
                    reversedText += char.ToLower(text[i]);
                }

                else
                {
                    reversedText += char.ToUpper(text[i]);
                }
            }

            return reversedText;
        }
    }

        
}
