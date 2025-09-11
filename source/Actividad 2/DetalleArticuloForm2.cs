using Actividad_2.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Actividad_2
{
    public partial class DetalleArticuloForm2 : Form
    {
        private readonly Articulo _articulo;
        private readonly ImagenRepository _imgRepo = new ImagenRepository();

        private List<Imagen> _imagenes = new List<Imagen>();
        private int _index = 0;

        public DetalleArticuloForm2(Articulo articulo)
        {
            InitializeComponent();
            _articulo = articulo ?? throw new ArgumentNullException(nameof(articulo));
            Load += DetalleArticuloForm2_Load;
            btnAnterior.Click += btnAnterior_Click;
            btnSiguiente.Click += btnSiguiente_Click;
        }

        private void DetalleArticuloForm2_Load(object sender, EventArgs e)
        {
            lblCodigo.Text = "Código: " + _articulo.Codigo;
            lblNombre.Text = "Nombre: " + _articulo.Nombre;
            lblDescripcion.Text = "Descripción: " + _articulo.Descripcion;
            lblPrecio.Text = "Precio: " + _articulo.Precio.ToString("0.##");
            lblMarca.Text = "Id Marca: " + _articulo.IdMarca;
            lblCategoria.Text = "Id Categoría: " + _articulo.IdCategoria;

             
            _imagenes = _imgRepo.ListarPorArticulo(_articulo.Id);
            _index = 0;
            MostrarImagenActual();
        }

        private void MostrarImagenActual()
        {
            if (_imagenes == null || _imagenes.Count == 0)
            {
                pictureBox1.Image = null;
                lblContador.Text = "Sin imágenes";
                btnAnterior.Enabled = btnSiguiente.Enabled = false;
                return;
            }

            if (_index < 0) _index = _imagenes.Count - 1;
            if (_index >= _imagenes.Count) _index = 0;

            var url = _imagenes[_index].ImagenURL;
            try
            {
                if (!string.IsNullOrWhiteSpace(url))
                {
                    pictureBox1.WaitOnLoad = false;
                    pictureBox1.LoadAsync(url);
                }
                else
                {
                    pictureBox1.Image = null;
                }
            }
            catch
            {
                pictureBox1.Image = null;
            }

            lblContador.Text = $"{_index + 1} / {_imagenes.Count}";
            btnAnterior.Enabled = _imagenes.Count > 1;
            btnSiguiente.Enabled = _imagenes.Count > 1;
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            _index--;
            MostrarImagenActual();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            _index++;
            MostrarImagenActual();
        }
    }
}
