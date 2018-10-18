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
    public partial class FrmMostrar : Form
    {
        Centralita centralita;
        private Llamada.TipoLlamada tipoLlamada;
        private Llamada.TipoLlamada TipoLlamada
        {
            set
            {
                this.tipoLlamada = value;
            }
        }
        private Centralita LaCentralita
        {
            get
            {
                return this.centralita;
            }
        }
        public FrmMostrar(Centralita centralita, Llamada.TipoLlamada tipoLlamada)
        {
            InitializeComponent();
            this.centralita = centralita;
            this.tipoLlamada = tipoLlamada;
        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("            //TODO: show only locales / provinciales / todas per button &&&&&&&&&&&&&&&&&&&&&&&&&&&&&");
            foreach (Llamada ll in LaCentralita.Llamadas)
            {
                switch (this.tipoLlamada)
                {
                    case Llamada.TipoLlamada.Local:
                        Local loc = (Local)ll;
                        sb.AppendLine((loc.ToString()));
                        break;

                    case Llamada.TipoLlamada.Provincial:

                        break;

                    case Llamada.TipoLlamada.Todas:

                        break;
                }

                switch (this.tipoLlamada)
                {
                    case Llamada.TipoLlamada.Local:
                        sb.AppendLine(String.Format("Ganancias por llamadas locales {0}",
                            LaCentralita.GananciasPorLocal));
                        break;

                    case Llamada.TipoLlamada.Provincial:
                        sb.AppendLine(String.Format("Ganancias por llamadas provinciales {0}",
                           LaCentralita.GananciasPorProvincial));
                        break;

                    case Llamada.TipoLlamada.Todas:
                        sb.AppendLine(String.Format("Ganancias por llamadas totales {0}",
                           LaCentralita.GananciasPorTotal));
                        break;
                }
                sb.AppendLine(LaCentralita.ToString());

                this.rtxtDatos.Text = sb.ToString();
            }
        }
    }
}
