using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Tomas";
            string surename = "Grikis";
            int age = 25;
            double height = 1.84;
            double weight = 99.5;
            string highSchoolName = "Kentucky High";
            string academicGroupCode = "30APR8I90BCESJ8";
            string courseCode = "D4GNQ9XXD9";
            string studyProgramName = "Automatinis testavimas";
            int numberOfSettledCredits = 10;

            Console.WriteLine("Vardas: " + name);
            Console.WriteLine("Pavardė: " + surename);
            Console.WriteLine("Amžius: " + age);
            Console.WriteLine("Ūgis: " + height);
            Console.WriteLine("Svoris: " + weight);
            Console.WriteLine("Aukštoji mokykla: " + highSchoolName);
            Console.WriteLine("Akademinės grupės kodas: " + academicGroupCode);
            Console.WriteLine("Kursas: " + courseCode);
            Console.WriteLine("Studijų programos pavadinimas: " + studyProgramName);
            Console.WriteLine("Atsiskaitytų kreditų skaičius: " + numberOfSettledCredits);
            Console.ReadLine();
        }
    }
}