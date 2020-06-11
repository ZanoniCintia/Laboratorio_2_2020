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

namespace FrmThreads
{
    public partial class Form1 : Form
    {
        Thread hiloSecundario;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /// Con parametrized thread para pasar 1 parametro
            //ParameterizedThreadStart pts = new ParameterizedThreadStart(AlterarLabelParam);
            //this.t = new Thread(pts);

            /// Sin parametros
            //this.t = new Thread(AlterarLabel);

            /// método como parámetro:
            ThreadStart ts = new ThreadStart(ActualizarHora);
            hiloSecundario = new Thread(ts);
        }

        // Delegado que emparenta con el metodo AlterarLabel ya que ninguno de los dos recibe parametros.
        delegate void DelegadoParaAlterarLabel();
        public void ActualizarHora()
        {
            do
            {
                this.AlterarLabelDate(DateTime.Now);
                Thread.Sleep(200);
            } while (true);
        }

        private void AlterarLabel()
        {
            // InvokeRequired consulta si estoy en el hilo principal, si estoy modifico el form, sino me invoco del secundario al primario.
            if (this.lblDate.InvokeRequired)
            {
                DelegadoParaAlterarLabel aux = new DelegadoParaAlterarLabel(AlterarLabel);
                this.Invoke(aux);
            }
            else
            {
                this.lblDate.Text = "Hilo Secundario";
            }
        }
        // Delegado que emparenta con el metodo AlterarLabel ya que ambos reciben un object.
        delegate void DelegadoParaAlterarLabelDate(object t);
        private void AlterarLabelDate(object texto)
        {
            // InvokeRequired consulta si estoy en el hilo principal, si estoy modifico el form, sino me invoco del secundario al primario.
            if (this.lblDate.InvokeRequired)
            {
                DelegadoParaAlterarLabelDate aux = new DelegadoParaAlterarLabelDate(AlterarLabelDate);
                object[] obj = new Object[] { texto };
                this.BeginInvoke(aux, obj);
            }
            else
            {
                this.lblDate.Text = texto.ToString();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Valido si el hilo está vivo, True está vivo, False llegó a su fin, si sigue corriendo lo aborto.
            if (hiloSecundario.IsAlive)
            {
                this.hiloSecundario.Abort();
            }

            ///Idem a IsAlive solo que con mas opciones
            //if(this.t.ThreadState != ThreadState.Aborted)
            //{
            //    this.t.Abort();
            //}
        }

        private void btnActiva_Click(object sender, EventArgs e)
        {
            /// Sin parametros
            //this.t.Start();

            /// Con parametrized thread para pasar 1 parametro
            //this.t.Start("Second Thread");

            /// método como parámetro:
            if (this.hiloSecundario.ThreadState == ThreadState.Unstarted)
            {
                this.hiloSecundario.Start();
            }
        }
    }
}
