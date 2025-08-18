using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsecionariaMotos
{
    internal class Moto
    {
        //Variables de instancia
        public string Marca;
        public int Modelo;
        public double ValorFabricacion;
        public Moto(string marca, int modelo, double valorFabricacion)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.ValorFabricacion = valorFabricacion;
        }
        public double CalcularDepreciacionLineal(int anioCalcular, int vidaUtil)
        {
            double valorActualizado;
            double  aniosUso = 0;
            aniosUso = anioCalcular - Modelo;

            valorActualizado = ValorFabricacion - (ValorFabricacion * (aniosUso / vidaUtil));


            return valorActualizado;
        }
        public double CalcularDepresiacionAnual(int anioCalcular, double tasaDespreciacion)
        {
            double valorActualizado ;
            int aniosUso = 0;

            aniosUso = anioCalcular - Modelo;
            
            valorActualizado = ValorFabricacion * Math.Pow((1 - tasaDespreciacion), aniosUso);
            return valorActualizado;
        }
        public String VerDescripcion()
        {
            return $"Marca: {Marca}, Modelo: {Modelo}, valor Fabricacion: {ValorFabricacion:C}";
        }
    }
}
