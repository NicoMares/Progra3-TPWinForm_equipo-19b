using Actividad_2.Dominio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Actividad_2
{
    public partial class Form1 : Form
    {
        private readonly ArticuloRepository repo = new ArticuloRepository();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarArticulos();
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            dataGridView1.CellClick += dataGridView1_CellClick;
            AplicarEstilosModernos();


             cbo_campo.Items.Add("Codigo");
             cbo_campo.Items.Add("Nombre");
             cbo_campo.Items.Add("Precio");

           /*  cbo_campo.Items.Add("Descripcion");
            cbo_campo.Items.Add("Marca");
           */
        }

        private void CargarArticulos()
        {
            List<Articulo> articulos = repo.Listar();
            dataGridView1.DataSource = articulos;

            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["Marca"].Visible = false;
            dataGridView1.Columns["Categoria"].Visible = false;

            if (dataGridView1.Columns["colEditar"] == null)
            {
                var colEditar = new DataGridViewImageColumn
                {
                    Name = "colEditar",
                    HeaderText = "Editar",
                    Image = Properties.Resources.edit,
                    Width = 50,
                    ImageLayout = DataGridViewImageCellLayout.Zoom
                };
                dataGridView1.Columns.Add(colEditar);
            }

            if (dataGridView1.Columns["colEliminar"] == null)
            {
                var colEliminar = new DataGridViewImageColumn
                {
                    Name = "colEliminar",
                    HeaderText = "Eliminar",
                    Image = Properties.Resources.delete, 
                    Width = 50,
                    ImageLayout = DataGridViewImageCellLayout.Zoom
                };
                dataGridView1.Columns.Add(colEliminar);
            }
        }



        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            var art = (Articulo)dataGridView1.CurrentRow.DataBoundItem;
            using (var f = new DetalleArticuloForm2(art))
                f.ShowDialog(this);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var articulo = (Articulo)dataGridView1.Rows[e.RowIndex].DataBoundItem;

            if (dataGridView1.Columns[e.ColumnIndex].Name == "colEditar")
            {
                using (var f = new EditArticuloForm(articulo))
                {
                    if (f.ShowDialog(this) == DialogResult.OK)
                        CargarArticulos();
                }
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "colEliminar")
            {
                var confirm = MessageBox.Show(
                    $"¿Seguro que querés eliminar el artículo '{articulo.Nombre}'?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        repo.Eliminar(articulo.Id);
                        CargarArticulos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo eliminar: " + ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void AplicarEstilosModernos()
        {
            this.BackColor = Color.FromArgb(245, 246, 248);
            this.Font = new Font("Segoe UI", 9F);

            menuStrip1.BackColor = Color.FromArgb(41, 128, 185);
            menuStrip1.ForeColor = Color.White;
            menuStrip1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                item.ForeColor = Color.White;
                foreach (ToolStripItem subItem in item.DropDownItems)
                {
                    subItem.BackColor = Color.White;
                    subItem.ForeColor = Color.Black;
                }
            }

            EstilizarBoton(btn_actualizar, Color.FromArgb(52, 152, 219));
            EstilizarBoton(btn_volver, Color.FromArgb(231, 76, 60));
            EstilizarBoton(btn_buscar, Color.FromArgb(39, 174, 96));

            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.EnableHeadersVisualStyles = false;

            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 128, 185);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 246, 248);
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView1.RowTemplate.Height = 28;

            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 128, 185);
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 246, 248);
        }

        private void EstilizarBoton(Button btn, Color colorFondo)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = colorFondo;
            btn.ForeColor = Color.White;
            btn.Cursor = Cursors.Hand;
            btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void agregarCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarCategoria agregarCategoria = new frmAgregarCategoria();
            agregarCategoria.ShowDialog();
        }

        private void agregarMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarMarca agregarMarca = new frmAgregarMarca();
            agregarMarca.ShowDialog();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarArticulo agregarArticulo = new frmAgregarArticulo();
            agregarArticulo.ShowDialog();
        }

        private void cbo_campo_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           string opcion =  cbo_campo.SelectedItem.ToString();


            switch (opcion)
            {
                case "Codigo":

                    cbo_criterio.Items.Clear();
                    cbo_criterio.Items.Add("Contiene");

                    break;

                case "Precio":

                    cbo_criterio.Items.Clear();
                    cbo_criterio.Items.Add("Mayor a");
                    cbo_criterio.Items.Add("Menor a");
                    cbo_criterio.Items.Add("Igual a");

                    break;

             
                case "Nombre":

                    cbo_criterio.Items.Clear();
                    cbo_criterio.Items.Add("Comienza con");
                    cbo_criterio.Items.Add("Contiene");
                    cbo_criterio.Items.Add("Termina con");

                    break;

                case "Descripcion":
                    cbo_criterio.Items.Clear();
                    cbo_criterio.Items.Add("Texto De Descripcion");

                    break;
                case "Marca":

                    cbo_criterio.Items.Clear();
                    cbo_criterio.Items.Add("Comienza con");
                    cbo_criterio.Items.Add("Contiene");
                    cbo_criterio.Items.Add("Termina con");

                    break;

                default:
                    break;
            }






















           

            
           


        }

        private void cbo_criterio_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            Articulo articulos = new Articulo();
            try
            {
                string campo = cbo_campo.SelectedItem.ToString();
                string criterio = cbo_criterio.SelectedItem.ToString();
                string buscar = txtbox_Filtro.Text;
                dataGridView1.DataSource = articulos.filtrar(campo, criterio, buscar);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }



        private void txtbox_busquedarapida_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_Filtro_TextChanged(object sender, EventArgs e)
        {

        }

        private void modificarMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMarca frmMarca = new frmMarca();
            frmMarca.ShowDialog();
        }
    }
}
