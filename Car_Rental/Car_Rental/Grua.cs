using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental
{
    class Grua : Maquina
    {
        //Atributos:

        //Constructor:
        public Grua(string miLicencia, int miPrecio, string miPatente, string miModelo, string miMarca) : base(miLicencia, miPrecio, miPatente, miMarca, miModelo) { }

        //Metodos:
        public override void InfoVehiculo()
        {
            Console.WriteLine("Grua: " + marca + " " + modelo);
        }
        public override string GetTipo()
        {
            return "Maquina Grua";
        }
    }
}
