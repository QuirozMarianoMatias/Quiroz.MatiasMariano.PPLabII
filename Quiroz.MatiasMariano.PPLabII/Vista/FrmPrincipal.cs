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

    public partial class FrmPrincipal : Form
    {
        private Electronica electronica;
        private FrmLogin frmLogin;
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        public FrmPrincipal(Electronica electronica, FrmLogin frmLogin) :this()
        {
            this.electronica = electronica;
            this.frmLogin = frmLogin;
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frmVentas = new FrmVentas(this.electronica,frmLogin);
            frmVentas.Show();

        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frmAdministrar = new FrmAdministrar(this.electronica,this.frmLogin);
            frmAdministrar.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.frmLogin.Show();
            this.Close();
        }
    }
}
