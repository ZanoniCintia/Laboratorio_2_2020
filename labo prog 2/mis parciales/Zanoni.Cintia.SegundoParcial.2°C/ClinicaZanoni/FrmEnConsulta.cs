using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
namespace ClinicaZanoni.Properties
{
    public partial class FrmEnConsulta : Form
    {

        Paciente enConsulta;
        Paciente aGrabar;


        public FrmEnConsulta()
        {
            InitializeComponent();
        }

        public Paciente AGrabar { get => aGrabar; set => aGrabar = value; }
        public Paciente EnConsulta { get => enConsulta; set => enConsulta = value; }


        /// <summary>
        /// invocaa el hilo secundario
        /// recibe un paciente muestra el nombre del paciente en el richTextBox
        /// pasa el dato recibido por parametro de un formulario a otro 
        /// una vez finalizada la lista lo deja vacio
        /// </summary>
        /// <param name="paciente"></param>
        public void AtenderPaciente(Paciente paciente)
        {
            if (this.rTBoxEnConsulta.InvokeRequired)
            {
                this.rTBoxEnConsulta.BeginInvoke((MethodInvoker)delegate ()
                {
                    this.aGrabar = enConsulta;

                    enConsulta = paciente;
                    if (enConsulta != null)
                        this.rTBoxEnConsulta.Text = enConsulta.Nombre +" "+enConsulta.Apellido + " " + enConsulta.Edad + " " + enConsulta.TipoCobertura; 
                    if (Clinica.Pacientes.Count == 0)
                        this.rTBoxEnConsulta.Clear();
                }
                );
            }
            else
            {
                this.AGrabar = enConsulta;
                enConsulta = paciente;
                this.rTBoxEnConsulta.Text = enConsulta.Nombre + " " + enConsulta.Apellido + " " + enConsulta.Edad + " " + enConsulta.TipoCobertura;
                if (Clinica.Pacientes.Count == 0)
                    this.rTBoxEnConsulta.Clear();
            }
        }


        /// <summary>
        /// invoca el hilo secundario
        /// recibe un paciente, si el paciente no es null crea un turno con el metodo GenerarTurno
        /// y lo muestra en el richTextBox
        /// </summary>
        /// <param name="pacienteYaAtendido"></param>
        public void PacienteAtendido(Paciente pacienteYaAtendido)
        {
            if (this.rTBoxTurnosFinalizados.InvokeRequired)
            {
                this.rTBoxTurnosFinalizados.BeginInvoke((MethodInvoker)delegate ()
                {
                    if (pacienteYaAtendido != null)
                        rTBoxTurnosFinalizados.Text += Clinica.GenerarTurnos(pacienteYaAtendido).ToString();
                
                }
                );
            }
            else
            {
                rTBoxTurnosFinalizados.Text += Clinica.GenerarTurnos(pacienteYaAtendido).ToString();
             
            }
        }

    }
}
