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

namespace ConversorBinario
{
    public partial class ConversorNumerico : Form
    {
        public ConversorNumerico()
        {
            InitializeComponent();
        }

        private void ConversorNumerico_Load(object sender, EventArgs e)
        {
            this.txtResultadoBinario.Enabled = false;
            this.txtResultadoDecimal.Enabled = false;
        }

        private void btnBinToDec_Click(object sender, EventArgs e)
        {
            Numero bin = new Numero();
            txtResultadoDecimal.Text = bin.BinarioDecimal(txtBinario.Text);

        }

        private void btnDecToBin_Click(object sender, EventArgs e)
        {
            Numero dec = new Numero();
            txtResultadoBinario.Text = dec.DecimalBinario(txtDecimal.Text);
        }
    }
}
