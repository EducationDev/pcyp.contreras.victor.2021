using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Ejercicio2.Importing
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\\population-final.csv";
            CsvReader reader = new CsvReader(filePath);
            Country[] countries = reader.ReadFirstNCountries(10);

            foreach (var country in countries)
            {
                Console.WriteLine("P:{0} C {1}", country.Population, country.Name);
            }
        }
    }
}
