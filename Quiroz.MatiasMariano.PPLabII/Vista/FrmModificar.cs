﻿using System;
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
        private Usuario usuario;
        
        public FrmModificar()
        {
            InitializeComponent();
        }
        public FrmModificar(Producto producto, FrmAdministrar frmAdministrar,Usuario usuario):this()
        {
            
            this.producto = producto;
            this.frmAdministrar = frmAdministrar;
            this.usuario = usuario;
        }
        private void FrmModificar_Load(object sender, EventArgs e)
        {
            this.lblNombreApellido.Text = usuario.Nombre + " " + usuario.Apellido;
            this.cmbModificar.Items.Add("Combo");
            this.cmbModificar.Items.Add("Precio");
            this.cmbModificar.Items.Add("Stock");
            this.rtfProducto.Text = this.producto.ToString();

        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.cmbModificar.SelectedItem.ToString() == "Combo")
            {
                if (MessageBox.Show("Estas seguro de modificar el Combo?", "Modificar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.producto.Combo = this.txtCombo.Text;
                    MessageBox.Show("Modificado con exito", "Modificar", MessageBoxButtons.OK);
                }
                    

            }
            else
            {
                if (this.cmbModificar.SelectedItem.ToString() == "Precio")
                {
                    if (MessageBox.Show("Estas seguro de modificar el Precio?", "Modificar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        this.producto.Precio = float.Parse(this.txtPrecio.Text);
                        MessageBox.Show("Modificado con exito", "Modificar", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    if(MessageBox.Show("El stock se sumara al existente esta seguro?", "Modificar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        this.producto.Stock += int.Parse(this.txtStock.Text);
                        MessageBox.Show("Modificado con exito", "Modificar", MessageBoxButtons.OK);
                    }
                    
                }
            }
            
            this.rtfProducto.Text = this.producto.ToString();
            frmAdministrar.ActualizarLista();

        }

        private void cmbModificar_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lblCombo.Visible = false;
            this.lblPrecio.Visible = false;
            this.txtCombo.Enabled = false;
            this.txtCombo.Visible = false;
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Visible = false;
            this.lblStock.Visible = false;
            this.txtStock.Enabled = false;
            this.txtStock.Visible = false;

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
                else
                {
                    if((this.cmbModificar.SelectedItem.ToString() == "Stock"))
                    {
                        this.lblStock.Visible = true;
                        this.txtStock.Enabled = true;
                        this.txtStock.Visible = true;
                    }
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
