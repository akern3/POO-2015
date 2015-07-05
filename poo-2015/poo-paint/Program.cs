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
            AreaDeDesenho area = new AreaDeDesenho();/*
            area.AdicionarFigura(new Retangulo(3, 4, 20, 50));
            area.AdicionarFigura(new Circulo(150, 45, 20));*/
            Application.Run(area);

        }

                

        
        
    }
}
