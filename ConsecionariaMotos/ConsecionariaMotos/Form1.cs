using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsecionariaMotos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string marca = Convert.ToString(tbMarca.Text);
            int modelo = Convert.ToInt32(tbModelo.Text);
            int anioCalcular = Convert.ToInt32(tbAñoCalcular.Text);
            int vidaUtil = Convert.ToInt32(tbVidaUtil.Text);
            int valorFabrica = Convert.ToInt32(tbValorFabricacion.Text);
            double tasaDespreciacion = Convert.ToDouble(tbTasaDespreciacion.Text);

            Moto MotoCotizacion; //Declaracion del objeto
            MotoCotizacion = new Moto(marca, modelo, valorFabrica); /// Instacia de un objeto

            //Calcular
            double despreciacionLineal = MotoCotizacion.CalcularDepreciacionLineal(anioCalcular, vidaUtil);
            double despreciacionAnual = MotoCotizacion.CalcularDepresiacionAnual(anioCalcular,tasaDespreciacion);

            MessageBox.Show(
                   $"{MotoCotizacion.VerDescripcion()}\n" +
                   $"Depreciación lineal: {despreciacionLineal.ToString("C")}\n" +
                   $"Depreciación anual: {despreciacionAnual.ToString("C")}",
                   "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
