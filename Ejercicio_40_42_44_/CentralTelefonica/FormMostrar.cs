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
    public partial class FormMostrar : Form
    {
        Centralita centralita;
        TipoLlamada tipoLlamada;

        public TipoLlamada tipoLLamada
        {
            set {  this.tipoLlamada=value; }
           
        }


        public FormMostrar(Centralita centralita)
        {
            InitializeComponent();
            this.centralita = centralita;
            
        }

        private void FormMostrar_Load(object sender, EventArgs e)
        {
            switch (tipoLlamada)
            {
                case TipoLlamada.Local:
                    richTextBox1.AppendText($"Facturacion por llamada local:{centralita.GananciaPorLocal.ToString()}");
                    break;
                case TipoLlamada.Provincial:
                    richTextBox1.AppendText($"Facturacion por llamada provincial:{centralita.GananciaPorProvincial.ToString()}");
                    break;
                case TipoLlamada.Todas:
                    richTextBox1.AppendText($"Facturacion total:{centralita.GananciaPorTotal.ToString()}");
                    break;

            }
        }
    }
}
