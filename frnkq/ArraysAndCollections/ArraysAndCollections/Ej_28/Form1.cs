using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej_28
{
    public partial class Form1 : Form
    {
        Dictionary<string, int> dic = new Dictionary<string, int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            string[] words =  this.rtxtTextBox.Text.Split(' ');
            foreach(string word in words)
            {
                if (dic.ContainsKey(word))
                    dic[word] += 1;
                else
                    dic.Add(word, 0);

            }
            this.lblCantPalabras.Text = "Cantidad de palabras: "+dic.Count.ToString();
          
        }
    }
}
