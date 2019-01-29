namespace CarpoolingIcesi
{
    partial class EstudianteMin
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbCondMinNombre = new System.Windows.Forms.Label();
            this.lbCondMinDire = new System.Windows.Forms.Label();
            this.lbCondMinCupo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbCondMinNombre
            // 
            this.lbCondMinNombre.AutoSize = true;
            this.lbCondMinNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCondMinNombre.Location = new System.Drawing.Point(14, 5);
            this.lbCondMinNombre.Name = "lbCondMinNombre";
            this.lbCondMinNombre.Size = new System.Drawing.Size(79, 24);
            this.lbCondMinNombre.TabIndex = 0;
            this.lbCondMinNombre.Text = "Nombre";
            // 
            // lbCondMinDire
            // 
            this.lbCondMinDire.AutoSize = true;
            this.lbCondMinDire.Location = new System.Drawing.Point(15, 29);
            this.lbCondMinDire.Name = "lbCondMinDire";
            this.lbCondMinDire.Size = new System.Drawing.Size(52, 13);
            this.lbCondMinDire.TabIndex = 1;
            this.lbCondMinDire.Text = "Dirección";
            // 
            // lbCondMinCupo
            // 
            this.lbCondMinCupo.AutoSize = true;
            this.lbCondMinCupo.Location = new System.Drawing.Point(15, 42);
            this.lbCondMinCupo.Name = "lbCondMinCupo";
            this.lbCondMinCupo.Size = new System.Drawing.Size(0, 13);
            this.lbCondMinCupo.TabIndex = 2;
            // 
            // EstudianteMin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbCondMinCupo);
            this.Controls.Add(this.lbCondMinDire);
            this.Controls.Add(this.lbCondMinNombre);
            this.Name = "EstudianteMin";
            this.Size = new System.Drawing.Size(150, 61);
            this.Load += new System.EventHandler(this.ConductorMin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCondMinNombre;
        private System.Windows.Forms.Label lbCondMinDire;
        private System.Windows.Forms.Label lbCondMinCupo;
    }
}
