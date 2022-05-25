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
            this.logo = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.DimGray;
            this.panelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelMenu.Controls.Add(this.btnSalir);
            this.panelMenu.Controls.Add(this.panelContenedor);
            this.panelMenu.Controls.Add(this.btnCrudVenta);
            this.panelMenu.Controls.Add(this.btnPermisos);
            this.panelMenu.Controls.Add(this.btnFiltrarVentas);
            this.panelMenu.Controls.Add(this.logo);
            this.panelMenu.Location = new System.Drawing.Point(0, 1);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 693);
            this.panelMenu.TabIndex = 0;
            // 
            // btnCrudVenta
            // 
            this.btnCrudVenta.BackColor = System.Drawing.Color.Transparent;
            this.btnCrudVenta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCrudVenta.BackgroundImage")));
            this.btnCrudVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCrudVenta.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnCrudVenta.FlatAppearance.BorderSize = 50;
            this.btnCrudVenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCrudVenta.Location = new System.Drawing.Point(47, 297);
            this.btnCrudVenta.Name = "btnCrudVenta";
            this.btnCrudVenta.Size = new System.Drawing.Size(130, 73);
            this.btnCrudVenta.TabIndex = 2;
            this.btnCrudVenta.UseVisualStyleBackColor = false;
            this.btnCrudVenta.Click += new System.EventHandler(this.btnCrudVenta_Click);
            // 
            // btnPermisos
            // 
            this.btnPermisos.BackColor = System.Drawing.Color.Transparent;
            this.btnPermisos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPermisos.BackgroundImage")));
            this.btnPermisos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPermisos.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnPermisos.FlatAppearance.BorderSize = 50;
            this.btnPermisos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPermisos.Location = new System.Drawing.Point(64, 412);
            this.btnPermisos.Name = "btnPermisos";
            this.btnPermisos.Size = new System.Drawing.Size(90, 73);
            this.btnPermisos.TabIndex = 3;
            this.btnPermisos.UseVisualStyleBackColor = false;
            this.btnPermisos.Click += new System.EventHandler(this.btnPermisos_Click);
            // 
            // btnFiltrarVentas
            // 
            this.btnFiltrarVentas.BackColor = System.Drawing.Color.Transparent;
            this.btnFiltrarVentas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFiltrarVentas.BackgroundImage")));
            this.btnFiltrarVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFiltrarVentas.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnFiltrarVentas.FlatAppearance.BorderSize = 50;
            this.btnFiltrarVentas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFiltrarVentas.Location = new System.Drawing.Point(64, 181);
            this.btnFiltrarVentas.Name = "btnFiltrarVentas";
            this.btnFiltrarVentas.Size = new System.Drawing.Size(90, 73);
            this.btnFiltrarVentas.TabIndex = 1;
            this.btnFiltrarVentas.Text = " ";
            this.btnFiltrarVentas.UseVisualStyleBackColor = false;
            this.btnFiltrarVentas.Click += new System.EventHandler(this.btnFiltrarVentas_Click);
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(14, 48);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(190, 100);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelContenedor.BackgroundImage")));
            this.panelContenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelContenedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelContenedor.Location = new System.Drawing.Point(222, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(558, 658);
            this.panelContenedor.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.Location = new System.Drawing.Point(92, 536);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(30, 30);
            this.btnSalir.TabIndex = 23;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(775, 615);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAdministrador";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Módulo Administrador";
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button btnCrudVenta;
        private System.Windows.Forms.Button btnPermisos;
        private System.Windows.Forms.Button btnFiltrarVentas;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button btnSalir;
    }
}