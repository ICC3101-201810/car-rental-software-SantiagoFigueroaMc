﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental
{
    class RetroExcavadora : Vehiculo
    {
        public int maxTon, hp;

        public RetroExcavadora(int miMaxTon, int miHp, int miprecio, string milicencia, string mipatente) : base (milicencia, miprecio, mipatente)
        {
            maxTon = miMaxTon;
            hp = miHp;
        }
    }
}