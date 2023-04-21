using AppListado.BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppListado
{
    public partial class frmListadoProductos : Form
    {
        private clListadoProductos oListadoProductos = new clListadoProductos();
        public frmListadoProductos()
        {
            InitializeComponent();
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            oListadoProductos.Agregar(txtCodigo.Text, txtDescripcion.Text,txtPrecio.Text);
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtCodigo.Focus();
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            oListadoProductos.Modificar(txtCodigo.Text, txtDescripcion.Text, txtPrecio.Text);
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtCodigo.Focus();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            oListadoProductos.Eliminar(txtCodigo.Text, txtDescripcion.Text, txtPrecio.Text);
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtCodigo.Focus();
        }

        private void btImprimir_Click(object sender, EventArgs e)
        {
            lblResultado.Text = oListadoProductos.Imprimir();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            clProducto oProducto = oListadoProductos.Buscar(txtCodigo.Text);
            if (oProducto != null)
            {
                txtCodigo.Text = oProducto.Codigo;
                txtDescripcion.Text = oProducto.Descripcion;
                txtPrecio.Text = oProducto.Precio.ToString("#,##0.00");
            }
            else
            {
                lblResultado.Text = "No se encontró el producto.";
            }

        }
    }
}
