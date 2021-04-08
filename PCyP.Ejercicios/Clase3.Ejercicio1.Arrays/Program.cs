using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Ejercicio1.Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //DayOfWeek();
            NthDay();

        }

        static void DayOfWeek()
        {

            string[] daysOfWeek = {
                "Monday",
                "Tuesday",
                "Wensday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            //for (int i = 0; i < daysOfWeek.Length; i++)
            //{
            //    Console.WriteLine("days Of Week: {0}", daysOfWeek[i]);
            //}

            Console.WriteLine("before");
            foreach (var day in daysOfWeek)
            {
                Console.WriteLine("days Of Week: {0}", day);
            }

            daysOfWeek[2] = "Wednesday";

            Console.WriteLine("after");
            foreach (var day in daysOfWeek)
            {
                Console.WriteLine("days Of Week: {0}", day);
            }


            Console.ReadKey();
        }

        static void NthDay()
        {

            string[] daysOfWeek = {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            Console.WriteLine("Which day do you want to display?");
            Console.Write("(Monday = 1, etc.) > ");
            int iDay = int.Parse(Console.ReadLine());

            string chosenDay = daysOfWeek[iDay - 1];
            Console.WriteLine($"That day is {chosenDay}");

        }

    }
}
