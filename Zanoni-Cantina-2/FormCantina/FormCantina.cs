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
using ControlCantina;

namespace FormCantina
{
    public partial class FormCantina : Form
    {
        Botella.Tipo tipo;
        public FormCantina()
        {
            InitializeComponent();
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Enum.TryParse<Botella.Tipo>(cmbTipo.SelectedValue.ToString(), out tipo);
         
        }

       

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Botella botella;
            if (radioButtonAgua.Checked)
            {
                botella = new Agua((int)numCapacidad.Value, txtBoxMarca.Text, (int)numeContenido.Value);
                
                barra1.AgregarBotella((Agua)botella);
            }

            if (radioButtonCerveza.Checked)
            {
                Enum.TryParse<Botella.Tipo>(cmbTipo.SelectedValue.ToString(), out tipo);
                botella = new Cerveza((int)numCapacidad.Value, txtBoxMarca.Text,tipo, (int)numeContenido.Value);
                
                barra1.AgregarBotella((Cerveza)botella);
            }
        }

        private void FormCantina_Load(object sender, EventArgs e)
        {
            this.barra1.SetCantina = Cantina.GetCantina(10);
            cmbTipo.DataSource = Enum.GetValues(typeof(Botella.Tipo));
        }
    }
}
