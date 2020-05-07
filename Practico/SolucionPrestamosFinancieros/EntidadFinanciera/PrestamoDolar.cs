using PrestamosPersonales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public class PrestamoDolar : Prestamo
	{
		#region Atributos
		private PeriodicidadDePago periodicidad;
		#endregion

		#region Properties
		public float Interes
		{
			get
			{
				return CalcularInteres();
			}
		}
		public PeriodicidadDePago Periodicidad
		{
			get
			{
				return this.periodicidad;
			}
		}
		#endregion

		#region Constructores
		public PrestamoDolar(float monto, DateTime vencimiento, PeriodicidadDePago periodicidad)
			: base(monto, vencimiento)
		{
			this.periodicidad = periodicidad;
		}
		public PrestamoDolar(Prestamo prestamo, PeriodicidadDePago periodicidad)
			: this(prestamo.Monto, prestamo.Vencimiento, periodicidad)
		{
		}
		#endregion

		#region Métodos
		private float CalcularInteres()
		{
			float porcentajeInteres = default(float);
			switch (this.periodicidad)
			{
				case PeriodicidadDePago.Mensual:
					porcentajeInteres = this.monto * 0.25f;
					break;
				case PeriodicidadDePago.Bimestral:
					porcentajeInteres = this.monto * 0.35f;
					break;
				case PeriodicidadDePago.Trimestral:
					porcentajeInteres = this.monto * 0.40f;
					break;
				default:
					break;
			}
			return porcentajeInteres;
		}

		public override void ExtenderPlazo(DateTime nuevoVencimiento)
		{
			//TimeSpan representa un intervalo de tiempo.
			TimeSpan diferenciaDeFecha = nuevoVencimiento - this.Vencimiento;
			if (diferenciaDeFecha.Days > 0)
			{
				this.monto += 2.5f * diferenciaDeFecha.Days;
				this.vencimiento = nuevoVencimiento;
			}
		}

		public override string Mostrar()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("Tipo de prestamo: " + this.GetType());
			sb.AppendFormat(base.Mostrar());
			sb.AppendFormat($"Interés: {this.Periodicidad}");
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
