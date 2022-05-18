namespace Proyecto_Herramientas2
{
    partial class FrmAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdministrador));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnCrudVenta = new System.Windows.Forms.Button();
            this.btnPermisos = new System.Windows.Forms.Button();
            this.btnFiltrarVentas = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.DimGray;
            this.panelMenu.Controls.Add(this.btnCrudVenta);
            this.panelMenu.Controls.Add(this.btnPermisos);
            this.panelMenu.Controls.Add(this.btnFiltrarVentas);
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Location = new System.Drawing.Point(0, 1);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 693);
            this.panelMenu.TabIndex = 0;
            // 
            // btnCrudVenta
            // 
            this.btnCrudVenta.Location = new System.Drawing.Point(27, 377);
            this.btnCrudVenta.Name = "btnCrudVenta";
            this.btnCrudVenta.Size = new System.Drawing.Size(152, 43);
            this.btnCrudVenta.TabIndex = 3;
            this.btnCrudVenta.Text = "Crud Ventas";
            this.btnCrudVenta.UseVisualStyleBackColor = true;
            this.btnCrudVenta.Click += new System.EventHandler(this.btnCrudVenta_Click);
            // 
            // btnPermisos
            // 
            this.btnPermisos.Location = new System.Drawing.Point(27, 481);
            this.btnPermisos.Name = "btnPermisos";
            this.btnPermisos.Size = new System.Drawing.Size(152, 43);
            this.btnPermisos.TabIndex = 2;
            this.btnPermisos.Text = "Permisos de Usuario";
            this.btnPermisos.UseVisualStyleBackColor = true;
            this.btnPermisos.Click += new System.EventHandler(this.btnPermisos_Click);
            // 
            // btnFiltrarVentas
            // 
            this.btnFiltrarVentas.Location = new System.Drawing.Point(27, 273);
            this.btnFiltrarVentas.Name = "btnFiltrarVentas";
            this.btnFiltrarVentas.Size = new System.Drawing.Size(152, 43);
            this.btnFiltrarVentas.TabIndex = 1;
            this.btnFiltrarVentas.Text = "Filtrar Ventas";
            this.btnFiltrarVentas.UseVisualStyleBackColor = true;
            this.btnFiltrarVentas.Click += new System.EventHandler(this.btnFiltrarVentas_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Location = new System.Drawing.Point(219, 1);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(845, 693);
            this.panelContenedor.TabIndex = 1;
            // 
            // FrmAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 689);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelMenu);
            this.Name = "FrmAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modulo Administrador";
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button btnCrudVenta;
        private System.Windows.Forms.Button btnPermisos;
        private System.Windows.Forms.Button btnFiltrarVentas;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}