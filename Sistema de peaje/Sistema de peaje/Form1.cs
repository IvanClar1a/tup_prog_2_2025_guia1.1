using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_peaje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Peaje peajes = new Peaje();
        private void btnRegistrarPeaje_Click(object sender, EventArgs e)
        {
            CargarPeaje Carga = new CargarPeaje();

            if (Carga.ShowDialog() == DialogResult.OK){
                int dia = Convert.ToInt32(Carga.tbDias.Text);
                int cantidad = Convert.ToInt32(Carga.tbCantidadAutos.Text);

                peajes.registrarResumenDia(dia, cantidad);

                MessageBox.Show("Datos cargados correctamente");
            }
        }

        private void btnVerResumen_Click(object sender, EventArgs e)
        {
            
        }
    }
}
