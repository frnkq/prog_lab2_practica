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
namespace formMostrar
{
    public partial class FormMostrar : Form
    {
        public FormMostrar()
        {
            InitializeComponent();
           
       }

        public void FormMostrar_eventoActualizador(string message)
        {
            this.lblMostrar.Text = message;
        }
    }
}
