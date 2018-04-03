using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental
{
    class Deportivo
    {
        public string marca;//fiat, bmw, audi, mini
        public string model;
        public int topSpeed;

        public Deportivo(string miMarca, string miModel, int miTopSpeed,int mipuertas, string mitraccion, int mirendimiento, int miprecio, string milicencia, string mipatente) : base(mipuertas, mitraccion, mirendimiento, milicencia, miprecio, mipatente)
        {
            marca = miMarca;
            model = miModel;
            topSpeed = miTopSpeed;
        }
    }
}
