using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[10];
            Console.WriteLine("--- Array ---\n\nEnter 10 numbers of your choice: ");
            for(int i = 0; i < 10; i++)
            {
                Console.Write($"\nNumber {i + 1}: ");
                int number = int.Parse(Console.ReadLine());
                array1[i] = number;
            }
            Console.WriteLine($"Array:\n");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Number {i + 1}: {array1[i]}\n");
            }
        }
    }
}
