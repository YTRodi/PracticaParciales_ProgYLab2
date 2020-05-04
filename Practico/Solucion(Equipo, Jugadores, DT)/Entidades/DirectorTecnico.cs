using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico : Persona
    {

		#region Atributos
		private int añosExperiencia;
		#endregion

		#region Properties

		public int AñosExperiencia
		{
			get
			{
				return this.añosExperiencia;
			}
			set
			{
				this.añosExperiencia = value;
			}
		}

		#endregion

		#region Constructores
		public DirectorTecnico(string nombre, string apellido, int edad, int dni, int añosExperiencia):base(nombre,apellido,edad,dni)
		{
			this.AñosExperiencia = añosExperiencia;
		}
		#endregion

		#region Métodos
		public override string Mostrar()
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine(base.Mostrar());
			sb.AppendLine("Años de experiencia: " + this.AñosExperiencia);

			return sb.ToString();
		}

		public override bool ValidarAptitud()
		{
			bool apto = false;
			if(this.Edad < 65 && this.AñosExperiencia >= 2)
			{
				apto = true;
			}
			return apto;
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
