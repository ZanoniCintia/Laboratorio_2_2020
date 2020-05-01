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

namespace FormSistemaSolar
{
    public partial class Form1 : Form
    {
        private static List<Astro> planeta;
        public Form1()
        {
            InitializeComponent();
            planeta = new List<Astro>();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbTipoPlanetas.Items.Add(Tipo.Rocoso);
            cmbTipoPlanetas.Items.Add(Tipo.Gaseoso);
        }

        private void btnMover_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarP_Click(object sender, EventArgs e)
        {
            bool agregado = true;
            if (txtNombrePlaneta.Text != "" && txtTiempoOrbita.Text !=""
                && numRotacionP.Value > 0 && numCantLunas.Value >= 0)
            {
                Planeta planetaNuevo = new Planeta(int.Parse(txtTiempoOrbita.Text), (int)numRotacionP.Value, txtNombrePlaneta.Text, (int)numCantLunas.Value, (Tipo)cmbTipoPlanetas.SelectedItem);
                
                foreach (Planeta aux in planeta)
                {
                    if (aux == planetaNuevo)
                    {
                        MessageBox.Show("El planeta ya se encuentra en la lista");
                        agregado = false;
                        break;
                    }
                    agregado = true; 
                }
                if (agregado)
                {
                    planeta.Add(planetaNuevo);
                    MessageBox.Show("El planeta se agrego con exito!!");
                    cmbPlaneta.Items.Add(txtNombrePlaneta.Text);
                }
                txtNombrePlaneta.Text = "";
                txtTiempoOrbita.Text = "";
                numRotacionP.Value = 0;
                numCantLunas.Value = 0;
            }
            else
            {
                
                MessageBox.Show("Debe completar los datos completos");
               
                

            }


        }

        private void btnAgregarSatelite_Click(object sender, EventArgs e)
        {
            
            if ( cmbPlaneta.Text != "" && numCompOrbita.Value >0  && txtNombreSatelite.Text != "" && 
                 numRotacionSatelite.Value >0 )
            {
                Satelite satelite = new Satelite((int)numCompOrbita.Value,(int)numRotacionSatelite.Value,txtNombreSatelite.Text);
                foreach (Planeta auxPlaneta in planeta)
                {
                    if((string)auxPlaneta == cmbPlaneta.Text)
                    {
                        if(auxPlaneta + satelite)
                        {
                            MessageBox.Show("El satelite se agrego con exito");
                        }
                        else
                        {
                            MessageBox.Show("No se pudo agregar");
                        }
                     
                    }
                 

                }
                
                txtNombrePlaneta.Text = "";
                txtTiempoOrbita.Text = "";
                numRotacionP.Value = 0;
                numCantLunas.Value = 0;
                cmbTipoPlanetas.Text = "";
            }
            else
            {
                richTextBox1.Text = txtNombreSatelite.Text;
                MessageBox.Show("Debe seleccionar un planeta ");

            }
            

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            foreach (Planeta auxPlaneta in planeta)
            {
                richTextBox1.AppendText(auxPlaneta.ToString());
             
            }
        }
    }
}
