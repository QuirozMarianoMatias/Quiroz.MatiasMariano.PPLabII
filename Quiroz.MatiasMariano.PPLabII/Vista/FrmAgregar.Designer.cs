
namespace Vista
{
    partial class FrmAgregar
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
            this.cmbAgregar = new System.Windows.Forms.ComboBox();
            this.lblAgregar = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCombo = new System.Windows.Forms.Label();
            this.txtCombo = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblConCable = new System.Windows.Forms.Label();
            this.cmbConCable = new System.Windows.Forms.ComboBox();
            this.lblCantidadDeCooler = new System.Windows.Forms.Label();
            this.txtCantidadDeCooler = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbAgregar
            // 
            this.cmbAgregar.FormattingEnabled = true;
            this.cmbAgregar.Location = new System.Drawing.Point(44, 92);
            this.cmbAgregar.Name = "cmbAgregar";
            this.cmbAgregar.Size = new System.Drawing.Size(121, 23);
            this.cmbAgregar.TabIndex = 0;
            this.cmbAgregar.SelectedIndexChanged += new System.EventHandler(this.cmbAgregar_SelectedIndexChanged);
            // 
            // lblAgregar
            // 
            this.lblAgregar.AutoSize = true;
            this.lblAgregar.Location = new System.Drawing.Point(44, 64);
            this.lblAgregar.Name = "lblAgregar";
            this.lblAgregar.Size = new System.Drawing.Size(186, 15);
            this.lblAgregar.TabIndex = 1;
            this.lblAgregar.Text = "Seleccione componente a agregar";
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(44, 146);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 23);
            this.cmbTipo.TabIndex = 2;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(44, 128);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(30, 15);
            this.lblTipo.TabIndex = 3;
            this.lblTipo.Text = "Tipo";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(44, 199);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 23);
            this.txtId.TabIndex = 4;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(44, 181);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(17, 15);
            this.lblId.TabIndex = 5;
            this.lblId.Text = "Id";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(44, 252);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 23);
            this.txtPrecio.TabIndex = 6;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(44, 234);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 15);
            this.lblPrecio.TabIndex = 7;
            this.lblPrecio.Text = "Precio";
            // 
            // lblCombo
            // 
            this.lblCombo.AutoSize = true;
            this.lblCombo.Location = new System.Drawing.Point(44, 288);
            this.lblCombo.Name = "lblCombo";
            this.lblCombo.Size = new System.Drawing.Size(47, 15);
            this.lblCombo.TabIndex = 8;
            this.lblCombo.Text = "Combo";
            // 
            // txtCombo
            // 
            this.txtCombo.Location = new System.Drawing.Point(44, 306);
            this.txtCombo.Name = "txtCombo";
            this.txtCombo.Size = new System.Drawing.Size(100, 23);
            this.txtCombo.TabIndex = 9;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(44, 343);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(36, 15);
            this.lblStock.TabIndex = 10;
            this.lblStock.Text = "Stock";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(44, 361);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(100, 23);
            this.txtStock.TabIndex = 11;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(44, 403);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 15);
            this.lblMarca.TabIndex = 12;
            this.lblMarca.Text = "Marca";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(44, 421);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 23);
            this.txtMarca.TabIndex = 13;
            // 
            // lblConCable
            // 
            this.lblConCable.AutoSize = true;
            this.lblConCable.Location = new System.Drawing.Point(328, 64);
            this.lblConCable.Name = "lblConCable";
            this.lblConCable.Size = new System.Drawing.Size(60, 15);
            this.lblConCable.TabIndex = 14;
            this.lblConCable.Text = "Con cable";
            this.lblConCable.Visible = false;
            // 
            // cmbConCable
            // 
            this.cmbConCable.Enabled = false;
            this.cmbConCable.FormattingEnabled = true;
            this.cmbConCable.Location = new System.Drawing.Point(328, 92);
            this.cmbConCable.Name = "cmbConCable";
            this.cmbConCable.Size = new System.Drawing.Size(121, 23);
            this.cmbConCable.TabIndex = 15;
            this.cmbConCable.Visible = false;
            // 
            // lblCantidadDeCooler
            // 
            this.lblCantidadDeCooler.AutoSize = true;
            this.lblCantidadDeCooler.Location = new System.Drawing.Point(493, 64);
            this.lblCantidadDeCooler.Name = "lblCantidadDeCooler";
            this.lblCantidadDeCooler.Size = new System.Drawing.Size(107, 15);
            this.lblCantidadDeCooler.TabIndex = 16;
            this.lblCantidadDeCooler.Text = "Cantidad de cooler";
            this.lblCantidadDeCooler.Visible = false;
            // 
            // txtCantidadDeCooler
            // 
            this.txtCantidadDeCooler.Enabled = false;
            this.txtCantidadDeCooler.Location = new System.Drawing.Point(493, 92);
            this.txtCantidadDeCooler.Name = "txtCantidadDeCooler";
            this.txtCantidadDeCooler.Size = new System.Drawing.Size(100, 23);
            this.txtCantidadDeCooler.TabIndex = 17;
            this.txtCantidadDeCooler.Visible = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(493, 385);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(125, 50);
            this.btnAceptar.TabIndex = 18;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(328, 385);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(125, 50);
            this.btnVolver.TabIndex = 19;
            this.btnVolver.Text = "Volver al menu Anterior";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FrmAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 456);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtCantidadDeCooler);
            this.Controls.Add(this.lblCantidadDeCooler);
            this.Controls.Add(this.cmbConCable);
            this.Controls.Add(this.lblConCable);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.txtCombo);
            this.Controls.Add(this.lblCombo);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.lblAgregar);
            this.Controls.Add(this.cmbAgregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmAgregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAgregar";
            this.Load += new System.EventHandler(this.FrmAgregar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAgregar;
        private System.Windows.Forms.Label lblAgregar;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCombo;
        private System.Windows.Forms.TextBox txtCombo;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblConCable;
        private System.Windows.Forms.ComboBox cmbConCable;
        private System.Windows.Forms.Label lblCantidadDeCooler;
        private System.Windows.Forms.TextBox txtCantidadDeCooler;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnVolver;
    }
}