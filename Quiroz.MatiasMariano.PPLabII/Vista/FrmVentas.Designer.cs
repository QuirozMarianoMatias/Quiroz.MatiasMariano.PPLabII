
namespace Vista
{
    partial class FrmVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVentas));
            this.lblProductos = new System.Windows.Forms.Label();
            this.lstProductos = new System.Windows.Forms.ListBox();
            this.lstVendedor = new System.Windows.Forms.ListBox();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.btnVender = new System.Windows.Forms.Button();
            this.lblMetodoDePago = new System.Windows.Forms.Label();
            this.txtMetodoDePago = new System.Windows.Forms.TextBox();
            this.lblPago = new System.Windows.Forms.Label();
            this.txtPago = new System.Windows.Forms.TextBox();
            this.dgbFactura = new System.Windows.Forms.DataGridView();
            this.Vendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MetodoDePago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vuelto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblNombreApellido = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgbFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.BackColor = System.Drawing.Color.Transparent;
            this.lblProductos.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProductos.ForeColor = System.Drawing.Color.Cyan;
            this.lblProductos.Location = new System.Drawing.Point(28, 67);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(78, 23);
            this.lblProductos.TabIndex = 0;
            this.lblProductos.Text = "Productos";
            // 
            // lstProductos
            // 
            this.lstProductos.BackColor = System.Drawing.Color.Aqua;
            this.lstProductos.FormattingEnabled = true;
            this.lstProductos.ItemHeight = 15;
            this.lstProductos.Location = new System.Drawing.Point(28, 93);
            this.lstProductos.Name = "lstProductos";
            this.lstProductos.Size = new System.Drawing.Size(435, 259);
            this.lstProductos.TabIndex = 1;
            this.lstProductos.SelectedIndexChanged += new System.EventHandler(this.lstProductos_SelectedIndexChanged);
            // 
            // lstVendedor
            // 
            this.lstVendedor.BackColor = System.Drawing.Color.Aqua;
            this.lstVendedor.FormattingEnabled = true;
            this.lstVendedor.ItemHeight = 15;
            this.lstVendedor.Location = new System.Drawing.Point(484, 93);
            this.lstVendedor.Name = "lstVendedor";
            this.lstVendedor.Size = new System.Drawing.Size(261, 259);
            this.lstVendedor.TabIndex = 2;
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.BackColor = System.Drawing.Color.Transparent;
            this.lblVendedor.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVendedor.ForeColor = System.Drawing.Color.Cyan;
            this.lblVendedor.Location = new System.Drawing.Point(484, 67);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(71, 23);
            this.lblVendedor.TabIndex = 3;
            this.lblVendedor.Text = "Vendedor";
            // 
            // btnVender
            // 
            this.btnVender.FlatAppearance.BorderSize = 0;
            this.btnVender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVender.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVender.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVender.Location = new System.Drawing.Point(484, 380);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(162, 42);
            this.btnVender.TabIndex = 4;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // lblMetodoDePago
            // 
            this.lblMetodoDePago.AutoSize = true;
            this.lblMetodoDePago.BackColor = System.Drawing.Color.Transparent;
            this.lblMetodoDePago.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMetodoDePago.ForeColor = System.Drawing.Color.Cyan;
            this.lblMetodoDePago.Location = new System.Drawing.Point(188, 358);
            this.lblMetodoDePago.Name = "lblMetodoDePago";
            this.lblMetodoDePago.Size = new System.Drawing.Size(108, 23);
            this.lblMetodoDePago.TabIndex = 5;
            this.lblMetodoDePago.Text = "Metodo de pago";
            // 
            // txtMetodoDePago
            // 
            this.txtMetodoDePago.BackColor = System.Drawing.Color.Aqua;
            this.txtMetodoDePago.Location = new System.Drawing.Point(339, 358);
            this.txtMetodoDePago.Name = "txtMetodoDePago";
            this.txtMetodoDePago.Size = new System.Drawing.Size(100, 23);
            this.txtMetodoDePago.TabIndex = 6;
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.BackColor = System.Drawing.Color.Transparent;
            this.lblPago.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPago.ForeColor = System.Drawing.Color.Cyan;
            this.lblPago.Location = new System.Drawing.Point(102, 399);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(194, 23);
            this.lblPago.TabIndex = 7;
            this.lblPago.Text = "Cantidad a pagar del cliente";
            // 
            // txtPago
            // 
            this.txtPago.BackColor = System.Drawing.Color.Aqua;
            this.txtPago.Location = new System.Drawing.Point(339, 399);
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(100, 23);
            this.txtPago.TabIndex = 8;
            // 
            // dgbFactura
            // 
            this.dgbFactura.BackgroundColor = System.Drawing.Color.Aqua;
            this.dgbFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Vendedor,
            this.Producto,
            this.Precio,
            this.Pago,
            this.MetodoDePago,
            this.Vuelto});
            this.dgbFactura.Location = new System.Drawing.Point(751, 93);
            this.dgbFactura.Name = "dgbFactura";
            this.dgbFactura.ReadOnly = true;
            this.dgbFactura.RowTemplate.Height = 25;
            this.dgbFactura.Size = new System.Drawing.Size(630, 259);
            this.dgbFactura.TabIndex = 9;
            // 
            // Vendedor
            // 
            this.Vendedor.HeaderText = "Vendedor";
            this.Vendedor.Name = "Vendedor";
            this.Vendedor.ReadOnly = true;
            // 
            // Producto
            // 
            this.Producto.FillWeight = 2000F;
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Pago
            // 
            this.Pago.HeaderText = "Pago";
            this.Pago.Name = "Pago";
            this.Pago.ReadOnly = true;
            // 
            // MetodoDePago
            // 
            this.MetodoDePago.HeaderText = "Metodo de pago";
            this.MetodoDePago.Name = "MetodoDePago";
            this.MetodoDePago.ReadOnly = true;
            // 
            // Vuelto
            // 
            this.Vuelto.HeaderText = "Vuelto";
            this.Vuelto.Name = "Vuelto";
            this.Vuelto.ReadOnly = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCerrar.Location = new System.Drawing.Point(1122, 380);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(162, 42);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.Text = "Cerrar Sesision";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Bebas Neue", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsuario.ForeColor = System.Drawing.Color.Aqua;
            this.lblUsuario.Location = new System.Drawing.Point(1205, 13);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(37, 25);
            this.lblUsuario.TabIndex = 11;
            this.lblUsuario.Text = "asd";
            // 
            // lblNombreApellido
            // 
            this.lblNombreApellido.AutoSize = true;
            this.lblNombreApellido.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreApellido.Font = new System.Drawing.Font("Bebas Neue", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombreApellido.ForeColor = System.Drawing.Color.Aqua;
            this.lblNombreApellido.Location = new System.Drawing.Point(1205, 38);
            this.lblNombreApellido.Name = "lblNombreApellido";
            this.lblNombreApellido.Size = new System.Drawing.Size(37, 25);
            this.lblNombreApellido.TabIndex = 12;
            this.lblNombreApellido.Text = "asd";
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.Properties.Resources.BackGround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1393, 463);
            this.Controls.Add(this.lblNombreApellido);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgbFactura);
            this.Controls.Add(this.txtPago);
            this.Controls.Add(this.lblPago);
            this.Controls.Add(this.txtMetodoDePago);
            this.Controls.Add(this.lblMetodoDePago);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.lblVendedor);
            this.Controls.Add(this.lstVendedor);
            this.Controls.Add(this.lstProductos);
            this.Controls.Add(this.lblProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVentas";
            this.Load += new System.EventHandler(this.FrmVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgbFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.ListBox lstProductos;
        private System.Windows.Forms.ListBox lstVendedor;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Label lblMetodoDePago;
        private System.Windows.Forms.TextBox txtMetodoDePago;
        private System.Windows.Forms.Label lblPago;
        private System.Windows.Forms.TextBox txtPago;
        private System.Windows.Forms.DataGridView dgbFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn MetodoDePago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vuelto;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblNombreApellido;
    }
}