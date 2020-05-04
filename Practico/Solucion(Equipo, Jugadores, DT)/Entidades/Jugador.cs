using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador : Persona
	{
		#region Atributos
		private float altura;
		private float peso;
		private Posicion posicion;
		#endregion

		#region Properties

		public float Altura
		{
			get
			{
				return this.altura;
			}
		}
		public float Peso
		{
			get
			{
				return this.peso;
			}
		}
		public Posicion Posicion
		{
			get
			{
				return this.posicion;
			}
		}

		#endregion

		#region Constructores
		public Jugador(string nombre, string apellido, int edad, int dni, float peso, float altura, Posicion posicion) : base(nombre, apellido, edad, dni)
		{
			this.peso = peso;
			this.altura = altura;
			this.posicion = posicion;
		}
		#endregion

		#region Métodos
		public override string Mostrar()
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine(base.Mostrar());
			sb.AppendLine("Altura: " + this.Altura);
			sb.AppendLine("Peso: " + this.Peso);
			sb.AppendLine("Posicion: " + this.Posicion);			

			return sb.ToString();

		}

		public bool ValidarEstadoFisico()
		{
			bool valida = false;

			//IMC = peso / altura^2
			double alturaAlCuadrado = Math.Pow(altura, 2);
			double imc = this.Peso / alturaAlCuadrado;

			if (imc >= 18.5f && imc <= 25.0f)
			{
				valida = true;
			}
			return valida;
		}

		public override bool ValidarAptitud()
		{
			bool apto = false;
			if(this.Edad < 40)
			{
				if(ValidarEstadoFisico())
				{
					apto = true;
				}
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
