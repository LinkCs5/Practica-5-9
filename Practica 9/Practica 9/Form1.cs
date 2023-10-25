using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practica_9.Entities;

namespace Practica_9
{
    public partial class Form1 : Form
    {
        private Reemplazador reemplazador;
        public Form1()
        {
            InitializeComponent();
            reemplazador = new Reemplazador();
        }
        private void buttonAgregarNumeros_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxCantidad.Text, out int cantidad))
            {
                reemplazador.AgregarNumeros(cantidad);
                listBoxNumeros.Items.Clear();
                foreach (int numero in reemplazador.numeros)
                {
                    listBoxNumeros.Items.Add(numero);
                }
            }
            else
            {
                MessageBox.Show("Cantidad no válida.");
            }
        }
        private void buttonReemplazar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxViejo.Text, out int viejo) && int.TryParse(textBoxNuevo.Text, out int nuevo))
            {
                reemplazador.Reemplazar(viejo, nuevo);
                listBoxNumeros.Items.Clear();
                foreach (int numero in reemplazador.numeros)
                {
                    listBoxNumeros.Items.Add(numero);
                }
            }
            else
            {
                MessageBox.Show("Valores viejo y nuevo no válidos.");
            }
        }
    }
}
