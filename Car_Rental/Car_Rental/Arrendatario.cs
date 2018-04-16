using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental
{
    abstract class Arrendatario : Usuario
    {
        //Atributos:
        string nombre;
        List<string> vehiculos_arrendados = new List<string>();
        
        //Constructor:
        public Arrendatario (string miNombre, string miId, string miPassword) : base (miId, miPassword)
        {
            nombre = miNombre;
        }

        //Metodos:
        public abstract string GetTipo();
        public abstract string GetLicencia();
        public string GetName()
        {
            return nombre;
        }
        public bool GetVehiculosArrendados(string arriendo)
        {
            if (vehiculos_arrendados.Contains(arriendo))
            {
                return false;
            }
            else
            {
                vehiculos_arrendados.Add(arriendo);
                return true;
            }

        }
    }
}
