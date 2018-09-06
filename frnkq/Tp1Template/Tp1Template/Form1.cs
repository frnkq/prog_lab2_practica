using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp1Template
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Numero1.AcceptsTab = false;
            this.Numero2.AcceptsTab = false;            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Numero1.Clear();
            this.Numero2.Clear();
        }
    }
}
