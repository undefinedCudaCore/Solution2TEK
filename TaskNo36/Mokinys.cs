﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskNo36
{
    internal class Mokinys
    {
        public string vardas;
        public string pavarde;
        public int amzius;
        public int klase;

        List<int> pazymiuSarasas = new List<int>(5);

        public Mokinys(string vardas, string pavarde, int amzius, int klase, List<int> pazymiuSarasas)
        {
            this.vardas = vardas;
            this.pavarde = pavarde;
            this.amzius = amzius;
            this.klase = klase;
            this.pazymiuSarasas = pazymiuSarasas;

        }

        public void isvestiInfoApieMokini()
        {
            Console.WriteLine($"Vasdas: {vardas}, pavarde: {pavarde}, amzius {amzius}, klase {klase}.");
            Console.WriteLine($"Pazymiai: {pazymiuSarasas[0]}, {pazymiuSarasas[1]}, {pazymiuSarasas[2]}, {pazymiuSarasas[3]}, {pazymiuSarasas[4]}. ");
        }
    }
}
