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
using Entidades;

namespace ClinicaZanoni
{
    public partial class FrmMenu : Form
    {
        EnConsulta enConsulta;
        ProximoPaciente delDia;
    
        private Turno nuevoTurno;
        
        
        
        
        public FrmMenu()
        {
            InitializeComponent();
            enConsulta = new EnConsulta();
            delDia = new ProximoPaciente();
           
            nuevoTurno = new Turno();
            
        }

       

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    

        private void FrmMenu_Load(object sender, EventArgs e)
        {
        
            ClinicaDAO.ConexionOpen();
            ClinicaDAO.SeleccionarPacientes();
            ClinicaDAO.SeleccionarEspecialistas();
            dataGridEspecialistas.DataSource =Clinica.CargarListaEspecialista(Clinica.LeerEspecialistasXML(), Clinica.Especialistas);  
            dataGridPacientes.DataSource = Clinica.CargarListasPaciente(Clinica.LeerPacientesXML(), Clinica.Pacientes);
            enConsulta.Show();
            delDia.Show();
            ClinicaDAO.ConexionClose();

        }

      



        private void btnAsignarTurno_Click(object sender, EventArgs e)
        {   
          
            //terminar

           // Paciente paciente = new Paciente(0,nombre,apellido,int.Parse(edad),sexo,direccion,ocupacion);
            //Especialista especialista = new Especialista(0, nombreD, apellidoD, int.Parse(edadD), sexo, direccionD, especialidadD);
             //Clinica.GenerarTurnos(paciente, especialista);
        }

        private void btnAsigTurnoDerivado_Click(object sender, EventArgs e)
        {
            switch (EstadoDelTurno.Creado)
            {
                case EstadoDelTurno.Creado:
                    
                    break;
                case EstadoDelTurno.EnConsulta:
                    
                    break;
                case EstadoDelTurno.Finalizado:
                    break;
            }
        }
    }
}
