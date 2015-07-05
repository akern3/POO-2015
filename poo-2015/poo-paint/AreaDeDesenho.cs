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
        private Figuras[] figuras = new Figuras[100];
        private static int contador = 0;
        private int MDownX;
        private int MDowny;
        public AreaDeDesenho()
        {
            InitializeComponent();
        }

        public void AdicionarFigura(Figuras fig)
        {
            if (contador <= 99)
            {
                figuras[contador] = fig;
                contador += 1;
            }
            else
            {

            }
        }

        public void Desenha(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            for (int i = 0; i < this.figuras.Length; i++)
            {
                Figuras f = this.figuras[i];
                if (f != null){
                    f.Desenha(g);
                }
                
            }

        }

        private void BuscaMouseUp(object sender, MouseEventArgs e)
        {

            switch (this.toolStripComboBox1.SelectedIndex)
            {
                case 0:
                    this.AdicionarFigura(new Circulo(MDownX, MDowny, e.X - MDownX, e.Y - MDowny));
                    break;
                case 1:
                    this.AdicionarFigura(new Retangulo(MDownX, MDowny, e.X - MDownX, e.Y - MDowny));
                    break;
                case 2:
                    this.AdicionarFigura(new Linha(MDownX, MDowny, e.X, e.Y));
                    break;
                default:
                    break;
            }
             
            this.Invalidate();
            MDownX = 0;
            MDowny = 0;
            
        }

        private void BuscaMouseDown(object sender, MouseEventArgs e)
        {
            MDownX = e.X;
            MDowny = e.Y;
        }

        private void MovimentoMouse(object sender, MouseEventArgs e)
        {

            if (MDownX != 0 && MDowny != 0)
            {
                switch (this.toolStripComboBox1.SelectedIndex)
                {
                    case 0:
                        this.figuras[contador] = (new Circulo(MDownX, MDowny, e.X - MDownX, e.Y - MDowny));
                        break;
                    case 1:
                        this.figuras[contador] = (new Retangulo(MDownX, MDowny, e.X - MDownX, e.Y - MDowny));
                        break;
                    case 2:
                        this.figuras[contador] = (new Linha(MDownX, MDowny, e.X, e.Y));
                        break;
                    default:
                        break;
                }
                this.Invalidate();
            }
        }
        
    }
}
