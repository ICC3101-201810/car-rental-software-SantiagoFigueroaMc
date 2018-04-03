using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental
{
    class Bus : Vehiculo
    {
        public int capacidadPasajeros, rendimiento;//Rendimiento es en km por ltr.

        public Bus (int miCapacidad, int miRendimiento, int miprecio, string milicencia, string mipatente) : base(milicencia, miprecio, mipatente)
        {
            capacidadPasajeros = miCapacidad;
            rendimiento = miRendimiento;
        }
    }
}
