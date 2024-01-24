using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consecutive_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] teszt = { 5, 4, 3, 2, 1 };
            Console.WriteLine(Cons(teszt));

            Console.ReadLine();
        }

        static bool Cons(int[] input)
        {
            int[] copy = input;

            for (int i = copy.Length - 1; i >= 1; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (copy[j] > copy[j + 1])
                    {
                        int tmp = copy[j];
                        copy[j] = copy[j + 1];
                        copy[j + 1] = tmp;
                    }
                }
            }
            int x = 0;

            while (x < copy.Length - 1 && copy[x + 1] - copy[x] == 1 && copy[x + 1] != copy[x])
            {
                x++;
            }

            return x == copy.Length - 1;


        }
    }
}
