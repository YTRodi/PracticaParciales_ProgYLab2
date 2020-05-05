using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PickUp : Vehiculo
	{
		#region Atributos
		private string modelo;
		private static int valorHora;
		#endregion

		#region Constructores
		static PickUp()
		{
			PickUp.valorHora = 70;
		}
		public PickUp(string patente, string modelo) : base(patente)
		{
			this.modelo = modelo;
			PickUp.valorHora = 70;
			//PickUp.valorHora = 70;
		}
		public PickUp(string patente, string modelo, int valorHora) : this(patente, modelo)
		{
			PickUp.valorHora = valorHora;
		}
		#endregion

		#region Métodos
		public override string ImprimirTicket()
		{
			StringBuilder sb = new StringBuilder();
			TimeSpan intervaloTiempo = DateTime.Now.Subtract(this.ingreso); //DateTime.Now.Hour - this.ingreso.Hour;
			int costoEstadia = (int)Math.Round(intervaloTiempo.TotalHours) * PickUp.valorHora;

			sb.AppendLine(base.ImprimirTicket());
			sb.AppendLine("Modelo: " + this.modelo);
			sb.AppendLine("Costo de la estadía: $" + costoEstadia);
			sb.AppendLine("<<------------------------->>");

			return sb.ToString();
		}
		#endregion

		#region Override
		public override string ConsultarDatos()
		{
			return this.ImprimirTicket();
		}

		public override bool Equals(object obj)
		{
			return (obj is PickUp);
		}
		#endregion


	}
}
