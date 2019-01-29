namespace CarpoolingIcesi
{
    partial class ControlConductor
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
            this.lbConductorTitlePasajeros = new System.Windows.Forms.Label();
            this.lytConductorListPasajeros = new System.Windows.Forms.TableLayoutPanel();
            this.lbConductorName = new System.Windows.Forms.Label();
            this.btnConductorSalir = new System.Windows.Forms.LinkLabel();
            this.lbConductorPuntos = new System.Windows.Forms.Label();
            this.lbConductorUbicacion = new System.Windows.Forms.Label();
            this.lbConductorTelefono = new System.Windows.Forms.Label();
            this.lblConductorPasajerosSeleccionados = new System.Windows.Forms.Label();
            this.lytConductorPasajerosElegido = new System.Windows.Forms.TableLayoutPanel();
            this.lbConductorCupo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbConductorTitlePasajeros
            // 
            this.lbConductorTitlePasajeros.AutoSize = true;
            this.lbConductorTitlePasajeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConductorTitlePasajeros.Location = new System.Drawing.Point(3, 10);
            this.lbConductorTitlePasajeros.Name = "lbConductorTitlePasajeros";
            this.lbConductorTitlePasajeros.Size = new System.Drawing.Size(97, 24);
            this.lbConductorTitlePasajeros.TabIndex = 0;
            this.lbConductorTitlePasajeros.Text = "Pasajeros:";
            // 
            // lytConductorListPasajeros
            // 
            this.lytConductorListPasajeros.ColumnCount = 1;
            this.lytConductorListPasajeros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.lytConductorListPasajeros.Location = new System.Drawing.Point(3, 37);
            this.lytConductorListPasajeros.Name = "lytConductorListPasajeros";
            this.lytConductorListPasajeros.RowCount = 15;
            this.lytConductorListPasajeros.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.lytConductorListPasajeros.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.lytConductorListPasajeros.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.lytConductorListPasajeros.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.lytConductorListPasajeros.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.lytConductorListPasajeros.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.lytConductorListPasajeros.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.lytConductorListPasajeros.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.lytConductorListPasajeros.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.lytConductorListPasajeros.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.lytConductorListPasajeros.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.lytConductorListPasajeros.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.lytConductorListPasajeros.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.lytConductorListPasajeros.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.lytConductorListPasajeros.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.lytConductorListPasajeros.Size = new System.Drawing.Size(150, 463);
            this.lytConductorListPasajeros.TabIndex = 1;
            // 
            // lbConductorName
            // 
            this.lbConductorName.AutoSize = true;
            this.lbConductorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConductorName.Location = new System.Drawing.Point(213, 37);
            this.lbConductorName.Name = "lbConductorName";
            this.lbConductorName.Size = new System.Drawing.Size(138, 37);
            this.lbConductorName.TabIndex = 2;
            this.lbConductorName.Text = "Nombre";
            this.lbConductorName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConductorSalir
            // 
            this.btnConductorSalir.AutoSize = true;
            this.btnConductorSalir.Location = new System.Drawing.Point(217, 158);
            this.btnConductorSalir.Name = "btnConductorSalir";
            this.btnConductorSalir.Size = new System.Drawing.Size(27, 13);
            this.btnConductorSalir.TabIndex = 9;
            this.btnConductorSalir.TabStop = true;
            this.btnConductorSalir.Text = "Salir";
            this.btnConductorSalir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnConductorSalir_LinkClicked);
            // 
            // lbConductorPuntos
            // 
            this.lbConductorPuntos.AutoSize = true;
            this.lbConductorPuntos.Location = new System.Drawing.Point(217, 133);
            this.lbConductorPuntos.Name = "lbConductorPuntos";
            this.lbConductorPuntos.Size = new System.Drawing.Size(93, 13);
            this.lbConductorPuntos.TabIndex = 8;
            this.lbConductorPuntos.Text = "Puntos Carpooling";
            // 
            // lbConductorUbicacion
            // 
            this.lbConductorUbicacion.AutoSize = true;
            this.lbConductorUbicacion.Location = new System.Drawing.Point(217, 108);
            this.lbConductorUbicacion.Name = "lbConductorUbicacion";
            this.lbConductorUbicacion.Size = new System.Drawing.Size(55, 13);
            this.lbConductorUbicacion.TabIndex = 7;
            this.lbConductorUbicacion.Text = "Ubicación";
            // 
            // lbConductorTelefono
            // 
            this.lbConductorTelefono.AutoSize = true;
            this.lbConductorTelefono.Location = new System.Drawing.Point(217, 83);
            this.lbConductorTelefono.Name = "lbConductorTelefono";
            this.lbConductorTelefono.Size = new System.Drawing.Size(85, 13);
            this.lbConductorTelefono.TabIndex = 6;
            this.lbConductorTelefono.Text = "Número tefónico";
            // 
            // lblConductorPasajerosSeleccionados
            // 
            this.lblConductorPasajerosSeleccionados.AutoSize = true;
            this.lblConductorPasajerosSeleccionados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConductorPasajerosSeleccionados.Location = new System.Drawing.Point(213, 258);
            this.lblConductorPasajerosSeleccionados.Name = "lblConductorPasajerosSeleccionados";
            this.lblConductorPasajerosSeleccionados.Size = new System.Drawing.Size(97, 24);
            this.lblConductorPasajerosSeleccionados.TabIndex = 10;
            this.lblConductorPasajerosSeleccionados.Text = "Pasajeros:";
            this.lblConductorPasajerosSeleccionados.Visible = false;
            this.lblConductorPasajerosSeleccionados.Click += new System.EventHandler(this.lblConductorPasajerosSeleccionados_Click);
            // 
            // lytConductorPasajerosElegido
            // 
            this.lytConductorPasajerosElegido.ColumnCount = 2;
            this.lytConductorPasajerosElegido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.lytConductorPasajerosElegido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.lytConductorPasajerosElegido.Location = new System.Drawing.Point(217, 297);
            this.lytConductorPasajerosElegido.Name = "lytConductorPasajerosElegido";
            this.lytConductorPasajerosElegido.RowCount = 2;
            this.lytConductorPasajerosElegido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.lytConductorPasajerosElegido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.lytConductorPasajerosElegido.Size = new System.Drawing.Size(276, 115);
            this.lytConductorPasajerosElegido.TabIndex = 11;
            this.lytConductorPasajerosElegido.Visible = false;
            // 
            // lbConductorCupo
            // 
            this.lbConductorCupo.AutoSize = true;
            this.lbConductorCupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConductorCupo.Location = new System.Drawing.Point(220, 225);
            this.lbConductorCupo.Name = "lbConductorCupo";
            this.lbConductorCupo.Size = new System.Drawing.Size(0, 24);
            this.lbConductorCupo.TabIndex = 12;
            // 
            // ControlConductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbConductorCupo);
            this.Controls.Add(this.lytConductorPasajerosElegido);
            this.Controls.Add(this.lblConductorPasajerosSeleccionados);
            this.Controls.Add(this.btnConductorSalir);
            this.Controls.Add(this.lbConductorPuntos);
            this.Controls.Add(this.lbConductorUbicacion);
            this.Controls.Add(this.lbConductorTelefono);
            this.Controls.Add(this.lbConductorName);
            this.Controls.Add(this.lytConductorListPasajeros);
            this.Controls.Add(this.lbConductorTitlePasajeros);
            this.Name = "ControlConductor";
            this.Size = new System.Drawing.Size(600, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbConductorTitlePasajeros;
        private System.Windows.Forms.TableLayoutPanel lytConductorListPasajeros;
        private System.Windows.Forms.Label lbConductorName;
        private System.Windows.Forms.LinkLabel btnConductorSalir;
        private System.Windows.Forms.Label lbConductorPuntos;
        private System.Windows.Forms.Label lbConductorUbicacion;
        private System.Windows.Forms.Label lbConductorTelefono;
        private System.Windows.Forms.Label lblConductorPasajerosSeleccionados;
        private System.Windows.Forms.TableLayoutPanel lytConductorPasajerosElegido;
        private System.Windows.Forms.Label lbConductorCupo;
    }
}
