using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Actividad_5.Domain;

namespace Actividad_5
{
    public partial class Form1 : Form
    {
        ClasificadorPalabras clasificador = new ClasificadorPalabras();
        public Form1()
        {
            InitializeComponent();
        }
        private void btnAgregarPalabra_Click (object sender, EventArgs e)
        {
            string palabra = txtPalabra.Text.Trim();
            if (!string.IsNullOrEmpty(palabra))
            {
                clasificador.AgregarPalabra(palabra);
                ActualizarListBox();
                txtPalabra.Clear();
            }
        }
        private void ActualizarListBox()
        {
            lstListas.Items.Clear();
            foreach( var letra in clasificador.OtenerLetrasClasificadas())
            {
                lstListas.Items.Add($"Lista de palabras que comienzan con {letra}: {string.Join(", ", clasificador.ObtenerPalabrasPorLetras(letra))}");
            }
        }
    }
}
