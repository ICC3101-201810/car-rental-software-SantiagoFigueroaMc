using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental
{
    class Empresa : Arrendatario
    {
        //Atributos:
        public string tipo;//Empresa, organicacion o institucion
        public string permiso;//Permiso para manejar el vehiculo respectivo.
        string licencia;

        //Constructor:
        public Empresa(string miNombre, string miId, string miPassword, string miTipo, string miPermiso, string miLicencia) : base (miNombre, miId, miPassword)
        {
            tipo = miTipo;
            permiso = miPermiso;
            licencia = miLicencia;
        }

        //Metodos:
        public override string GetLicencia()
        {
            return licencia;
        }

        public override string GetTipo()
        {
            return "Empresa";
        }
    }
}
