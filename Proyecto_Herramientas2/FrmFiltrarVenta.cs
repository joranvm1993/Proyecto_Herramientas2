using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Proyecto_Herramientas2
{
    public partial class FrmFiltrarVenta : Form
    {
        MaestroDAL maestroDAL;
        VentaDAL ventaDAL;
        public FrmFiltrarVenta()
        {
            maestroDAL = new MaestroDAL();
            ventaDAL = new VentaDAL();
            
            InitializeComponent();
        }
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (FiltrarVentas().Count > 0)
            {
                FiltrarVentas();
            }
            else
            {
                MessageBox.Show("No se encontraron ventas para este vendedor");
            }
        }
        #region Private Methods
        public List<Venta> FiltrarVentas()
        {
            List<Venta> listVentaFiltradas = new List<Venta>();
            
            var listVentas = ventaDAL.ObtenerVenta();

            listVentaFiltradas= listVentas.Where(venta => venta.UsuarioVendedor == txtUsuarioVendedor.Text).ToList();

            lstvwFiltrarVenta.Items.Clear();
            
            foreach (var i in listVentaFiltradas)
            {
                ListViewItem item = new ListViewItem();
                item = lstvwFiltrarVenta.Items.Add(i.Producto.Nombre);
                item.SubItems.Add(i.Precio.ToString());
                item.SubItems.Add(i.Transportadora.Nombre);
                item.SubItems.Add(i.NombreCliente);
                item.SubItems.Add(i.CiudadDestino);
            }
            return listVentaFiltradas;
        }
        #endregion
    }
}
