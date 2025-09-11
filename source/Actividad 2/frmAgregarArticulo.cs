using Actividad_2.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_2
{
    public partial class frmAgregarArticulo : Form
    {
        public frmAgregarArticulo()
        {
            InitializeComponent();
        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            Articulo nuevo = new Articulo();
            ArticuloRepository repository = new ArticuloRepository();

            try
            {

                nuevo.Codigo = txtCodigo.Text;
                nuevo.Nombre = txtNombre.Text;
                nuevo.Descripcion = txtDescripcion.Text;
                nuevo.Marca = (Marca)cboMarca.SelectedItem;
                nuevo.Categoria = (Categoria)cboCategoria.SelectedItem;
                nuevo.Precio = float.Parse(txtPrecio.Text);

                repository.Agregar(nuevo);
                MessageBox.Show("Agregado exitosamente");
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAgregarArticulo_Load(object sender, EventArgs e)
        {
            MarcaRepository marcaRepository = new MarcaRepository();
            CategoriaRepository categoriaRepository = new CategoriaRepository();

            try
            {
                cboMarca.DataSource = marcaRepository.Listar();
                cboMarca.DisplayMember = "Descripcion";
                cboCategoria.DataSource = categoriaRepository.Listar();
                cboCategoria.DisplayMember = "Descripcion";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
