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
using EditPersonGUI;
namespace PersonDirectoryGUI
{
    public partial class PersonDirectory : Form
    {
        public PersonDirectory()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DbConnection.ConnectDB();

            foreach(Persona p in PersonDao.loadPersons())
            {
               this.listPersons.Items.Add(p);
            }
        }



        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DbConnection.DisconnectDB();
        }

        private void listPersons_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Persona person = ((Persona)this.listPersons.SelectedItem);
            EditPerson editPerson = new EditPerson(person);
            if (editPerson.ShowDialog() == DialogResult.OK)
            {
                this.listPersons.Items.Clear();
                foreach (Persona p in PersonDao.loadPersons())
                {
                    this.listPersons.Items.Add(p);
                }
            }          
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.listPersons.Items.Clear();
            foreach (Persona p in PersonDao.SearchPersons(this.txtSearchBox.Text))
            {
                this.listPersons.Items.Add(p);
            }
        }
    }
}
