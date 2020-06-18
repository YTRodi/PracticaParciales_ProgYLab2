using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Automovil : Vehiculo
    {
		#region Atributos
		private ConsoleColor color;
		private static int valorHora;
		#endregion

		#region Constructores
		static Automovil()
		{
			Automovil.valorHora = 50;
		}
		public Automovil(string patente, ConsoleColor color) : base(patente)
		{
			this.color = color;
		}
		public Automovil(string patente, ConsoleColor color, int valorHora) : this(patente,color)
		{
			Automovil.valorHora = valorHora;
		}
		#endregion

		#region Métodos
		public override string ImprimirTicket()
		{
			StringBuilder sb = new StringBuilder();
			TimeSpan intervaloTiempo = DateTime.Now.Subtract(this.ingreso); //DateTime.Now.Hour - this.ingreso.Hour;
			int costoEstadia = (int)Math.Round(intervaloTiempo.TotalHours) * Automovil.valorHora;

			sb.AppendLine(base.ImprimirTicket());
			sb.AppendLine("Color: " + this.color);
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
			return (obj is Automovil);
		}
		#endregion

	}
}
