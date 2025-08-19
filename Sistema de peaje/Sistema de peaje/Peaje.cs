using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_peaje
{
    internal class Peaje
    {

        private int[] cantidades = new int[31];
        private int totalAutos = 0;


        //Registrar un dia con su cantidad de autos
        public void registrarResumenDia(int dia, int cantidadVehiculos)
        {
            if (dia < 1 || dia > 31) { MessageBox.Show("El dia debe estar entre 1 y 31"); }
            cantidades[dia - 1] = cantidadVehiculos;
            totalAutos = totalAutos + cantidadVehiculos;
        }

        public double PromCantVehiculosDelMes
        {
            get
            {
                return totalAutos / 31.0;
            }
        }
    
        public string CalcularDiasMayoresAlPromedio()
        {
            string resultado = "";
            double promedio = PromCantVehiculosDelMes;
         
            for (int i = 0; i < 31; i++) // recorro 0 a 30
            {
                if (cantidades[i] > promedio)
                {
                    resultado += $"Día {i + 1}: {cantidades[i]} autos\n";
                }
            }

            return resultado;
        }
        public int CalcularTercioDelMesMayor()
        {
            int[] sumas = new int[3];

            for (int i = 0; i < 20; i++)
            {
                if (i <= 10)// índices 0 a 9 → 1er tercio
                    sumas[0] += cantidades[i];
                else if (i <= 20)// índices 10 a 19 → 2do tercio
                    sumas[1] += cantidades[i];
                else// índices 20 a 30 → 3er tercio
                    sumas[2] += cantidades[i];
            }
            int max = 0, pos = 0;
            for (int i = 0; i < 3; i++)
            {
                if (sumas[i] > max)
                {
                    max = sumas[i];
                    pos = i;
                }
            }
            return pos + 1; // 1er, 2do o 3er tercio
        }
        

    }
}
