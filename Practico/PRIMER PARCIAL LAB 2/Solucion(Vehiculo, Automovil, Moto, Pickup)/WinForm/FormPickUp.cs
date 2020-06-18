using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class FormPickUp : Form
    {
        public FormPickUp()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            PickUp nuevaPickUp = new PickUp(txtPatente.Text, txtModelo.Text);
            MessageBox.Show(nuevaPickUp.ConsultarDatos());
        }
    }
}
