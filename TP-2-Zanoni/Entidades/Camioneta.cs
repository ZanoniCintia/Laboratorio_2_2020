﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Camioneta:Vehiculo
    {
        public Camioneta(EMarca marca, string codigo, ConsoleColor color)
            : base(marca,codigo, color)
        {
        }
        /// <summary>
        /// Las camionetas son grandes
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Grande;
            }
        }

        public new string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CAMIONETA");
            sb.AppendLine(base.ToString());
            sb.AppendLine($"TAMAÑO : {this.Tamanio}");
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
