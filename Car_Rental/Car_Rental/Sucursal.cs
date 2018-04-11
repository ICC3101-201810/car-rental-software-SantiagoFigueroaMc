using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental
{
    class Sucursal
    {
        List<Vehiculo> vehiculos;
        List<string> arriendos;

        public void arrendar(Vehiculo vehiculo, Persona persona, int dias)
        {
            string arriendo = vehiculo.patente + "_" + persona.nombre + "_" + dias.ToString();
            arriendos.Add(arriendo);
        }

        public void agregarVehiculo(Vehiculo vehiculo)
        {
            vehiculos.Add(vehiculo);
        }
    }
}
