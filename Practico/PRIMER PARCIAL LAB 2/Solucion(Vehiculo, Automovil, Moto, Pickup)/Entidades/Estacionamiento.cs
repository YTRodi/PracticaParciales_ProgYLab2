using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estacionamiento
	{
		#region Atributos
		private int espacioDisponible;
		private string nombreEstacionamiento;
		private List<Vehiculo> listaVehiculos;
		#endregion

		#region Properties

		#endregion

		#region Constructores
		private Estacionamiento()
		{
			this.listaVehiculos = new List<Vehiculo>();
		}
		public Estacionamiento(string nombre, int espacioDisponible) : this()
		{
			this.nombreEstacionamiento = nombre;
			this.espacioDisponible = espacioDisponible;
		}
		#endregion

		#region Métodos

		#endregion

		#region Conversiones

		public static explicit operator string(Estacionamiento est)
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine("Nombre Estacionamiento: " + est.nombreEstacionamiento);
			sb.AppendLine("Espacio disponible: " + est.espacioDisponible);
			sb.AppendLine("Datos de los vehiculos: \n");
			foreach (Vehiculo item in est.listaVehiculos)
			{
				sb.AppendLine(item.ConsultarDatos());
			}

			return sb.ToString();
		}

		#endregion

		#region Operaciones
		public static bool operator ==(Estacionamiento est, Vehiculo vehi)
		{
			bool adentroDeLista = false;
			foreach (Vehiculo item in est.listaVehiculos)
			{
				if(item == vehi)
				{
					adentroDeLista = true;
					break;
				}
			}
			//if (est.listaVehiculos.Contains(vehi))
			//{
			//	adentroDeLista = true;
			//}
			return adentroDeLista;
		}

		public static bool operator !=(Estacionamiento est, Vehiculo vehi)
		{
			return !(est == vehi);
		}


		public static Estacionamiento operator +(Estacionamiento est, Vehiculo vehi)
		{
			if (est != vehi)
			{
				if (!(vehi.Patente is null))
				{
					if (est.espacioDisponible > est.listaVehiculos.Count)
					{
						est.listaVehiculos.Add(vehi);
					}
				}
			}
			return est;
		}

		public static string operator -(Estacionamiento est, Vehiculo vehi)
		{
			if(est == vehi)
			{
				est.listaVehiculos.Remove(vehi);
				return vehi.ImprimirTicket();
			}
			else
			{
				return "El vehículo no es parte del estacionamiento. \n";
			}
		}
		#endregion

		#region Override

		#endregion


	}
}
