namespace Capa_Visual
{
    partial class frmPrincipal
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
            this.btnSouvenir = new System.Windows.Forms.Button();
            this.btnCompra = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSouvenir
            // 
            this.btnSouvenir.Location = new System.Drawing.Point(112, 97);
            this.btnSouvenir.Name = "btnSouvenir";
            this.btnSouvenir.Size = new System.Drawing.Size(137, 71);
            this.btnSouvenir.TabIndex = 0;
            this.btnSouvenir.Text = "Souvenir";
            this.btnSouvenir.UseVisualStyleBackColor = true;
            this.btnSouvenir.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnCompra
            // 
            this.btnCompra.Location = new System.Drawing.Point(434, 97);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Size = new System.Drawing.Size(152, 71);
            this.btnCompra.TabIndex = 1;
            this.btnCompra.Text = "Realizar Compras";
            this.btnCompra.UseVisualStyleBackColor = true;
            this.btnCompra.Click += new System.EventHandler(this.btnCompra_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(299, 306);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 412);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCompra);
            this.Controls.Add(this.btnSouvenir);
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSouvenir;
        private System.Windows.Forms.Button btnCompra;
        private System.Windows.Forms.Button btnSalir;
    }
}