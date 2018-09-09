using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[1000];
            Random randint = new Random();
            for(int i = 0; i < 1000; i++)
            {
                array1[i] = randint.Next(1000, 9999);
            }

            int check;

            for (int i = 0; i < array1.Length; i++)
            {
                int total = 0;
                check = array1[i];
                for(int j = 0; j < array1.Length; j++)
                {
                    if (check == array1[j])
                        total += 1;
                }
                Console.WriteLine($"The number {i} has occured {total} times");
            }
        }
    }
}
