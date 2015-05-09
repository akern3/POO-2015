using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace poo_paint
{
    public partial class AreaDeDesenho : Form
    {
        private Figuras[] figuras = new Figuras[10];
        private static int contador = 0;
        public AreaDeDesenho()
        {
            InitializeComponent();
        }

        public void AdicionarFigura(Figuras fig)
        {
            if (contador <= 9)
            {
                figuras[contador] = fig;
                contador += 1;
            }
            else
            {

            }
        }
        private void Desenha(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            e.Graphics.DrawRectangle(Pens.Black, 4, 4, 100, 40);
            e.Graphics.DrawRectangle(Pens.Black, 104, 44, 100, 40);
            e.Graphics.DrawRectangle(Pens.Black, 204, 84, 100, 40);
        }
    }
}
