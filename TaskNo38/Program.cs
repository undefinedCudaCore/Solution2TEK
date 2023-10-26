using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskNo38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Gyvate boa = new Gyvate("Gyvate", "Boa", "Ruda", 0.45, 2.36);

            boa.GyvunoInformacija();

            Console.ReadKey();
        }
    }
}
