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
        //Declaramos el objeto y lo instanciamos
        Peaje peajes = new Peaje();
        private void btnRegistrarPeaje_Click(object sender, EventArgs e)
        {   
            //Creamos el objeto de la clase CargarPeaje

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
            lsbVerResumen.Items.Clear();//Items.Clear() borra todo lo que estaba listado antes, así empezás limpio.

            //Agrega una línea de título (un item) al ListBox.
            lsbVerResumen.Items.Add("Los días en que ingresaron más autos que el promedio en el mes:");

            //Llama al método de tu clase Peaje que calcula el promedio
            //mensual y arma un texto con los días cuya cantidad de autos supera ese promedio.
            string resultado = peajes.CalcularDiasMayoresAlPromedio();
            //Agrega ese texto al ListBox como un solo item.
            lsbVerResumen.Items.Add(resultado);

            //Agrega otro título para el segundo resultado.
            lsbVerResumen.Items.Add("¿Cuál de los tercios del mes tuvo mayor movimiento?");

            //Llama a CalcularTercioDelMesMayor(), que devuelve 1, 2 o 3 según qué tercio del mes tuvo más autos.
            //ToString() lo convierte a texto para poder mostrarlo en el ListBox
            lsbVerResumen.Items.Add(peajes.CalcularTercioDelMesMayor().ToString());
        }
    }
}
