using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_paint
{
    public class Retangulo
    {
        public Retangulo(int x, int y, int lar, int alt)
        {
            this.x = x;
            this.y = y;
            this.lar = lar;
            this.alt = alt;
        }

        public int x { get; set; }
        public int y { get; set; }
        public int lar { get; set; }
        public int alt { get; set; }

        public string imprimeRelangulo()
        {
            for (int i = 0; i < x; i++)
            {
                Console.Write("-");
                
            }

            Console.WriteLine();

            for (int i = 0; i < y; i++)
            {
                Console.Write("|");
                for (int i2 = 1; i2 < x-1; i2++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("|");
            }

            for (int i = 0; i < x; i++)
            {
                Console.Write("-");
                
            }

            Console.WriteLine();
            return "pronto";
        }

    }
}
