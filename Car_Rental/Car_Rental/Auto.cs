using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental
{
    abstract class Auto : Vehiculo
    {
        public int puertas;
        public string traccion; //2x4 o 4x4
        public int rendimiento;

        public Auto(int miPuertas, string miTraccion, int miRendimiento, int miprecio, string milicencia, string mipatente): base (milicencia, miprecio, mipatente)
        {
            puertas = miPuertas;
            traccion = miTraccion;
            rendimiento = miRendimiento;
        }
    }
}
