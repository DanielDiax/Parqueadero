using System;

namespace Parqueadero
{
    class Program
    {
        

        static void Main(string[] args)
        {
            DateTime fecha = new DateTime();
            string vehiculo = "";
            bool contemplado = false;
            string cliente = "";


            Console.WriteLine("****Parqueadero****");

          
            Console.WriteLine("Digite C si cobra la estadia de un automovil\n" +
                "Digite M si cobra la estadia de una moto\n" +
                "Digite B si cobra la estadia de una bicicleta\n");


            //fecha = DateTime.Now;
            //Console.WriteLine("La hora actual es: " + fecha);
            

            while (!contemplado)
            {
                vehiculo = Console.ReadLine();
                vehiculo = vehiculo.ToUpper();

                switch (vehiculo)
                {
                    case "C":
                        CalcularCarro();
                        contemplado = true;
                        break;
                    case "M":
                        contemplado = true;
                        break;
                    case "B":
                        contemplado = true;
                        break;
                    default:
                        Console.WriteLine("No esta contemplada la opción");
                        contemplado = false;
                        break;
                }
            }
        }

        public static void CalcularCarro() 
        {
            bool existe = false;
            string[] vehiculos = new string[10];
            string[] clientes = new string[10];

            vehiculos[0] = "LTU87F";
            vehiculos[1] = "LVT55E";
            vehiculos[2] = "RTR83F";
            vehiculos[3] = "BTY96C";
            vehiculos[4] = "MGR854";
            vehiculos[5] = "KFM558";
            vehiculos[6] = "FGT888";
            vehiculos[7] = "AAA001";
            vehiculos[8] = "AAA002";
            vehiculos[9] = "AAA003";

            clientes[0] = "Daniel";
            clientes[1] = "David";
            clientes[2] = "Edwin";
            clientes[3] = "Carlos";
            clientes[4] = "Laura";
            clientes[5] = "Juan";
            clientes[6] = "Ana";
            clientes[7] = "Diego";
            clientes[8] = "Neider";
            clientes[9] = "Andres";

            

            Console.WriteLine("Digite la opción que corresponda:\n" +
                "1: Pago de mensualidad\n" + 
                "2: pago por horas\n" +
                "3: solo lavado de vehiculo");

            int opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 1) 
            {
                Console.WriteLine("Ingrese placa: ");
                string vehiculo = Console.ReadLine();
                vehiculo = vehiculo.ToUpper();
                for (int i = 0; i < vehiculos.Length; i++)
                {
                    if (vehiculo == vehiculos[i]) existe = true;
                }
                if (existe == true) 
                {
                    int mensualidad = 80000;
                    Console.WriteLine("La mensualidad de ha renovado correctamente tras el pago de la mensulidad por valor de: " + mensualidad);
                }
                   
                else 
                Console.WriteLine("El cliente no existe.");

            }

            Console.WriteLine("Ingrese el valor de la hora para carros");
            int valorHoraCarro = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el tiempo que permanecio el carro en el parqueadero en horas");
            int tiempoPermanencia = Convert.ToInt32(Console.ReadLine());
        }
    }
}
