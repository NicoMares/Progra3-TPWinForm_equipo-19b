namespace Actividad_2
{
    partial class DetalleArticuloForm2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Controles del diseñador
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label lblContador;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.lblContador = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DetalleArticuloForm2 (Form)
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 300);
            this.Name = "DetalleArticuloForm2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detalle de artículo";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(20, 20);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(52, 15);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 50);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 15);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(20, 80);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(75, 15);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(20, 110);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(45, 15);
            this.lblPrecio.TabIndex = 3;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(20, 140);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(44, 15);
            this.lblMarca.TabIndex = 4;
            this.lblMarca.Text = "Marca:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(20, 170);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(64, 15);
            this.lblCategoria.TabIndex = 5;
            this.lblCategoria.Text = "Categoría:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(340, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(340, 228);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(80, 25);
            this.btnAnterior.TabIndex = 7;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Location = new System.Drawing.Point(430, 233);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(35, 15);
            this.lblContador.TabIndex = 8;
            this.lblContador.Text = "0 / 0";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(520, 228);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(80, 25);
            this.btnSiguiente.TabIndex = 9;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            // 
            // Add controls
            // 
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            // 
            // Finaliza
            // 
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
