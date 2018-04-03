using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental
{
    class Persona
    {
        public string nombre; //Nombre completo de la persona
        public string tipoLicencia; //Para autos, motos, maquinaria pesada, buses, etc

        public Persona(string miNombre, string miLicencia)
        {
            nombre = miNombre;
            tipoLicencia = miLicencia;
        }
    }
}
