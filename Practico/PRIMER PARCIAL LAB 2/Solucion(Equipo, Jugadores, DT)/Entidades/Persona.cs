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
        //ATRIBUTOS EN PROTECTED ASI PUEDEN USARLOS LAS CLASES DERIVADAS.
        protected string apellido;
        protected int dni;
        protected int edad;
        protected string nombre;
        #endregion

        #region Properties

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
        }

        public int Dni
        {
            get
            {
                return this.dni;
            }
        }

        public int Edad
        {
            get
            {
                return this.edad;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        #endregion

        #region Constructores
        public Persona(string nombre, string apellido, int edad, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.dni = dni;
        }
        #endregion

        #region Métodos
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Nombre: " + this.Nombre);
            sb.AppendLine("Apellido: " + this.Apellido);
            sb.AppendLine("Edad: " + this.Edad);
            sb.AppendLine("Dni: " + this.Dni);

            return sb.ToString();
        }

        public abstract bool ValidarAptitud();
        #endregion
    }
}
