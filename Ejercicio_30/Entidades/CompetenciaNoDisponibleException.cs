﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CompetenciaNoDisponibleException:Exception
    {
        private string nombreClase;
        private string nombreMetodo;

        public string NombreClase
        {
            get { return this.nombreClase; }
           
        }

        public string NombreMetodo
        {
            get { return this.nombreMetodo; }
            
        }

        public CompetenciaNoDisponibleException(string mensaje,string clase, string metodo)
             : this(mensaje, clase, metodo, null)
        {

        }
        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo, Exception innerException)
            : base(mensaje, innerException)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
        //sin terminar

            return sb.ToString();
        }
    }
}
