using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Interfaces;

namespace Entidades
{
    public class InfoHilos
    {
        #region Atributos
        private IRespuesta<int> callback;
        private Thread hilo;
        private int id;
        private static Random randomizer;
        #endregion

        #region Properties

        #endregion

        #region Constructores
        static InfoHilos()
        {
            InfoHilos.randomizer = new Random();
        }
        public InfoHilos(int id, IRespuesta<int> callback)
        {
            this.id = id;
            this.callback = callback;
            this.hilo = new Thread(new ThreadStart(this.Ejecutar));
            this.hilo.Start();
        }
        #endregion
            
        #region Métodos
        private void Ejecutar()
        {
            Thread.Sleep(InfoHilos.randomizer.Next(1000, 5000));

            this.callback.RespuestaHilo(this.id);
        }
        #endregion
    }
}
