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
    public partial class ProximoPaciente : Form
    {

        Turno proxTurno;
      

        public ProximoPaciente()
        {
            InitializeComponent();
            proxTurno = new Turno();
        }

        public Turno ProxTurno { get => proxTurno; set => proxTurno = value; }

        private void ProximoPaciente_Load(object sender, EventArgs e)
        {
            //List<Turno> pacienteDev = Clinica.GenerarTurnosDerivados(Clinica.LeerPacientesXML(), Clinica.LeerEspecialistasXML());
            //List<Turno> pacienteClinica = Clinica.GenerarTurnosClinica(Clinica.Pacientes, Clinica.Especialistas);

            //foreach (Turno item in pacienteDev)
            //{
            //    rTBoxProximoPaciente.Text += item.
            //}
        }

      
    }
}
