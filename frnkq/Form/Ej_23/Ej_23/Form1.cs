using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sobrecarga_ej20;

namespace Ej_23
{
    public partial class ConversorMonedas : Form
    {
        public ConversorMonedas()
        {
            InitializeComponent();
        }


        private void btnConvertEuro_Click(object sender, EventArgs e)
        {
            double d;
            double.TryParse(this.txtEuroInput.Text, out d);

            Euro euro = new Euro(d);
            txtEurosInEuros.Text = euro.GetCantidad().ToString();

            Dolar dolar = (Dolar)euro;
            txtEurosInDolars.Text = dolar.GetCantidad().ToString();

            Peso peso = (Peso)euro;
            txtEurosInPesos.Text = peso.GetCantidad().ToString();
        }

        private void btnConvertDolar_Click(object sender, EventArgs e)
        {
            double d;
            double.TryParse(this.txtDolarInput.Text, out d);

            Dolar dolar = new Dolar(d);
            txtDolarsInDolars.Text = dolar.GetCantidad().ToString();

            Euro euro = (Euro)dolar;
            txtDolarsInEuros.Text = euro.GetCantidad().ToString();

            Peso peso = (Peso)dolar;
            txtDolarsInPesos.Text = peso.GetCantidad().ToString();
        }

        private void btnConvertPeso_Click(object sender, EventArgs e)
        {
            double d;
            double.TryParse(this.txtPesoInput.Text, out d);

            Peso peso = new Peso(d);
            txtPesosInPesos.Text = peso.GetCantidad().ToString();

            Euro euro = (Euro)peso;
            txtPesosInEuros.Text = euro.GetCantidad().ToString();

            Dolar dolar = (Dolar)peso;
            txtPesosInDolars.Text = dolar.GetCantidad().ToString();
        }
    }
}
