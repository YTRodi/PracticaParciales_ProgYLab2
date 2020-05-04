using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace WinDT
{
    public partial class FormDt : Form
    {
        private DirectorTecnico directorTecnico;

        public FormDt()
        {
            InitializeComponent();
        }

        public FormDt(DirectorTecnico dt) : this()
        {
            this.directorTecnico = dt;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            this.directorTecnico = new DirectorTecnico(txtNombre.Text,
                                                    txtApellido.Text,
                                                    (int)numUDEdad.Value,
                                                    (int)numUDDni.Value,
                                                    (int)numUDExpericencia.Value);

            MessageBox.Show("Se ha creado el DT",
                "Notificación",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if(this.directorTecnico is null)
            {
                MessageBox.Show("Aún no se ha creado el DT en el form",
                    "Notificación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else if(this.directorTecnico.ValidarAptitud())
            {
                MessageBox.Show("El DT es apto\n\n" + this.directorTecnico.Mostrar(),
                    "Notificación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {

                MessageBox.Show("El DT NO es apto",
                    "Notificación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
