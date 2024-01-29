namespace Vista.Secretario
{
    partial class Modificar_paciente
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.L_contactos = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.L_celular = new System.Windows.Forms.Label();
            this.L_correo = new System.Windows.Forms.Label();
            this.TB_correo = new System.Windows.Forms.TextBox();
            this.TB_celular = new System.Windows.Forms.TextBox();
            this.DTP_fecNacimiento = new System.Windows.Forms.DateTimePicker();
            this.CB_cobertura = new System.Windows.Forms.ComboBox();
            this.TB_dni = new System.Windows.Forms.TextBox();
            this.TB_nombre = new System.Windows.Forms.TextBox();
            this.TB_Apellido = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.B_Guardar = new System.Windows.Forms.Button();
            this.L_fecNacimiento = new System.Windows.Forms.Label();
            this.L_cobertura = new System.Windows.Forms.Label();
            this.L_dni = new System.Windows.Forms.Label();
            this.L_nombre = new System.Windows.Forms.Label();
            this.L_apellido = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TB_nombreFiltro = new System.Windows.Forms.TextBox();
            this.TB_dniFiltro = new System.Windows.Forms.TextBox();
            this.L_nombreFiltro = new System.Windows.Forms.Label();
            this.LdniFiltro = new System.Windows.Forms.Label();
            this.L_Filtro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 202);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 89;
            // 
            // L_contactos
            // 
            this.L_contactos.AutoSize = true;
            this.L_contactos.ForeColor = System.Drawing.Color.White;
            this.L_contactos.Location = new System.Drawing.Point(305, 277);
            this.L_contactos.Name = "L_contactos";
            this.L_contactos.Size = new System.Drawing.Size(50, 13);
            this.L_contactos.TabIndex = 85;
            this.L_contactos.Text = "Contacto";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.L_celular);
            this.panel2.Controls.Add(this.L_correo);
            this.panel2.Controls.Add(this.TB_correo);
            this.panel2.Controls.Add(this.TB_celular);
            this.panel2.Location = new System.Drawing.Point(286, 293);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(486, 100);
            this.panel2.TabIndex = 88;
            // 
            // L_celular
            // 
            this.L_celular.AutoSize = true;
            this.L_celular.ForeColor = System.Drawing.Color.White;
            this.L_celular.Location = new System.Drawing.Point(47, 27);
            this.L_celular.Name = "L_celular";
            this.L_celular.Size = new System.Drawing.Size(84, 13);
            this.L_celular.TabIndex = 3;
            this.L_celular.Text = "Teléfono Celular";
            // 
            // L_correo
            // 
            this.L_correo.AutoSize = true;
            this.L_correo.ForeColor = System.Drawing.Color.White;
            this.L_correo.Location = new System.Drawing.Point(298, 26);
            this.L_correo.Name = "L_correo";
            this.L_correo.Size = new System.Drawing.Size(94, 13);
            this.L_correo.TabIndex = 6;
            this.L_correo.Text = "Correo Electronico";
            // 
            // TB_correo
            // 
            this.TB_correo.Location = new System.Drawing.Point(314, 47);
            this.TB_correo.Name = "TB_correo";
            this.TB_correo.Size = new System.Drawing.Size(100, 20);
            this.TB_correo.TabIndex = 10;
            // 
            // TB_celular
            // 
            this.TB_celular.Location = new System.Drawing.Point(44, 47);
            this.TB_celular.Name = "TB_celular";
            this.TB_celular.Size = new System.Drawing.Size(100, 20);
            this.TB_celular.TabIndex = 13;
            // 
            // DTP_fecNacimiento
            // 
            this.DTP_fecNacimiento.Location = new System.Drawing.Point(537, 194);
            this.DTP_fecNacimiento.Name = "DTP_fecNacimiento";
            this.DTP_fecNacimiento.Size = new System.Drawing.Size(200, 20);
            this.DTP_fecNacimiento.TabIndex = 87;
            // 
            // CB_cobertura
            // 
            this.CB_cobertura.FormattingEnabled = true;
            this.CB_cobertura.Location = new System.Drawing.Point(537, 134);
            this.CB_cobertura.Name = "CB_cobertura";
            this.CB_cobertura.Size = new System.Drawing.Size(121, 21);
            this.CB_cobertura.TabIndex = 86;
            // 
            // TB_dni
            // 
            this.TB_dni.Location = new System.Drawing.Point(280, 224);
            this.TB_dni.Name = "TB_dni";
            this.TB_dni.Size = new System.Drawing.Size(100, 20);
            this.TB_dni.TabIndex = 84;
            // 
            // TB_nombre
            // 
            this.TB_nombre.Location = new System.Drawing.Point(277, 179);
            this.TB_nombre.Name = "TB_nombre";
            this.TB_nombre.Size = new System.Drawing.Size(100, 20);
            this.TB_nombre.TabIndex = 83;
            // 
            // TB_Apellido
            // 
            this.TB_Apellido.Location = new System.Drawing.Point(280, 134);
            this.TB_Apellido.Name = "TB_Apellido";
            this.TB_Apellido.Size = new System.Drawing.Size(100, 20);
            this.TB_Apellido.TabIndex = 82;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(531, 422);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 81;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // B_Guardar
            // 
            this.B_Guardar.BackColor = System.Drawing.Color.DodgerBlue;
            this.B_Guardar.ForeColor = System.Drawing.Color.White;
            this.B_Guardar.Location = new System.Drawing.Point(613, 423);
            this.B_Guardar.Name = "B_Guardar";
            this.B_Guardar.Size = new System.Drawing.Size(75, 23);
            this.B_Guardar.TabIndex = 80;
            this.B_Guardar.Text = "Guardar";
            this.B_Guardar.UseVisualStyleBackColor = false;
            // 
            // L_fecNacimiento
            // 
            this.L_fecNacimiento.AutoSize = true;
            this.L_fecNacimiento.ForeColor = System.Drawing.Color.White;
            this.L_fecNacimiento.Location = new System.Drawing.Point(531, 158);
            this.L_fecNacimiento.Name = "L_fecNacimiento";
            this.L_fecNacimiento.Size = new System.Drawing.Size(108, 13);
            this.L_fecNacimiento.TabIndex = 79;
            this.L_fecNacimiento.Text = "Fecha de Nacimiento";
            // 
            // L_cobertura
            // 
            this.L_cobertura.AutoSize = true;
            this.L_cobertura.ForeColor = System.Drawing.Color.White;
            this.L_cobertura.Location = new System.Drawing.Point(528, 106);
            this.L_cobertura.Name = "L_cobertura";
            this.L_cobertura.Size = new System.Drawing.Size(53, 13);
            this.L_cobertura.TabIndex = 78;
            this.L_cobertura.Text = "Cobertura";
            // 
            // L_dni
            // 
            this.L_dni.AutoSize = true;
            this.L_dni.ForeColor = System.Drawing.Color.White;
            this.L_dni.Location = new System.Drawing.Point(280, 202);
            this.L_dni.Name = "L_dni";
            this.L_dni.Size = new System.Drawing.Size(26, 13);
            this.L_dni.TabIndex = 77;
            this.L_dni.Text = "DNI";
            // 
            // L_nombre
            // 
            this.L_nombre.AutoSize = true;
            this.L_nombre.ForeColor = System.Drawing.Color.White;
            this.L_nombre.Location = new System.Drawing.Point(277, 158);
            this.L_nombre.Name = "L_nombre";
            this.L_nombre.Size = new System.Drawing.Size(44, 13);
            this.L_nombre.TabIndex = 76;
            this.L_nombre.Text = "Nombre";
            // 
            // L_apellido
            // 
            this.L_apellido.AutoSize = true;
            this.L_apellido.ForeColor = System.Drawing.Color.White;
            this.L_apellido.Location = new System.Drawing.Point(274, 107);
            this.L_apellido.Name = "L_apellido";
            this.L_apellido.Size = new System.Drawing.Size(44, 13);
            this.L_apellido.TabIndex = 75;
            this.L_apellido.Text = "Apellido";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TB_nombreFiltro);
            this.panel1.Controls.Add(this.TB_dniFiltro);
            this.panel1.Controls.Add(this.L_nombreFiltro);
            this.panel1.Controls.Add(this.LdniFiltro);
            this.panel1.Controls.Add(this.L_Filtro);
            this.panel1.Location = new System.Drawing.Point(195, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 100);
            this.panel1.TabIndex = 74;
            // 
            // TB_nombreFiltro
            // 
            this.TB_nombreFiltro.Location = new System.Drawing.Point(152, 60);
            this.TB_nombreFiltro.Name = "TB_nombreFiltro";
            this.TB_nombreFiltro.Size = new System.Drawing.Size(100, 20);
            this.TB_nombreFiltro.TabIndex = 4;
            // 
            // TB_dniFiltro
            // 
            this.TB_dniFiltro.Location = new System.Drawing.Point(4, 61);
            this.TB_dniFiltro.Name = "TB_dniFiltro";
            this.TB_dniFiltro.Size = new System.Drawing.Size(100, 20);
            this.TB_dniFiltro.TabIndex = 3;
            // 
            // L_nombreFiltro
            // 
            this.L_nombreFiltro.AutoSize = true;
            this.L_nombreFiltro.ForeColor = System.Drawing.Color.White;
            this.L_nombreFiltro.Location = new System.Drawing.Point(175, 32);
            this.L_nombreFiltro.Name = "L_nombreFiltro";
            this.L_nombreFiltro.Size = new System.Drawing.Size(90, 13);
            this.L_nombreFiltro.TabIndex = 2;
            this.L_nombreFiltro.Text = "Apellido y nombre";
            // 
            // LdniFiltro
            // 
            this.LdniFiltro.AutoSize = true;
            this.LdniFiltro.ForeColor = System.Drawing.Color.White;
            this.LdniFiltro.Location = new System.Drawing.Point(29, 39);
            this.LdniFiltro.Name = "LdniFiltro";
            this.LdniFiltro.Size = new System.Drawing.Size(26, 13);
            this.LdniFiltro.TabIndex = 1;
            this.LdniFiltro.Text = "DNI";
            this.LdniFiltro.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // L_Filtro
            // 
            this.L_Filtro.AutoSize = true;
            this.L_Filtro.ForeColor = System.Drawing.Color.White;
            this.L_Filtro.Location = new System.Drawing.Point(26, 0);
            this.L_Filtro.Name = "L_Filtro";
            this.L_Filtro.Size = new System.Drawing.Size(29, 13);
            this.L_Filtro.TabIndex = 0;
            this.L_Filtro.Text = "Filtro";
            // 
            // Modificar_paciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.L_contactos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DTP_fecNacimiento);
            this.Controls.Add(this.CB_cobertura);
            this.Controls.Add(this.TB_dni);
            this.Controls.Add(this.TB_nombre);
            this.Controls.Add(this.TB_Apellido);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.B_Guardar);
            this.Controls.Add(this.L_fecNacimiento);
            this.Controls.Add(this.L_cobertura);
            this.Controls.Add(this.L_dni);
            this.Controls.Add(this.L_nombre);
            this.Controls.Add(this.L_apellido);
            this.Controls.Add(this.panel1);
            this.Name = "Modificar_paciente";
            this.Text = "Modificar_paciente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label L_contactos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label L_celular;
        private System.Windows.Forms.Label L_correo;
        private System.Windows.Forms.TextBox TB_correo;
        private System.Windows.Forms.TextBox TB_celular;
        private System.Windows.Forms.DateTimePicker DTP_fecNacimiento;
        private System.Windows.Forms.ComboBox CB_cobertura;
        private System.Windows.Forms.TextBox TB_dni;
        private System.Windows.Forms.TextBox TB_nombre;
        private System.Windows.Forms.TextBox TB_Apellido;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button B_Guardar;
        private System.Windows.Forms.Label L_fecNacimiento;
        private System.Windows.Forms.Label L_cobertura;
        private System.Windows.Forms.Label L_dni;
        private System.Windows.Forms.Label L_nombre;
        private System.Windows.Forms.Label L_apellido;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TB_nombreFiltro;
        private System.Windows.Forms.TextBox TB_dniFiltro;
        private System.Windows.Forms.Label L_nombreFiltro;
        private System.Windows.Forms.Label LdniFiltro;
        private System.Windows.Forms.Label L_Filtro;
    }
}