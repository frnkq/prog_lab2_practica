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
using Archivos;
using System.Threading;
using Patentes;
namespace _20181122_SP
{
   
    public partial class FrmPpal : Form
    {
        
        Queue<Patente> cola;
        List<Thread> hilos;
        public event MostrarPatente VistaPatente;

        public FrmPpal()
        {
            InitializeComponent();

            this.cola = new Queue<Patente>();
            this.hilos = new List<Thread>();
        }

        private void FrmPpal_Load(object sender, EventArgs e)
        {
            vistaPatente1.finExposicion += ProximaPatente;
            vistaPatente2.finExposicion += ProximaPatente;
            VistaPatente += this.vistaPatente1.MostrarPatente;
            VistaPatente += this.vistaPatente2.MostrarPatente;
        }

        private void FrmPpal_FormClosing(object sender, FormClosingEventArgs e)
        {
            FinalizarSimulacion();
        }

        private void btnXml_Click(object sender, EventArgs e)
        {
            Patente[] patentes = new Patente[10];
            Archivos.Xml<Patente[]> xml = new Xml<Patente[]>();
            try
            {
                xml.Leer("patentes.xml", out patentes);

            }
            catch(Exception exception)
            {

            }
            foreach (Patente p in patentes)
            {
                VistaPatente.Invoke(p);
                cola.Enqueue(p.ValidarPatente(p.CodigoPatente));
            }
            IniciarSimulacion();
        }

        private void btnTxt_Click(object sender, EventArgs e)
        {
            Archivos.Texto texto = new Archivos.Texto();
            string datos;
            texto.Leer("patentes.txt", out datos);

            string[] patentes = datos.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            foreach(string patente in patentes)
            {
                try
                {
                    Patente p = new Patente();
                    p = p.ValidarPatente(patente);
                    VistaPatente.Invoke(p);
                    cola.Enqueue(p.ValidarPatente(p.CodigoPatente));
                }
                catch (Exception ex)
                {

                }
                IniciarSimulacion();
            }
        }

        private void btnSql_Click(object sender, EventArgs e)
        {
            try
            {
                Queue<Patente> patentes = new Queue<Patente>();
                Archivos.Sql sql = new Archivos.Sql();
                sql.Leer("Patentes", out patentes);
                foreach(Patente p in patentes)
                {

                        VistaPatente.Invoke(p);
                        cola.Enqueue(p.ValidarPatente(p.CodigoPatente));
                }

            }
            catch (Exception ex)
            {

            }
            IniciarSimulacion();
        }

        private void IniciarSimulacion()
        {
            foreach (Thread t in this.hilos)
            {
                if (t.IsAlive)
                    t.Abort();
            }

            //Llamará al método ProximaPatente para cada uno de los objetos del tipo VistaPatente del
            ProximaPatente(this.vistaPatente1);
            ProximaPatente(this.vistaPatente2);
        }

        private void ProximaPatente(VistaPatente vp)
        {
            if(cola.Count > 0)
            {
                Thread hilo = new Thread(new ParameterizedThreadStart(vp.MostrarPatente));
                hilo.Start(cola.Dequeue());
                this.hilos.Add(hilo);
            }
        }

        private void FinalizarSimulacion()
        {
            foreach(Thread hilo in hilos)
            {
                if (hilo.IsAlive)
                    hilo.Abort();
            }  
        }
    }
}
