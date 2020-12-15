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

namespace VistaForm
{
    public partial class FrmListar : Form
    {
        Inventario lista;
        public FrmListar(Inventario lista)
        {
            InitializeComponent();
            this.lista = lista;
        }


        private void FrmListar_Load(object sender, EventArgs e)
        {
            dtgvMostar.Rows.Clear();
            
            foreach (Producto pAux in lista.Productos)
            {
                int indice = dtgvMostar.Rows.Add(); //adiciona renglon
                                               //coloco info
                dtgvMostar.Rows[indice].Cells[0].Value = pAux.Codigo.ToString();
                Type b2 = pAux.GetType();
                switch (pAux.GetType().Name.ToString())
                {
                    case "Herramienta":
                        dtgvMostar.Rows[indice].Cells[1].Value = ((Herramienta)pAux).TipoHerramienta.ToString();
                        break;
                    case "Iluminacion":
                        dtgvMostar.Rows[indice].Cells[1].Value = ((Iluminacion)pAux).TipoIluminacion.ToString();
                        dtgvMostar.Rows[indice].Cells[5].Value = ((Iluminacion)pAux).ColorFoco.ToString();
                        break;
                    case "Insumos":
                        dtgvMostar.Rows[indice].Cells[1].Value = ((Insumos)pAux).TipoDeInsumos.ToString();
                        break;
                }
                dtgvMostar.Rows[indice].Cells[2].Value = pAux.Nombre.ToString();
                dtgvMostar.Rows[indice].Cells[3].Value = pAux.Precio.ToString();
                dtgvMostar.Rows[indice].Cells[4].Value = pAux.Stock.ToString();
                
            }
            dtgvMostar.AutoResizeColumns();
        }

        private void dtgvMostar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
                MessageBox.Show(dtgvMostar.Rows[e.RowIndex].Index.ToString());
        }
    }
}
