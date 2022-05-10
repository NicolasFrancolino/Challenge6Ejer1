using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge6Ejer1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangulo rectangulo = new Rectangulo();
            rectangulo.Lado1 = 4;
            rectangulo.Lado2 = 8;
            Console.WriteLine("la superficie del rectangulo es " + rectangulo.RetornarSuperficie());
            Console.WriteLine("el perimetro del rectangulo es " + rectangulo.RetornarPerimetro());
            Console.ReadKey();
        }
    }
}
