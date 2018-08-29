using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos_ej17_pens
{
    class Boligrafo
    {
        private const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta)
        {
            this.tinta = tinta;
        }

        public Boligrafo(ConsoleColor color)
        {
            this.tinta = cantidadTintaMaxima;
            this.color = color;
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        public bool Pintar(int gasto, out string dibujo)
        {
            this.SetTinta((short)(this.tinta-gasto));
            int asteriscs = this.tinta / gasto;
            dibujo = "";
            if (this.tinta >= gasto)
            {
                for (int i = 0; i <= asteriscs; i++)
                    dibujo = dibujo + "*";
                return true;
            }
            return false;
        }

        public void Recargar()
        {
            this.SetTinta(cantidadTintaMaxima);
        }

        private void SetTinta(short tinta)
        {
            this.tinta = tinta;

            if (this.tinta > cantidadTintaMaxima)
                this.tinta = cantidadTintaMaxima;
            if (this.tinta < 0)
                this.tinta = 0;
        }
    }
}
