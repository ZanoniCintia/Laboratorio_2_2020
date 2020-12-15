using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic.Entidades
{
    public static class ExtencionFormatearPrecio
    {
        public static string FormatearPrecio(this double precio)
        {
            decimal.Round((decimal)precio);
            return string.Format($"${0}",precio);
            
        }
    }
}
