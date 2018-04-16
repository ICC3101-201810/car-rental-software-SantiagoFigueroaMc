using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental
{
    class Administrador : Usuario
    {
        //Atributos:
        List<Sucursal> Sucursales = new List<Sucursal>();

        //Constructor:
        public Administrador(string miId, string miPassword) : base(miId, miPassword) { }

        //Metodos:
        public bool CrearSucursal(string nombre_nueva_sucursal)
        {
            //verificar que no exista de antes:
            foreach (Sucursal sucursal_antiguas in Sucursales)
            {
                if (sucursal_antiguas.GetName() == nombre_nueva_sucursal)
                {
                    return false; //la sucursal ya existe
                }
            }
            Sucursal nueva_sucursal = new Sucursal(nombre_nueva_sucursal);
            Sucursales.Add(nueva_sucursal);
            return true; //sucursal agregada
        }
        public void AgregarVehiculo_sucursal(Vehiculo vehiculo, Sucursal sucursal)
        {
            if (sucursal.AgregarVehiculo(vehiculo))
            {
                Console.WriteLine ("Vehiculo agregado");
            }
        }
        public void ArrendarVehiculo(Arrendatario arrendatario, Vehiculo vehiculo, int dias, Sucursal sucursal)
        {
            if (arrendatario.GetTipo() == "Persona")
            {
                if (arrendatario.GetLicencia() == "B")
                {
                    sucursal.Arrendar(vehiculo, arrendatario, dias);
                    arrendatario.GetVehiculosArrendados(sucursal.Arrendar(vehiculo, arrendatario, dias).ToString());
                }
            }
        }
        public void MostrarVehiculosEnSucursal(Sucursal sucursal)
        {
            List<Vehiculo> vehiculos = sucursal.GetVehiculos();
            foreach (Vehiculo vehiculo in vehiculos)
            {
                vehiculo.InfoVehiculo();
            }
        }
        public List<Sucursal> ListaSucursales()
        {
            return Sucursales;
        }
    }
}
