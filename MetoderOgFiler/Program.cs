using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetoderOgFiler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opgave 1 – skriv til fil
            File.WriteAllText(@".\StarWars.txt", "Han skød først");

            // Opgave 2 – læs en tekstfil
            string starwars = File.ReadAllText(@".\StarWars.txt");
            Console.WriteLine(starwars);

            // Opgave 3 – slet en fil
            File.Delete(@".\StarWars.txt");

            // Opgave 4 – opret en mappe
            Directory.CreateDirectory(@".\Droids");

            // Opgave 5 – slet en mappe
            File.WriteAllText(@".\Droids\R2D2.txt", "beep bop");
            // Directory.Delete(@".\Droids", true);

            // Opgave 6 – Enumerate filer i en mappe
            string[] files = Directory.GetFiles(@".\Droids", "*.txt", SearchOption.AllDirectories);
            foreach (string fil in files)
            {
                Console.WriteLine(fil);
            }

            // Opgave 5 – læs fra fil (Forstår ikke helt pga. Formulering)

            // Opgave 6 – skriv til fil (Forstår ikke helt pga. Formulering)

            // Opgave 7 – Fil og mappe manipulation
            Console.Clear();

            Console.WriteLine(" -Program Begyndelse-");

            File.WriteAllText(@".\Sandsynlighed", "1/10"); // Add file (1)
            File.WriteAllText(@".\Sandsynlighed2", "2/10");
            File.WriteAllText(@".\Sandsynlighed3", "3/10");


            File.Delete(@".\Sandsynlighed"); // Delete file (2)

            string[] txtFiles = Directory.GetFiles(@"C: \Users\drito\source\repos\MetoderOgFiler\MetoderOgFiler\bin\Debug", "*.txt", SearchOption.AllDirectories); // Display files (3)
            foreach (string file in txtFiles)
            {
                Console.WriteLine(file);
            }

            Directory.CreateDirectory(@".\Dansk"); // Add folder (4)

            string[] txtFilesInFolder = Directory.GetFiles(@".\Droids", "*.txt", SearchOption.AllDirectories); // Display files in folder (5) 
            foreach (string file in txtFilesInFolder)
            {
                Console.WriteLine(file);
            }
            Console.ReadKey();
        }
    }
}
