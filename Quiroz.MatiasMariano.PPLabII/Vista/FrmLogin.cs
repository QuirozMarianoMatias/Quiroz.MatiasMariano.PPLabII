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
    public partial class FrmLogin : Form
    {
        private Electronica electronica;
        public FrmLogin()
        {
            electronica = new Electronica();

            //agrego usuarios
            electronica += new Usuario(1, "Pepe", "Perez", "perez21@gmail.com", "123asd", true);
            electronica += new Usuario(2, "rodrigo", "Dias", "Dias@gmail.com", "asd123");
            electronica += new Usuario(3, "carlos", "baus", "baus@gmail.com", "asd");
            electronica += new Usuario(4, "emanuel", "villegas", "villegas@gmail.com", "123");
            //agrego productos
            electronica += new Perifericos(1,1000,"logitech", true, ETipo.Teclado,"combo1",20);
            electronica += new Perifericos(2, 3000, "logitech", true, ETipo.Mouse, "combo1",15);
            electronica += new Cpu(3, 1000, "intel",1, ETipo.Procesador, "combo2",3);
            electronica += new Cpu(4, 1000, "Nvidia", 3, ETipo.PlacaDeVideo, "combo2", 5); ;




            InitializeComponent();

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            foreach (Usuario item in electronica.Usuarios)
            {
                if(Usuario.ValidarUsuario(item,this.txtEmail.Text, this.txtClave.Text))
                {
                    this.Hide();
                    this.txtClave.Clear();
                    this.txtEmail.Clear();

                    if (item.Admin)
                    {
                        FrmPrincipal principal = new FrmPrincipal(electronica,this,item);
                        principal.Show();
                        
                       
                    }
                    else
                    {
                        FrmVentas ventas = new FrmVentas(electronica,this,item); 
                        ventas.Show();
                        //ventas.FormClosing();
                        
                    }

                }

            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDuenio_Click(object sender, EventArgs e)
        {
            this.txtEmail.Text = "perez21@gmail.com";
            this.txtClave.Text = "123asd";
        }

        private void btnVendedor_Click(object sender, EventArgs e)
        {
            this.txtEmail.Text = "Dias@gmail.com";
            this.txtClave.Text = "asd123";
        }
    }
}
