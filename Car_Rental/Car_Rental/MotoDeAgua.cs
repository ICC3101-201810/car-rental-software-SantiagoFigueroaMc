using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental
{
    class MotoDeAgua : Vehiculo
    {
        public int hp;

        public MotoDeAgua (int miHp, int miprecio, string milicencia, string mipatente) : base (milicencia, miprecio, mipatente)
        {
            hp = miHp;
        }
    }
}
