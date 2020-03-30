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

        public Boligrafo(ConsoleColor color,short tinta)
        {
            color = this.color;
            tinta = this.tinta;
        }
        public ConsoleColor GetColor
        {
            get { return this.color; }
            
        }
        public short GetTinta
        {
            get { return this.tinta; }

        }
       
        private void SetTinta(short tinta)
        {
            if (tinta >= 0 && tinta == cantidadTintaMaxima)
            {
                if (tinta > 0 && tinta < 100)
                {
                    Console.WriteLine("Cargar tinta");
                }
                else if (tinta < 0)
                {
                    Console.WriteLine("Gastar tinta");
                }
            }
        }

        public void Recargar()
        {
            SetTinta(cantidadTintaMaxima);
        }

        public bool Pintar(short gasto, out string dibujo)
        {
           
            dibujo = "*";
            if (gasto > 0)
            {
                SetTinta(gasto);
                Console.WriteLine("Puede pintar");
                for (int i = 0; i < gasto; i++)
                {
                    
                    Console.WriteLine(dibujo);
                }
                
            } 
            return true;
        }



    }
}
