using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace poo_paint
{
    class Program
    {
        static void Main(string[] args)
        {
            AreaDeDesenho d = new AreaDeDesenho();
            Application.Run(d);
            /*Figuras desenho = new Figuras(50,10,10,6);
            Circulo circulo = new Circulo(1,2,3);
            Figura figura = new Figura();
            circulo.imprime();
            figura.imprime();
            desenho.imprime();
            Console.ReadLine();*/
            d.AdicionarFigura(new Circulo(10,5,5));
            d.AdicionarFigura(new Retangulo(14, 10, 50, 63));
        }
    }
}
