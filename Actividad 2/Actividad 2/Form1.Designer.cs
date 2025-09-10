using System.Windows.Forms;

namespace Actividad_2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.panelFilters = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_campo = new System.Windows.Forms.Label();
            this.cbo_campo = new System.Windows.Forms.ComboBox();
            this.lbl_criterio = new System.Windows.Forms.Label();
            this.cbo_criterio = new System.Windows.Forms.ComboBox();
            this.lbl_filtro = new System.Windows.Forms.Label();
            this.cbo_filtro = new System.Windows.Forms.ComboBox();
            this.lbl_filtrorapido = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_volver = new System.Windows.Forms.Button();
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.tableLeft = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.panelFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.tableLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1100, 24);
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
            this.lista_articulo.Text = "Artículo";
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
            this.lista_categoria.Text = "Categoría";
            // 
            // agregarCategoriaToolStripMenuItem
            // 
            this.agregarCategoriaToolStripMenuItem.Name = "agregarCategoriaToolStripMenuItem";
            this.agregarCategoriaToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.agregarCategoriaToolStripMenuItem.Text = "Agregar Categoría";
            // 
            // eliminarCategoriaToolStripMenuItem
            // 
            this.eliminarCategoriaToolStripMenuItem.Name = "eliminarCategoriaToolStripMenuItem";
            this.eliminarCategoriaToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.eliminarCategoriaToolStripMenuItem.Text = "Eliminar Categoría";
            // 
            // modificarCategoriaToolStripMenuItem
            // 
            this.modificarCategoriaToolStripMenuItem.Name = "modificarCategoriaToolStripMenuItem";
            this.modificarCategoriaToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.modificarCategoriaToolStripMenuItem.Text = "Modificar Categoría";
            // 
            // panelFilters
            // 
            this.panelFilters.BackColor = System.Drawing.Color.White;
            this.panelFilters.Controls.Add(this.lbl_campo);
            this.panelFilters.Controls.Add(this.cbo_campo);
            this.panelFilters.Controls.Add(this.lbl_criterio);
            this.panelFilters.Controls.Add(this.cbo_criterio);
            this.panelFilters.Controls.Add(this.lbl_filtro);
            this.panelFilters.Controls.Add(this.cbo_filtro);
            this.panelFilters.Controls.Add(this.lbl_filtrorapido);
            this.panelFilters.Controls.Add(this.textBox1);
            this.panelFilters.Controls.Add(this.btn_buscar);
            this.panelFilters.Controls.Add(this.btn_actualizar);
            this.panelFilters.Controls.Add(this.btn_volver);
            this.panelFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilters.Location = new System.Drawing.Point(0, 24);
            this.panelFilters.Name = "panelFilters";
            this.panelFilters.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.panelFilters.Size = new System.Drawing.Size(1100, 56);
            this.panelFilters.TabIndex = 1;
            // 
            // lbl_campo
            // 
            this.lbl_campo.AutoSize = true;
            this.lbl_campo.Location = new System.Drawing.Point(13, 8);
            this.lbl_campo.Name = "lbl_campo";
            this.lbl_campo.Size = new System.Drawing.Size(49, 15);
            this.lbl_campo.TabIndex = 0;
            this.lbl_campo.Text = "Campo:";
            // 
            // cbo_campo
            // 
            this.cbo_campo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_campo.Location = new System.Drawing.Point(68, 11);
            this.cbo_campo.Name = "cbo_campo";
            this.cbo_campo.Size = new System.Drawing.Size(140, 23);
            this.cbo_campo.TabIndex = 1;
            // 
            // lbl_criterio
            // 
            this.lbl_criterio.AutoSize = true;
            this.lbl_criterio.Location = new System.Drawing.Point(214, 8);
            this.lbl_criterio.Name = "lbl_criterio";
            this.lbl_criterio.Size = new System.Drawing.Size(49, 15);
            this.lbl_criterio.TabIndex = 2;
            this.lbl_criterio.Text = "Criterio:";
            // 
            // cbo_criterio
            // 
            this.cbo_criterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_criterio.Location = new System.Drawing.Point(269, 11);
            this.cbo_criterio.Name = "cbo_criterio";
            this.cbo_criterio.Size = new System.Drawing.Size(160, 23);
            this.cbo_criterio.TabIndex = 3;
            // 
            // lbl_filtro
            // 
            this.lbl_filtro.AutoSize = true;
            this.lbl_filtro.Location = new System.Drawing.Point(435, 8);
            this.lbl_filtro.Name = "lbl_filtro";
            this.lbl_filtro.Size = new System.Drawing.Size(37, 15);
            this.lbl_filtro.TabIndex = 4;
            this.lbl_filtro.Text = "Filtro:";
            // 
            // cbo_filtro
            // 
            this.cbo_filtro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_filtro.Location = new System.Drawing.Point(478, 11);
            this.cbo_filtro.Name = "cbo_filtro";
            this.cbo_filtro.Size = new System.Drawing.Size(160, 23);
            this.cbo_filtro.TabIndex = 5;
            // 
            // lbl_filtrorapido
            // 
            this.lbl_filtrorapido.AutoSize = true;
            this.lbl_filtrorapido.Location = new System.Drawing.Point(644, 8);
            this.lbl_filtrorapido.Name = "lbl_filtrorapido";
            this.lbl_filtrorapido.Size = new System.Drawing.Size(98, 15);
            this.lbl_filtrorapido.TabIndex = 6;
            this.lbl_filtrorapido.Text = "Búsqueda rápida:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(748, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 23);
            this.textBox1.TabIndex = 7;
            // 
            // btn_buscar
            // 
            this.btn_buscar.AutoSize = true;
            this.btn_buscar.Location = new System.Drawing.Point(974, 11);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 25);
            this.btn_buscar.TabIndex = 8;
            this.btn_buscar.Text = "Buscar";
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.AutoSize = true;
            this.btn_actualizar.Location = new System.Drawing.Point(13, 42);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(75, 25);
            this.btn_actualizar.TabIndex = 9;
            this.btn_actualizar.Text = "Actualizar";
            // 
            // btn_volver
            // 
            this.btn_volver.AutoSize = true;
            this.btn_volver.Location = new System.Drawing.Point(94, 42);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(75, 25);
            this.btn_volver.TabIndex = 10;
            this.btn_volver.Text = "Volver";
            // 
            // splitMain
            // 
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.Location = new System.Drawing.Point(0, 80);
            this.splitMain.Name = "splitMain";
            // Panel izquierdo
            this.splitMain.Panel1.Controls.Add(this.tableLeft);
            // Panel derecho colapsado
            this.splitMain.Panel2Collapsed = true;
            this.splitMain.Size = new System.Drawing.Size(1100, 570);
            this.splitMain.SplitterDistance = 1100;
            this.splitMain.TabIndex = 2;
            // 
            // tableLeft
            // 
            this.tableLeft.ColumnCount = 1;
            this.tableLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLeft.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLeft.Controls.Add(this.dataGridView2, 0, 1);
            this.tableLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLeft.Location = new System.Drawing.Point(0, 0);
            this.tableLeft.Name = "tableLeft";
            this.tableLeft.Padding = new System.Windows.Forms.Padding(10);
            this.tableLeft.RowCount = 2;
            this.tableLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLeft.Size = new System.Drawing.Size(1100, 570);
            this.tableLeft.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1074, 406);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.Location = new System.Drawing.Point(13, 425);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(1074, 132);
            this.dataGridView2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.splitMain);
            this.Controls.Add(this.panelFilters);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catálogo - Gestión de artículos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelFilters.ResumeLayout(false);
            this.panelFilters.PerformLayout();
            this.splitMain.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.tableLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem agregarMarcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarMarcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarMarcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lista_categoria;
        private System.Windows.Forms.ToolStripMenuItem agregarCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarCategoriaToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel panelFilters;
        private System.Windows.Forms.Label lbl_campo;
        private System.Windows.Forms.Label lbl_criterio;
        private System.Windows.Forms.Label lbl_filtro;
        private System.Windows.Forms.ComboBox cbo_campo;
        private System.Windows.Forms.ComboBox cbo_criterio;
        private System.Windows.Forms.ComboBox cbo_filtro;
        private System.Windows.Forms.Label lbl_filtrorapido;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.TableLayoutPanel tableLeft;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}
