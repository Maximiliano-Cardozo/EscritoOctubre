namespace Capa_Visual
{
    partial class t
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
            this.dgvSouvenir = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblArticulo = new System.Windows.Forms.Label();
            this.txtArticulo = new System.Windows.Forms.TextBox();
            this.btnRealizarCompra = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblStock = new System.Windows.Forms.Label();
            this.Souvenir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSouvenir)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSouvenir
            // 
            this.dgvSouvenir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSouvenir.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Souvenir,
            this.Stock});
            this.dgvSouvenir.Location = new System.Drawing.Point(12, 40);
            this.dgvSouvenir.Name = "dgvSouvenir";
            this.dgvSouvenir.Size = new System.Drawing.Size(374, 137);
            this.dgvSouvenir.TabIndex = 0;
            this.dgvSouvenir.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSouvenir_CellContentClick);
            this.dgvSouvenir.SelectionChanged += new System.EventHandler(this.dgvSouvenir_SelectionChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(143, 24);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(98, 13);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Seleccione Articulo";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // lblArticulo
            // 
            this.lblArticulo.AutoSize = true;
            this.lblArticulo.Location = new System.Drawing.Point(15, 192);
            this.lblArticulo.Name = "lblArticulo";
            this.lblArticulo.Size = new System.Drawing.Size(116, 13);
            this.lblArticulo.TabIndex = 2;
            this.lblArticulo.Text = "Articulo Seleccionado :";
            // 
            // txtArticulo
            // 
            this.txtArticulo.Location = new System.Drawing.Point(131, 185);
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.ReadOnly = true;
            this.txtArticulo.Size = new System.Drawing.Size(255, 20);
            this.txtArticulo.TabIndex = 3;
            this.txtArticulo.TextChanged += new System.EventHandler(this.txtArticulo_TextChanged);
            // 
            // btnRealizarCompra
            // 
            this.btnRealizarCompra.Location = new System.Drawing.Point(131, 274);
            this.btnRealizarCompra.Name = "btnRealizarCompra";
            this.btnRealizarCompra.Size = new System.Drawing.Size(75, 23);
            this.btnRealizarCompra.TabIndex = 4;
            this.btnRealizarCompra.Text = "Realizar Compra";
            this.btnRealizarCompra.UseVisualStyleBackColor = true;
            this.btnRealizarCompra.Click += new System.EventHandler(this.btnRealizarCompra_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(131, 211);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(77, 20);
            this.txtCantidad.TabIndex = 6;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ingrese Cantidad";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(235, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(128, 247);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(0, 13);
            this.lblStock.TabIndex = 8;
            // 
            // Souvenir
            // 
            this.Souvenir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Souvenir.HeaderText = "Souvenir";
            this.Souvenir.Name = "Souvenir";
            this.Souvenir.ReadOnly = true;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.Visible = false;
            // 
            // t
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 329);
            this.ControlBox = false;
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRealizarCompra);
            this.Controls.Add(this.txtArticulo);
            this.Controls.Add(this.lblArticulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvSouvenir);
            this.Name = "t";
            this.Text = "Compra";
            this.Load += new System.EventHandler(this.t_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSouvenir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSouvenir;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblArticulo;
        private System.Windows.Forms.TextBox txtArticulo;
        private System.Windows.Forms.Button btnRealizarCompra;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Souvenir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
    }
}