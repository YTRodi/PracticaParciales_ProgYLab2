using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo
	{
		#region Atributos
		protected DateTime ingreso;
		protected string patente;
		#endregion

		#region Properties

		public string Patente
		{
			get
			{
					return this.patente;
			}
			set
			{
				if(value.Length == 6)
				{
					this.patente = value;
				}
			}
		}

		#endregion

		#region Constructores
		public Vehiculo(string patente)
		{
			this.ingreso = DateTime.Now.AddHours(-3);
			this.Patente = patente;
		}
		#endregion

		#region Métodos
		public abstract string ConsultarDatos();

		public virtual string ImprimirTicket()
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendFormat("Datos del vehiculo -- {0}", this.GetType());
			sb.AppendLine("\n<<------------------------->>");
			sb.Append(this.ToString());
			sb.Append("Hora de ingreso: " + this.ingreso);//muestro la hora nada más.

			return sb.ToString();
		}
		#endregion

		#region Operaciones
		public static bool operator ==(Vehiculo v1, Vehiculo v2)
		{
			bool patenteIguales = false;
			if(v1.Patente == v2.Patente)
			{
				if(v1.Equals(v2) && v2.Equals(v2))//usar el equals sobrescrito de las clases derivadas.
				{
					patenteIguales = true;
				}
			}
			return patenteIguales;
		}

		public static bool operator !=(Vehiculo v1, Vehiculo v2)
		{
			return !(v1 == v2);
		}

		#endregion

		#region Override
		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine(string.Format("Patente: {0}",this.patente));

			return sb.ToString();
		}
		#endregion

	}
}
