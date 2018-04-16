using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental
{
    class Moto : Vehiculo
    {
        //Atributos:
        public int hp, rendimiento;//Rendimiento es en km por ltr.
        public bool incluyeCasco, tieneMaletas;// true or false

        //Constructor:
        public Moto(string miMarca, string miModelo, int miHp, int miRendimiento, bool miCasco, bool miMaleta, int miPrecio, string miLicencia, string miPatente) : base(miLicencia, miPrecio, miPatente, miMarca, miModelo)
        {
            hp = miHp;
            rendimiento = miRendimiento;
            incluyeCasco = miCasco;
            tieneMaletas = miMaleta;
        }

        //Metodos:
        public override void InfoVehiculo()
        {
            Console.WriteLine("Moto: " + marca + " " + modelo);
        }
        public override string GetTipo()
        {
            return "Moto";
        }
    }
}
