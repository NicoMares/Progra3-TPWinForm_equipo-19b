namespace Actividad_2
{
    partial class frmModificarCategoria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDescripcionCategoria = new System.Windows.Forms.Label();
            this.txtDescripcionCategoria = new System.Windows.Forms.TextBox();
            this.btnModificarCategoria = new System.Windows.Forms.Button();
            this.lblModificarCategoria = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDescripcionCategoria
            // 
            this.lblDescripcionCategoria.AutoSize = true;
            this.lblDescripcionCategoria.Location = new System.Drawing.Point(46, 121);
            this.lblDescripcionCategoria.Name = "lblDescripcionCategoria";
            this.lblDescripcionCategoria.Size = new System.Drawing.Size(69, 13);
            this.lblDescripcionCategoria.TabIndex = 15;
            this.lblDescripcionCategoria.Text = "Descripcion: ";
            // 
            // txtDescripcionCategoria
            // 
            this.txtDescripcionCategoria.Location = new System.Drawing.Point(123, 118);
            this.txtDescripcionCategoria.Name = "txtDescripcionCategoria";
            this.txtDescripcionCategoria.Size = new System.Drawing.Size(141, 20);
            this.txtDescripcionCategoria.TabIndex = 12;
            // 
            // btnModificarCategoria
            // 
            this.btnModificarCategoria.Location = new System.Drawing.Point(123, 155);
            this.btnModificarCategoria.Name = "btnModificarCategoria";
            this.btnModificarCategoria.Size = new System.Drawing.Size(141, 23);
            this.btnModificarCategoria.TabIndex = 13;
            this.btnModificarCategoria.Text = "Guardar cambios";
            this.btnModificarCategoria.UseVisualStyleBackColor = true;
            this.btnModificarCategoria.Click += new System.EventHandler(this.btnModificarCategoria_Click);
            // 
            // lblModificarCategoria
            // 
            this.lblModificarCategoria.AutoSize = true;
            this.lblModificarCategoria.Location = new System.Drawing.Point(102, 85);
            this.lblModificarCategoria.Name = "lblModificarCategoria";
            this.lblModificarCategoria.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblModificarCategoria.Size = new System.Drawing.Size(173, 13);
            this.lblModificarCategoria.TabIndex = 14;
            this.lblModificarCategoria.Text = "Ingresa los cambios de la categoria";
            // 
            // frmModificarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 263);
            this.Controls.Add(this.lblDescripcionCategoria);
            this.Controls.Add(this.txtDescripcionCategoria);
            this.Controls.Add(this.btnModificarCategoria);
            this.Controls.Add(this.lblModificarCategoria);
            this.Name = "frmModificarCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmModificarCategoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescripcionCategoria;
        private System.Windows.Forms.TextBox txtDescripcionCategoria;
        private System.Windows.Forms.Button btnModificarCategoria;
        private System.Windows.Forms.Label lblModificarCategoria;
    }
}