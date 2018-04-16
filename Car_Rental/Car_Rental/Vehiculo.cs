using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental
{
    abstract class Vehiculo : IArrendable
    {
        //Atributos:
        public string licencia;//Licencia requerida para manejar este vehiculo
        public int precio;//Precio del arriendo por dias
        public string patente;//Su forma varia segun tipo de vehiculo
        public string marca, modelo;

        //Constructor:
        public Vehiculo(string miLicencia, int miPrecio, string miPatente, string miMarca, string miModelo)
        {
            licencia = miLicencia;
            precio = miPrecio;
            patente = miPatente;
            modelo = miModelo;
            marca = miMarca;
        }

        //Metodos:
        public virtual void InfoVehiculo()
        {
            Console.WriteLine(marca + " " + modelo);
        }
        public abstract string GetTipo();
    }
}
