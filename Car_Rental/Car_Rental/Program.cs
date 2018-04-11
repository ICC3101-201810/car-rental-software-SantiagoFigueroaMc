using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental
{
    class Program
    {
        void arrendar()//Informacion: licencia, permiso, nombre empresa (organisacion, institucion),
        {

        }

        static void Main(string[] args)
        {
            //Vehiculos:
            Sedan sedan = new Sedan("Honda", "Accord", true, 5, "2x4", 10, 7000000, "B", "FFKP-97");

            //Sucursales:
            Sucursal LasCondes2525 = new Sucursal();

            //Personas:
            Persona persona1 = new Persona("Pedro Correa", "B");

            //Empresas:
            Empresa empresa1 = new Empresa("Colegio Cordillera", "Institucion", );


            LasCondes2525.agregarVehiculo(sedan);
        }
    }
}
