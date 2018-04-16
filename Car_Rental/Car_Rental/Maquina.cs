using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental
{
    class Maquina : Vehiculo
    {
        //Atributos:

        //Constructor:
        public Maquina(string miLicencia, int miPrecio, string miPatente, string miModelo, string miMarca) : base(miLicencia, miPrecio, miPatente, miMarca, miModelo) { }

        //Metodos:
        public override string GetTipo()
        {
            throw new NotImplementedException();
        }


    }
}
