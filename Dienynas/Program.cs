using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dienynas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Test class PamokosPazymiai functionality
            List<double> matematikosPazymiai = new List<double>();
            matematikosPazymiai.Add(1);
            matematikosPazymiai.Add(10);
            matematikosPazymiai.Add(8);
            matematikosPazymiai.Add(6);
            matematikosPazymiai.Add(5);
            matematikosPazymiai.Add(9);

            PamokosPazymiai pamokosPazymiai = new PamokosPazymiai("Matematika", matematikosPazymiai);

            double vidurkis = pamokosPazymiai.GautiVidurki();

            Console.WriteLine($"Pamokos {pamokosPazymiai.Pamoka} pazymiu vidurkis yra {vidurkis}");
            Console.ReadKey();

            //Test

        }
    }
}
