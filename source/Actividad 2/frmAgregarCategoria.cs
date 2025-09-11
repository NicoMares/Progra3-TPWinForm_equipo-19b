using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_2.Dominio
{
    public partial class frmAgregarCategoria : Form
    {
        public frmAgregarCategoria()
        {
            InitializeComponent();
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            Categoria nuevaCategoria = new Categoria();
            CategoriaRepository repository = new CategoriaRepository();

            try
            {
                nuevaCategoria.Descripcion = txtAgregarCategoria.Text;
                repository.agregarCategoria(nuevaCategoria);
                MessageBox.Show("Agregado exitosamente");
                Close();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
