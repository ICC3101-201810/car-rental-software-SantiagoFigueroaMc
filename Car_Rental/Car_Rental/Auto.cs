using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental
{
    class Auto : Vehiculo
    {
        //Atributos:
        public int puertas;
        public string traccion; //2x4 o 4x4
        public int rendimiento;
        public string tipo; //familiar, deportivo, economico

        //Constructor:
        public Auto(string miMarca, string miModelo, string miTipo, int miPuertas, string miTraccion, int miRendimiento, int miPrecio, string miLicencia, string miPatente):
            base (miLicencia, miPrecio, miPatente, miMarca, miModelo)
        {
            puertas = miPuertas;
            traccion = miTraccion;
            rendimiento = miRendimiento;
            tipo = miTipo;
        }

        //Metodos:
        public override void InfoVehiculo()
        {
            Console.WriteLine("Auto: " + marca + " " + modelo);
        }
        public override string GetTipo()
        {
            return "Auto";
        }
    }
}
