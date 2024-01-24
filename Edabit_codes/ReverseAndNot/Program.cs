using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAndNot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add an integer:");

            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(ReverseAndNot(input));
            Console.ReadLine();
        }
        static string ReverseAndNot(int i)
        {
            string integerString = i.ToString();
            string integerStringReversed = "";

            for (int j = integerString.Length - 1; j >= 0; j--)
            {
                integerStringReversed += integerString[j];
            }

            return integerStringReversed + integerString;

        }
    }
}
