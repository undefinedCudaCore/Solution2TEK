using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskNo38
{
    internal class Gyvate : Gyvunas
    {
        public Gyvate(string pavadinimas, string rusis, string spalva, double aukstis, double ilgis) : base(pavadinimas, rusis, spalva, aukstis, ilgis)
        {
            //Pavadinimas = pavadinimas;
            //Rusis = rusis;
            //Spalva = spalva;
            //Aukstis = aukstis;
            //Ilgis = ilgis;
        }

        public void gyvunoInformacija()
        {
            Console.WriteLine();
            Console.WriteLine($"Gyvūnas: {Pavadinimas};");
            Console.WriteLine($"Rūšis: {Rusis};");
            Console.WriteLine($"Spalva: {Spalva};");
            Console.WriteLine($"Aukštis: {Aukstis}m;");
            Console.WriteLine($"Ilgis: {Ilgis}m;");
            Console.WriteLine();
        }
    }
}
