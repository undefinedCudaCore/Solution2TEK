using System;
using System.Collections.Generic;

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

            List<double> istorijosPazymiai = matematikosPazymiai;
            List<double> biologijosPazymiai = matematikosPazymiai;

            PamokosPazymiai pamokosPazymiai1 = new PamokosPazymiai("Matematika", matematikosPazymiai);
            PamokosPazymiai pamokosPazymiai2 = new PamokosPazymiai("Istorija", istorijosPazymiai);
            PamokosPazymiai pamokosPazymiai3 = new PamokosPazymiai("Biologija", biologijosPazymiai);


            double vidurkis = pamokosPazymiai1.GautiVidurki();

            Console.WriteLine($"Pamokos {pamokosPazymiai1.Pamoka} pazymiu vidurkis yra {vidurkis}");

            Mokinys mokinys1 = new Mokinys("Tadas", "Blinda");
            Mokinys mokinys2 = new Mokinys("Tomas", "Edisonas");
            Mokinys mokinys3 = new Mokinys("Albertas", "Ensteinas");
            //Mokinys mokinys4 = new Mokinys("Mykolas", "Blindys");

            mokinys1.PazymiaiA.Add(pamokosPazymiai1);
            mokinys1.PazymiaiA.Add(pamokosPazymiai2);
            mokinys1.PazymiaiA.Add(pamokosPazymiai3);

            mokinys2.PazymiaiA.Add(pamokosPazymiai1);
            mokinys2.PazymiaiA.Add(pamokosPazymiai2);
            mokinys2.PazymiaiA.Add(pamokosPazymiai3);

            mokinys3.PazymiaiA.Add(pamokosPazymiai1);
            mokinys3.PazymiaiA.Add(pamokosPazymiai2);
            mokinys3.PazymiaiA.Add(pamokosPazymiai3);

            List<Mokinys> mokiniai = new List<Mokinys>();
            mokiniai.Add(mokinys1);
            mokiniai.Add(mokinys2);
            mokiniai.Add(mokinys3);
            //mokiniai.Add(mokinys3);

            Dienynas dienynas = new Dienynas(mokiniai);
            dienynas.IvestiPazymius("Matematika", mokinys1, matematikosPazymiai);



            Console.ReadKey();

        }
    }
}
