using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public class PrestamoPesos : Prestamo
	{
		#region Atributos
		private float porcentajeInteres;
		#endregion

		#region Properties

		public float Interes
		{
			get
			{
				return CalcularInteres();
			}
		}

		#endregion

		#region Constructores
		public PrestamoPesos(float monto, DateTime vencimiento, float interes) : base(monto, vencimiento)
		{
			this.porcentajeInteres = interes;
		}
		public PrestamoPesos(Prestamo prestamo, float porcentajeInteres) 
			: this(prestamo.Monto, prestamo.Vencimiento, porcentajeInteres)
		{

		}
		#endregion

		#region Métodos
		private float CalcularInteres()
		{
			return this.monto * this.porcentajeInteres / 100;
		}

		public override void ExtenderPlazo(DateTime nuevoVencimiento)
		{
			//TimeSpan representa un intervalo de tiempo.
			TimeSpan diferenciaDeFecha = nuevoVencimiento - this.Vencimiento;
			if(diferenciaDeFecha.Days > 0)
			{
				//aumento un 0.25% de interés por cada día extendido el plazo
				this.porcentajeInteres += 0.25f * diferenciaDeFecha.Days;
				this.vencimiento = nuevoVencimiento;
			}
		}

		public override string Mostrar()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("Tipo de prestamo: " + this.GetType());
			sb.AppendFormat(base.Mostrar());
			sb.AppendFormat($"Interés: ${this.Interes}");
			sb.AppendFormat("\n<<------------------------------>>");
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
