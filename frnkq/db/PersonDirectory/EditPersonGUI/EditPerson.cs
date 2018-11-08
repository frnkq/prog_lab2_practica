using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonDirectory;
namespace EditPersonGUI
{
    public partial class EditPerson : Form
    {
        Persona persona;
        public EditPerson(Persona persona)
        {
            InitializeComponent();
            this.persona = persona;
        }

        private void EditPerson_Load(object sender, EventArgs e)
        {
            this.txtID.Enabled = false;
            this.txtID.Text = persona.ID;

            this.txtFirstName.Text = persona.FirstName;
            this.txtMiddleName.Text = persona.MiddleName;
            this.txtLastName.Text = persona.LastName;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.ID = this.txtID.Text;
            persona.FirstName = this.txtFirstName.Text;
            persona.MiddleName = this.txtMiddleName.Text;
            persona.LastName = this.txtLastName.Text;

            if (PersonDao.updatePersona(persona))
            {
                this.Close();
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Error!!! :(");
            }
        }
    }
}
