namespace Proyecto_Herramientas2
{
    partial class FrmFiltrarVenta
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.lstvwFiltrarVenta = new System.Windows.Forms.ListView();
            this.Producto = new System.Windows.Forms.ColumnHeader();
            this.Precio = new System.Windows.Forms.ColumnHeader();
            this.Transportadora = new System.Windows.Forms.ColumnHeader();
            this.Cliente = new System.Windows.Forms.ColumnHeader();
            this.Direccion = new System.Windows.Forms.ColumnHeader();
            this.txtUsuarioVendedor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese Usuario Vendedor.";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(554, 174);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(117, 35);
            this.btnFiltrar.TabIndex = 2;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // lstvwFiltrarVenta
            // 
            this.lstvwFiltrarVenta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Producto,
            this.Precio,
            this.Transportadora,
            this.Cliente,
            this.Direccion});
            this.lstvwFiltrarVenta.GridLines = true;
            this.lstvwFiltrarVenta.HideSelection = false;
            this.lstvwFiltrarVenta.Location = new System.Drawing.Point(165, 281);
            this.lstvwFiltrarVenta.Name = "lstvwFiltrarVenta";
            this.lstvwFiltrarVenta.Size = new System.Drawing.Size(506, 130);
            this.lstvwFiltrarVenta.TabIndex = 3;
            this.lstvwFiltrarVenta.UseCompatibleStateImageBehavior = false;
            this.lstvwFiltrarVenta.View = System.Windows.Forms.View.Details;
            // 
            // Producto
            // 
            this.Producto.Text = "Producto";
            this.Producto.Width = 100;
            // 
            // Precio
            // 
            this.Precio.Text = "Precio";
            this.Precio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Precio.Width = 100;
            // 
            // Transportadora
            // 
            this.Transportadora.Text = "Transportadora";
            this.Transportadora.Width = 100;
            // 
            // Cliente
            // 
            this.Cliente.Text = "Cliente";
            this.Cliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Cliente.Width = 100;
            // 
            // Direccion
            // 
            this.Direccion.Text = "Ciudad Destino";
            this.Direccion.Width = 100;
            // 
            // txtUsuarioVendedor
            // 
            this.txtUsuarioVendedor.Location = new System.Drawing.Point(464, 73);
            this.txtUsuarioVendedor.Name = "txtUsuarioVendedor";
            this.txtUsuarioVendedor.Size = new System.Drawing.Size(182, 23);
            this.txtUsuarioVendedor.TabIndex = 4;
            // 
            // FrmFiltrarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 636);
            this.Controls.Add(this.txtUsuarioVendedor);
            this.Controls.Add(this.lstvwFiltrarVenta);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFiltrarVenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.ListView lstvwFiltrarVenta;
        private System.Windows.Forms.ColumnHeader Producto;
        private System.Windows.Forms.ColumnHeader Precio;
        private System.Windows.Forms.ColumnHeader Transportadora;
        private System.Windows.Forms.ColumnHeader Cliente;
        private System.Windows.Forms.ColumnHeader Direccion;
        private System.Windows.Forms.TextBox txtUsuarioVendedor;
    }
}