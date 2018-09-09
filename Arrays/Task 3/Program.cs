using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[100];
            Random randint = new Random();
            for(int i = 0; i < array1.Length; i++)
            {
                array1[i] = randint.Next(1111, 9999);
            }
            Console.WriteLine("Enter the number you want to find (between 1111 and 9999):\n");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine($"The number {Array.IndexOf(array1, num)} is at index...");
        }
    }
}
