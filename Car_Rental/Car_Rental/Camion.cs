using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental
{
    class Camion : Maquina
    {
        //Atributos:

        //Constructor:
        public Camion(string miLicencia, int miPrecio, string miPatente, string miModelo, string miMarca) : base(miLicencia, miPrecio, miPatente, miMarca, miModelo) { }

        //Metodos:
        public override void InfoVehiculo()
        {
            Console.WriteLine("Camion: " + marca + " " + modelo);
        }
        public override string GetTipo()
        {
            return "Maquina Camion";
        }
    }
}
