using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace frmTestDelegados
{
    public delegate void ActualizarLabel(string message);
    public partial class FormDelegado : Form
    {
        public event ActualizarLabel eventoActualizar;
        public FormDelegado()
        {
            InitializeComponent();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string texto = this.eltexto.Text;
            eventoActualizar.Invoke(texto);
        }

        
    }
}
