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
    public partial class FrmAdministrar : Form
    {
        private Electronica electronica;
        private FrmLogin frmLogin;
        private Usuario usuario;


        public FrmAdministrar()
        {
            InitializeComponent();
        }
        public FrmAdministrar(Electronica electronica,FrmLogin frmLogin,Usuario usuario):this()
        {

            this.electronica = electronica;
            this.frmLogin = frmLogin;
            this.usuario = usuario;



        }

        private void FrmAdministrar_Load(object sender, EventArgs e)
        {
            this.cmbFiltrar.Items.Add("todos");

            this.lblNombreApellido.Text = usuario.Nombre + " " + usuario.Apellido;

            this.cmbFiltrar.SelectedIndex = 0;

            this.ActualizarLista();
            
        }

       

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
        
            string combo = this.cmbFiltrar.SelectedItem.ToString();

            this.lstProductos.Items.Clear();

            if (combo != "todos")
            {
                
                this.CargarProducto(this.electronica.MostrarPorCombo(electronica, combo));

            }
            else
            {
                this.CargarProducto(this.electronica.Productos);
            }

        }
        /// <summary>
        /// carga los productos el listbox
        /// </summary>
        /// <param name="productos">recibe la lista a cargar</param>
        private void CargarProducto(List<Producto> productos)
        {
            this.lstProductos.Items.Clear();
            foreach (Producto item in productos)
            {
                this.lstProductos.Items.Add(item);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Producto producto = (Producto)this.lstProductos.SelectedItem;
            if (MessageBox.Show("Estas seguro de eliminar el producto?", "Eliminar", MessageBoxButtons.YesNo)== DialogResult.Yes)
            {
                this.electronica -= producto;
                MessageBox.Show("Eliminado con exito!!!", "Eliminado", MessageBoxButtons.OK);
            }


            

            CargarProducto(this.electronica.Productos);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frmAgregar = new FrmAgregar(this.electronica,this,this.usuario);
            frmAgregar.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
            if (this.electronica==(Producto)this.lstProductos.SelectedItem)
            {
                this.Hide();
                Form frmModificar = new FrmModificar((Producto)this.lstProductos.SelectedItem, this,this.usuario);
                frmModificar.Show();
            }
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.frmLogin.Show();
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtBuscar.Text);

            this.lstProductos.Items.Clear();
            if(electronica.Productos!= null)
            {
                this.CargarProducto(this.electronica.BuscarPorId(electronica, id));
            }
            
        }
        /// <summary>
        /// actualiza la lista del combobox
        /// </summary>
        public void ActualizarLista()
        {
            this.CargarProducto(this.electronica.Productos); 

            if (electronica.Productos != null)
            {
                foreach (Producto item in this.electronica.Productos)
                {
                    if (!(this.cmbFiltrar.Items.Contains(item.Combo)))
                    {
                        this.cmbFiltrar.Items.Add(item.Combo);
                    }

                }
            }
        }

        
    }
}
