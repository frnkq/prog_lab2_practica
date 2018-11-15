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
namespace frmAltaAlumno
{
    public delegate void ActualizarFoto(string path);
    public delegate void MostrarPersona(Persona p);
    public partial class frmAltaAlumno : Form
    {
        
        private frmMostrarPersona frmMostrarPersona;

        private frmMostrarPersona FrmMostrarPersona
        {
            get
            {
                return this.frmMostrarPersona;
            }
            set
            {
                this.frmMostrarPersona = value;
            }
        }

        frmBuscarFoto frmBuscarFoto;
        public event MostrarPersona mostrarPersonaEvento;
        public frmAltaAlumno()
        {
            InitializeComponent();
            this.FrmMostrarPersona = new frmMostrarPersona();
            mostrarPersonaEvento += this.FrmMostrarPersona.ShowPerson;
            
        }

        private void txtRuta_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            frmBuscarFoto = new frmBuscarFoto(this);
            frmBuscarFoto.ShowDialog();
        }

        public void ActualizarFotoText(string path)
        {
                txtRuta.Text = path;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona(this.txtNombre.Text, 
                this.txtApellido.Text, int.Parse(this.txtDni.Text), this.txtRuta.Text);

            mostrarPersonaEvento.Invoke(persona);
        }

        private void mostrarPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.FrmMostrarPersona.Show();
        }
    }
}
