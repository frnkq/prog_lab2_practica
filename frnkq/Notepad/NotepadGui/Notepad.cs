using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Notepad;
namespace NotepadGui
{
    public partial class Notepad : Form
    {
        global::Notepad.Notepad notepad;
        public Notepad()
        {
            InitializeComponent();
            notepad = new global::Notepad.Notepad();
            this.lblStatusBar.Text = this.rtxtTextBox.Text.Length + " caracteres";
        }

        private void miAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.AddExtension = true;
            openFileDialog.DefaultExt = "txt";
            openFileDialog.Multiselect = false;
            openFileDialog.RestoreDirectory = true;
            openFileDialog.ShowDialog();
            notepad.FilePath = openFileDialog.FileName;
            if(notepad.FilePath != null)
            {
                this.rtxtTextBox.Text = notepad.Leer();
                this.Text = openFileDialog.FileName;
            }
            
        }

        private void miGuardar_Click(object sender, EventArgs e)
        {
          
                notepad.Guardar(rtxtTextBox.Text);
            
        }

        private void miGuardarComo_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.ShowDialog();
            saveFileDialog.AddExtension = true;
            saveFileDialog.DefaultExt = "txt";
            notepad.FilePath = saveFileDialog.FileName;
            notepad.Guardar(rtxtTextBox.Text);
            this.Text = notepad.FilePath;
        }

        private void rtxtTextBox_TextChanged(object sender, EventArgs e)
        {
            this.lblStatusBar.Text = this.rtxtTextBox.Text.Length + " caracteres";
        }
    }
}
