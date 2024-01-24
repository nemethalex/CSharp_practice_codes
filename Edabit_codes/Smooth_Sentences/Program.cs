using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smooth_Sentences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give a sentence:");
            string sentence = Console.ReadLine();

            Console.WriteLine(IsSmooth(sentence));
            Console.ReadLine();
        }

        static bool IsSmooth(string input)
        {
            List<string> wordsOfSentence = new List<string>();
            wordsOfSentence = input.Split(' ').ToList();

            int i = 0;


            while (i < wordsOfSentence.Count - 1 && wordsOfSentence[i][wordsOfSentence[i].Length - 1] == wordsOfSentence[i + 1][0])
            {
                i++;
            }

            return i == wordsOfSentence.Count - 1;
        }
    }
}
