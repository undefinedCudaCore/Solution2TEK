using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dienynas
{
    internal class PamokosPazymiai
    {
        public string Pamoka;
        List<double> Pazymiai = new List<double>();

        public PamokosPazymiai(string pamoka, List<double> pazymiai)
        {
            Pamoka = pamoka;
            Pazymiai = pazymiai;
        }

        public double GautiVidurki()
        {
            double suma = 0;
            for (int i = 0; i < Pazymiai.Count; i++)
            {
                suma += Pazymiai[i];
            }
            return suma / Pazymiai.Count;
        }
    }
}
