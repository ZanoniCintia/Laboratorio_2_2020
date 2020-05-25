using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadDeVueltas;
        private List<VehiculoDeCarrera> competidores;
        private TipoCompetencia tipo;

        public short CantidadCompetidores
        {
            get
            {
               return  this.cantidadCompetidores;
            }
            set
            {
                this.cantidadCompetidores = value;
            }
        }

        public short CantidadDeVueltas
        {
            get
            {
                return this.cantidadDeVueltas;
            }
            set
            {
                this.cantidadDeVueltas = value;
            }
        }
        public VehiculoDeCarrera this[int index]
        {
            get
            {
                if(index < competidores.Count && index >= 0)
                {
                    return this.competidores[index];
                }
                else
                {
                    return null;
                }
            }
           
        }

        public TipoCompetencia Tipo
        {
            get { return this.tipo; }
            set { this.tipo = value; }
        }



        private Competencia()
        {
            this.competidores = new List<VehiculoDeCarrera>();
        }

        public Competencia(short cantidadVueltas,short cantidadCompetidores,TipoCompetencia tipo) 
            :this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadDeVueltas = cantidadVueltas;
            this.tipo = tipo;
        }



        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cantidad de competidores: {this.cantidadCompetidores}");
            sb.AppendLine($"Cantidad de vueltas: {this.cantidadDeVueltas}");
            sb.AppendLine($"Tipo de competencia : {this.Tipo}");
            foreach (VehiculoDeCarrera aux in competidores)
            {
                sb.AppendLine(aux.MostrarDatos());
            }
            return sb.ToString();
        }
        public static bool operator ==(Competencia c,VehiculoDeCarrera v)//no esta claro
        {
            bool retorno = false;
            if((c.Tipo == TipoCompetencia.F1 && v is MotoCross) || (c.Tipo == TipoCompetencia.MotoCross && v is AutoF1))
            {
                throw new CompetenciaNoDisponibleException("El vehiculo no corresponde a la competencia", "Competencia", "Operador ==");
            }
            foreach (VehiculoDeCarrera auxvehiculo in c.competidores)
            {
                if(auxvehiculo == v)
                {
                    retorno = true;
                    break;
                }
            }
            
            return retorno;
        }

        public static bool operator !=(Competencia c,VehiculoDeCarrera a)
        {
            return !(c == a);
        }

        public static bool operator +(Competencia c,VehiculoDeCarrera v)
        {
            
            bool retorno = false;
            Random aleatorio = new Random();
            if (c.competidores.Count < c.CantidadCompetidores)
            {
                try 
                {
                    if (c != v)
                    {
                        c.competidores.Add(v);
                        v.EnCompetencia = true;
                        v.VueltasRestantes = c.cantidadDeVueltas;
                        v.CantidadCombustible = (short)aleatorio.Next(15, 100);
                        retorno = true;
                    }
                }
                catch(CompetenciaNoDisponibleException e)
                {
                    throw new CompetenciaNoDisponibleException("Competencia incorrecta", "Competencia", "Operador +",e);
                }
              


            }
            
                /*  bool retorno = false;
                  Random aleatorio = new Random();
                  if(!(c is null) && !(v is null))
                  {

                      if (c.competidores.Count <= c.cantidadCompetidores && c == v)
                      {
                          foreach (VehiculoDeCarrera auxVehiculo in c.competidores)
                          {
                              if(auxVehiculo != v)
                              {
                                  c.competidores.Add(v);
                                  v.EnCompetencia = true;
                                  v.VueltasRestantes = c.cantidadVueltas;
                                  v.CantidadCombustible = (short)aleatorio.Next(15, 100);
                                  retorno = true;
                                  break;
                              }

                          }
                      }

                  }*/
                return retorno;
        }

        public static bool operator -(Competencia c, VehiculoDeCarrera v)
        {
            bool retorno = false;
            if (!(c is null) && !(v is null))
            {
                if (c == v)
                {
                    c.competidores.Remove(v);
                    v.CantidadCombustible = 0;
                    v.EnCompetencia = false;
                    v.VueltasRestantes = 0;
                    retorno = true;
                }
            }
            return retorno;
            
        }

      

        public enum TipoCompetencia
        {
            F1,
            MotoCross
        }
    }
}
