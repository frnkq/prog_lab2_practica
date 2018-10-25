using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaHerencia;

namespace CentralTelefonica
{
    public partial class Llamador : Form
    {
        Centralita centralita;
        public Centralita LaCentralita
        {
            get
            {
                return this.centralita;
            }
        }
        public Llamador(Centralita centralita)
        {
            InitializeComponent();
            this.centralita = centralita;
            cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
            this.txtNumeroDestino.ReadOnly = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNumeroDestino.Clear();
            this.txtNumeroOrigen.Clear();
            this.cmbFranja.Enabled = true;
        }

        private void btnDial1_Click(object sender, EventArgs e)
        {
                this.txtNumeroDestino.AppendText("1");
        }

        private void btnDial2_Click(object sender, EventArgs e)
        {
            this.txtNumeroDestino.AppendText("2");
        }

        private void btnDial3_Click(object sender, EventArgs e)
        {
            this.txtNumeroDestino.AppendText("3");
        }

        private void btnDial4_Click(object sender, EventArgs e)
        {
            this.txtNumeroDestino.AppendText("4");
        }

        private void btnDial5_Click(object sender, EventArgs e)
        {
            this.txtNumeroDestino.AppendText("5");
        }

        private void btnDial6_Click(object sender, EventArgs e)
        {
            this.txtNumeroDestino.AppendText("6");
        }

        private void btnDial7_Click(object sender, EventArgs e)
        {
            this.txtNumeroDestino.AppendText("7");
        }

        private void btnDial8_Click(object sender, EventArgs e)
        {
            this.txtNumeroDestino.AppendText("8");
        }

        private void btnDial9_Click(object sender, EventArgs e)
        {
            this.txtNumeroDestino.AppendText("9");
        }

        private void btnDial0_Click(object sender, EventArgs e)
        {
            this.txtNumeroDestino.AppendText("0");
        }

        private void btnDialAsterisc_Click(object sender, EventArgs e)
        {
            this.txtNumeroDestino.AppendText("*");
        }

        private void btnDialPound_Click(object sender, EventArgs e)
        {
            this.txtNumeroDestino.AppendText("#");
        }

        private void txtNumeroDestino_TextChanged(object sender, EventArgs e)
        {
            if (!this.txtNumeroDestino.Text.StartsWith("#"))
                this.cmbFranja.Enabled = false;
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {

            Random random = new Random();
            float randDuracion = random.Next(1 , 50);
            float randCosto = (float)(random.NextDouble() * (5.6 - 0.5) + 0.5);
            string nroDestino = this.txtNumeroDestino.Text;
            string nroOrigen = this.txtNumeroOrigen.Text;

            Provincial.Franja franja;
            Enum.TryParse<Provincial.Franja>(cmbFranja.SelectedValue.ToString(), out franja);
            
            if (nroDestino.StartsWith("#"))
            {
                Provincial llamada = new Provincial(nroOrigen, franja, randDuracion, nroDestino);
                this.centralita += llamada;
            }
            else
            {
                Local llamada = new Local(nroOrigen, randDuracion, nroDestino, randCosto);
                try
                {
                    this.centralita += llamada;
                }
                catch(CentralitaException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch(FallaLogException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }

            this.txtNumeroDestino.Clear();
        }
    }
}
