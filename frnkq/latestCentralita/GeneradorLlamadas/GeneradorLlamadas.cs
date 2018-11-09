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
namespace GeneradorLlamadas
{
    public partial class GeneradorLlamadas : Form
    {
        private Centralita centralita;
        private bool seguirGenerando = false;
        public Centralita Centralita
        {
            get
            {
                return this.centralita;
            }
        }
        public GeneradorLlamadas()
        {
            InitializeComponent();
        }

        public GeneradorLlamadas(Centralita centralita) : this()
        {
            this.centralita = centralita;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.rtxtGeneradorLLamadas.Enabled = false;
        }
        public void GenerarLlamadas()
        {
            seguirGenerando = true;
            Random random = new Random();
        while (seguirGenerando)
        {
                float randDuracion = random.Next(1, 50);
            float randCosto = (float)(random.NextDouble() * (5.6 - 0.5) + 0.5);

            System.Threading.Thread.Sleep(200);


            string nroDestino = "";
            if (random.Next(10) % 2 == 0)
            {
                nroDestino = "#";  
            }

            nroDestino += random.Next(0,9999999).ToString();

            System.Threading.Thread.Sleep(200);

            string nroOrigen = random.Next(0, 9999999).ToString();

            System.Threading.Thread.Sleep(200);


            Provincial.Franja franja = (Provincial.Franja)(random.Next(2));


           
                if (nroDestino.StartsWith("#"))
                {
                    Provincial llamada = new Provincial(nroOrigen, franja, randDuracion, nroDestino);
                    this.centralita += llamada;
                    llamada.Guardar();
                    if (this.rtxtGeneradorLLamadas.InvokeRequired)
                    {
                        this.rtxtGeneradorLLamadas.BeginInvoke((MethodInvoker)delegate ()
                        {
                            this.rtxtGeneradorLLamadas.Text = "Llamada Generada  \n\n" + llamada.ToString();
                        }
                        );
                    }
                    else
                    {
                        this.rtxtGeneradorLLamadas.Text = "Llamada Generada  \n\n" + llamada.ToString();
                    }

                }
                else
                {
                    Local llamada = new Local(nroOrigen, randDuracion, nroDestino, randCosto);
                    try
                    {
                        this.centralita += llamada;
                        llamada.Guardar();

                        if (this.rtxtGeneradorLLamadas.InvokeRequired)
                        {
                            this.rtxtGeneradorLLamadas.BeginInvoke((MethodInvoker)delegate ()
                            {
                                this.rtxtGeneradorLLamadas.Text = "Llamada Generada  \n\n" + llamada.ToString();
                            }
                            );
                        }
                        else
                        {
                            this.rtxtGeneradorLLamadas.Text = "Llamada Generada  \n\n" + llamada.ToString();
                        }

                    }
                    catch (CentralitaException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    catch (FallaLogException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                System.Threading.Thread.Sleep(3000);

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            seguirGenerando = false;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
