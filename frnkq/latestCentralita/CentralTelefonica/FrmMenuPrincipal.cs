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
    public partial class FrmMenuPrincipal : Form
    {
        Centralita centralita;
        public FrmMenuPrincipal()
        {
            InitializeComponent();
            this.centralita = new Centralita("Fede Center");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnGenerarLlamada_Click(object sender, EventArgs e)
        {
            Llamador llamador = new Llamador(this.centralita);
            llamador.ShowDialog();

            this.centralita = llamador.LaCentralita;            
        }

        private void btnFacturacionTotal_Click(object sender, EventArgs e)
        {
            FrmMostrar mostrar = new FrmMostrar(this.centralita, Llamada.TipoLlamada.Todas);
            mostrar.ShowDialog();
        }

        private void btnFacturacionLocal_Click(object sender, EventArgs e)
        {
            FrmMostrar mostrar = new FrmMostrar(this.centralita, Llamada.TipoLlamada.Local);
            mostrar.ShowDialog();
        }

        private void btnFacturacionProvincial_Click(object sender, EventArgs e)
        {
            FrmMostrar mostrar = new FrmMostrar(this.centralita, Llamada.TipoLlamada.Provincial);
            mostrar.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.centralita.Leer());
            this.Close();
            
        }
    }
}
