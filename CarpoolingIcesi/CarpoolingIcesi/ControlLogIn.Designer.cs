namespace CarpoolingIcesi
{
    partial class ControlLogIn
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
            this.lbLoginTitle = new System.Windows.Forms.Label();
            this.txtLoginCodigo = new System.Windows.Forms.TextBox();
            this.lbLoginCodigo = new System.Windows.Forms.Label();
            this.lbLoginContrasena = new System.Windows.Forms.Label();
            this.txtLoginContrasena = new System.Windows.Forms.TextBox();
            this.btnLoginLogin = new System.Windows.Forms.Button();
            this.btnLoginRegister = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lbLoginTitle
            // 
            this.lbLoginTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLoginTitle.AutoSize = true;
            this.lbLoginTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoginTitle.Location = new System.Drawing.Point(159, 150);
            this.lbLoginTitle.Name = "lbLoginTitle";
            this.lbLoginTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbLoginTitle.Size = new System.Drawing.Size(282, 57);
            this.lbLoginTitle.TabIndex = 0;
            this.lbLoginTitle.Text = "Carpool Icesi";
            this.lbLoginTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbLoginTitle.UseCompatibleTextRendering = true;
            // 
            // txtLoginCodigo
            // 
            this.txtLoginCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginCodigo.Location = new System.Drawing.Point(159, 239);
            this.txtLoginCodigo.Name = "txtLoginCodigo";
            this.txtLoginCodigo.Size = new System.Drawing.Size(280, 35);
            this.txtLoginCodigo.TabIndex = 1;
            // 
            // lbLoginCodigo
            // 
            this.lbLoginCodigo.AutoSize = true;
            this.lbLoginCodigo.Location = new System.Drawing.Point(159, 220);
            this.lbLoginCodigo.Name = "lbLoginCodigo";
            this.lbLoginCodigo.Size = new System.Drawing.Size(111, 13);
            this.lbLoginCodigo.TabIndex = 2;
            this.lbLoginCodigo.Text = "Código de Estudiante:";
            // 
            // lbLoginContrasena
            // 
            this.lbLoginContrasena.AutoSize = true;
            this.lbLoginContrasena.Location = new System.Drawing.Point(159, 286);
            this.lbLoginContrasena.Name = "lbLoginContrasena";
            this.lbLoginContrasena.Size = new System.Drawing.Size(64, 13);
            this.lbLoginContrasena.TabIndex = 4;
            this.lbLoginContrasena.Text = "Contraseña:";
            // 
            // txtLoginContrasena
            // 
            this.txtLoginContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginContrasena.Location = new System.Drawing.Point(159, 305);
            this.txtLoginContrasena.Name = "txtLoginContrasena";
            this.txtLoginContrasena.Size = new System.Drawing.Size(280, 35);
            this.txtLoginContrasena.TabIndex = 3;
            this.txtLoginContrasena.UseSystemPasswordChar = true;
            // 
            // btnLoginLogin
            // 
            this.btnLoginLogin.Location = new System.Drawing.Point(328, 347);
            this.btnLoginLogin.Name = "btnLoginLogin";
            this.btnLoginLogin.Size = new System.Drawing.Size(109, 23);
            this.btnLoginLogin.TabIndex = 5;
            this.btnLoginLogin.Text = "Iniciar Sesión";
            this.btnLoginLogin.UseVisualStyleBackColor = true;
            this.btnLoginLogin.Click += new System.EventHandler(this.btnLoginLogin_Click);
            // 
            // btnLoginRegister
            // 
            this.btnLoginRegister.AutoSize = true;
            this.btnLoginRegister.Location = new System.Drawing.Point(162, 347);
            this.btnLoginRegister.Name = "btnLoginRegister";
            this.btnLoginRegister.Size = new System.Drawing.Size(49, 13);
            this.btnLoginRegister.TabIndex = 6;
            this.btnLoginRegister.TabStop = true;
            this.btnLoginRegister.Text = "Registrar";
            this.btnLoginRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnLoginRegister_LinkClicked);
            // 
            // ControlLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLoginRegister);
            this.Controls.Add(this.btnLoginLogin);
            this.Controls.Add(this.lbLoginContrasena);
            this.Controls.Add(this.txtLoginContrasena);
            this.Controls.Add(this.lbLoginCodigo);
            this.Controls.Add(this.txtLoginCodigo);
            this.Controls.Add(this.lbLoginTitle);
            this.Name = "ControlLogIn";
            this.Size = new System.Drawing.Size(600, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLoginTitle;
        private System.Windows.Forms.TextBox txtLoginCodigo;
        private System.Windows.Forms.Label lbLoginCodigo;
        private System.Windows.Forms.Label lbLoginContrasena;
        private System.Windows.Forms.TextBox txtLoginContrasena;
        private System.Windows.Forms.Button btnLoginLogin;
        private System.Windows.Forms.LinkLabel btnLoginRegister;
    }
}
