using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental
{
    class Moto : Vehiculo
    {
        public int hp, rendimiento;//Rendimiento es en km por ltr.
        public bool incluyeCasco;// true or false
        public bool tieneMaletas;// true or false

        public Moto(int miHp, int miRendimiento, bool miCasco, bool miMaleta, int miprecio, string milicencia, string mipatente) : base(milicencia, miprecio, mipatente)
        {
            hp = miHp;
            rendimiento = miRendimiento;
            incluyeCasco = miCasco;
            tieneMaletas = miMaleta;
        }
    }
}
