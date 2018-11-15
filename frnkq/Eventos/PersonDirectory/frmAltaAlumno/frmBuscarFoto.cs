using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmAltaAlumno
{
    public partial class frmBuscarFoto : Form
    {
        public event ActualizarFoto pathUpdate;
        public frmBuscarFoto(Form formPrincipal)
        {
            InitializeComponent();
            pathUpdate += ((frmAltaAlumno)formPrincipal).ActualizarFotoText;
        }

        private void btnBuscarFoto_Click(object sender, EventArgs e)
        {
            this.openFileDialog.ShowDialog();
            pathUpdate.Invoke(this.openFileDialog.FileName);
            this.Close();
        }
    }
}
