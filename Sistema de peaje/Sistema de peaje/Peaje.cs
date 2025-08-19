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
        
        private int[] cantidades ;
        
        public Peaje() {
            cantidades = new int[32];
        }

        //Registrar un dia con su cantidad de autos
        public void registrarResumenDia(int dia, int cantidadVehiculos)
        {
            if(dia < 1 || dia > 31) { MessageBox.Show("El dia debe estar entre 1 y 31"); }
            cantidades[dia] =  cantidadVehiculos;
        }
        public int VerCantidadAutosEnUnDia(int dia)
        {   
            //Devolver la cantidad de autos en un dia
            return cantidades[dia];
        }
        public double PromCantVehiculosDelMes
        {
            get
            {
                int total = 0;
                int diasConCarga = 0;
                for (int i = 1; i <= 31; i++)
                {
                    if (cantidades[i] > 0)
                    {
                        total += cantidades[i];
                        diasConCarga++;
                    }
                }
              
                return (double)total / diasConCarga;
            }
        }
    }

}
