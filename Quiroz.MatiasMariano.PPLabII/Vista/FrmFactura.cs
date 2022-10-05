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
    public partial class FrmFactura : Form
    {
        private Producto producto;
        private float pago;
        private float precio;
        private string metodoDePago;

        public FrmFactura()
        {
            InitializeComponent();
        }
        public FrmFactura(Producto producto,float pago,float precio,string metodoDePago) :this()
        {
            this.producto = producto;
            this.pago = pago;
            this.precio = precio;
            this.metodoDePago = metodoDePago;
        }

        private void FrmFactura_Load(object sender, EventArgs e)
        {
            this.rtfFactura.Text = this.Mostrar();
        }

        private string  Mostrar ()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Factura");
            sb.AppendLine($"producto {producto.Tipo}");
            sb.AppendLine($"metodo de pago {this.metodoDePago}");
            sb.AppendLine($"pago {this.pago}");
            sb.AppendLine($"precio {this.precio}");
            sb.AppendLine($"vuelto {this.pago - precio}");


            return sb.ToString();
        }

        public  override string ToString()
        {
            return this.Mostrar();
        }


    }
}
