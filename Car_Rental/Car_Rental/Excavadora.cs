using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental
{
    class Excavadora : Maquina
    {
        //Atributos:

        //Constructor:
        public Excavadora(string miLicencia, int miPrecio, string miPatente, string miModelo, string miMarca) : base(miLicencia, miPrecio, miPatente, miMarca, miModelo) { }

        //Metodos:
        public override void InfoVehiculo()
        {
            Console.WriteLine("Excavadora: " + marca + " " + modelo);
        }
        public override string GetTipo()
        {
            return "Maquina Excavadora";
        }
    }
}
