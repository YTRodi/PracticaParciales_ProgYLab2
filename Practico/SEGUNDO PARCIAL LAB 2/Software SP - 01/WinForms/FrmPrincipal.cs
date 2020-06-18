using Entidades;
using Excepciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class FrmPrincipal : Form
    {
        private LosHilos hilos;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.hilos = new LosHilos();

            //Asigno manejador de evento
            this.hilos.EventoAvisarFin += this.MostrarMensajeFin;
        }

        private void btnLanzar_Click(object sender, EventArgs e)
        {
            try
            {
                this.hilos += 1;

                MessageBox.Show("Lanzado!",
                    "Notificación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            }
            catch (CantidadInvalidaException ex)
            {
                MessageBox.Show(ex.Message,
                    "Notificación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnBitacora_Click(object sender, EventArgs e)
        {
            this.MostrarMensajeFin(this.hilos.Bitacora);
        }

        #region Métodos
        /// <summary>
        /// Manejador del eventoAvisoFin.
        /// </summary>
        private void MostrarMensajeFin(string msg) //Misma firma del evento
        {
            MessageBox.Show(msg,
                "Notificación",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        #endregion

        
    }
}
