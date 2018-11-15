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
    public partial class frmDelegados : Form
    {
        private string path;
        public event Delegado evento;
        public frmDelegados()
        {
            InitializeComponent();
            this.openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
        }

        private void buttonBuscarFoto_Click(object sender, EventArgs e)
        {
            this.openFileDialog.ShowDialog();
            path = openFileDialog.FileName;
            evento.Invoke(path);
        }
    }
}
