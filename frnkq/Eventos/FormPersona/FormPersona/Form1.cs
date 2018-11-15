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
namespace FormPersona
{
    public partial class Form1 : Form
    {
        private event DelegadoString miEvento;
        private Persona persona;
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            miEvento += NotificarCambio;
        }

        public void NotificarCambio(string mensaje)
        {
            if (this.InvokeRequired)
            {
                DelegadoString del = new DelegadoString(NotificarCambio);
                del.Invoke(mensaje);
            }
            else
            {
                MessageBox.Show(mensaje+"\n"+this.persona.Mostrar());
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string nombre = this.txtNombre.Text;
            string apellido = this.txtApellido.Text;
            if(this.persona == null)
            {
                this.persona = new Persona(nombre, apellido);
                this.btnCrear.Text = "Actualizar";
                this.miEvento.Invoke("La persona se ha creado");
            }
            else
            {
                this.btnCrear.Text = "Actualizar";
                this.persona.Nombre = nombre;
                this.persona.Apellido = apellido;
                this.miEvento.Invoke("La persona se ha actualizado");
            }
        }
    }
}
