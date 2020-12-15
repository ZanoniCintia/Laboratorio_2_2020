using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;



namespace Entidades
{
    public static  class Clinica
    {
        
        private static List<Turno> turnos;
        private static List<Paciente> pacientes;
        private static List<Especialista> especialistas;
        private static List<string> observacionesDeConsultas;
        private static List<Paciente> listaDefinitaPacientes;
        private static ArchivoTexto archivo;
      

        private static Random orandoms;
        private static Turno turno;
        
        


        #region Propiedades

        /// <summary>
        /// propiedad publica lista de turnos
        /// </summary>
        public static List<Turno> Turnos
        {
            get { return turnos; }
            set { turnos = value; }
        }

        /// <summary>
        /// propiedad publica lista de pacientes
        /// </summary>
        public static List<Paciente> Pacientes
        {
            get { return pacientes; }
            set { pacientes = value; }
        }


        /// <summary>
        /// propiedad publica lista de especialistas
        /// </summary>
        public static List<Especialista> Especialistas
        {
            get { return especialistas; }
            set { especialistas = value; }
        }


    

        #endregion

        #region Metodos

        /// <summary>
        /// constructor estatico
        /// </summary>
        static Clinica()
        {
            
            turnos = new List<Turno>();
            pacientes = CargarListasPaciente(LeerPacientesXML(), ClinicaDAO.SeleccionarPacientes());
            archivo = new ArchivoTexto();
            especialistas = CargarListaEspecialista(LeerEspecialistasXML(), ClinicaDAO.SeleccionarEspecialistas());
            observacionesDeConsultas = new List<string>();
            orandoms = new Random();

         

        }


        /// <summary>
        /// selecciona observaciones de manera random para cargar al momento de generar el turno
        /// </summary>
        /// <returns>el string que asigna</returns>
        public static string RandomClinica()
        {
            int aux = orandoms.Next(0, observacionesDeConsultas.Count + 1);
            
            observacionesDeConsultas.Add("Dolor de cabeza");
            observacionesDeConsultas.Add("Covid-19");
            observacionesDeConsultas.Add("Gripe");
            observacionesDeConsultas.Add("Metamorfosis");
            observacionesDeConsultas.Add("Mutacion");
            observacionesDeConsultas.Add("Dolor de cabello");
            observacionesDeConsultas.Add("Fractura");
            observacionesDeConsultas.Add("Se la dio en la pera");
            observacionesDeConsultas.Add("Cambio de aceite");
            observacionesDeConsultas.Add("Rotacion de extremidades");
            observacionesDeConsultas.Add("Se golpeo");
            return observacionesDeConsultas[aux];

        }

      
        /// <summary>
        /// recibe una lista de pacientes y una de especialistas y crea un turno
        /// segun sus numeros de Id guarda el turno en la base de datos o en XML
        /// </summary>
        /// <param name="paciente"></param>
        /// <param name="especialista"></param>
        /// <returns>una lista de turnos</returns>
        public static Turno GenerarTurnos(Paciente paciente)
        {
            
            string fecha = DateTime.Now.FormatearFecha();
            string auxObservacion = RandomClinica();
            Serializadora<Turno> guardar=new Serializadora<Turno>();
           
            Turno turno=null;
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ".\\SegundoParcialUtn\\ArchivosClinica";

            try
            {



                    foreach (Especialista auxEspecialista in especialistas)
                    {
                        turno = new Turno(paciente.Id, auxEspecialista.Id, RandomClinica(), fecha);
                      
                            if (paciente.Id >= 1 && paciente.Id <= 113 && auxEspecialista.Id >= 1 && auxEspecialista.Id <= 110)
                            {
                                ClinicaDAO.IngresarTurno(turno);

                            }
                            else if (paciente.Id >= 900 && paciente.Id <= 1899 && auxEspecialista.Id >= 1500 && auxEspecialista.Id <= 1529)
                            {
                                guardar.Escribir("Turnos"+ fecha +".Xml", ruta, turno);
                            }

                       
                    }

            }
            catch (Exception e)
            {
                archivo.Escribir("Errores.log", ruta, e.Message);
                
            }
           
            return turno;
        }



        /// <summary>
        /// recibe 2 listas de pacientes uno de xml y otro de base de datos
        /// las recorre y guarda cada uno de sus elementos en una nueva 
        /// </summary>
        /// <param name="listapacientesSql,"></param>
        /// <param name="listapacientesXMl"></param>
        /// <returns>una lista nueva completa</returns>
        public static  List<Paciente> CargarListasPaciente(List<Paciente> listapacientesSql, List<Paciente> listapacientesXMl)
        {
            List<Paciente> listaCompleta = new List<Paciente>();
            foreach (Paciente auxPaciente in listapacientesSql)
            {
                listaCompleta.Add(auxPaciente);

            }
            foreach (Paciente auxPacientes in listapacientesXMl)
            {
                listaCompleta.Add(auxPacientes);
            }

            return listaCompleta;
        }


        /// <summary>
        /// recibe 2 listas de especialistas las recorre y guarda cada uno de sus elementos en una nueva 
        /// </summary>
        /// <param name="listaEspecialistasXML"></param>
        /// <param name="listaEspecialistasSql"></param>
        /// <returns>una lista nueva completa</returns>
        public static List<Especialista> CargarListaEspecialista(List<Especialista> listaEspecialistasXML, List<Especialista> listaEspecialistasSql)
        {
            List<Especialista> listaCompleta = new List<Especialista>();
            foreach (Especialista auxEspecialista in listaEspecialistasXML)
            {
                listaCompleta.Add(auxEspecialista);
            }
            foreach (Especialista auxEspecialistas in listaEspecialistasSql)
            {
                listaCompleta.Add(auxEspecialistas);
            }
            return listaCompleta;
        }







        #endregion


        #region Leer Y Guardar

        /// <summary>
        /// lee el archivo de formato xml y lo devuelve en una lista de pacientes
        /// </summary>
        /// <returns>lista</returns>
        public static List<Paciente> LeerPacientesXML()
        {
            Serializadora<List<Paciente>> xml = new Serializadora<List<Paciente>>();
            string ruta= Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ".\\SegundoParcialUtn\\ArchivosClinica\\PacientesSegundaClinica.xml";
            xml.Leer(ruta, out List<Paciente> listPac);
 
            return listPac;

        }


        /// <summary>
        /// lee el archivo de formato xml y lo devuelve en una lista de pacientes
        /// </summary>
        /// <returns>lista</returns>
        public static List<Especialista> LeerEspecialistasXML()
        {
            Serializadora<List<Especialista>> xml = new Serializadora<List<Especialista>>();
            string ruta= Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ".\\SegundoParcialUtn\\ArchivosClinica\\DoctoresSegundaClinica.xml";
            xml.Leer(ruta, out List<Especialista> listaEspe);
           
            return listaEspe; 

        }


        #endregion




        

    }
}
