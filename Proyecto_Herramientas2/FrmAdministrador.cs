using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Herramientas2
{
    public partial class FrmAdministrador : Form
    {
        public FrmAdministrador()
        {
            InitializeComponent();
        }
        private void btnFiltrarVentas_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FrmFiltrarVenta());
        }

        #region Private Methods
        private void AbrirFormHijo(object formhijo)
        {
            if (panelContenedor.Controls.Count > 0)
            {
                panelContenedor.Controls.RemoveAt(0);
            }

            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(fh);
            panelContenedor.Tag = fh;
            fh.Show();
        }

        private void btnCrudVenta_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FrmVenta());
        }
       
        private void btnPermisos_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FrmPermisos());
        }
        #endregion

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Salir de la app (confirmación de salida)
            if (MessageBox.Show("¿Deseas salir?", "Confirma salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
               Application.Exit();
            }
            
        }
    }
}
