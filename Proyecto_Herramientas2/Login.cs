using AccesoDatos;
using System;
using System.Windows.Forms;

namespace Proyecto_Herramientas2
{
    public partial class Login : Form
    {
        private LoginDAL _loginDAL;
        public Login()
        {
            _loginDAL = new LoginDAL();
            InitializeComponent();
        }
        private void lblLimpiarCampos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LimpiarCampos();
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Acceder();
        }

        #region Private methods
        private void LimpiarCampos()
        {
            txtUsuario.Clear();
            txtContrasena.Clear();
            txtUsuario.Focus();
        }
        private void Acceder()
        {
            var respuesta = _loginDAL.ObtenerCredendiales(txtUsuario.Text, txtContrasena.Text);

            if (respuesta != null)
            {
                LoginInfo.Rol = respuesta.Rol.Nombre;

                if (respuesta.Rol.Nombre == "administrador")
                {
                    FrmAdministrador frmAdministrador = new FrmAdministrador();
                    frmAdministrador.ShowDialog();
                    this.Close();
                }
                else if(respuesta.Rol.Nombre == "vendedor")
                {
                    FrmVenta frmVenta = new FrmVenta();
                    frmVenta.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Usuario y/o Contraseña incorrectas");
                LimpiarCampos();
            };
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
