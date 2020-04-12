using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Punto
    {
        private int y;
        private int x;

        public int GetX()
        {
           return this.x;
        }

        public int GetY()
        {
            return this.y;
        }

        public Punto(int x, int y)
        {
            this.x = GetX();
            this.y = GetY();
        }


    }

    public class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        public float Area()
        {
            
            return this.area;
        }

        public float Perimetro()
        {
            return this.perimetro;
        }

       
        public Rectangulo(Punto vertice1,Punto vertice3)
        {
           // Punto aux= new Punto(Convert.ToInt32(vertice1),Convert.ToInt32(vertice2));
            Math.Abs(Convert.ToInt32(vertice1));
            Math.Abs(Convert.ToInt32(vertice2));
        }
    }
}
