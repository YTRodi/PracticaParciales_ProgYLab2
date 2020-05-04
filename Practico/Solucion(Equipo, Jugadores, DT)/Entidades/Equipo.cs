using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
	{
		#region Atributos
		private const int cantidadMaximaJugadores = 6;
		private DirectorTecnico directorTecnico;
		private List<Jugador> listaJugadores;
		private string nombreEquipo;
		#endregion

		#region Properties

		public DirectorTecnico DirectorTecnico
		{
			set
			{
				if(value.ValidarAptitud())
				{
					this.directorTecnico = value;
				}
			}
		}

		public string Nombre
		{
			get
			{
				return this.nombreEquipo;
			}
		}

		#endregion

		#region Constructores
		private Equipo()
		{
			this.listaJugadores = new List<Jugador>();
		}
		public Equipo(string nombre) : this()
		{
			this.nombreEquipo = nombre;
		}
		#endregion

		#region Métodos

		#endregion

		#region Conversiones
		public static explicit operator string(Equipo equipito)
		{
			//(string)equipito;

			StringBuilder sb = new StringBuilder();
			sb.AppendLine("<----Datos del equipo---->");
			sb.AppendLine("Nombre del equipo: " + equipito.nombreEquipo);

			if (equipito.directorTecnico is null)
			{
				sb.AppendLine("Sin DT asignado");
			}
			else
			{
				sb.AppendLine("Director técnico: " + equipito.directorTecnico);

				sb.AppendLine("<----Datos de los jugadores---->");
				foreach (Jugador item in equipito.listaJugadores)
				{
					sb.AppendLine(item.Mostrar());
				}
			}
			return sb.ToString();
		}


		public static bool operator ==(Equipo equipito, Jugador jugadorcito)
		{
			bool estaEnElEquipo = false;
			if(equipito.listaJugadores.Contains(jugadorcito))
			{
				estaEnElEquipo = true;
			}
			return estaEnElEquipo;
		}

		public static bool operator !=(Equipo equipito, Jugador jugadorcito)
		{
			return !(equipito == jugadorcito);
		}


		public static Equipo operator +(Equipo equipito, Jugador jugadorcito)
		{
			if(equipito != jugadorcito)
			{
				if(Equipo.cantidadMaximaJugadores <= 6)
				{
					if (jugadorcito.ValidarAptitud())
					{
						equipito.listaJugadores.Add(jugadorcito);
					}
				}
			}
			return equipito;
		}

		public static bool ValidarEquipo(Equipo equipito)
		{
			bool validaEquipo = false;

			int countArquero = 0;
			int countDefensor = 0;
			int countCentral = 0;
			int countDelantero = 0;

			foreach (Jugador item in equipito.listaJugadores)
			{
				switch (item.Posicion)
				{
					case Posicion.Arquero:
						countArquero++;
						break;

					case Posicion.Defensor:
						countDefensor++;
						break;

					case Posicion.Central:
						countCentral++;
						break;

					case Posicion.Delantero:
						countDelantero++;
						break;
				}
			}

			if (!(equipito.directorTecnico is null))
			{
				if(equipito.listaJugadores.Count == Equipo.cantidadMaximaJugadores)
				{
					if(countArquero == 1 &&
						countDefensor >= 1 &&
						countCentral >= 1 &&
						countDelantero >= 1)
					{
						validaEquipo = true;
					}
				}
			}
			return validaEquipo;
		}
		#endregion
	}
}
