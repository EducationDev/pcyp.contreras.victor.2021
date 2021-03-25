using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.Ejercicio1.Figuras
{
    /// <summary>
    /// Realizar un programa capaz de calcular el área y perímetro de un cuadrado, rectángulo y triángulo. 
    /// Todos los datos necesarios para su funcionamiento se ingresan por teclado.
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Mundo!!!");
            Figura fig = new Figura();
            fig.Perimetro();
            Console.WriteLine("Perimetro{0}", fig.Perimetro());
        }
    }
}
