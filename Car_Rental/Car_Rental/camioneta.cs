using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental
{
    class Camioneta
    {
        public string marca;//fiat, bmw, audi, mini
        public string model;
        public string cabina;//doble o simple
        public int maxLoad;

        public Camioneta(string miMarca, string miModel, string miCabina, int miMaxLoad,int mipuertas, string mitraccion, int mirendimiento, int miprecio, string milicencia, string mipatente) : base(mipuertas, mitraccion, mirendimiento, milicencia, miprecio, mipatente)
        {
            marca = miMarca;
            model = miModel;
            cabina = miCabina;
            maxLoad = miMaxLoad;
        }
    }
}
