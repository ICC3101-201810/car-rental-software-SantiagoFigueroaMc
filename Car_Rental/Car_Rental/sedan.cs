using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental
{
    class Sedan
    {
        public string marca;//fiat, bmw, audi, mini
        public string model;
        public bool carPlay;

        public Sedan(string miMarca, string miModel, bool miCarPlay, int mipuertas, string mitraccion, int mirendimiento, int miprecio, string milicencia, string mipatente) : base(mipuertas, mitraccion, mirendimiento, milicencia, miprecio, mipatente)
        {
            marca = miMarca;
            model = miModel;
            carPlay = miCarPlay;
        }
    }
}
