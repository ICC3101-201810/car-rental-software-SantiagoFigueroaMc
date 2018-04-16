using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental
{
    class Sucursal
    {
        //Atributos:
        List<Vehiculo> vehiculos = new List<Vehiculo>();
        List<string> arriendos = new List<string>();
        string Nombre;

        //Constructor:
        public Sucursal (string miNombre)
        {
            Nombre = miNombre;
        }

        //Metodos:
        public string GetName()
        {
            return Nombre;
        }
        public bool AgregarVehiculo(Vehiculo vehiculoNuevo)
        {
            if (vehiculos != null)
            {
                if (vehiculos.Contains(vehiculoNuevo))
                {
                    Console.WriteLine("El vehiculo ya se encuentra en la sucursal");
                    return false;
                }
            }
            vehiculos.Add(vehiculoNuevo);
            return true;
        }
        public bool Arrendar(Vehiculo vehiculo, Arrendatario arrendatario, int dias)
        {
            string arriendo_nuevo = vehiculo.GetTipo() + ". Patente: " + vehiculo.patente + " - Nombre arrendatario: " + arrendatario.GetName() + " - Tiempo: " + dias.ToString();
            if (arriendos.Contains(arriendo_nuevo))
            {
                Console.WriteLine("El arriendo ya existe.");
                return false;
            }
            arriendos.Add(arriendo_nuevo);
            Console.WriteLine("Arriendo agregado.");
            return true;
        }
        public List<Vehiculo> GetVehiculos()
        {
            return vehiculos;
        }
    }
}
