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

            Retangulo desenho = new Retangulo(20,3,5,6);

            desenho.imprimeRelangulo();
            Console.ReadLine();
        }
    }
}
