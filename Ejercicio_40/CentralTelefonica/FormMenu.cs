using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaHerencia;

namespace CentralTelefonica
{
    public partial class FormMenu : Form
    {
        FrmLlamador frmLlamador;
        FormMostrar formMostrar;
        Centralita centralita;
        public FormMenu()
        {
            InitializeComponent();
            centralita = new Centralita("Mi central");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //frmLlamador.Visible = true;
            frmLlamador.ShowDialog();
            
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            frmLlamador = new FrmLlamador(centralita);
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //total
            formMostrar = new FormMostrar(centralita);
            formMostrar.tipoLLamada = TipoLlamada.Todas;
            formMostrar.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //local
            formMostrar = new FormMostrar(centralita);
            formMostrar.tipoLLamada = TipoLlamada.Local;
            formMostrar.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //provincial
            formMostrar = new FormMostrar(centralita);
            formMostrar.tipoLLamada = TipoLlamada.Provincial;
            formMostrar.ShowDialog();
        }
    }
}
