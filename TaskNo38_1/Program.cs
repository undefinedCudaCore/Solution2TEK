using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskNo38_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Gyvate2cs boa = new Gyvate2cs("Gyvate", "ABoa", "Ruda", 1.45, 2.46);

            boa.GyvunoInformacija();

            Console.ReadKey();
        }
    }
}
