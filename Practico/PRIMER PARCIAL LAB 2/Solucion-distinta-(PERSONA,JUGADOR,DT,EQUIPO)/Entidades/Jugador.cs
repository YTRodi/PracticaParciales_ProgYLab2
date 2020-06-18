using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador : Persona
	{
		#region Atributos
		private bool esCapitan;
		private int numero;
		#endregion

		#region Properties

		public bool EsCapitan
		{
			get
			{
				return this.esCapitan;
			}
			set
			{
				this.esCapitan = value;
			}
		}
		public int Numero
		{
			get
			{
				return this.numero;
			}
			set
			{
				this.numero = value;
			}
		}

		#endregion

		#region Constructores
		public Jugador(string nombre, string apellido) : base(nombre, apellido)
		{
			this.EsCapitan = false;
			this.Numero = 0;
		}
		public Jugador(string nombre, string apellido, int numero, bool esCapitan) : this(nombre, apellido)
		{
			this.EsCapitan = esCapitan;
			this.Numero = numero;
		}
		#endregion

		#region Métodos
		protected override string FichaTecnica()
		{
			StringBuilder sb = new StringBuilder();

			if(this.EsCapitan)
			{
				sb.AppendFormat($"{this.NombreCompleto()}, capitán del equipo, Camiseta número {this.Numero}");
			}
			else
			{
				sb.AppendFormat($"{this.NombreCompleto()} Camiseta número {this.Numero}");
			}
			return sb.ToString();
		}
		#endregion

		#region Conversiones

		public static explicit operator int(Jugador jugadorcito)
		{
			return jugadorcito.Numero;
		}
		#endregion

		#region Operaciones
		public static bool operator ==(Jugador j1, Jugador j2)
		{
			bool sonIugales = false;
			if (j1.Nombre == j2.Nombre && j1.Apellido == j2.Apellido && j1.Numero == j2.Numero)
			{
				sonIugales = true;
			}
			return sonIugales;
		}

		public static bool operator !=(Jugador j1, Jugador j2)
		{
			return !(j1 == j2);
		}
		#endregion

		#region Override
		public override string ToString()
		{
			return this.FichaTecnica();
		}
		public override bool Equals(object obj)
		{
			return (obj is Jugador);
		}
		#endregion


	}
}
