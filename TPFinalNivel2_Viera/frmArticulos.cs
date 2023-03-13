using Dominio;
using Negocio;
using System.Windows.Forms;
using winform;

namespace TPFinalNivel2_Viera
{
    public partial class frmArticulos : Form

    {
        private List<Articulos> listaArticulos;

        public frmArticulos()
        {
            InitializeComponent();
        }

        private void frmArticulos_Load(object sender, EventArgs e)
        {
            cargar();
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Descripción");
            cboCampo.Items.Add("Precio");
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulos seleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.ImagenUrl);
            }
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulos.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxArticulos.Load("https://wpdirecto.com/wp-content/uploads/2017/08/alt-de-una-imagen.png");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulos alta = new frmAltaArticulos();
            alta.ShowDialog();
            cargar();
        }
        private void cargar()
        {
            NegociodeArticulos negocio = new NegociodeArticulos();
            try
            {
                listaArticulos = negocio.listar();
                dgvArticulos.DataSource = listaArticulos;
                ocultarColumnas();
                cargarImagen(listaArticulos[0].ImagenUrl);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulos seleccionado;
            seleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;

            frmAltaArticulos modificar = new frmAltaArticulos(seleccionado);
            modificar.ShowDialog();
            cargar();
            cargarImagen(seleccionado.ImagenUrl);
        }

        private void btnElimanar_Click(object sender, EventArgs e)
        {
            NegociodeArticulos negocio = new NegociodeArticulos();
            Articulos seleccionado;
            try
            {

                DialogResult respuesta = MessageBox.Show("¿De verdad querés eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.Id);
                    cargar();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();
            if (opcion == "Precio")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor A");
                cboCriterio.Items.Add("Menor A");
                cboCriterio.Items.Add("Igual A");
            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            NegociodeArticulos negocio = new NegociodeArticulos();

            try
            {
                if (validarFiltro())
                    return;

                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txbFiltro.Text;
                dgvArticulos.DataSource = negocio.filtrar(campo, criterio, filtro);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ocultarColumnas()
        {
            dgvArticulos.Columns["ImagenUrl"].Visible = false;
            dgvArticulos.Columns["Id"].Visible = false;
            dgvArticulos.Columns["Precio"].DefaultCellStyle.Format = "0,0";
        }

        private void txbFiltroRapido_TextChanged(object sender, EventArgs e)
        {
            List<Articulos> listaFiltrada;
            string filtroRapido = txbFiltroRapido.Text;
            string valueStr = filtroRapido.ToString();
            string filteredStr = valueStr.Replace(".", "");

            if (filtroRapido.Length >= 1)
            {

                listaFiltrada = listaArticulos.FindAll(x => x.Codigo.ToUpper().Contains(filtroRapido.ToUpper()) || x.Nombre.ToUpper().Contains(filtroRapido.ToUpper()) || x.Descripcion.ToUpper().Contains(filtroRapido.ToUpper()) || x.Marca.Descripcion.ToUpper().Contains(filtroRapido.ToUpper()) || x.Categoria.Descripcion.ToUpper().Contains(filtroRapido.ToUpper()) || x.Precio.ToString().Contains(filteredStr));
            }
            else
            {
                listaFiltrada = listaArticulos;
            }


            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;
            ocultarColumnas();
        }
        private bool validarFiltro()
        {
            if (cboCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el campo para filtrar ");
                return true;
            }
            if (cboCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el Criterio para filtrar ");
                return true;
            }

            if (cboCampo.SelectedItem.ToString() == "Precio")
            {
                if (string.IsNullOrEmpty(txbFiltro.Text))
                {
                    MessageBox.Show("Debes cargar el filtro para numéricos");
                    return true;
                }
                if (!(soloNumeros(txbFiltro.Text)))
                {
                    MessageBox.Show("Por favor ingresar, solo numeros para filtrar por un campo numero");
                    return true;
                }

            }

            return false;

        }

        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            Articulos selecionado;
            selecionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;

            frmDetalle detalle = new frmDetalle(selecionado);
            detalle.ShowDialog();
            cargar();
        }
    }
}