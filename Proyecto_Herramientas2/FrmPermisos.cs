using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Herramientas2
{
    public partial class FrmPermisos : Form
    { 
        private MaestroDAL maestroDAL;
        private PermisoDAL permisoDAL;
        public FrmPermisos()
        {
            maestroDAL = new MaestroDAL();
            permisoDAL= new PermisoDAL();
            InitializeComponent();
        }
        private void FrmPermisos_Load(object sender, EventArgs e)
        {
            LlenarComboBoxRol();
        }
        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            if (ConfirmarContrasena())
            {
                if (ValidarUsuario())
                {
                    CrearUsuario();
                    LimpiarCampos();
                    MessageBox.Show("Usuario creado con exito");
                }
                else
                {
                    MessageBox.Show("Este usuario ya existe");
                    LimpiarCampos();
                }
            }
            else
            {
                MessageBox.Show("Confirme la contraseña!");
            };
        }

        #region Private Methods
        private void LlenarComboBoxRol()
        {
            var ListRol = maestroDAL.ObtenerRol();
            
            cbRol.DisplayMember = "Nombre";
            cbRol.ValueMember = "Id";
            cbRol.DataSource = ListRol;
        }
        private void LimpiarCampos()
        {
            txtNombre.Text = String.Empty;
            txtUsuario.Text = String.Empty;
            txtContrasena.Text = String.Empty;
            txtConfrimar.Text = String.Empty;
        }
        private bool ConfirmarContrasena()
        {
            bool result = false;

            if (txtContrasena.Text == txtConfrimar.Text)
            {
                result = true;
            }

            return result;
        }
        private void CrearUsuario()
        {
            Usuario usuario = new Usuario();

            usuario.Nombre = txtNombre.Text;
            usuario.User = txtUsuario.Text;
            usuario.Contrasena = txtContrasena.Text;
            usuario.Rol_Id= int.Parse(cbRol.SelectedValue.ToString());

            permisoDAL.CrearUsuario(usuario);
        }

        private bool ValidarUsuario()
        {
            var listUsuario = permisoDAL.ObtnenerUsuario();
            
            bool result = true;

            foreach (var i in listUsuario)
            {
                if (i.User == txtUsuario.Text)
                {
                    result = false;
                }
            }
            return result;
        }
        #endregion
    }
}
