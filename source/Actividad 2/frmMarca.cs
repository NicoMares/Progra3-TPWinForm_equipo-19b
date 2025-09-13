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
    public partial class frmMarca : Form
    {
        private List<Marca> listaMarca;
        public frmMarca()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void frmMarca_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            MarcaRepository marcaRepository = new MarcaRepository();

            try
            {
                listaMarca = marcaRepository.Listar();
                dgvMarca.DataSource = listaMarca;
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Marca seleccion;
            seleccion = (Marca)dgvMarca.CurrentRow.DataBoundItem;
            frmModificarMarca modificarMarca = new frmModificarMarca(seleccion);
            modificarMarca.ShowDialog();
            cargar();
        }
    }
}
