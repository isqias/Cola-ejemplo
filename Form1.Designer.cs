namespace Actividad_3
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
            this.lstDatosS = new System.Windows.Forms.ListBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnVaciar = new System.Windows.Forms.Button();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstDatosS
            // 
            this.lstDatosS.FormattingEnabled = true;
            this.lstDatosS.Location = new System.Drawing.Point(74, 135);
            this.lstDatosS.Name = "lstDatosS";
            this.lstDatosS.Size = new System.Drawing.Size(160, 212);
            this.lstDatosS.TabIndex = 0;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(272, 147);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(106, 41);
            this.btnInsertar.TabIndex = 1;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(272, 194);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(106, 41);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(272, 241);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(106, 41);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnVaciar
            // 
            this.btnVaciar.Location = new System.Drawing.Point(272, 288);
            this.btnVaciar.Name = "btnVaciar";
            this.btnVaciar.Size = new System.Drawing.Size(106, 41);
            this.btnVaciar.TabIndex = 4;
            this.btnVaciar.Text = "Vaciar";
            this.btnVaciar.UseVisualStyleBackColor = true;
            this.btnVaciar.Click += new System.EventHandler(this.btnVaciar_Click);
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(384, 158);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(150, 20);
            this.txtDato.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDato);
            this.Controls.Add(this.btnVaciar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.lstDatosS);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstDatosS;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnVaciar;
        private System.Windows.Forms.TextBox txtDato;
    }
}

