
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregar));
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
            this.lblAdmin = new System.Windows.Forms.Label();
            this.lblNombreApellido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbAgregar
            // 
            this.cmbAgregar.BackColor = System.Drawing.Color.Aqua;
            this.cmbAgregar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.lblAgregar.BackColor = System.Drawing.Color.Transparent;
            this.lblAgregar.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAgregar.ForeColor = System.Drawing.Color.Aqua;
            this.lblAgregar.Location = new System.Drawing.Point(44, 64);
            this.lblAgregar.Name = "lblAgregar";
            this.lblAgregar.Size = new System.Drawing.Size(189, 19);
            this.lblAgregar.TabIndex = 1;
            this.lblAgregar.Text = "Seleccione componente a agregar";
            // 
            // cmbTipo
            // 
            this.cmbTipo.BackColor = System.Drawing.Color.Aqua;
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(44, 146);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 23);
            this.cmbTipo.TabIndex = 2;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.BackColor = System.Drawing.Color.Transparent;
            this.lblTipo.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTipo.ForeColor = System.Drawing.Color.Aqua;
            this.lblTipo.Location = new System.Drawing.Point(44, 128);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(30, 19);
            this.lblTipo.TabIndex = 3;
            this.lblTipo.Text = "Tipo";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.Aqua;
            this.txtId.Location = new System.Drawing.Point(44, 199);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 23);
            this.txtId.TabIndex = 4;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.Transparent;
            this.lblId.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblId.ForeColor = System.Drawing.Color.Aqua;
            this.lblId.Location = new System.Drawing.Point(44, 181);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 19);
            this.lblId.TabIndex = 5;
            this.lblId.Text = "Id";
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.Aqua;
            this.txtPrecio.Location = new System.Drawing.Point(44, 252);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 23);
            this.txtPrecio.TabIndex = 6;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecio.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrecio.ForeColor = System.Drawing.Color.Aqua;
            this.lblPrecio.Location = new System.Drawing.Point(44, 234);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(42, 19);
            this.lblPrecio.TabIndex = 7;
            this.lblPrecio.Text = "Precio";
            // 
            // lblCombo
            // 
            this.lblCombo.AutoSize = true;
            this.lblCombo.BackColor = System.Drawing.Color.Transparent;
            this.lblCombo.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCombo.ForeColor = System.Drawing.Color.Aqua;
            this.lblCombo.Location = new System.Drawing.Point(44, 288);
            this.lblCombo.Name = "lblCombo";
            this.lblCombo.Size = new System.Drawing.Size(42, 19);
            this.lblCombo.TabIndex = 8;
            this.lblCombo.Text = "Combo";
            // 
            // txtCombo
            // 
            this.txtCombo.BackColor = System.Drawing.Color.Aqua;
            this.txtCombo.Location = new System.Drawing.Point(44, 306);
            this.txtCombo.Name = "txtCombo";
            this.txtCombo.Size = new System.Drawing.Size(100, 23);
            this.txtCombo.TabIndex = 9;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.BackColor = System.Drawing.Color.Transparent;
            this.lblStock.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStock.ForeColor = System.Drawing.Color.Aqua;
            this.lblStock.Location = new System.Drawing.Point(44, 343);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(40, 19);
            this.lblStock.TabIndex = 10;
            this.lblStock.Text = "Stock";
            // 
            // txtStock
            // 
            this.txtStock.BackColor = System.Drawing.Color.Aqua;
            this.txtStock.Location = new System.Drawing.Point(44, 361);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(100, 23);
            this.txtStock.TabIndex = 11;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.BackColor = System.Drawing.Color.Transparent;
            this.lblMarca.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMarca.ForeColor = System.Drawing.Color.Aqua;
            this.lblMarca.Location = new System.Drawing.Point(44, 403);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(42, 19);
            this.lblMarca.TabIndex = 12;
            this.lblMarca.Text = "Marca";
            // 
            // txtMarca
            // 
            this.txtMarca.BackColor = System.Drawing.Color.Aqua;
            this.txtMarca.Location = new System.Drawing.Point(44, 421);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 23);
            this.txtMarca.TabIndex = 13;
            // 
            // lblConCable
            // 
            this.lblConCable.AutoSize = true;
            this.lblConCable.BackColor = System.Drawing.Color.Transparent;
            this.lblConCable.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblConCable.ForeColor = System.Drawing.Color.Aqua;
            this.lblConCable.Location = new System.Drawing.Point(328, 64);
            this.lblConCable.Name = "lblConCable";
            this.lblConCable.Size = new System.Drawing.Size(61, 19);
            this.lblConCable.TabIndex = 14;
            this.lblConCable.Text = "Con cable";
            this.lblConCable.Visible = false;
            // 
            // cmbConCable
            // 
            this.cmbConCable.BackColor = System.Drawing.Color.Aqua;
            this.cmbConCable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.lblCantidadDeCooler.BackColor = System.Drawing.Color.Transparent;
            this.lblCantidadDeCooler.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCantidadDeCooler.ForeColor = System.Drawing.Color.Aqua;
            this.lblCantidadDeCooler.Location = new System.Drawing.Point(493, 64);
            this.lblCantidadDeCooler.Name = "lblCantidadDeCooler";
            this.lblCantidadDeCooler.Size = new System.Drawing.Size(109, 19);
            this.lblCantidadDeCooler.TabIndex = 16;
            this.lblCantidadDeCooler.Text = "Cantidad de cooler";
            this.lblCantidadDeCooler.Visible = false;
            // 
            // txtCantidadDeCooler
            // 
            this.txtCantidadDeCooler.BackColor = System.Drawing.Color.Aqua;
            this.txtCantidadDeCooler.Enabled = false;
            this.txtCantidadDeCooler.Location = new System.Drawing.Point(493, 92);
            this.txtCantidadDeCooler.Name = "txtCantidadDeCooler";
            this.txtCantidadDeCooler.Size = new System.Drawing.Size(100, 23);
            this.txtCantidadDeCooler.TabIndex = 17;
            this.txtCantidadDeCooler.Visible = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAceptar.Location = new System.Drawing.Point(493, 385);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(125, 50);
            this.btnAceptar.TabIndex = 18;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVolver.Location = new System.Drawing.Point(328, 385);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(125, 50);
            this.btnVolver.TabIndex = 19;
            this.btnVolver.Text = "Volver al menu Anterior";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.BackColor = System.Drawing.Color.Transparent;
            this.lblAdmin.Font = new System.Drawing.Font("Bebas Neue", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAdmin.ForeColor = System.Drawing.Color.Aqua;
            this.lblAdmin.Location = new System.Drawing.Point(493, -2);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(54, 25);
            this.lblAdmin.TabIndex = 20;
            this.lblAdmin.Text = "Dueño";
            // 
            // lblNombreApellido
            // 
            this.lblNombreApellido.AutoSize = true;
            this.lblNombreApellido.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreApellido.Font = new System.Drawing.Font("Bebas Neue", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombreApellido.ForeColor = System.Drawing.Color.Aqua;
            this.lblNombreApellido.Location = new System.Drawing.Point(493, 23);
            this.lblNombreApellido.Name = "lblNombreApellido";
            this.lblNombreApellido.Size = new System.Drawing.Size(54, 25);
            this.lblNombreApellido.TabIndex = 21;
            this.lblNombreApellido.Text = "Dueño";
            // 
            // FrmAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(664, 456);
            this.Controls.Add(this.lblNombreApellido);
            this.Controls.Add(this.lblAdmin);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Label lblNombreApellido;
    }
}