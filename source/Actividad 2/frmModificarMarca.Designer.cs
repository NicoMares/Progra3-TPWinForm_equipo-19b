namespace Actividad_2
{
    partial class frmModificarMarca
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
            this.btnModificarMarca = new System.Windows.Forms.Button();
            this.lblModificarMarca = new System.Windows.Forms.Label();
            this.txtDescripcionMarca = new System.Windows.Forms.TextBox();
            this.lblDescripcionMarca = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnModificarMarca
            // 
            this.btnModificarMarca.Location = new System.Drawing.Point(89, 145);
            this.btnModificarMarca.Name = "btnModificarMarca";
            this.btnModificarMarca.Size = new System.Drawing.Size(141, 23);
            this.btnModificarMarca.TabIndex = 2;
            this.btnModificarMarca.Text = "Guardar cambios";
            this.btnModificarMarca.UseVisualStyleBackColor = true;
            this.btnModificarMarca.Click += new System.EventHandler(this.btnModificarMarca_Click);
            // 
            // lblModificarMarca
            // 
            this.lblModificarMarca.AutoSize = true;
            this.lblModificarMarca.Location = new System.Drawing.Point(68, 75);
            this.lblModificarMarca.Name = "lblModificarMarca";
            this.lblModificarMarca.Size = new System.Drawing.Size(158, 13);
            this.lblModificarMarca.TabIndex = 7;
            this.lblModificarMarca.Text = "Ingresa los cambios de la marca";
            // 
            // txtDescripcionMarca
            // 
            this.txtDescripcionMarca.Location = new System.Drawing.Point(89, 108);
            this.txtDescripcionMarca.Name = "txtDescripcionMarca";
            this.txtDescripcionMarca.Size = new System.Drawing.Size(141, 20);
            this.txtDescripcionMarca.TabIndex = 1;
            // 
            // lblDescripcionMarca
            // 
            this.lblDescripcionMarca.AutoSize = true;
            this.lblDescripcionMarca.Location = new System.Drawing.Point(12, 111);
            this.lblDescripcionMarca.Name = "lblDescripcionMarca";
            this.lblDescripcionMarca.Size = new System.Drawing.Size(69, 13);
            this.lblDescripcionMarca.TabIndex = 11;
            this.lblDescripcionMarca.Text = "Descripcion: ";
            // 
            // frmModificarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 263);
            this.Controls.Add(this.lblDescripcionMarca);
            this.Controls.Add(this.txtDescripcionMarca);
            this.Controls.Add(this.btnModificarMarca);
            this.Controls.Add(this.lblModificarMarca);
            this.Name = "frmModificarMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmModificarMarca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModificarMarca;
        private System.Windows.Forms.Label lblModificarMarca;
        private System.Windows.Forms.TextBox txtDescripcionMarca;
        private System.Windows.Forms.Label lblDescripcionMarca;
    }
}