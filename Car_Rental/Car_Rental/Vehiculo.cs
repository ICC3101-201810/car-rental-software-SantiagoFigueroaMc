using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental
{
    abstract class Vehiculo : IArrendable
    {


        public string licencia;//Licencia requerida para manejar este vehiculo
        public int precio;//Precio del arriendo por dias
        public string patente;//Su forma varia segun tipo de vehiculo
        

        public Vehiculo(string miLicencia, int miPrecio, string miPatente)
        {
            licencia = miLicencia;
            precio = miPrecio;
            patente = miPatente;
        }
    }
}
