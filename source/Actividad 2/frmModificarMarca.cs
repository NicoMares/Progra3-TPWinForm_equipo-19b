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
    public partial class frmModificarMarca : Form
    {
        Marca marca = null;
        public frmModificarMarca(Marca m)
        {
            InitializeComponent();
            this.marca = m;
        }

        private void btnModificarMarca_Click(object sender, EventArgs e)
        {
            MarcaRepository marcaRepository = new MarcaRepository();
            try { 
            
                marca.Descripcion = txtDescripcionMarca.Text;

                marcaRepository.modificar(marca);
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
