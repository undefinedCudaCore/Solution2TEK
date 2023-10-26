using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskNo38_1
{
    internal class Gyvate2cs : Gyvunas2
    {
        public Gyvate2cs(string pavadinimas, string rusis, string spalva, double aukstis, double ilgis) : base(pavadinimas, rusis, spalva, aukstis, ilgis)
        {

        }

        public override void GyvunoInformacija()
        {
            Console.WriteLine();
            Console.WriteLine($"Gyvūnas: {Pavadinimas};");
            Console.WriteLine($"Rūšis: {Rusis};");
            Console.WriteLine($"Spalva: {Spalva};");
            Console.WriteLine($"Aukštis: {Aukstis}m;");
            Console.WriteLine($"Ilgis: {Ilgis}m;");
            Console.WriteLine();
            Gyvunas2.IsvestiConstanta();
        }

    }
}
