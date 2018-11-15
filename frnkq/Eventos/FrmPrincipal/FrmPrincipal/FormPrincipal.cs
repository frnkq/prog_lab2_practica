using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using frmTestDelegados;
using formMostrar;
namespace FrmPrincipal
{

    public partial class Form1 : Form
    {
        frmTestDelegados.FormDelegado frmDelegados = new frmTestDelegados.FormDelegado();
        formMostrar.FormMostrar frmMostrar = new formMostrar.FormMostrar();
        public Form1()
        {
            InitializeComponent();
        }

        private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            frmDelegados.MdiParent = this;
            frmDelegados.Show();
            
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDelegados.eventoActualizar += frmMostrar.FormMostrar_eventoActualizador;
            frmMostrar.MdiParent = this;
            frmMostrar.Show();
        }
    }
}
