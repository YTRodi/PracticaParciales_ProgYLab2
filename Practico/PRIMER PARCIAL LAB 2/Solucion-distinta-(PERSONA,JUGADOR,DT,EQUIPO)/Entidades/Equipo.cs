using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
	{
        #region Enumerados
        public enum Deportes
        {
            Basquet,
            Futbol,
            Handball,
            Rugby
        }
        #endregion

        #region Atributos
        private static Deportes deporte;
        private DirectorTecnico dt;
        private List<Jugador> listaJugadores;
        private string nombreEquipo;
        #endregion

        #region Properties

        public Deportes Deporte
        {
            set
            {
                Equipo.deporte = value;
            }
        }
        #endregion

        #region Constructores
        static Equipo()
        {
            Equipo.deporte = Deportes.Futbol;
        }
        private Equipo()
        {
            this.listaJugadores = new List<Jugador>();
        }

        public Equipo(string nombre, DirectorTecnico dt) : this()
        {
            this.nombreEquipo = nombre;
            this.dt = dt;
        }
        public Equipo(string nombre, DirectorTecnico dt, Deportes deportes) : this(nombre, dt)
        {
            this.Deporte = deportes;
        }
        #endregion

        #region Métodos

        #endregion

        #region Conversiones

        public static implicit operator string(Equipo equipito)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("**{0} {1}**\n", equipito.nombreEquipo, Equipo.deporte);
            sb.AppendLine("Nómina de jugadores: ");
            foreach (Jugador item in equipito.listaJugadores)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Dirigido por: " + equipito.dt.NombreCompleto());
            return sb.ToString();
        }

        #endregion

        #region Operaciones
        public static bool operator ==(Equipo equipito, Jugador jugadorcito)
        {
            bool estaEnLista = false;
            foreach (Jugador item in equipito.listaJugadores)
            {
                if(item == jugadorcito)
                {
                    estaEnLista = true;
                    break;
                }
            }
            return estaEnLista;
        }

        public static bool operator !=(Equipo equipito, Jugador jugadorcito)
        {
            return !(equipito == jugadorcito);
        }

        public static Equipo operator +(Equipo equipito, Jugador jugadorcito)
        {
            if(equipito != jugadorcito)
            {
                equipito.listaJugadores.Add(jugadorcito);
            }
            return equipito; 
        }

        public static Equipo operator -(Equipo equipito, Jugador jugadorcito)
        {
            if (equipito == jugadorcito)
            {
                equipito.listaJugadores.Remove(jugadorcito);
            }
            return equipito;
        }

        #endregion

        #region Override

        #endregion


    }
}
