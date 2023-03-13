using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;
using System.Configuration;
using System.IO;
using System.Formats.Asn1;

namespace winform
{
    public partial class frmAltaArticulos : Form
    {
        private Articulos articulos = null;
        private OpenFileDialog archivo = null;

        public frmAltaArticulos()
        {
            InitializeComponent();
        }

        public frmAltaArticulos(Articulos articulos)
        {
            InitializeComponent();
            this.articulos = articulos;
            Text = "Modificar Pokemon";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Articulos art = new Articulos();
            NegociodeArticulos negocio = new NegociodeArticulos();
            try
            {
                if (articulos == null)
                    articulos = new Articulos();

                articulos.Codigo = txbCodigo.Text;
                articulos.Nombre = txbNombre.Text;
                articulos.Descripcion = txbDescripcion.Text;
                articulos.Marca = (Marca)cboIdMarca.SelectedItem;
                articulos.Categoria = (Categoria)cboIdCategoria.SelectedItem;
                articulos.ImagenUrl = txbImagenUrl.Text;
                validarPrecio(txbPrecio);
                articulos.Precio = Decimal.Parse(txbPrecio.Text);


                if (articulos.Id != 0)
                {
                    negocio.modificar(articulos);
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    negocio.agregar(articulos);
                    MessageBox.Show("Agregado exitosamente");
                }
                if (archivo != null && !(txbImagenUrl.Text.ToUpper().Contains("HTTP")))
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);

                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAltaArticulos_Load(object sender, EventArgs e)
        {
            NegocioMarcas negocioMarcas = new NegocioMarcas();
            NegocioCategorias negocioCategorias = new NegocioCategorias();
            try
            {
                cboIdMarca.DataSource = negocioMarcas.listar();
                cboIdMarca.ValueMember = "Id";
                cboIdMarca.DisplayMember = "Descripcion";
                cboIdCategoria.DataSource = negocioCategorias.listar();
                cboIdCategoria.ValueMember = "Id";
                cboIdCategoria.DisplayMember = "Descripcion";

                if (articulos != null)
                {
                    txbCodigo.Text = articulos.Codigo;
                    txbNombre.Text = articulos.Nombre;
                    txbDescripcion.Text = articulos.Descripcion;
                    txbImagenUrl.Text = articulos.ImagenUrl;
                    txbPrecio.Text = articulos.Precio.ToString("0");
                    cboIdMarca.SelectedValue = articulos.Marca.Id;
                    cboIdCategoria.SelectedValue = articulos.Categoria.Id;
                }
                cargarImagen(txbImagenUrl.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txbImagenUrl_Leave(object sender, EventArgs e)
        {
            cargarImagen(txbImagenUrl.Text);
        }

        public void cargarImagen(string imagen)
        {
            try
            {
                pbxAltaArticulos.Load(imagen);
                
            }
            catch (Exception ex)
            {
                pbxAltaArticulos.Load("https://wpdirecto.com/wp-content/uploads/2017/08/alt-de-una-imagen.png");
            }
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                txbImagenUrl.Text = archivo.FileName;
                cargarImagen(archivo.FileName);

                //File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);
            }
        }

        private static bool validarPrecio(TextBox caja)
        {
            try
            {

                decimal d = Convert.ToDecimal(caja.Text);
                return true;
            }
            catch (Exception ex)
            {
                caja.Text = "0";
                caja.Select(0, caja.Text.Length);
                return false;

            }
        }

        public void txbPrecio_KeyUp(object sender, KeyEventArgs e)
        {
            validarPrecio((TextBox) sender);
        }
    }
}

