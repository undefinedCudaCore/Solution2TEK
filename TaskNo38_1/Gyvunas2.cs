using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskNo38_1
{
    internal class Gyvunas2
    {
        protected string Pavadinimas { get; set; }
        protected string Rusis { get; set; }
        protected string Spalva { get; set; }
        protected double Aukstis { get; set; }
        protected double Ilgis { get; set; }

        public Gyvunas2(string pavadinimas, string rusis, string spalva, double aukstis, double ilgis)
        {
            Pavadinimas = pavadinimas;
            Rusis = rusis;
            Spalva = spalva;
            Aukstis = aukstis;
            Ilgis = ilgis;
        }
    }
}
