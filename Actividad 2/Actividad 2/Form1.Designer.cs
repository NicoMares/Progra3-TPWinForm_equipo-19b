namespace Actividad_2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lista_articulo = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lista_marca = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarMarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarMarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarMarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lista_categoria = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_campo = new System.Windows.Forms.Label();
            this.lbl_criterio = new System.Windows.Forms.Label();
            this.lbl_filtro = new System.Windows.Forms.Label();
            this.cbo_campo = new System.Windows.Forms.ComboBox();
            this.cbo_criterio = new System.Windows.Forms.ComboBox();
            this.cbo_filtro = new System.Windows.Forms.ComboBox();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_volver = new System.Windows.Forms.Button();
            this.lbl_filtrorapido = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_agregarImagen = new System.Windows.Forms.Button();
            this.btn_proximo = new System.Windows.Forms.Button();
            this.btn_anterior = new System.Windows.Forms.Button();
            this.lbl_grupo = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lista_articulo,
            this.lista_marca,
            this.lista_categoria});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            // 
            // lista_articulo
            // 
            this.lista_articulo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.modificarToolStripMenuItem});
            this.lista_articulo.Name = "lista_articulo";
            this.lista_articulo.Size = new System.Drawing.Size(61, 20);
            this.lista_articulo.Text = "Articulo";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.agregarToolStripMenuItem.Text = "Agregar";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            // 
            // lista_marca
            // 
            this.lista_marca.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarMarcaToolStripMenuItem,
            this.eliminarMarcaToolStripMenuItem,
            this.modificarMarcaToolStripMenuItem});
            this.lista_marca.Name = "lista_marca";
            this.lista_marca.Size = new System.Drawing.Size(52, 20);
            this.lista_marca.Text = "Marca";
            // 
            // agregarMarcaToolStripMenuItem
            // 
            this.agregarMarcaToolStripMenuItem.Name = "agregarMarcaToolStripMenuItem";
            this.agregarMarcaToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.agregarMarcaToolStripMenuItem.Text = "Agregar Marca";
            // 
            // eliminarMarcaToolStripMenuItem
            // 
            this.eliminarMarcaToolStripMenuItem.Name = "eliminarMarcaToolStripMenuItem";
            this.eliminarMarcaToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.eliminarMarcaToolStripMenuItem.Text = "Eliminar Marca";
            // 
            // modificarMarcaToolStripMenuItem
            // 
            this.modificarMarcaToolStripMenuItem.Name = "modificarMarcaToolStripMenuItem";
            this.modificarMarcaToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.modificarMarcaToolStripMenuItem.Text = "Modificar Marca";
            // 
            // lista_categoria
            // 
            this.lista_categoria.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarCategoriaToolStripMenuItem,
            this.eliminarCategoriaToolStripMenuItem,
            this.modificarCategoriaToolStripMenuItem});
            this.lista_categoria.Name = "lista_categoria";
            this.lista_categoria.Size = new System.Drawing.Size(70, 20);
            this.lista_categoria.Text = "Categoria";
            // 
            // agregarCategoriaToolStripMenuItem
            // 
            this.agregarCategoriaToolStripMenuItem.Name = "agregarCategoriaToolStripMenuItem";
            this.agregarCategoriaToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.agregarCategoriaToolStripMenuItem.Text = "Agregar Categoria";
            // 
            // eliminarCategoriaToolStripMenuItem
            // 
            this.eliminarCategoriaToolStripMenuItem.Name = "eliminarCategoriaToolStripMenuItem";
            this.eliminarCategoriaToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.eliminarCategoriaToolStripMenuItem.Text = "Eliminar Categoria";
            // 
            // modificarCategoriaToolStripMenuItem
            // 
            this.modificarCategoriaToolStripMenuItem.Name = "modificarCategoriaToolStripMenuItem";
            this.modificarCategoriaToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.modificarCategoriaToolStripMenuItem.Text = "Modificar Categoria";
            // 
            // lbl_campo
            // 
            this.lbl_campo.AutoSize = true;
            this.lbl_campo.Location = new System.Drawing.Point(12, 40);
            this.lbl_campo.Name = "lbl_campo";
            this.lbl_campo.Size = new System.Drawing.Size(40, 13);
            this.lbl_campo.TabIndex = 1;
            this.lbl_campo.Text = "Campo";
            this.lbl_campo.Click += new System.EventHandler(this.lbl_campo_Click);
            // 
            // lbl_criterio
            // 
            this.lbl_criterio.AutoSize = true;
            this.lbl_criterio.Location = new System.Drawing.Point(198, 43);
            this.lbl_criterio.Name = "lbl_criterio";
            this.lbl_criterio.Size = new System.Drawing.Size(39, 13);
            this.lbl_criterio.TabIndex = 2;
            this.lbl_criterio.Text = "Criterio";
            this.lbl_criterio.Click += new System.EventHandler(this.lbl_criterio_Click);
            // 
            // lbl_filtro
            // 
            this.lbl_filtro.AutoSize = true;
            this.lbl_filtro.Location = new System.Drawing.Point(412, 43);
            this.lbl_filtro.Name = "lbl_filtro";
            this.lbl_filtro.Size = new System.Drawing.Size(29, 13);
            this.lbl_filtro.TabIndex = 3;
            this.lbl_filtro.Text = "Filtro";
            this.lbl_filtro.Click += new System.EventHandler(this.lbl_filtro_Click);
            // 
            // cbo_campo
            // 
            this.cbo_campo.FormattingEnabled = true;
            this.cbo_campo.Location = new System.Drawing.Point(59, 40);
            this.cbo_campo.Name = "cbo_campo";
            this.cbo_campo.Size = new System.Drawing.Size(121, 21);
            this.cbo_campo.TabIndex = 4;
            this.cbo_campo.SelectedIndexChanged += new System.EventHandler(this.cbo_campo_SelectedIndexChanged);
            // 
            // cbo_criterio
            // 
            this.cbo_criterio.FormattingEnabled = true;
            this.cbo_criterio.Location = new System.Drawing.Point(244, 39);
            this.cbo_criterio.Name = "cbo_criterio";
            this.cbo_criterio.Size = new System.Drawing.Size(121, 21);
            this.cbo_criterio.TabIndex = 5;
            this.cbo_criterio.SelectedIndexChanged += new System.EventHandler(this.cbo_criterio_SelectedIndexChanged);
            // 
            // cbo_filtro
            // 
            this.cbo_filtro.FormattingEnabled = true;
            this.cbo_filtro.Location = new System.Drawing.Point(462, 37);
            this.cbo_filtro.Name = "cbo_filtro";
            this.cbo_filtro.Size = new System.Drawing.Size(121, 21);
            this.cbo_filtro.TabIndex = 6;
            this.cbo_filtro.SelectedIndexChanged += new System.EventHandler(this.cbo_filtro_SelectedIndexChanged);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Location = new System.Drawing.Point(15, 83);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(75, 23);
            this.btn_actualizar.TabIndex = 7;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(713, 37);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 8;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // btn_volver
            // 
            this.btn_volver.Image = global::Actividad_2.Properties.Resources.flechaRegreso;
            this.btn_volver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_volver.Location = new System.Drawing.Point(650, 89);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(75, 23);
            this.btn_volver.TabIndex = 9;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            // 
            // lbl_filtrorapido
            // 
            this.lbl_filtrorapido.AutoSize = true;
            this.lbl_filtrorapido.Location = new System.Drawing.Point(141, 93);
            this.lbl_filtrorapido.Name = "lbl_filtrorapido";
            this.lbl_filtrorapido.Size = new System.Drawing.Size(66, 13);
            this.lbl_filtrorapido.TabIndex = 10;
            this.lbl_filtrorapido.Text = "Filtro Rapido";
            this.lbl_filtrorapido.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(223, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 20);
            this.textBox1.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(284, 289);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(296, 136);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(504, 61);
            this.dataGridView2.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.Location = new System.Drawing.Point(305, 203);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(314, 221);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btn_agregarImagen
            // 
            this.btn_agregarImagen.Location = new System.Drawing.Point(692, 415);
            this.btn_agregarImagen.Name = "btn_agregarImagen";
            this.btn_agregarImagen.Size = new System.Drawing.Size(96, 23);
            this.btn_agregarImagen.TabIndex = 15;
            this.btn_agregarImagen.Text = "Agregar imagen";
            this.btn_agregarImagen.UseVisualStyleBackColor = true;
            // 
            // btn_proximo
            // 
            this.btn_proximo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_proximo.Location = new System.Drawing.Point(666, 252);
            this.btn_proximo.Name = "btn_proximo";
            this.btn_proximo.Size = new System.Drawing.Size(86, 23);
            this.btn_proximo.TabIndex = 16;
            this.btn_proximo.Text = "Proximo ";
            this.btn_proximo.UseVisualStyleBackColor = true;
            // 
            // btn_anterior
            // 
            this.btn_anterior.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_anterior.Location = new System.Drawing.Point(666, 311);
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(86, 23);
            this.btn_anterior.TabIndex = 17;
            this.btn_anterior.Text = "Anterior";
            this.btn_anterior.UseVisualStyleBackColor = true;
            // 
            // lbl_grupo
            // 
            this.lbl_grupo.AutoSize = true;
            this.lbl_grupo.Location = new System.Drawing.Point(12, 438);
            this.lbl_grupo.Name = "lbl_grupo";
            this.lbl_grupo.Size = new System.Drawing.Size(73, 13);
            this.lbl_grupo.TabIndex = 18;
            this.lbl_grupo.Text = "Grupo N° 19B";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 456);
            this.Controls.Add(this.lbl_grupo);
            this.Controls.Add(this.btn_anterior);
            this.Controls.Add(this.btn_proximo);
            this.Controls.Add(this.btn_agregarImagen);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_filtrorapido);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.cbo_filtro);
            this.Controls.Add(this.cbo_criterio);
            this.Controls.Add(this.cbo_campo);
            this.Controls.Add(this.lbl_filtro);
            this.Controls.Add(this.lbl_criterio);
            this.Controls.Add(this.lbl_campo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lista_articulo;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lista_marca;
        private System.Windows.Forms.ToolStripMenuItem lista_categoria;
        private System.Windows.Forms.ToolStripMenuItem agregarMarcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarMarcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarMarcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarCategoriaToolStripMenuItem;
        private System.Windows.Forms.Label lbl_campo;
        private System.Windows.Forms.Label lbl_criterio;
        private System.Windows.Forms.Label lbl_filtro;
        private System.Windows.Forms.ComboBox cbo_campo;
        private System.Windows.Forms.ComboBox cbo_criterio;
        private System.Windows.Forms.ComboBox cbo_filtro;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Label lbl_filtrorapido;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_agregarImagen;
        private System.Windows.Forms.Button btn_proximo;
        private System.Windows.Forms.Button btn_anterior;
        private System.Windows.Forms.Label lbl_grupo;
    }
}

