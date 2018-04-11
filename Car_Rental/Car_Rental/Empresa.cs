using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental
{
    class Empresa
    {
        public string nombre;
        public string tipo;//Empresa, organicacion o institucion
        public string permiso;//Permiso para manejar el vehiculo respectivo.

        public Empresa(string miNombre, string miTipo, string miPermiso)
        {
            nombre = miNombre;
            tipo = miTipo;
            permiso = miPermiso;
        }
    }
}
