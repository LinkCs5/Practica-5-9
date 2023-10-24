using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Actividad_6.Domain;

namespace Actividad_6
{
    public partial class Form1 : Form
    {
        InversorPalabras inversor = new InversorPalabras();

        public Form1()
        {
            InitializeComponent();
        }
        private void btnInvertir_Click(object sender, EventArgs e)
        {
            string palabra = txtPalabra.Text;
            string palabraInvertida = inversor.Invertir(palabra);
            lblPalabraInvertida.Text = palabraInvertida;
        }
    }
}
