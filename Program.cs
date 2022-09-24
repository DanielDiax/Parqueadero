using System;

namespace Parqueadero
{
    class Program
    {
        

        static void Main(string[] args)
        {
            
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

            int costoLavadaBreve = 45000;
            int costoPolichada = 90000;
            int costoLavadaFull = 80000;
            int mensualidad = 80000;

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

            clientes[0] = "DANIEL";
            clientes[1] = "DAVID";
            clientes[2] = "EDWIN";
            clientes[3] = "CARLOS";
            clientes[4] = "LAURA";
            clientes[5] = "JUAN";
            clientes[6] = "ANA";
            clientes[7] = "DIEGO";
            clientes[8] = "NEIDER";
            clientes[9] = "ANDRES";

            DateTime fecha = new DateTime();
            fecha = DateTime.Now;



            Console.WriteLine("Digite la opción que corresponda:\n" +
                "1: Pago de mensualidad\n" + 
                "2: pago por horas\n" +
                "3: solo lavado de vehiculo");

            int opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 1) 
            {
                Console.WriteLine("Ingrese placa: o el nombre del cliente");
                string cliente = Console.ReadLine();
                cliente = cliente.ToUpper();
                for (int i = 0; i < vehiculos.Length; i++)
                {
                    if (cliente == vehiculos[i] || cliente == clientes[i]) existe = true;
                }
                if (existe == true) 
                {
                    Console.WriteLine("El cliente existente.");
                    
                    Console.WriteLine("La mensualidad se ha renovado correctamente tras el pago de la mensulidad por valor de: \n" + mensualidad + " el " + fecha);
                    Console.WriteLine("Ya que una cosa no quita la otra,  ¿vamos a lavar el carro?\n"+
                                        "S para (Si) N para (No)");
                    string resp = Console.ReadLine();
                    resp = resp.ToUpper();
                    if (resp == "S")
                    {
                        int total = 0;
                        Console.WriteLine("¿Que tipo de lavada?,  ¿breve o mela?\n" +
                                        "B para (Breve) M para (Mela)");

                        string lavada = Console.ReadLine();
                        lavada = lavada.ToUpper();
                        if (lavada == "B") total = mensualidad + costoLavadaBreve;
                        else total = mensualidad + costoLavadaFull;

                        Console.WriteLine("Ya entrados en gastos...,  ¿vamos a polichar el carro?\n" +
                                        "S para (Si) N para (No)");
                        string resp2 = Console.ReadLine();
                        resp2 = resp2.ToUpper();
                        if (resp2 == "S")
                        {
                            total += costoPolichada;
                            Console.WriteLine("Sus gastos serían de: " + mensualidad + " de mensualidad más " + total + "de la lavada y polichada");
                        }
                        else
                        {
                            Console.WriteLine("Sus gastos serían de: " + mensualidad + " de mensualidad más " + total + "de la lavada");
                        }

                    }
                    else 
                    {
                        Console.WriteLine("Qie pirobo tan duro.");
                    }
                }
                else
                {
                    Console.WriteLine("El cliente no existe.");
                }
            }
            if (opcion == 2)
            {
                Console.WriteLine("Ingrese el valor de la hora para carros");
                int valorHoraCarro = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el tiempo que permanecio el carro en el parqueadero en horas");
                int tiempoPermanencia = Convert.ToInt32(Console.ReadLine());

                int cobroparqueo = valorHoraCarro * tiempoPermanencia;

                Console.WriteLine("¿El cliente solicito servicio de lavadero ?\n" +
                                    "S para (Si) N para (No)");
                string resp = Console.ReadLine();
                resp = resp.ToUpper();
                if (resp == "S")
                {
                    int total = 0;
                    int totalLavada = 0;
                    Console.WriteLine("¿Que tipo de lavada?,  ¿breve o mela?\n" +
                                    "B para (Breve) M para (Mela)");

                    string lavada = Console.ReadLine();
                    lavada = lavada.ToUpper();
                    if (lavada == "B") total = cobroparqueo + costoLavadaBreve; 
                    else total = cobroparqueo + costoLavadaFull;

                    Console.WriteLine("Ya entrados en gastos...,  ¿vamos a polichar el carro?\n" +
                                    "S para (Si) N para (No)");
                    string resp2 = Console.ReadLine();
                    resp2 = resp2.ToUpper();
                    if (resp2 == "S")
                    {
                        total += costoPolichada;
                        Console.WriteLine("Sus gastos serían de: " + cobroparqueo + " de estadía más " + total + "de la lavada y polichada");
                    }
                    else
                    {
                        Console.WriteLine("Sus gastos serían de: " + cobroparqueo + " de estadía más " + total + "de la lavada");
                    }

                }
            }
            
        }
    }
}
