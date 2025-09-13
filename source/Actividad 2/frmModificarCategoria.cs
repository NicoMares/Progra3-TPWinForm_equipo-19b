using Actividad_2.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_2
{
    public partial class frmModificarCategoria : Form
    {
        Categoria categoria = null;
        public frmModificarCategoria(Categoria c)
        {
            InitializeComponent();
            this.categoria = c;
        }

        private void btnModificarCategoria_Click(object sender, EventArgs e)
        {
            CategoriaRepository categoriaRepository = new CategoriaRepository();
            try
            {

                categoria.Descripcion = txtDescripcionCategoria.Text;

                categoriaRepository.modificar(categoria);
                MessageBox.Show("Modificado exitosamente");
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString()); ;
            }
        }
    }
}
