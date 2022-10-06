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

namespace Vista
{
    public partial class FrmContador : Form
    {
        Electronica electronica;
        public FrmContador()
        {
            InitializeComponent();
        }
        public FrmContador(Electronica electronica):this()
        {
            this.electronica = electronica;
        }

        private void FrmContador_Load(object sender, EventArgs e)
        {
         

            this.ActualizarLista();

            int n;

            n = this.dgvContador.Rows.Add();

            this.dgvContador.Rows[n].Cells[0].Value = this.electronica.CantidadDeVentas;
            this.dgvContador.Rows[n].Cells[1].Value = this.electronica.BuscarProductoMasVendido(electronica);
            this.dgvContador.Rows[n].Cells[3].Value = this.electronica.Capital;
        }

        private void cmbCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void ActualizarLista()
        {
            

            if (electronica.Productos != null)
            {
                foreach (Producto item in this.electronica.Productos)
                {
                    if (!(this.cmbCombo.Items.Contains(item.Combo)))
                    {
                        this.cmbCombo.Items.Add(item.Combo);
                    }

                }
            }
        }

        private void cmbCombo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int n;

            n = this.dgvContador.Rows.Add();
            this.dgvContador.Rows[n].Cells[2].Value = this.electronica.PromedioPorTag(electronica, this.cmbCombo.SelectedItem.ToString());
        }
    }
}
