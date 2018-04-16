using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental
{
    class Camioneta : Vehiculo
    {
        //Atributos:
        public int capacidad; //carga maxima en pick-up
        public string tipoCabina;//doble o simple
        public int puertas;
        public string traccion;
        public int rendimiento;

        //Constructor:
        public Camioneta(string miMarca, string miModelo, string miTipoCabina, int miCapacidad,int miPuertas, string miTraccion, int miRendimiento, int miPrecio, string miLicencia, string miPatente) : 
            base(miLicencia, miPrecio, miPatente, miMarca, miModelo)
        {
            capacidad = miCapacidad;
            tipoCabina = miTipoCabina;
            puertas = miPuertas;
            traccion = miTraccion;
            rendimiento = miRendimiento;

        }

        //Metodos:
        public override void InfoVehiculo()
        {
            Console.WriteLine("Camioneta: " + marca + " " + modelo);
        }
        public override string GetTipo()
        {
            return "Camioneta";
        }
    }
}
