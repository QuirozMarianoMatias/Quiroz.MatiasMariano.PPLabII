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
    public partial class FrmVentas : Form
    {
        private Electronica electronica;
        private FrmLogin frmLogin;
        public FrmVentas()
        {
            InitializeComponent();
        }

        public FrmVentas(Electronica electronica, FrmLogin frmLogin) :this()
        {
            this.electronica = electronica;
            this.frmLogin = frmLogin;

        }
        public new void FormClosing()
        {
            this.Close();
        }

        

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            this.CargarProducto();
            this.CargarVendedor();
        }

        private void lstProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void CargarProducto()
        {
            this.lstProductos.Items.Clear();
            foreach (Producto item in electronica.Productos)
            {
              this.lstProductos.Items.Add(item);
            }
        }

        private void CargarVendedor()
        {

            foreach (Usuario item in electronica.Usuarios)
            {
               this.lstVendedor.Items.Add(item);
            }
        }

        private void reset()
        {
            this.lstProductos.Items.Clear();
            this.CargarProducto();
            this.lstVendedor.Items.Clear();
            this.CargarVendedor();
            this.txtMetodoDePago.Clear();
            this.txtPago.Clear();

        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            Usuario usuario = (Usuario)this.lstVendedor.SelectedItem;
            Producto producto = (Producto)this.lstProductos.SelectedItem;
            float pago = float.Parse(this.txtPago.Text);

            if (electronica.VenderProducto(electronica,producto,pago, this.txtMetodoDePago.Text) && usuario != null)
            {
                int n;

                n = this.dgbFactura.Rows.Add();

                this.dgbFactura.Rows[n].Cells[0].Value = usuario.Apellido;
                this.dgbFactura.Rows[n].Cells[1].Value = producto.Tipo;
                
                this.dgbFactura.Rows[n].Cells[3].Value = pago;
                this.dgbFactura.Rows[n].Cells[4].Value = this.txtMetodoDePago.Text;
                if(this.txtMetodoDePago.Text == "Credito")
                {
                    this.dgbFactura.Rows[n].Cells[5].Value = pago - Calculos.AplicarAumento(producto.Precio);
                    this.dgbFactura.Rows[n].Cells[2].Value =  Calculos.AplicarAumento(producto.Precio);
                }
                else
                {
                    this.dgbFactura.Rows[n].Cells[5].Value = pago - producto.Precio;
                    this.dgbFactura.Rows[n].Cells[2].Value = producto.Precio;
                }
                
                this.reset();

            }
            else
            {
                MessageBox.Show("recibe que los campos esten correctos!!!", "Error", MessageBoxButtons.OK);
            }




        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.frmLogin.Show();
            this.Close();
        }
    }
}