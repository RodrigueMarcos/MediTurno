namespace Vista
{
    partial class Login
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
            this.L_usuario = new System.Windows.Forms.Label();
            this.L_contraseña = new System.Windows.Forms.Label();
            this.TB_Usuario = new System.Windows.Forms.TextBox();
            this.TB_contraseña = new System.Windows.Forms.TextBox();
            this.B_iniciarSesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // L_usuario
            // 
            this.L_usuario.AutoSize = true;
            this.L_usuario.BackColor = System.Drawing.Color.MidnightBlue;
            this.L_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_usuario.ForeColor = System.Drawing.Color.White;
            this.L_usuario.Location = new System.Drawing.Point(179, 102);
            this.L_usuario.Name = "L_usuario";
            this.L_usuario.Size = new System.Drawing.Size(54, 16);
            this.L_usuario.TabIndex = 0;
            this.L_usuario.Text = "Usuario";
            // 
            // L_contraseña
            // 
            this.L_contraseña.AutoSize = true;
            this.L_contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_contraseña.ForeColor = System.Drawing.Color.White;
            this.L_contraseña.Location = new System.Drawing.Point(172, 137);
            this.L_contraseña.Name = "L_contraseña";
            this.L_contraseña.Size = new System.Drawing.Size(76, 16);
            this.L_contraseña.TabIndex = 1;
            this.L_contraseña.Text = "Contraseña";
            // 
            // TB_Usuario
            // 
            this.TB_Usuario.Location = new System.Drawing.Point(269, 102);
            this.TB_Usuario.Name = "TB_Usuario";
            this.TB_Usuario.Size = new System.Drawing.Size(100, 20);
            this.TB_Usuario.TabIndex = 2;
            // 
            // TB_contraseña
            // 
            this.TB_contraseña.Location = new System.Drawing.Point(269, 137);
            this.TB_contraseña.Name = "TB_contraseña";
            this.TB_contraseña.Size = new System.Drawing.Size(100, 20);
            this.TB_contraseña.TabIndex = 3;
            // 
            // B_iniciarSesion
            // 
            this.B_iniciarSesion.BackColor = System.Drawing.Color.DodgerBlue;
            this.B_iniciarSesion.ForeColor = System.Drawing.Color.White;
            this.B_iniciarSesion.Location = new System.Drawing.Point(182, 229);
            this.B_iniciarSesion.Name = "B_iniciarSesion";
            this.B_iniciarSesion.Size = new System.Drawing.Size(197, 38);
            this.B_iniciarSesion.TabIndex = 4;
            this.B_iniciarSesion.Text = "Iniciar Sesion";
            this.B_iniciarSesion.UseVisualStyleBackColor = false;
            this.B_iniciarSesion.Click += new System.EventHandler(this.B_iniciarSesion_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.B_iniciarSesion);
            this.Controls.Add(this.TB_contraseña);
            this.Controls.Add(this.TB_Usuario);
            this.Controls.Add(this.L_contraseña);
            this.Controls.Add(this.L_usuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_usuario;
        private System.Windows.Forms.Label L_contraseña;
        private System.Windows.Forms.TextBox TB_Usuario;
        private System.Windows.Forms.TextBox TB_contraseña;
        private System.Windows.Forms.Button B_iniciarSesion;
    }
}

