using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serpientes_y_Escaleras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Jugadores n1 = new Jugadores(1);
        Jugadores n2 = new Jugadores(2);
        Dado d = new Dado();
        Tablero tabl = new Tablero();
        private void button1_Click(object sender, EventArgs e)
        {
            do
            {
                n1.avanzar(d.LANZAR());
                n2.avanzar(d.LANZAR());
                txtres.Text = n1.ToString() + " , " + Environment.NewLine + n2.ToString();
            } while (n1.posicon < 100 && n2.posicon < 100);
            if(n1.posicon > n2.posicon)
            {
                txtres.Text = Environment.NewLine + n1.ToString() + " Gano";
            }
            else
            {
                txtres.Text = Environment.NewLine + n2.ToString() + " Gano";
            }
        }
    }
}
