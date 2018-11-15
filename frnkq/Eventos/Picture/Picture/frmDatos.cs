using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture
{
    public delegate void Delegado(string text);
    public partial class frmDatos : Form
    {
        frmDelegados thisForm = new frmDelegados();

        public frmDatos()
        {
            InitializeComponent();
            thisForm.evento += ActualizarFoto;
        }

        public void ActualizarFoto(string path)
        {
            this.pictureBox.ImageLocation = path;
        }

        public void ActualizarNombre(string path)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            thisForm.ShowDialog();
        }
    }
}
