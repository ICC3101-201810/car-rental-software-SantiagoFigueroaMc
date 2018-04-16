using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental
{
    class Bus : Vehiculo
    {
        //Atributos:
        public int capacidadPasajeros, rendimiento;//Rendimiento es en km por ltr.

        //Constructor:
        public Bus (string miMarca, string miModelo, int miCapacidad, int miRendimiento, int miprecio, string milicencia, string mipatente) : base(milicencia, miprecio, mipatente, miMarca, miModelo)
        {
            capacidadPasajeros = miCapacidad;
            rendimiento = miRendimiento;
        }

        //Metodos:
        public override void InfoVehiculo()
        {
            Console.WriteLine("Bus: " + marca + " " + modelo);
        }
        public override string GetTipo()
        {
            return "Bus";
        }
    }
}
