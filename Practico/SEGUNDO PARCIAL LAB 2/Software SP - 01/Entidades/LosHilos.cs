using Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Entidades
{
    public class LosHilos : IRespuesta<int>
    {
        #region Atributos
        private int id;
        private List<InfoHilos> misHilos;
        private string pathBitacora = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\bitacora.txt";
        #endregion

        #region Properties
        public string Bitacora
        {
            get
            {
                string contenido = string.Empty;
                using (StreamReader sr = new StreamReader(this.pathBitacora))
                {
                    contenido = sr.ReadToEnd();
                }
                return contenido;
            }

            set
            {
                using (StreamWriter sw = new StreamWriter(this.pathBitacora,true))
                {
                    sw.WriteLine(value);
                }
            }
        }
        #endregion

        #region Constructores
        public LosHilos()
        {
            this.id = 0;
            this.misHilos = new List<InfoHilos>();
        }
        #endregion

        #region Métodos
        public static LosHilos AgregarHilos(LosHilos hilos)
        {
            hilos.id++;

            InfoHilos infoH = new InfoHilos(hilos.id, hilos);//Me deja poner hilos pq implementa la interfaz IRespuesta

            hilos.misHilos.Add(infoH);

            return hilos;
        }


        #endregion

        #region Delegados y Eventos para avisar.
        public delegate void AvisoFin(string msg);
        public event AvisoFin EventoAvisarFin;
        #endregion

        #region Implementación interfaz IRespuesta
        public void RespuestaHilo(int id)
        {
            string msg = $"Termino el hilo {id}";

            this.Bitacora = msg;

            this.EventoAvisarFin(msg);//Ejecuto el evento.
        }
        #endregion

        #region Operaciones

        public static LosHilos operator +(LosHilos hilos, int cantidad)
        {
            if (cantidad < 1)
            {
                throw new CantidadInvalidaException();
            }
            else if (cantidad > 0)
            {
                for (int i = 0; i < cantidad; i++)
                {
                    hilos = LosHilos.AgregarHilos(hilos);
                }
            }

            return hilos;
        }
        #endregion
    }
}
