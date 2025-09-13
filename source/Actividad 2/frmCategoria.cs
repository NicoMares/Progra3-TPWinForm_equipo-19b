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
    public partial class frmCategoria : Form
    {

        private List<Categoria> listaCategoria;
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            CategoriaRepository categoriaRepository = new CategoriaRepository();

            try
            {
                listaCategoria = categoriaRepository.Listar();
                dgvCategoria.DataSource = listaCategoria;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
        Categoria seleccion;
        seleccion = (Categoria)dgvCategoria.CurrentRow.DataBoundItem;
        frmModificarCategoria modificarCategoria = new frmModificarCategoria(seleccion);
        modificarCategoria.ShowDialog();
        cargar();

        }



    }
}
