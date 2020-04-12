using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Boligrafo
    {
        const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.color=color;
            this.tinta=tinta;
        }
        public ConsoleColor GetColor()
        {
          return this.color; 

        }
      

        

        public int GetTinta()
        {
            return this.tinta;
            
        }

        private void SetTinta(short tinta)
        {
            int cantidadTinta = this.tinta + tinta;
            if (cantidadTinta >= cantidadTintaMaxima)
            {
                this.tinta = cantidadTintaMaxima;
            }
            else if (cantidadTinta >= 0 && cantidadTinta < cantidadTintaMaxima)
            {
                this.tinta = (short)cantidadTinta;
            }

            


        }
        public void Recargar()
        {
            SetTinta(cantidadTintaMaxima);
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            bool ret = false;
            dibujo = "";
            if (this.tinta - gasto >= 0)
            {
                SetTinta((short)-gasto);
                for (int i = 0; i < gasto; i++)
                {
                    dibujo += "*";
                }
                ret = true;
            }
            else
            {
                for (int i = this.tinta; i > 0; i--)
                {
                    dibujo += "*";
                }
                SetTinta((short)-this.tinta);
                ret = false;
            }
            
            return ret;
        }

    }
}