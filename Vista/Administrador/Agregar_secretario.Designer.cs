namespace Vista.Administrador
{
    partial class Agregar_secretario
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
            this.DT_fecNacimiento = new System.Windows.Forms.DateTimePicker();
            this.TB_correo = new System.Windows.Forms.TextBox();
            this.TB_celular = new System.Windows.Forms.TextBox();
            this.TB_dni = new System.Windows.Forms.TextBox();
            this.TB_apellido = new System.Windows.Forms.TextBox();
            this.TB_nombre = new System.Windows.Forms.TextBox();
            this.B_Cancelar = new System.Windows.Forms.Button();
            this.B_Guardar = new System.Windows.Forms.Button();
            this.L_Secretario = new System.Windows.Forms.Label();
            this.L_Correo = new System.Windows.Forms.Label();
            this.L_fecNacimiento = new System.Windows.Forms.Label();
            this.L_Telefono = new System.Windows.Forms.Label();
            this.L_dni = new System.Windows.Forms.Label();
            this.L_Apellido = new System.Windows.Forms.Label();
            this.L_Nombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DT_fecNacimiento
            // 
            this.DT_fecNacimiento.Location = new System.Drawing.Point(503, 144);
            this.DT_fecNacimiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DT_fecNacimiento.Name = "DT_fecNacimiento";
            this.DT_fecNacimiento.Size = new System.Drawing.Size(265, 22);
            this.DT_fecNacimiento.TabIndex = 55;
            // 
            // TB_correo
            // 
            this.TB_correo.Location = new System.Drawing.Point(507, 193);
            this.TB_correo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TB_correo.Name = "TB_correo";
            this.TB_correo.Size = new System.Drawing.Size(132, 22);
            this.TB_correo.TabIndex = 54;
            // 
            // TB_celular
            // 
            this.TB_celular.Location = new System.Drawing.Point(243, 340);
            this.TB_celular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TB_celular.Name = "TB_celular";
            this.TB_celular.Size = new System.Drawing.Size(132, 22);
            this.TB_celular.TabIndex = 53;
            // 
            // TB_dni
            // 
            this.TB_dni.Location = new System.Drawing.Point(243, 272);
            this.TB_dni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TB_dni.Name = "TB_dni";
            this.TB_dni.Size = new System.Drawing.Size(132, 22);
            this.TB_dni.TabIndex = 51;
            // 
            // TB_apellido
            // 
            this.TB_apellido.Location = new System.Drawing.Point(243, 224);
            this.TB_apellido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TB_apellido.Name = "TB_apellido";
            this.TB_apellido.Size = new System.Drawing.Size(132, 22);
            this.TB_apellido.TabIndex = 50;
            // 
            // TB_nombre
            // 
            this.TB_nombre.Location = new System.Drawing.Point(236, 165);
            this.TB_nombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TB_nombre.Name = "TB_nombre";
            this.TB_nombre.Size = new System.Drawing.Size(132, 22);
            this.TB_nombre.TabIndex = 49;
            // 
            // B_Cancelar
            // 
            this.B_Cancelar.BackColor = System.Drawing.Color.DodgerBlue;
            this.B_Cancelar.ForeColor = System.Drawing.Color.White;
            this.B_Cancelar.Location = new System.Drawing.Point(744, 476);
            this.B_Cancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.B_Cancelar.Name = "B_Cancelar";
            this.B_Cancelar.Size = new System.Drawing.Size(100, 28);
            this.B_Cancelar.TabIndex = 48;
            this.B_Cancelar.Text = "Cancelar";
            this.B_Cancelar.UseVisualStyleBackColor = false;
            // 
            // B_Guardar
            // 
            this.B_Guardar.BackColor = System.Drawing.Color.DodgerBlue;
            this.B_Guardar.ForeColor = System.Drawing.Color.White;
            this.B_Guardar.Location = new System.Drawing.Point(599, 476);
            this.B_Guardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.B_Guardar.Name = "B_Guardar";
            this.B_Guardar.Size = new System.Drawing.Size(100, 28);
            this.B_Guardar.TabIndex = 47;
            this.B_Guardar.Text = "Guardar";
            this.B_Guardar.UseVisualStyleBackColor = false;
            // 
            // L_Secretario
            // 
            this.L_Secretario.AutoSize = true;
            this.L_Secretario.BackColor = System.Drawing.Color.MidnightBlue;
            this.L_Secretario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Secretario.ForeColor = System.Drawing.Color.White;
            this.L_Secretario.Location = new System.Drawing.Point(231, 50);
            this.L_Secretario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L_Secretario.Name = "L_Secretario";
            this.L_Secretario.Size = new System.Drawing.Size(69, 16);
            this.L_Secretario.TabIndex = 46;
            this.L_Secretario.Text = "Secretario";
            this.L_Secretario.Click += new System.EventHandler(this.L_Medico_Click);
            // 
            // L_Correo
            // 
            this.L_Correo.AutoSize = true;
            this.L_Correo.BackColor = System.Drawing.Color.MidnightBlue;
            this.L_Correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Correo.ForeColor = System.Drawing.Color.White;
            this.L_Correo.Location = new System.Drawing.Point(499, 174);
            this.L_Correo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L_Correo.Name = "L_Correo";
            this.L_Correo.Size = new System.Drawing.Size(48, 16);
            this.L_Correo.TabIndex = 44;
            this.L_Correo.Text = "Correo";
            // 
            // L_fecNacimiento
            // 
            this.L_fecNacimiento.AutoSize = true;
            this.L_fecNacimiento.BackColor = System.Drawing.Color.MidnightBlue;
            this.L_fecNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_fecNacimiento.ForeColor = System.Drawing.Color.White;
            this.L_fecNacimiento.Location = new System.Drawing.Point(500, 124);
            this.L_fecNacimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L_fecNacimiento.Name = "L_fecNacimiento";
            this.L_fecNacimiento.Size = new System.Drawing.Size(135, 16);
            this.L_fecNacimiento.TabIndex = 43;
            this.L_fecNacimiento.Text = "Fecha de Nacimiento";
            // 
            // L_Telefono
            // 
            this.L_Telefono.AutoSize = true;
            this.L_Telefono.BackColor = System.Drawing.Color.MidnightBlue;
            this.L_Telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Telefono.ForeColor = System.Drawing.Color.White;
            this.L_Telefono.Location = new System.Drawing.Point(232, 320);
            this.L_Telefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L_Telefono.Name = "L_Telefono";
            this.L_Telefono.Size = new System.Drawing.Size(106, 16);
            this.L_Telefono.TabIndex = 42;
            this.L_Telefono.Text = "Telefono Celular";
            // 
            // L_dni
            // 
            this.L_dni.AutoSize = true;
            this.L_dni.BackColor = System.Drawing.Color.MidnightBlue;
            this.L_dni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_dni.ForeColor = System.Drawing.Color.White;
            this.L_dni.Location = new System.Drawing.Point(232, 252);
            this.L_dni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L_dni.Name = "L_dni";
            this.L_dni.Size = new System.Drawing.Size(30, 16);
            this.L_dni.TabIndex = 40;
            this.L_dni.Text = "DNI";
            // 
            // L_Apellido
            // 
            this.L_Apellido.AutoSize = true;
            this.L_Apellido.BackColor = System.Drawing.Color.MidnightBlue;
            this.L_Apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Apellido.ForeColor = System.Drawing.Color.White;
            this.L_Apellido.Location = new System.Drawing.Point(228, 204);
            this.L_Apellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L_Apellido.Name = "L_Apellido";
            this.L_Apellido.Size = new System.Drawing.Size(57, 16);
            this.L_Apellido.TabIndex = 39;
            this.L_Apellido.Text = "Apellido";
            // 
            // L_Nombre
            // 
            this.L_Nombre.AutoSize = true;
            this.L_Nombre.BackColor = System.Drawing.Color.MidnightBlue;
            this.L_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Nombre.ForeColor = System.Drawing.Color.White;
            this.L_Nombre.Location = new System.Drawing.Point(239, 124);
            this.L_Nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L_Nombre.Name = "L_Nombre";
            this.L_Nombre.Size = new System.Drawing.Size(56, 16);
            this.L_Nombre.TabIndex = 38;
            this.L_Nombre.Text = "Nombre";
            // 
            // Agregar_secretario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.DT_fecNacimiento);
            this.Controls.Add(this.TB_correo);
            this.Controls.Add(this.TB_celular);
            this.Controls.Add(this.TB_dni);
            this.Controls.Add(this.TB_apellido);
            this.Controls.Add(this.TB_nombre);
            this.Controls.Add(this.B_Cancelar);
            this.Controls.Add(this.B_Guardar);
            this.Controls.Add(this.L_Secretario);
            this.Controls.Add(this.L_Correo);
            this.Controls.Add(this.L_fecNacimiento);
            this.Controls.Add(this.L_Telefono);
            this.Controls.Add(this.L_dni);
            this.Controls.Add(this.L_Apellido);
            this.Controls.Add(this.L_Nombre);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Agregar_secretario";
            this.Text = "Nuevo secretario";
            this.Load += new System.EventHandler(this.Agregar_secretario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker DT_fecNacimiento;
        private System.Windows.Forms.TextBox TB_correo;
        private System.Windows.Forms.TextBox TB_celular;
        private System.Windows.Forms.TextBox TB_dni;
        private System.Windows.Forms.TextBox TB_apellido;
        private System.Windows.Forms.TextBox TB_nombre;
        private System.Windows.Forms.Button B_Cancelar;
        private System.Windows.Forms.Button B_Guardar;
        private System.Windows.Forms.Label L_Secretario;
        private System.Windows.Forms.Label L_Correo;
        private System.Windows.Forms.Label L_fecNacimiento;
        private System.Windows.Forms.Label L_Telefono;
        private System.Windows.Forms.Label L_dni;
        private System.Windows.Forms.Label L_Apellido;
        private System.Windows.Forms.Label L_Nombre;
    }
}