using Actividad_7.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_7
{
    public partial class Form1 : Form
    {
        VerificadorPalindromo verificador = new VerificadorPalindromo();
        public Form1()
        {
            InitializeComponent();
        }
        public void btnVerificar_Click(object sender, EventArgs e)
        {
            string Palabra = txtPalabra.Text;
            bool esPalindromo = verificador.EsPalindromo(Palabra);
            if(esPalindromo )
            {
                lblResultado.Text = "Es un palindromo";
            }
            else
            {
                lblResultado.Text = "No es un palindromo";
            }
        }
    }
}
