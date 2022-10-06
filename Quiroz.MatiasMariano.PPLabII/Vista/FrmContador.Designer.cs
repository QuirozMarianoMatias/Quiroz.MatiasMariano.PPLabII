
namespace Vista
{
    partial class FrmContador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContador));
            this.dgvContador = new System.Windows.Forms.DataGridView();
            this.VentasTotales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductoMasVendido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PromedioPorTag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GananciaTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbCombo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContador)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvContador
            // 
            this.dgvContador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContador.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VentasTotales,
            this.ProductoMasVendido,
            this.PromedioPorTag,
            this.GananciaTotal});
            this.dgvContador.Location = new System.Drawing.Point(12, 116);
            this.dgvContador.Name = "dgvContador";
            this.dgvContador.RowTemplate.Height = 25;
            this.dgvContador.Size = new System.Drawing.Size(1251, 288);
            this.dgvContador.TabIndex = 0;
            // 
            // VentasTotales
            // 
            this.VentasTotales.HeaderText = "Ventas Totales";
            this.VentasTotales.Name = "VentasTotales";
            // 
            // ProductoMasVendido
            // 
            this.ProductoMasVendido.HeaderText = "Producto Mas Vendido";
            this.ProductoMasVendido.Name = "ProductoMasVendido";
            // 
            // PromedioPorTag
            // 
            this.PromedioPorTag.HeaderText = "Promedio Por Tag";
            this.PromedioPorTag.Name = "PromedioPorTag";
            // 
            // GananciaTotal
            // 
            this.GananciaTotal.HeaderText = "Ganancia Total";
            this.GananciaTotal.Name = "GananciaTotal";
            // 
            // cmbCombo
            // 
            this.cmbCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCombo.FormattingEnabled = true;
            this.cmbCombo.Location = new System.Drawing.Point(12, 53);
            this.cmbCombo.Name = "cmbCombo";
            this.cmbCombo.Size = new System.Drawing.Size(121, 23);
            this.cmbCombo.TabIndex = 1;
            this.cmbCombo.SelectedIndexChanged += new System.EventHandler(this.cmbCombo_SelectedIndexChanged_1);
            // 
            // FrmContador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 476);
            this.Controls.Add(this.cmbCombo);
            this.Controls.Add(this.dgvContador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmContador";
            this.Text = "FrmContador";
            this.Load += new System.EventHandler(this.FrmContador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvContador;
        private System.Windows.Forms.DataGridViewTextBoxColumn VentasTotales;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductoMasVendido;
        private System.Windows.Forms.DataGridViewTextBoxColumn PromedioPorTag;
        private System.Windows.Forms.DataGridViewTextBoxColumn GananciaTotal;
        private System.Windows.Forms.ComboBox cmbCombo;
    }
}