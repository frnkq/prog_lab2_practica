using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Temporizador
{
    public delegate void encargadoTiempo();
    public class Temporizador
    {
        public Thread hilo;
        public int intervalo;

        public event encargadoTiempo eventoTiempo;

        public bool Activo
        {
            get
            {
                if (this.hilo.IsAlive)
                    return true;

                return false;
            }
            set
            {
                if(value == true)
                {
                    if (!hilo.IsAlive)
                    {
                        this.hilo = new Thread(Corriendo);
                        hilo.Start();
                    }

                }
            }
        }

        public int Intervalo
        {
            get
            {
                return this.intervalo;
            }
            set
            {
                this.intervalo = value;
            }
        }

        public Temporizador(int interval)
        {
            this.hilo = new Thread(Corriendo);
            this.intervalo = interval;
        }

        public void Corriendo()
        {
            this.Activo = true;
            do
            {
                Thread.Sleep(intervalo);
                this.eventoTiempo.Invoke();
            } while (this.Activo);
            
        }


    }
}
