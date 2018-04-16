using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental
{
    class Persona : Arrendatario
    {
        public string tipoLicencia; //Para autos, motos, maquinaria pesada, buses, etc

        public Persona(string miNombre, string miId, string miPassword, string miLicencia) : base (miNombre, miId, miPassword)
        {
            tipoLicencia = miLicencia;
        }

        public override string GetTipo()
        {
            return "Persona";
        }

        public override string GetLicencia()
        {
            return tipoLicencia;
        }
    }
}
