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
namespace WindowsFormsApp3
{



    public partial class Form1 : Form
    {
        Form2 f2;

        List<Perro> colaStrings;

        Thread t1;



        public Form1()
        {
            colaStrings = new List<Perro>();
            colaStrings.Add(new Perro("Pichichus",5));
            colaStrings.Add(new Perro("Pepe",5));
            colaStrings.Add(new Perro("Romeo",5));
            colaStrings.Add(new Perro("Carola",5));
            colaStrings.Add(new Perro("Jazmin",5));
            colaStrings.Add(new Perro("Juanita",5));
            colaStrings.Add(new Perro("Lucilka",5));
            colaStrings.Add(new Perro("Romeina",5));
            InitializeComponent();

            f2 = new Form2();
            

            f2.Show();
          

            t1 = new Thread(IniciarCiclo);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualizarLista();
            t1.Start();



        }

        public void ActualizarLista()
        {
            if (this.listView1.InvokeRequired)
            {
                this.listView1.BeginInvoke((MethodInvoker)delegate ()
                {
                    this.listView1.Items.Clear();
                    foreach (Perro item in colaStrings)
                    {
                        listView1.Items.Add(item.ToString() + "\n");
                    }
                }
                );
            }
            else
            {
                foreach (Perro item in colaStrings)
                {
                    listView1.Items.Add(item.ToString() + "\n");
                }
            }

        }
        public void IniciarCiclo()
        {
            do
            {

                f2.ActualizarDato(colaStrings[0]);
                Thread.Sleep(3000);

                colaStrings.Remove(colaStrings[0]);

                this.ActualizarLista();
            }
            while (true);

        }
    }
}
