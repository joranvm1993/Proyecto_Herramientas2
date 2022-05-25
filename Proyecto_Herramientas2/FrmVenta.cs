using AccesoDatos;
using Entidades;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Proyecto_Herramientas2
{
    
    public partial class FrmVenta : Form
    {
        int idVenta = 0;
        private MaestroDAL maestroDAL;
        private VentaDAL ventaDAL;

        public FrmVenta()
        {
            InitializeComponent();
            maestroDAL = new MaestroDAL();
            ventaDAL = new VentaDAL();
        }
        private void FrmVenta_Load(object sender, EventArgs e)
        {
            InicializaComboBoxProducto();
            InicializaComboBoxTransportadora();
            ObtenerVenta();
            btnModificarVenta.Enabled = EsAdmin();
            btnEliminar.Enabled = EsAdmin();
        }
        private void btnCrearVenta_Click(object sender, EventArgs e)
        {
            if (ValidarCamposObligatorios())
            {
                CrearVenta();
                LimpiarCampos();
                ObtenerVenta();
                MessageBox.Show("Venta creada con exito");
            }
            else
            {
                MessageBox.Show("Debe de ingresar todos los campos");
            }
        }
        private void btnModificarVenta_Click(object sender, EventArgs e)
        {
            if (ValidarCamposObligatorios())
            {
                ModificarVenta();
                LimpiarCampos();
                ObtenerVenta();
                MessageBox.Show("Venta modificada con exito");
            }
            else
            {
                MessageBox.Show("Debe de ingresar todos los campos");
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarVenta();
        }
        private void listvwVenta_ItemSelectionChanged_1(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            cbProducto.SelectedValue = int.Parse(e.Item.SubItems[7].Text);
            cbTransportadora.SelectedValue = int.Parse(e.Item.SubItems[8].Text);
            txtPrecio.Text = e.Item.SubItems[1].Text;
            txtCiudadDestino.Text = e.Item.SubItems[2].Text;
            txtCliente.Text = e.Item.SubItems[4].Text;
            txtDireccion.Text = e.Item.SubItems[5].Text;
            txtUsuarioVendedor.Text = e.Item.SubItems[6].Text;
            idVenta = int.Parse(e.Item.SubItems[9].Text);
        }

        #region Private Methods
        private void CrearVenta()
        {
            Venta venta = new Venta();
            venta.Precio = float.Parse(txtPrecio.Text.ToString());
            venta.NombreCliente = txtCliente.Text;
            venta.Direccion = txtDireccion.Text;
            venta.CiudadDestino = txtCiudadDestino.Text;
            venta.UsuarioVendedor = txtUsuarioVendedor.Text;
            venta.ProductoId = int.Parse(cbProducto.SelectedValue.ToString());
            venta.TransportadoraId = int.Parse(cbTransportadora.SelectedValue.ToString());

            ventaDAL.CrearVenta(venta);
        }
        private void ObtenerVenta()
        {
            listvwVenta.Items.Clear();
            var ListVenta = ventaDAL.ObtenerVenta();

            foreach (Venta venta in ListVenta)
            {
                ListViewItem item = new ListViewItem();
                item = listvwVenta.Items.Add(venta.Producto.Nombre);
                item.SubItems.Add(venta.Precio.ToString());
                item.SubItems.Add(venta.CiudadDestino);
                item.SubItems.Add(venta.Transportadora.Nombre);
                item.SubItems.Add(venta.NombreCliente);
                item.SubItems.Add(venta.Direccion);
                item.SubItems.Add(venta.UsuarioVendedor);
                item.SubItems.Add(venta.Producto.Id.ToString());
                item.SubItems.Add(venta.Transportadora.Id.ToString());
                item.SubItems.Add(venta.Id.ToString());
            }
        }

        private void ModificarVenta()
        {
            Venta venta = new Venta();
            venta.Id = idVenta;
            venta.Precio = float.Parse(txtPrecio.Text.ToString());
            venta.NombreCliente = txtCliente.Text;
            venta.Direccion = txtDireccion.Text;
            venta.CiudadDestino = txtCiudadDestino.Text;
            venta.UsuarioVendedor = txtUsuarioVendedor.Text;
            venta.ProductoId = int.Parse(cbProducto.SelectedValue.ToString());
            venta.TransportadoraId = int.Parse(cbTransportadora.SelectedValue.ToString());

            ventaDAL.ModificarVenta(venta);
        }
        private void EliminarVenta()
        {
            if (idVenta > 0)
            {
                var respuesta = ventaDAL.EliminarVenta(idVenta);
                ObtenerVenta();

                if (respuesta)
                {
                    LimpiarCampos();
                    MessageBox.Show("Venta eliminada con exito");
                }
            }
            else
            {
                MessageBox.Show("Seleccione la venta a eliminar");
            }
        }
        private void LimpiarCampos()
        {
            txtPrecio.Text = string.Empty;
            txtCliente.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtCiudadDestino.Text = string.Empty;
            txtUsuarioVendedor.Text = string.Empty;
            cbProducto.SelectedIndex = 0;
            cbTransportadora.SelectedIndex= 0;
            idVenta = 0;
        }
        private void InicializaComboBoxProducto()
        {
            var ListProducto = maestroDAL.ObtenerProducto();

            cbProducto.DisplayMember = "Nombre";
            cbProducto.ValueMember = "Id";
            cbProducto.DataSource = ListProducto;
        }
        private void InicializaComboBoxTransportadora()
        {
            var ListTransportadora = maestroDAL.ObtenerTransportadora();

            cbTransportadora.DisplayMember = "Nombre";
            cbTransportadora.ValueMember = "Id";
            cbTransportadora.DataSource = ListTransportadora;
        }
        private bool ValidarCamposObligatorios()
        {
            bool validarCampos = false;
            
            if (txtCiudadDestino.Text != string.Empty && txtCliente.Text != string.Empty &&
                txtPrecio.Text != string.Empty && txtUsuarioVendedor.Text != string.Empty && 
                txtDireccion.Text != string.Empty)
            {
                validarCampos = true;
            }
            return validarCampos;
        }
        private bool EsAdmin()
        {
            if (LoginInfo.Rol == "administrador")
            {
                return true;
            }
            else if (LoginInfo.Rol == "vendedor")
            {
                return false;
            }
            return false;
        }
        #endregion

        private void txtUsuarioVendedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

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
