using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
	#region Enumerados
	public enum TipoDePrestamo
	{
		Pesos,
		Dolares,
		Todos
	}

	public enum PeriodicidadDePago
	{
		Mensual,
		Bimestral,
		Trimestral
	}
	#endregion
	
	public abstract class Prestamo
	{
		#region Atributos
		protected float monto;
		protected DateTime vencimiento;
		#endregion

		#region Properties
		public float Monto
		{
			get
			{
				return this.monto;
			}
		}
		public DateTime Vencimiento
		{
			get
			{
				return this.vencimiento;
			}
			set
			{
				if (value > DateTime.Now.Date)
				{
					this.vencimiento = value;
				}
				else
				{
					this.vencimiento = DateTime.Now.Date;
				}
				this.vencimiento = value;
			}
		}

		#endregion

		#region Constructores
		public Prestamo(float monto, DateTime vencimiento)
		{
			this.monto = monto;
			this.Vencimiento = vencimiento;
		}
		#endregion

		#region Métodos
		public static int OrdenarPorFecha(Prestamo p1, Prestamo p2)
		{
			int retorno = 0;
			if(p1.vencimiento > p2.vencimiento)
			{
				retorno = 1;
			}
			else if(p1.vencimiento < p2.vencimiento)
			{
				retorno = -1;
			}
			return retorno;
		}

		public abstract void ExtenderPlazo(DateTime nuevoVencimiento);

		public virtual string Mostrar()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("Monto: " + this.Monto);
			sb.AppendLine("Vencimiento: " + this.Vencimiento);
			return sb.ToString();
		}
		#endregion

		#region Conversiones

		#endregion

		#region Operaciones

		#endregion

		#region Override

		#endregion

	}
}
