using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_paint
{
    class Program
    {
        static void Main(string[] args)
        {

            Retangulo desenho = new Retangulo(50,10,10,6);
            Circulo circulo = new Circulo(1,2,3);
            Figura figura = new Figura();
            circulo.imprime();
            figura.imprime();
            desenho.imprime();
            Console.ReadLine();
        }
    }
}
