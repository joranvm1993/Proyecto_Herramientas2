namespace Proyecto_Herramientas2
{
    partial class FrmVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVenta));
            this.cbProducto = new System.Windows.Forms.ComboBox();
            this.cbTransportadora = new System.Windows.Forms.ComboBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCiudadDestino = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.btnCrearVenta = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUsuarioVendedor = new System.Windows.Forms.TextBox();
            this.listvwVenta = new System.Windows.Forms.ListView();
            this.Producto = new System.Windows.Forms.ColumnHeader();
            this.Precio = new System.Windows.Forms.ColumnHeader();
            this.Ciudad_Destino = new System.Windows.Forms.ColumnHeader();
            this.Transportadora = new System.Windows.Forms.ColumnHeader();
            this.Cliente = new System.Windows.Forms.ColumnHeader();
            this.Dirección = new System.Windows.Forms.ColumnHeader();
            this.Usuario = new System.Windows.Forms.ColumnHeader();
            this.btnModificarVenta = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // cbProducto
            // 
            this.cbProducto.FormattingEnabled = true;
            this.cbProducto.Location = new System.Drawing.Point(591, 88);
            this.cbProducto.Name = "cbProducto";
            this.cbProducto.Size = new System.Drawing.Size(121, 23);
            this.cbProducto.TabIndex = 4;
            // 
            // cbTransportadora
            // 
            this.cbTransportadora.FormattingEnabled = true;
            this.cbTransportadora.Location = new System.Drawing.Point(591, 163);
            this.cbTransportadora.Name = "cbTransportadora";
            this.cbTransportadora.Size = new System.Drawing.Size(121, 23);
            this.cbTransportadora.TabIndex = 6;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(591, 126);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(121, 23);
            this.txtPrecio.TabIndex = 5;
            // 
            // txtCiudadDestino
            // 
            this.txtCiudadDestino.Location = new System.Drawing.Point(591, 200);
            this.txtCiudadDestino.Name = "txtCiudadDestino";
            this.txtCiudadDestino.Size = new System.Drawing.Size(121, 23);
            this.txtCiudadDestino.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(473, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(473, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(473, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ciudad Destino";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(473, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Transportadora";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(66, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nombre Cliente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(66, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Dirección";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(199, 200);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(121, 23);
            this.txtCliente.TabIndex = 1;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(199, 237);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(121, 23);
            this.txtDireccion.TabIndex = 2;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // btnCrearVenta
            // 
            this.btnCrearVenta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCrearVenta.BackgroundImage")));
            this.btnCrearVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCrearVenta.Location = new System.Drawing.Point(515, 274);
            this.btnCrearVenta.Name = "btnCrearVenta";
            this.btnCrearVenta.Size = new System.Drawing.Size(35, 35);
            this.btnCrearVenta.TabIndex = 8;
            this.btnCrearVenta.UseVisualStyleBackColor = true;
            this.btnCrearVenta.Click += new System.EventHandler(this.btnCrearVenta_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(66, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Usuario Vendedor";
            // 
            // txtUsuarioVendedor
            // 
            this.txtUsuarioVendedor.Location = new System.Drawing.Point(199, 274);
            this.txtUsuarioVendedor.Name = "txtUsuarioVendedor";
            this.txtUsuarioVendedor.Size = new System.Drawing.Size(121, 23);
            this.txtUsuarioVendedor.TabIndex = 3;
            this.txtUsuarioVendedor.TextChanged += new System.EventHandler(this.txtUsuarioVendedor_TextChanged);
            // 
            // listvwVenta
            // 
            this.listvwVenta.BackColor = System.Drawing.Color.LightBlue;
            this.listvwVenta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Producto,
            this.Precio,
            this.Ciudad_Destino,
            this.Transportadora,
            this.Cliente,
            this.Dirección,
            this.Usuario});
            this.listvwVenta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listvwVenta.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.listvwVenta.FullRowSelect = true;
            this.listvwVenta.GridLines = true;
            this.listvwVenta.HideSelection = false;
            this.listvwVenta.Location = new System.Drawing.Point(35, 359);
            this.listvwVenta.Name = "listvwVenta";
            this.listvwVenta.Size = new System.Drawing.Size(722, 199);
            this.listvwVenta.TabIndex = 15;
            this.listvwVenta.TileSize = new System.Drawing.Size(5, 10);
            this.listvwVenta.UseCompatibleStateImageBehavior = false;
            this.listvwVenta.View = System.Windows.Forms.View.Details;
            this.listvwVenta.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listvwVenta_ItemSelectionChanged_1);
            // 
            // Producto
            // 
            this.Producto.Text = "Producto";
            this.Producto.Width = 85;
            // 
            // Precio
            // 
            this.Precio.Text = "Precio";
            this.Precio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Precio.Width = 75;
            // 
            // Ciudad_Destino
            // 
            this.Ciudad_Destino.Text = "Ciudad Destino";
            this.Ciudad_Destino.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Ciudad_Destino.Width = 115;
            // 
            // Transportadora
            // 
            this.Transportadora.Text = "Transportadora";
            this.Transportadora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Transportadora.Width = 115;
            // 
            // Cliente
            // 
            this.Cliente.Text = "Cliente";
            this.Cliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Cliente.Width = 100;
            // 
            // Dirección
            // 
            this.Dirección.Text = "Direccion";
            this.Dirección.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Dirección.Width = 100;
            // 
            // Usuario
            // 
            this.Usuario.Text = "Usuario Vendedor";
            this.Usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Usuario.Width = 125;
            // 
            // btnModificarVenta
            // 
            this.btnModificarVenta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModificarVenta.BackgroundImage")));
            this.btnModificarVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnModificarVenta.Location = new System.Drawing.Point(599, 274);
            this.btnModificarVenta.Name = "btnModificarVenta";
            this.btnModificarVenta.Size = new System.Drawing.Size(35, 35);
            this.btnModificarVenta.TabIndex = 9;
            this.btnModificarVenta.UseVisualStyleBackColor = true;
            this.btnModificarVenta.Click += new System.EventHandler(this.btnModificarVenta_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminar.Location = new System.Drawing.Point(677, 274);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(35, 35);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.Location = new System.Drawing.Point(370, 592);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(30, 30);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(87, 45);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(190, 100);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 19;
            this.logo.TabStop = false;
            // 
            // FrmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(791, 654);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificarVenta);
            this.Controls.Add(this.listvwVenta);
            this.Controls.Add(this.txtUsuarioVendedor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCrearVenta);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCiudadDestino);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.cbTransportadora);
            this.Controls.Add(this.cbProducto);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modulo Ventas";
            this.Load += new System.EventHandler(this.FrmVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbProducto;
        private System.Windows.Forms.ComboBox cbTransportadora;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCiudadDestino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Button btnCrearVenta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUsuarioVendedor;
        private System.Windows.Forms.ListView listvwVenta;
        private System.Windows.Forms.ColumnHeader Producto;
        private System.Windows.Forms.ColumnHeader Precio;
        private System.Windows.Forms.ColumnHeader Ciudad_Destino;
        private System.Windows.Forms.ColumnHeader Transportadora;
        private System.Windows.Forms.ColumnHeader Cliente;
        private System.Windows.Forms.ColumnHeader Dirección;
        private System.Windows.Forms.ColumnHeader Usuario;
        private System.Windows.Forms.Button btnModificarVenta;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox logo;
    }
}