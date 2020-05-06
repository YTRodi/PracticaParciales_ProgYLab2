using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
	{
		#region Atributos
		private string nombre;
		private string apellido;
		#endregion

		#region Properties

		public string Nombre
		{
			get
			{
				return this.nombre;
			}
		}

		public string Apellido
		{
			get
			{
				return this.apellido;
			}
		}

		#endregion

		#region Constructores
		public Persona(string nombre,string apellido)
		{
			this.nombre = nombre;
			this.apellido = apellido;
		}
		#endregion

		#region Métodos
		protected abstract string FichaTecnica();

		public virtual string NombreCompleto()
		{
			return string.Format("{0} {1}", this.Nombre, this.Apellido);
		}
		#endregion
	}
}
