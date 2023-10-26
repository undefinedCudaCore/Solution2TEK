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
        public List<double> PazymiaiB = new List<double>();

        public PamokosPazymiai(string pamoka, List<double> pazymiai)
        {
            Pamoka = pamoka;
            PazymiaiB = pazymiai;
        }

        public double GautiVidurki()
        {
            double suma = 0;
            for (int i = 0; i < PazymiaiB.Count; i++)
            {
                suma += PazymiaiB[i];
            }
            return suma / PazymiaiB.Count;
        }
    }
}
