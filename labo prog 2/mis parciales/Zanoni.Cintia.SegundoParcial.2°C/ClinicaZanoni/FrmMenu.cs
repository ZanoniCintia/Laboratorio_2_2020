using ClinicaZanoni.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Entidades;

namespace ClinicaZanoni
{
    public delegate void ManejoTurnos();

    public partial class FrmMenu : Form
    {
        FrmEnConsulta frmenConsulta;
        FrmProximoPaciente frmProximoPaciente;
        Thread hiloSecundario;
        public event ManejoTurnos eventoTurnos;

        /// <summary>
        /// constructor Form principal
        /// instancia los otros formularios
        /// le asigna al evento los metodos manejadores correspondientes
        /// </summary>
        public FrmMenu()
        {
            InitializeComponent();
            frmenConsulta = new FrmEnConsulta();
            frmProximoPaciente = new FrmProximoPaciente();
            eventoTurnos += ActualizarProximoPaciente;
            eventoTurnos += AtenderProximoPaciente;
            eventoTurnos += PacienteAtendido;
            eventoTurnos += RemoverLista;
        }


   

        /// <summary>
        /// carga los dataGrid con las listas correspondientes
        /// instancia el hilo secundario, le pasa un metodo
        /// activa el hilo secundario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMenu_Load(object sender, EventArgs e)
        {

            dataGridEspecialistas.DataSource = Clinica.Especialistas;

            dataGridPacientes.DataSource = Clinica.Pacientes;

            frmenConsulta.Show();
            frmProximoPaciente.Show();


            hiloSecundario = new Thread(TiempoDeConsulta);
            hiloSecundario.Start();

        }

        /// <summary>
        /// duerme el hilo por 10 segundos e invoca el evento
        /// itera mientras la lista de pacientes contenga elementos
        /// cuando la lista queda vacia desactiva el hilo secundario
        /// </summary>
        public void TiempoDeConsulta()
        {          
            do
            {
                Thread.Sleep(10000);
                eventoTurnos.Invoke();

            } while (Clinica.Pacientes.Count != 0);

            hiloSecundario.Abort();
        }


        /// <summary>
        /// trae del formulario proximo paciente el metodo que lo actualiza
        /// </summary>
        public void ActualizarProximoPaciente()
        {
            frmProximoPaciente.ActualizarProximoPaciente();
        }

        /// <summary>
        /// dentro del hilo secundario va eliminando de la lista un elemento 
        /// seleccionando la posicion que ocupa el mismo
        /// vuelve a insertar la lista en el dataGrid con el elemento eliminado
        /// </summary>
        public void RemoverLista()
        {
            if (this.dataGridPacientes.InvokeRequired)
            {
                this.dataGridPacientes.BeginInvoke((MethodInvoker)delegate ()
                {
                    dataGridPacientes.DataSource = null;
                    dataGridPacientes.Rows.Clear();
                    if (Clinica.Pacientes.Count != 0)
                        Clinica.Pacientes.Remove(Clinica.Pacientes[0]);
                    dataGridPacientes.DataSource = Clinica.Pacientes;
                }
                );
            }
            else
            {
                dataGridPacientes.DataSource = null;
                dataGridPacientes.Rows.Clear();
                if (Clinica.Pacientes.Count != 0)
                    Clinica.Pacientes.Remove(Clinica.Pacientes[0]);
                dataGridPacientes.DataSource = Clinica.Pacientes;
            }

        }
        /// <summary>
        /// pasa el paciente de un formulario a otro
        /// </summary>
        public void AtenderProximoPaciente()
        {
            frmenConsulta.AtenderPaciente(frmProximoPaciente.PacienteActualEnEspera);
        }

        /// <summary>
        /// muestra en el formulario el turno generado
        /// </summary>
        public void PacienteAtendido()
        {
            frmenConsulta.PacienteAtendido(frmenConsulta.EnConsulta);
        }

        /// <summary>
        /// cierra la aplicacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
