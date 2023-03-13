using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform
{
    public partial class frmDetalle : Form
    {
        private Articulos detalle;

        public frmDetalle()
        {
            InitializeComponent();
        }

        public frmDetalle(Articulos detalle)
        {
            InitializeComponent();
            this.detalle = detalle;
        }

        private void frmDetalle_Load(object sender, EventArgs e)
        {
            NegocioMarcas negocioMarcas = new NegocioMarcas();
            NegocioCategorias negocioCategorias = new NegocioCategorias();

            try
            {
                cbxMarca.DataSource = negocioMarcas.listar();
                cbxMarca.ValueMember = "Id";
                cbxMarca.DisplayMember = "Descripcion";
                cbxIdCategoria.DataSource = negocioCategorias.listar();
                cbxIdCategoria.ValueMember = "Id";
                cbxIdCategoria.DisplayMember = "Descripcion";

                if (detalle != null)
                {
                    txbCodigo.Text = detalle.Codigo;
                    txbNombre.Text = detalle.Nombre;
                    txbDescripcion.Text = detalle.Descripcion;
                    txbImagenUrl.Text = detalle.ImagenUrl;
                    txbPrecio.Text = detalle.Precio.ToString("0");
                    cbxMarca.SelectedValue = detalle.Marca.Id;
                    cbxIdCategoria.SelectedValue = detalle.Categoria.Id;
                }

                cargarImagen(txbImagenUrl.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void cargarImagen(string imagen)
        {
            try
            {
                pbxfrmDetalle.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxfrmDetalle.Load("https://wpdirecto.com/wp-content/uploads/2017/08/alt-de-una-imagen.png");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
