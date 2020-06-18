using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using PrestamosPersonales;

namespace EntidadFinanciera
{
	public class Financiera
	{
		#region Atributos
		private List<Prestamo> listaDePrestamos;
		private string razonSocial;
		#endregion

		#region Properties

		public float InteresesEnDolares
		{
			get
			{
				return this.CalcularInteresGanado(TipoDePrestamo.Dolares);
			}
		}
		public float InteresesEnPesos
		{
			get
			{
				return this.CalcularInteresGanado(TipoDePrestamo.Pesos);
			}
		}
		public float InteresesTotales
		{
			get
			{
				return this.CalcularInteresGanado(TipoDePrestamo.Todos);
			}
		}


		public List<Prestamo> ListaDePrestamos
		{
			get
			{
				return this.listaDePrestamos;
			}
		}
		public string RazonSocial
		{
			get
			{
				return this.razonSocial;
			}
		}
		#endregion

		#region Constructores
		private Financiera()
		{
			this.listaDePrestamos = new List<Prestamo>();
		}
		public Financiera(string razonSocial) : this()
		{
			this.razonSocial = razonSocial;
		}
		#endregion

		#region Métodos
		public static string Mostrar(Financiera financiera)
		{
			//tiene que usar la conversión explicita.
			return (string)financiera;
		}


		public void OrdenarPrestamos()
		{
			this.listaDePrestamos.Sort(Prestamo.OrdenarPorFecha);
		}

		private float CalcularInteresGanado(TipoDePrestamo tipoDePrestamo)
		{
			float retornoInteresGanado = default(float);
			foreach (Prestamo item in this.listaDePrestamos)
			{
				if(tipoDePrestamo is TipoDePrestamo.Pesos && item is PrestamoPesos)
					retornoInteresGanado += ((PrestamoPesos)(item)).Interes;

				if (tipoDePrestamo is TipoDePrestamo.Dolares && item is PrestamoDolar)
					retornoInteresGanado += ((PrestamoDolar)(item)).Interes;

				if (tipoDePrestamo is TipoDePrestamo.Todos)
				{
					if(item is PrestamoPesos)
						retornoInteresGanado += ((PrestamoPesos)(item)).Interes;
					if(item is PrestamoDolar)
						retornoInteresGanado += ((PrestamoDolar)(item)).Interes;

				}
			}
			return retornoInteresGanado;
		}
		#endregion

		#region Conversiones
		public static explicit operator string(Financiera financiera)
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendFormat("╔════════════════════════════════════════════════╗\n");
			sb.AppendFormat("║              Razón social: {0}       ║\n", financiera.RazonSocial);
			sb.AppendFormat("║         Intereses totales ganados: {0}     ║\n" , financiera.InteresesTotales);
			sb.AppendFormat("║       Intereses en pesos ganados: $ {0}       ║\n" , financiera.InteresesEnPesos);
			sb.AppendFormat("║     Intereses en dolares ganados: U$D {0}  ║\n" , financiera.InteresesEnDolares);
			sb.AppendFormat("╚════════════════════════════════════════════════╝\n");
			financiera.OrdenarPrestamos();
			foreach (Prestamo item in financiera.listaDePrestamos)
			{
				if(item is PrestamoPesos)
					sb.AppendLine(((PrestamoPesos)(item)).Mostrar());

				if(item is PrestamoDolar)
					sb.AppendLine(((PrestamoDolar)(item)).Mostrar());
			}

			return sb.ToString();
		}
		#endregion

		#region Operaciones
		public static Financiera operator +(Financiera financiera, Prestamo prestamo)
		{
			if (financiera != prestamo)
				financiera.listaDePrestamos.Add(prestamo);
			return financiera;
		}

		public static bool operator ==(Financiera financiera, Prestamo prestamo)
		{
			bool estaEnFinanciera = false;
			foreach (Prestamo item in financiera.listaDePrestamos)
			{
				if (item == prestamo)
				{
					//con esto evitemos que se cargue más de una vez un prestamo.
					estaEnFinanciera = true;
					break;
				}
			}
			return estaEnFinanciera;
		}

		public static bool operator !=(Financiera financiera, Prestamo prestamo)
		{
			return !(financiera == prestamo);
		}
		#endregion

		#region Override

		#endregion

	}
}
