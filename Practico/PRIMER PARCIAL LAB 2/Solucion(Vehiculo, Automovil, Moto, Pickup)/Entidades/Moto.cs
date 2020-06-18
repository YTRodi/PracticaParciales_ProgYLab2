using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : Vehiculo
	{
		#region Atributos
		private int cilindrada;
		private short ruedas;
		private static int valorHora;
		#endregion

		#region Constructores
		static Moto()
		{
			Moto.valorHora = 30;
		}
		public Moto(string patente, int cilindrada) : base(patente)
		{
			this.cilindrada = cilindrada;
			this.ruedas = 2;
			Moto.valorHora = 30;
		}
		public Moto(string patente, int cilindrada, short ruedas) : this(patente, cilindrada)
		{
			if(ruedas > 2)
			{
				this.ruedas = 2;
			}
			//ruedas = 2;
			//this.ruedas = ruedas;
			//this.ruedas = 2;
		}
		public Moto(string patente, int cilindrada, short ruedas, int valorHora) : this(patente, cilindrada, ruedas)
		{
			Moto.valorHora = valorHora;
		}
		#endregion

		#region Métodos
		public override string ImprimirTicket()
		{
			StringBuilder sb = new StringBuilder();

			TimeSpan intervaloTiempo = DateTime.Now.Subtract(this.ingreso); //DateTime.Now.Hour - this.ingreso.Hour;
			//int costoEstadia = this.ingreso.Hour * Moto.valorHora;
			int costoEstadia = (int)Math.Round(intervaloTiempo.TotalHours) * Moto.valorHora;

			sb.AppendLine(base.ImprimirTicket());
			sb.AppendLine("Tipo de vehiculo: " + this.GetType());
			sb.AppendLine("Cilindrada: " + this.cilindrada);
			sb.AppendLine("Ruedas: " + this.ruedas);
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
			return (obj is Moto);
		}
		#endregion


	}
}
