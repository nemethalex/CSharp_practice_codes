using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_of_Multiples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add the number: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Add the lenght: ");
            int lenght = int.Parse(Console.ReadLine());

            int[] theArray = ArrayOfMultiples(num, lenght);

            Console.Write($"The first {lenght} multiples of {num}: ");

            for (int i = 0; i < theArray.Length; i++)
            {
                Console.Write(theArray[i] + "; ");
            }



            Console.ReadLine();
        }

        static int[] ArrayOfMultiples(int num, int lenght)
        {
            int[] solution = new int[lenght];


            for (int i = 0; i < lenght; i++)
            {
                solution[i] = num * (i + 1);
            }

            return solution;
        }
    }
}
