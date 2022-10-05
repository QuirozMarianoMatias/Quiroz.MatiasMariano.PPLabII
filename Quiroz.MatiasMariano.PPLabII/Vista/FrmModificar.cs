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
    public partial class FrmModificar : Form
    {
        private Producto producto;
        private FrmAdministrar frmAdministrar;
        
        public FrmModificar()
        {
            InitializeComponent();
        }
        public FrmModificar(Producto producto, FrmAdministrar frmAdministrar):this()
        {
            
            this.producto = producto;
            this.frmAdministrar = frmAdministrar;
        }
        private void FrmModificar_Load(object sender, EventArgs e)
        {

            this.cmbModificar.Items.Add("Combo");
            this.cmbModificar.Items.Add("Precio");
            this.rtfProducto.Text = this.producto.ToString();

        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.cmbModificar.SelectedItem.ToString() == "Combo")
            {
                if (MessageBox.Show("Estas seguro de modificar el Combo?", "Modificar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.producto.Combo = this.txtCombo.Text;
                }
                    

            }
            else
            {
                if (this.cmbModificar.SelectedItem.ToString() == "Precio")
                {
                    if (MessageBox.Show("Estas seguro de modificar el Precio?", "Modificar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        this.producto.Precio = float.Parse(this.txtPrecio.Text);
                    }
                }
            }
        }

        private void cmbModificar_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lblCombo.Visible = false;
            this.lblPrecio.Visible = false;
            this.txtCombo.Enabled = false;
            this.txtCombo.Visible = false;
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Visible = false;
            if (this.cmbModificar.SelectedItem.ToString() == "Combo")
            {
                this.lblCombo.Visible = true;
                this.txtCombo.Enabled = true;
                this.txtCombo.Visible = true;
            }
            else
            {
                if (this.cmbModificar.SelectedItem.ToString() == "Precio")
                {
                    this.lblPrecio.Visible = true;
                    this.txtPrecio.Enabled = true;
                    this.txtPrecio.Visible = true;
                }
            }
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.frmAdministrar.Show();
        }
    }
}
