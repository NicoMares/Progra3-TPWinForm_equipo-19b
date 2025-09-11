using Actividad_2.Dominio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Actividad_2
{
    public class EditArticuloForm : Form
    {
        private readonly Articulo _articulo;
        private readonly ArticuloRepository _repo = new ArticuloRepository();
        private readonly MarcaRepository _marcaRepo = new MarcaRepository();
        private readonly CategoriaRepository _catRepo = new CategoriaRepository();

        // Controles
        private TextBox txtCodigo, txtNombre, txtDescripcion, txtPrecio;
        private ComboBox cboMarca, cboCategoria;
        private Button btnGuardar, btnCancelar;

        public EditArticuloForm(Articulo articulo)
        {
            _articulo = articulo ?? throw new ArgumentNullException(nameof(articulo));
            InitializeComponent();
            Load += EditArticuloForm_Load;
        }

        private void InitializeComponent()
        {
            Text = "Modificar artículo";
            StartPosition = FormStartPosition.CenterParent;
            Font = new Font("Segoe UI", 9F);
            ClientSize = new Size(520, 320);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;

            var lblCodigo = new Label { Text = "Código", Location = new Point(20, 20), AutoSize = true };
            var lblNombre = new Label { Text = "Nombre", Location = new Point(20, 60), AutoSize = true };
            var lblDescripcion = new Label { Text = "Descripción", Location = new Point(20, 100), AutoSize = true };
            var lblPrecio = new Label { Text = "Precio", Location = new Point(20, 140), AutoSize = true };
            var lblMarca = new Label { Text = "Marca", Location = new Point(20, 180), AutoSize = true };
            var lblCategoria = new Label { Text = "Categoría", Location = new Point(20, 220), AutoSize = true };

            txtCodigo = new TextBox { Location = new Point(120, 18), Width = 360 };
            txtNombre = new TextBox { Location = new Point(120, 58), Width = 360 };
            txtDescripcion = new TextBox { Location = new Point(120, 98), Width = 360 };
            txtPrecio = new TextBox { Location = new Point(120, 138), Width = 120 };

            cboMarca = new ComboBox { Location = new Point(120, 178), Width = 240, DropDownStyle = ComboBoxStyle.DropDownList };
            cboCategoria = new ComboBox { Location = new Point(120, 218), Width = 240, DropDownStyle = ComboBoxStyle.DropDownList };

            btnGuardar = new Button { Text = "Guardar", Location = new Point(290, 260), Width = 90 };
            btnCancelar = new Button { Text = "Cancelar", Location = new Point(390, 260), Width = 90 };

            btnGuardar.Click += btnGuardar_Click;
            btnCancelar.Click += (s, e) => DialogResult = DialogResult.Cancel;

            Controls.AddRange(new Control[] {
                lblCodigo, txtCodigo,
                lblNombre, txtNombre,
                lblDescripcion, txtDescripcion,
                lblPrecio, txtPrecio,
                lblMarca, cboMarca,
                lblCategoria, cboCategoria,
                btnGuardar, btnCancelar
            });
        }

        private void EditArticuloForm_Load(object sender, EventArgs e)
        {
            // Combos
            var marcas = _marcaRepo.Listar();
            var categorias = _catRepo.Listar();

            cboMarca.DataSource = marcas;
            cboMarca.DisplayMember = "Descripcion";
            cboMarca.ValueMember = "Id";

            cboCategoria.DataSource = categorias;
            cboCategoria.DisplayMember = "Descripcion";
            cboCategoria.ValueMember = "Id";

            // Datos actuales
            txtCodigo.Text = _articulo.Codigo;
            txtNombre.Text = _articulo.Nombre;
            txtDescripcion.Text = _articulo.Descripcion;
            txtPrecio.Text = _articulo.Precio.ToString("0.##");

            // Selección inicial
            if (marcas.Any(m => m.Id == _articulo.Marca.Id))
                cboMarca.SelectedValue = _articulo.Marca.Id;
            if (categorias.Any(c => c.Id == _articulo.Categoria.Id))
                cboCategoria.SelectedValue = _articulo.Categoria.Id;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validaciones mínimas
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("El código es obligatorio.");
                txtCodigo.Focus(); return;
            }
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio.");
                txtNombre.Focus(); return;
            }
            if (!float.TryParse(txtPrecio.Text.Replace(",", "."), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out float precio))
            {
                MessageBox.Show("Precio inválido.");
                txtPrecio.Focus(); return;
            }
            if (cboMarca.SelectedItem == null || cboCategoria.SelectedItem == null)
            {
                MessageBox.Show("Seleccione marca y categoría.");
                return;
            }

            // Armar objeto actualizado
            _articulo.Codigo = txtCodigo.Text.Trim();
            _articulo.Nombre = txtNombre.Text.Trim();
            _articulo.Descripcion = txtDescripcion.Text.Trim();
            _articulo.Precio = precio;
            _articulo.Marca.Id = (int)cboMarca.SelectedValue;
            _articulo.Categoria.Id = (int)cboCategoria.SelectedValue;

            try
            {
                _repo.Actualizar(_articulo);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
