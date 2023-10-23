using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskNo35
{
    internal class Array
    {
        public static void Masyvas(int[] array)
        {
            int arraySumOne = 0;
            int arraySumTwo = 0;

            for (int i = 0; i < array.Length; i++)
            {
                arraySumOne += array[i];
            }

            arraySumTwo = array.Sum();

            Console.WriteLine($"First answer: {arraySumOne}");
            Console.WriteLine($"Second answer: {arraySumTwo}");
        }
    }
}
