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


namespace ClinicaZanoni
{
    public partial class FrmProximoPaciente : Form
    {
        Paciente pacienteActualEnEspera;
        Paciente pacienteASerAtendido;



        public FrmProximoPaciente()
        {
            InitializeComponent();

        }

        public Paciente PacienteASerAtendido { get => pacienteASerAtendido; }
        public Paciente PacienteActualEnEspera { get => pacienteActualEnEspera; }


        /// <summary>
        /// invoca el hilo secundario
        /// guarda en paciente a ser atendido el paciente en espera 
        /// pone en paciente en espera al proximo de la lista
        /// copia en el richTexBox el paciente en espera mostrando su nombre
        /// si la lista termino deja vacio el richTextBox
        /// 
        /// </summary>
        public void ActualizarProximoPaciente()
        {
            if (this.rTBoxProximoPaciente.InvokeRequired)
            {
                this.rTBoxProximoPaciente.BeginInvoke((MethodInvoker)delegate ()
                {
                    this.pacienteASerAtendido = pacienteActualEnEspera;
                    if (Clinica.Pacientes.Count != 0)
                        this.pacienteActualEnEspera = Clinica.Pacientes[0];
                  
                    if (pacienteActualEnEspera != null)
                        this.rTBoxProximoPaciente.Text = pacienteActualEnEspera.Nombre + " " + pacienteActualEnEspera.Apellido + " " + pacienteActualEnEspera.Edad + " " + pacienteActualEnEspera.TipoCobertura; 
                    if (Clinica.Pacientes.Count == 0)
                        this.rTBoxProximoPaciente.Clear();
                }
                );
            }
            else
            {
                this.pacienteASerAtendido = pacienteActualEnEspera;

                this.pacienteActualEnEspera = Clinica.Pacientes[0];
                if (pacienteActualEnEspera != null)
                    this.rTBoxProximoPaciente.Text = pacienteActualEnEspera.Nombre + " " + pacienteActualEnEspera.Apellido + " " + pacienteActualEnEspera.Edad + " " + pacienteActualEnEspera.TipoCobertura; 
                if (Clinica.Pacientes.Count == 0)
                    this.rTBoxProximoPaciente.Clear();
            }
        }


        private void ProximoPaciente_Load(object sender, EventArgs e)
        {
         
        }


    }
}
