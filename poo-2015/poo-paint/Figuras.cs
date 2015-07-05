using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace poo_paint
{
    public class Retangulo : Figuras
    {
        public Retangulo(int x, int y, int lar, int alt)
        {
            this.x = x;
            this.y = y;
            this.lar = lar;
            this.alt = alt;
            contador = contador + 1;
        }

        
        public int lar { get; set; }
        public int alt { get; set; }
        private static int contador { get; set; }

        public override void imprime()
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
            /*return "pronto";*/
        }
        public static void ZeraContador()
        {
            contador = 0;
        }
        public static int LeContador()
        {
            return contador;
        }

        public override void Desenha(Graphics g)
        {
            g.DrawRectangle(Pens.Black, this.x, this.y, this.lar, this.alt);
        }
    }
    public class Figuras
    {

        public int x { get; set; }
        public int y { get; set; }
        public virtual void imprime()
        {
            Console.WriteLine("Figura");
        }

        public virtual void Desenha(Graphics g)
        {

        }
    }
    public class Circulo:Figuras
    {
        public Circulo(int x, int y, int raio)
        {
            this.x = x;
            this.y = y;
            this.raio = raio;
        }

        public Circulo(int x, int y, int X1, int Y1)
        {
            this.x = x;
            this.y = y;
            this.X1 = X1;
            this.Y1 = Y1;
        }
        public int raio { get; set; }
        int X1;
        int Y1;
        public override void imprime()
        {
            Console.WriteLine("Circulo");
        }

        public override void Desenha(Graphics g)
        {
            g.DrawEllipse(Pens.Black, this.x, this.y, this.X1, this.Y1);
        }
    }

    public class Linha:Figuras
    {
        public Linha(int x,int y,int X1,int Y1)
        {
            this.x = x;
            this.y = y;
            this.X1 = X1;
            this.Y1 = Y1;
        }

        int X1;
        int Y1;

        public override void Desenha(Graphics g)
        {
            g.DrawLine(Pens.Black, x, y, X1, Y1);
        }
    }
}
