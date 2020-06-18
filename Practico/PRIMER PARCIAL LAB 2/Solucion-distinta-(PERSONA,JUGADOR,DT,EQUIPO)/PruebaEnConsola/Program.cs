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
            //FUNCIONANDO.
            DirectorTecnico dt = new DirectorTecnico("Yaguito", "Rodi");
            Equipo equipito = new Equipo("Huracán de San Rafael",dt);//por defecto futbol
            
            Jugador j1 = new Jugador("Juan", "Perez");//num = 0 y esCapitan false -- OK
            Jugador j2 = new Jugador("Sebastian", "Dominguez");// num = 0 y esCapitan false-- OK
            Jugador j3 = new Jugador("Lionel", "Messi", 10, true);
            Jugador j4 = new Jugador("Marcos", "Sosa", 100, false);
            Jugador j5 = new Jugador("Luis", "Suarez", 9, false);
            Jugador j6 = new Jugador("Alberto", "Palacios");// num = 0 y esCapitan false-- OK

            Jugador j1COPIA = new Jugador("Juan", "Perez");// num = 0 y esCapitan false-- OK


            equipito = equipito + j1;
            equipito = equipito + j1COPIA;//NO
            equipito = equipito + j2;
            equipito = equipito + j2;//intento agregar de nuevo a j2
            equipito = equipito + j3;
            equipito = equipito + j4;
            equipito = equipito + j5;
            equipito = equipito + j6;

            //COUNT 6
            Console.WriteLine(equipito);//imprimo el equipo.

            Console.ReadKey();
            Console.Beep();
            Console.Clear();

            equipito = equipito - j1;//saco a juan perez
            equipito = equipito - j2;//saco a sebastian dominguez

            Console.WriteLine(equipito);//imprimo de nuevo

            Console.ReadKey();
            Console.Beep();
        }
    }
}
