using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temporizador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Temporizador t = new Temporizador(1000);
            t.eventoTiempo += T_eventoTiempo;
            System.Threading.Thread hilo = new System.Threading.Thread(t.Corriendo);
            hilo.Start();
        }

        private void T_eventoTiempo()
        {
            if (this.label1.InvokeRequired)
            {
                encargadoTiempo e = new encargadoTiempo(T_eventoTiempo);
                this.Invoke(e);
            }
            else
            {
                this.label1.Text = DateTime.Now.ToString();
            }
            throw new NotImplementedException();
        }
    }
}
