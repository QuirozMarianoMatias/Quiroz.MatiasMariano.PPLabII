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
    public partial class FrmAgregar : Form
    {
        private Electronica electronica;
        private FrmAdministrar FrmAdministrar;
        private Usuario usuario;
        public FrmAgregar()
        {
            InitializeComponent();
        }

        public FrmAgregar(Electronica electronica, FrmAdministrar frmAdministrar,Usuario usuario) : this()
        {
            this.electronica = electronica;
            this.FrmAdministrar = frmAdministrar;
            this.usuario = usuario;

        }

        private void FrmAgregar_Load(object sender, EventArgs e)
        {
            this.cmbAgregar.Items.Add(typeof(Perifericos).Name);
            this.cmbAgregar.Items.Add(typeof(Cpu).Name);
            this.lblNombreApellido.Text = this.lblNombreApellido.Text = usuario.Nombre + " " + usuario.Apellido;



        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(this.cmbAgregar.SelectedItem != null)
            {
                if (this.cmbAgregar.SelectedItem.ToString() == typeof(Perifericos).Name)
                {


                    int id = int.Parse(this.txtId.Text);
                    float precio = float.Parse(this.txtPrecio.Text);
                    string marca = this.txtMarca.Text;
                    bool conCable = false;
                    ETipo tipo = (ETipo)this.cmbTipo.SelectedItem;
                    string combo = this.txtCombo.Text;
                    int stock = int.Parse(this.txtStock.Text);



                    if (cmbConCable.SelectedItem.ToString() == "si")
                    {
                        conCable = true;
                    }



                    Perifericos perifericos = new(id, precio, marca, conCable, tipo, combo, stock);
                    if (perifericos != null)
                    {
                        electronica += perifericos;
                    }

                }

                if (this.cmbAgregar.SelectedItem.ToString() == typeof(Cpu).Name)
                {


                    int id = int.Parse(this.txtId.Text);
                    float precio = float.Parse(this.txtPrecio.Text);
                    string marca = this.txtMarca.Text;
                    int cantidadDeCooler = int.Parse(this.txtCantidadDeCooler.Text);
                    ETipo tipo = (ETipo)this.cmbTipo.SelectedItem;
                    string combo = this.txtCombo.Text;
                    int stock = int.Parse(this.txtStock.Text);


                    Cpu cpu = new(id, precio, marca, cantidadDeCooler, tipo, combo, stock);

                    electronica += cpu;
                }
                MessageBox.Show("Agregado con exito", "Agregar", MessageBoxButtons.OK);
                FrmAdministrar.ActualizarLista();
            }
            
           

        }

        private void cmbAgregar_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lblConCable.Visible = false;
            this.cmbConCable.Visible = false;
            this.cmbConCable.Enabled = false;
            this.lblCantidadDeCooler.Visible = false;
            this.txtCantidadDeCooler.Visible = false;
            this.txtCantidadDeCooler.Enabled = false;
            this.cmbTipo.Items.Clear();

            if (this.cmbAgregar.SelectedItem.ToString() == typeof(Perifericos).Name)
            {
                this.lblConCable.Visible = true;
                this.cmbConCable.Visible = true;
                this.cmbConCable.Enabled = true;

                this.cmbConCable.Items.Add("si");
                this.cmbConCable.Items.Add("no");

                this.cmbTipo.Items.Add(ETipo.Auriculares);
                this.cmbTipo.Items.Add(ETipo.Mouse);
                this.cmbTipo.Items.Add(ETipo.Teclado);



            }
            if (this.cmbAgregar.SelectedItem.ToString() == typeof(Cpu).Name)
            {
                this.lblCantidadDeCooler.Visible = true;
                this.txtCantidadDeCooler.Visible = true;
                this.txtCantidadDeCooler.Enabled = true;
                this.cmbTipo.Items.Add(ETipo.Procesador);
                this.cmbTipo.Items.Add(ETipo.PlacaDeVideo);
                
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.FrmAdministrar.Show();
            this.Close();
            
            
        }
    }
}
