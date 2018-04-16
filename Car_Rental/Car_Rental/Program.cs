using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Administrador admin = new Administrador("19606307-2","contrasena");
            Persona persona1 = new Persona("Pedro Correa", "12345678-9","contrasena", "B");
            Empresa empresa1 = new Empresa("Colegio Cordillera", "25648598-5", "contrasena","Institucion", "Bus", "C");

            //Inicio programa:
            bool CorrerPrograma = true;
            //Inicio programa.
            while (CorrerPrograma)
            {
                char temp;//variable temporal, se usara para las selecciones de cada menu.
                //Menu sucursales
                int suc_seleccionada = MenuSucursales(admin);
                //Agregar sucursal
                if (suc_seleccionada == 0)
                {
                    CrearSucursal(admin);
                }
                //Menu inicio
                if (suc_seleccionada != 0)
                    {
                    temp = MenuInicio(admin, suc_seleccionada);
                    Sucursal sucursal_actual = admin.ListaSucursales()[suc_seleccionada-1];
                    if (temp == '1')//arrendar un vehiculo
                    {
                        ElegirVehiculo(admin, sucursal_actual);
                    }
                    if (temp == '2')//revisar vehiculos
                    {
                        admin.MostrarVehiculosEnSucursal(admin.ListaSucursales()[suc_seleccionada-1]);
                    }
                    if (temp == '3')
                    {
                        Vehiculo vehiculo_recibido = RegistrarVehiculo();
                        admin.AgregarVehiculo_sucursal(vehiculo_recibido, sucursal_actual);
                    }
                    if (temp == '0')
                    {

                    }
                }
            }
            //Fin programa.
            Console.WriteLine("Programa finalizado");
            Console.ReadLine();
        }

        //-------------------------------------------------------------------------------------|
        //----------------------------------------MENUS----------------------------------------|
        //-------------------------------------------------------------------------------------|

        static int MenuSucursales(Administrador admin)
        {
            int sucursal_seleccionada = 0;
            Console.WriteLine("Sucursales disponibles:");
            if (admin.ListaSucursales().Count() > 0)
            {
                int n = 1;
                foreach(Sucursal sucursal in admin.ListaSucursales())
                {
                    Console.WriteLine(n + ". " + sucursal.GetName());
                    n++;
                }
            }
            Console.WriteLine((admin.ListaSucursales().Count()+1).ToString() + ". Agregar nueva sucursal.\nSeleccion: ");
            int.TryParse(Console.ReadLine(), out sucursal_seleccionada);
            while (sucursal_seleccionada == 0)
            {
                Console.WriteLine("Seleccion: ");
                int.TryParse(Console.ReadLine(), out sucursal_seleccionada);
            }
            if (admin.ListaSucursales().Count()+1 == sucursal_seleccionada)
            {
                sucursal_seleccionada = 0;
            }
            return sucursal_seleccionada;//cero para agregar una nueva sucursal
        }

        static char MenuInicio(Administrador admin, int suc_seleccionada)
        {
            char seleccion;
            
            Console.WriteLine("CAR RENTAL. " + admin.ListaSucursales()[suc_seleccionada-1].GetName() + "\nSeleccione:\n1. Arrendar vehiculo.\n2. Revisar vehiculos.\n3. Agregar vehiculo.\n0. Salir.\nIngrese seleccion: ");
            seleccion = Console.ReadLine()[0];
            while (seleccion != '0' & seleccion != '1' & seleccion != '2' &seleccion != '3')
            {
                Console.WriteLine("CAR RENTAL. " + admin.ListaSucursales()[suc_seleccionada - 1].GetName() + "\nSeleccione:\n1. Arrendar vehiculo.\n2. Revisar vehiculos.\n3. Agregar vehiculo.\n0. Salir.\nIngrese seleccion: ");
                seleccion = Console.ReadLine()[0];
            }
            return seleccion;
        }

        static void CrearSucursal(Administrador admin)
        {
            Console.WriteLine("Ingrese el nombre de la nueva sucursal: ");
            string sucursal_nombre = Console.ReadLine();
            if (sucursal_nombre != "0")
            {
                while (admin.CrearSucursal(sucursal_nombre) == false & sucursal_nombre != "0")
                {
                    Console.WriteLine("Esta sucursal ya existe. Ingrese el nombre de la nueva sucursal: ");
                    sucursal_nombre = Console.ReadLine();
                }
                Console.WriteLine("Sucursal agregada con exito\n");
            }
        }

        static Vehiculo ElegirVehiculo(Administrador admin, Sucursal sucursal_actual)
        {
            if (sucursal_actual.GetVehiculos() == null)
            {
                Console.WriteLine("No hay vehiculos en esta sucursal");
                return null;
            }
            else
            {
                admin.MostrarVehiculosEnSucursal(sucursal_actual);
                Console.WriteLine("Selecion: ");
                int vehiculo_seleccionado;
                int.TryParse(Console.ReadLine(), out vehiculo_seleccionado);
                if (vehiculo_seleccionado == 0)
                {
                    return null;
                }
                return sucursal_actual.GetVehiculos()[vehiculo_seleccionado];
            }
        }

        static Vehiculo RegistrarVehiculo()
        {
            Console.WriteLine("Ingresar vehiculo");
            Console.WriteLine("Tipo de vehiculo:");
            Console.WriteLine("1. Auto.");
            Console.WriteLine("2. Camioneta.");
            Console.WriteLine("3. Moto.");
            Console.WriteLine("4. Bus.");
            Console.WriteLine("5. Camion.");
            Console.WriteLine("6. Grua.");
            Console.WriteLine("7. Excavadora.");
            Console.WriteLine("0. Volver");
            Console.WriteLine("Seleccion: ");
            int.TryParse(Console.ReadLine(), out int tipo_vehiculo);
            if (tipo_vehiculo == 1)//auto
            {
                Console.WriteLine("Marca: ");
                string marca = Console.ReadLine();
                Console.WriteLine("Modelo: ");
                string modelo = Console.ReadLine();
                Console.WriteLine("Tipo de auto (deportivo, familiar, economico): ");
                string tipo = Console.ReadLine();
                Console.WriteLine("Tipo de traccion: ");
                string traccion = Console.ReadLine();
                Console.WriteLine("Licencia requerida para conducir: ");
                string licencia = Console.ReadLine();
                Console.WriteLine("Patente: ");
                string patente = Console.ReadLine();
                Console.WriteLine("Numero de puertas: ");
                int.TryParse(Console.ReadLine(), out int puertas);
                Console.WriteLine("Rendimiento (km/L): ");
                int.TryParse(Console.ReadLine(), out int rendimiento);
                Console.WriteLine("Precio (por dia): ");
                int.TryParse(Console.ReadLine(), out int precio);
                
                Auto auto = new Auto(marca, modelo, tipo, puertas, traccion, rendimiento, precio, licencia, patente);
                return auto;
            }
            if (tipo_vehiculo == 2)//Camioneta
            {
                Console.WriteLine("Marca: ");
                string marca = Console.ReadLine();
                Console.WriteLine("Modelo: ");
                string modelo = Console.ReadLine();
                Console.WriteLine("Tipo de cabina (doble o simple): ");
                string tipoCabina = Console.ReadLine();
                Console.WriteLine("Capacidad: ");
                int.TryParse(Console.ReadLine(), out int capacidad);
                Console.WriteLine("Tipo de traccion: ");
                string traccion = Console.ReadLine();
                Console.WriteLine("Licencia requerida para conducir: ");
                string licencia = Console.ReadLine();
                Console.WriteLine("Patente: ");
                string patente = Console.ReadLine();
                Console.WriteLine("Numero de puertas: ");
                int.TryParse(Console.ReadLine(), out int puertas);
                Console.WriteLine("Rendimiento (km/L): ");
                int.TryParse(Console.ReadLine(), out int rendimiento);
                Console.WriteLine("Precio (por dia): ");
                int.TryParse(Console.ReadLine(), out int precio);
                Camioneta camioneta = new Camioneta(marca, modelo, tipoCabina, capacidad, puertas, traccion, rendimiento, precio, licencia, patente);
                return camioneta;
            }
            if (tipo_vehiculo == 3)
            {
                Console.WriteLine("Marca: ");
                string marca = Console.ReadLine();
                Console.WriteLine("Modelo: ");
                string modelo = Console.ReadLine();
                Console.WriteLine("Licencia requerida para conducir: ");
                string licencia = Console.ReadLine();
                Console.WriteLine("Patente: ");
                string patente = Console.ReadLine();
                Console.WriteLine("Hp: ");
                int.TryParse(Console.ReadLine(), out int hp);
                Console.WriteLine("Rendimiento (km/L): ");
                int.TryParse(Console.ReadLine(), out int rendimiento);
                Console.WriteLine("Precio (por dia): ");
                int.TryParse(Console.ReadLine(), out int precio);
                Console.WriteLine("Casco (si o no): ");
                string tiene_casco = Console.ReadLine();
                bool casco;
                if (tiene_casco.ToLower() == "si")
                {
                    casco = true;
                }
                else
                {
                    casco = false;
                }
                Console.WriteLine("Maleta (si o no): ");
                string tiene_maleta = Console.ReadLine();
                bool maleta;
                if (tiene_maleta.ToLower() == "si")
                {
                    maleta = true;
                }
                else
                {
                    maleta = false;
                }
                Moto moto = new Moto(marca, modelo, hp, rendimiento, casco, maleta, precio, licencia, patente);
                return moto;
            }
            if (tipo_vehiculo == 4)
            {
                Console.WriteLine("Marca: ");
                string marca = Console.ReadLine();
                Console.WriteLine("Modelo: ");
                string modelo = Console.ReadLine();
                Console.WriteLine("Licencia requerida para conducir: ");
                string licencia = Console.ReadLine();
                Console.WriteLine("Patente: ");
                string patente = Console.ReadLine();
                Console.WriteLine("Capacidad (personas sentadas): ");
                int.TryParse(Console.ReadLine(), out int capacidad);
                Console.WriteLine("Rendimiento (km/L): ");
                int.TryParse(Console.ReadLine(), out int rendimiento);
                Console.WriteLine("Precio (por dia): ");
                int.TryParse(Console.ReadLine(), out int precio);
                Bus bus = new Bus(marca, modelo, capacidad, rendimiento, precio, licencia, patente);
                return bus;
            }
            if (tipo_vehiculo == 5)//Camion
            {
                Console.WriteLine("Marca: ");
                string marca = Console.ReadLine();
                Console.WriteLine("Modelo: ");
                string modelo = Console.ReadLine();
                Console.WriteLine("Licencia requerida para conducir: ");
                string licencia = Console.ReadLine();
                Console.WriteLine("Patente: ");
                string patente = Console.ReadLine();
                Console.WriteLine("Precio (por dia): ");
                int.TryParse(Console.ReadLine(), out int precio);
                Camion camion = new Camion(licencia, precio, patente, modelo, marca);
                return camion;
            }
            if (tipo_vehiculo == 6)//grua
            {
                Console.WriteLine("Marca: ");
                string marca = Console.ReadLine();
                Console.WriteLine("Modelo: ");
                string modelo = Console.ReadLine();
                Console.WriteLine("Licencia requerida para conducir: ");
                string licencia = Console.ReadLine();
                Console.WriteLine("Patente: ");
                string patente = Console.ReadLine();
                Console.WriteLine("Precio (por dia): ");
                int.TryParse(Console.ReadLine(), out int precio);
                Grua grua = new Grua(licencia, precio, patente, modelo, marca);
                return grua;
            }
            if (tipo_vehiculo == 7)//Excavadora
            {
                Console.WriteLine("Marca: ");
                string marca = Console.ReadLine();
                Console.WriteLine("Modelo: ");
                string modelo = Console.ReadLine();
                Console.WriteLine("Licencia requerida para conducir: ");
                string licencia = Console.ReadLine();
                Console.WriteLine("Patente: ");
                string patente = Console.ReadLine();
                Console.WriteLine("Precio (por dia): ");
                int.TryParse(Console.ReadLine(), out int precio);
                Excavadora excavadora = new Excavadora(licencia, precio, patente, modelo, marca);
                return excavadora;
            }
            return null;
        }
    }
}
