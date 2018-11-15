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
    public partial class frmMostrarPersona : Form
    {
        public frmMostrarPersona()
        {
            InitializeComponent();
        }

        public void ShowPerson(Entidades.Persona p)
        {
            this.lblNombre.Text = p.Nombre;
            this.lblApellido.Text = p.Apellido;
            this.lblDni.Text = p.Dni.ToString();
            this.pictureBox.ImageLocation = p.FotoAlumno;
            this.pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
