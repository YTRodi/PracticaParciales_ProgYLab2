using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
namespace PruebaEnConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Estacionamiento e = new Estacionamiento("UTN", 6);

            // Creación de Vehículos
            Console.WriteLine("MOTOS");
            Vehiculo m1 = new Moto("ASD123", 75, 4);
            Console.WriteLine(m1.ConsultarDatos());
            Moto m2 = new Moto("ASDaa123", 175);
            Console.WriteLine(m2.ConsultarDatos());
            Moto m3 = new Moto("QWE312", 175, 4, 35);
            Console.WriteLine(m3.ConsultarDatos());

            Console.ReadKey();
            Console.Beep();
            Console.Clear();

            Console.WriteLine("PICKUPS");
            PickUp p1 = new PickUp("TYR753", "78", 51);
            Console.WriteLine(p1.ConsultarDatos());
            PickUp p2 = new PickUp("TYR753", "Model A");
            Console.WriteLine(p2.ConsultarDatos());

            Console.ReadKey();
            Console.Beep();
            Console.Clear();

            Console.WriteLine("AUTOMOVILES");
            Automovil a1 = new Automovil("POI952", ConsoleColor.Red);
            Console.WriteLine(a1.ConsultarDatos());
            Automovil a2 = new Automovil("MNB651", ConsoleColor.DarkCyan, 23);
            Console.WriteLine(a2.ConsultarDatos());

            Console.ReadKey();
            Console.Beep();
            Console.Clear();

            Console.WriteLine("--------------------------------");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Estacionamiento Ingreso\n");
            e += m1;
            e += p1;
            e += a1;
            e += m1;//no
            e += p1;//no
            e += a1;//no
            e += m2;//no porque tiene patente mayor a 6 caracteres
            e += p2;//igual patente que p1.
            e += a2;
            e += m3;
            Console.WriteLine((string)e);//imprime todos los datos del estacionamiento

            Console.ReadKey();
            Console.Beep();
            Console.Clear();

            Console.WriteLine("--------------------------------");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Estacionamiento Egreso\n");
            //Console.WriteLine(e - m1);
            Console.WriteLine(e - p1);
            Console.WriteLine(e - a1);
            Console.WriteLine(e - m2);//no pertenece al estacionamiento
            Console.WriteLine(e - p2);//idem
            Console.WriteLine(e - a2);
            Console.WriteLine(e - m3);
            Console.WriteLine("--------------------------------");

            Console.ReadKey();
            Console.Beep();
            Console.Clear();

            Console.WriteLine((string)e);//si tildo e -m1, queda el dela patente ASD123.
            
            //FUNCIONANDO.

            Console.ReadKey();
        }
    }
}
