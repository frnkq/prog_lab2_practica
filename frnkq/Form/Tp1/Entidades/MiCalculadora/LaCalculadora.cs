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

namespace MiCalculadora
{
    public partial class LaCalculadora : Form
    {
        public LaCalculadora()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        
        /// <summary>
        /// Clears the values of: lblResultado, txtNumero1, txtNumero2, cmbOperador
        /// </summary>
        private void Limpiar()
        {
            this.txtNumero1.Clear();
            this.txtNumero2.Clear();
            this.cmbOperador.Text = String.Empty;
            this.lblResultado.Text = String.Empty;

        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = LaCalculadora.Operar(this.txtNumero1.Text, 
                this.txtNumero2.Text, this.cmbOperador.Text).ToString();
        }

        private static double Operar(string numero1, string numero2, string operador)
        {
            Entidades.Calculadora calculator = new Entidades.Calculadora();
            Entidades.Numero n1 = new Numero(numero1);
            Entidades.Numero n2 = new Numero(numero2);
            return calculator.Operar(n1, n2, operador);
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Entidades.Numero numeroAConvertir = new Entidades.Numero();
            this.lblResultado.Text = numeroAConvertir.DecimalBinario(this.lblResultado.Text);
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Entidades.Numero numeroAConvertir = new Entidades.Numero();
            this.lblResultado.Text = numeroAConvertir.BinarioDecimal(this.lblResultado.Text);
        }
    }
}
