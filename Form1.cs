using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace syp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btndale_Click(object sender, EventArgs e)
        {
            Jugadores n1 = new Jugadores(1);
            Jugadores n2 = new Jugadores(2);
            Dado d = new Dado();
            Tablero tabl = new Tablero();
            do
            {
                n1.avanzar(d.LANZAR());
                n2.avanzar(d.LANZAR());
                txtres.Text += Environment.NewLine + n1.ToString() + " , " + Environment.NewLine + n2.ToString();
            } while (n1.posicion < 100 && n2.posicion < 100);
           /* if (n1.posicion > n2.posicion)
            {
                txtres.Text = Environment.NewLine + n1.ToString() + " Gano";
            }
            else
            {
                txtres.Text = Environment.NewLine + n2.ToString() + " Gano";
            }*/
        }
    }
}
