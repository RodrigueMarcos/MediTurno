namespace Vista.Secretario
{
    partial class Agregar_turno
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
            this.L_horarios = new System.Windows.Forms.Label();
            this.L_Fecha = new System.Windows.Forms.Label();
            this.DT_Fecha = new System.Windows.Forms.DateTimePicker();
            this.B_Cancelar = new System.Windows.Forms.Button();
            this.B_Guardar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.L_Paciente = new System.Windows.Forms.Label();
            this.L_Medico = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.L_cobertura = new System.Windows.Forms.Label();
            this.L_dni = new System.Windows.Forms.Label();
            this.L_nombrePaciente = new System.Windows.Forms.Label();
            this.B_BuscarPaciente = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.L_Especialidad = new System.Windows.Forms.Label();
            this.L_Matricula = new System.Windows.Forms.Label();
            this.L_nombreMedico = new System.Windows.Forms.Label();
            this.B_BuscarMedico = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // L_horarios
            // 
            this.L_horarios.AutoSize = true;
            this.L_horarios.ForeColor = System.Drawing.Color.White;
            this.L_horarios.Location = new System.Drawing.Point(150, 217);
            this.L_horarios.Name = "L_horarios";
            this.L_horarios.Size = new System.Drawing.Size(103, 13);
            this.L_horarios.TabIndex = 22;
            this.L_horarios.Text = "Horarios Disponibles";
            // 
            // L_Fecha
            // 
            this.L_Fecha.AutoSize = true;
            this.L_Fecha.ForeColor = System.Drawing.Color.White;
            this.L_Fecha.Location = new System.Drawing.Point(147, 181);
            this.L_Fecha.Name = "L_Fecha";
            this.L_Fecha.Size = new System.Drawing.Size(37, 13);
            this.L_Fecha.TabIndex = 21;
            this.L_Fecha.Text = "Fecha";
            // 
            // DT_Fecha
            // 
            this.DT_Fecha.Location = new System.Drawing.Point(150, 197);
            this.DT_Fecha.Name = "DT_Fecha";
            this.DT_Fecha.Size = new System.Drawing.Size(200, 20);
            this.DT_Fecha.TabIndex = 20;
            // 
            // B_Cancelar
            // 
            this.B_Cancelar.BackColor = System.Drawing.Color.DodgerBlue;
            this.B_Cancelar.ForeColor = System.Drawing.Color.White;
            this.B_Cancelar.Location = new System.Drawing.Point(505, 390);
            this.B_Cancelar.Name = "B_Cancelar";
            this.B_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.B_Cancelar.TabIndex = 19;
            this.B_Cancelar.Text = "Cancelar";
            this.B_Cancelar.UseVisualStyleBackColor = false;
            // 
            // B_Guardar
            // 
            this.B_Guardar.BackColor = System.Drawing.Color.DodgerBlue;
            this.B_Guardar.ForeColor = System.Drawing.Color.White;
            this.B_Guardar.Location = new System.Drawing.Point(586, 390);
            this.B_Guardar.Name = "B_Guardar";
            this.B_Guardar.Size = new System.Drawing.Size(75, 23);
            this.B_Guardar.TabIndex = 18;
            this.B_Guardar.Text = "Guardar";
            this.B_Guardar.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(139, 236);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(497, 148);
            this.dataGridView1.TabIndex = 17;
            // 
            // L_Paciente
            // 
            this.L_Paciente.AutoSize = true;
            this.L_Paciente.ForeColor = System.Drawing.Color.White;
            this.L_Paciente.Location = new System.Drawing.Point(441, 61);
            this.L_Paciente.Name = "L_Paciente";
            this.L_Paciente.Size = new System.Drawing.Size(85, 13);
            this.L_Paciente.TabIndex = 16;
            this.L_Paciente.Text = "Buscar Paciente";
            // 
            // L_Medico
            // 
            this.L_Medico.AutoSize = true;
            this.L_Medico.ForeColor = System.Drawing.Color.White;
            this.L_Medico.Location = new System.Drawing.Point(147, 38);
            this.L_Medico.Name = "L_Medico";
            this.L_Medico.Size = new System.Drawing.Size(78, 13);
            this.L_Medico.TabIndex = 15;
            this.L_Medico.Text = "Buscar Médico";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.L_cobertura);
            this.panel2.Controls.Add(this.L_dni);
            this.panel2.Controls.Add(this.L_nombrePaciente);
            this.panel2.Controls.Add(this.B_BuscarPaciente);
            this.panel2.Location = new System.Drawing.Point(426, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 14;
            // 
            // L_cobertura
            // 
            this.L_cobertura.AutoSize = true;
            this.L_cobertura.ForeColor = System.Drawing.Color.White;
            this.L_cobertura.Location = new System.Drawing.Point(15, 75);
            this.L_cobertura.Name = "L_cobertura";
            this.L_cobertura.Size = new System.Drawing.Size(53, 13);
            this.L_cobertura.TabIndex = 4;
            this.L_cobertura.Text = "Cobertura";
            // 
            // L_dni
            // 
            this.L_dni.AutoSize = true;
            this.L_dni.ForeColor = System.Drawing.Color.White;
            this.L_dni.Location = new System.Drawing.Point(15, 54);
            this.L_dni.Name = "L_dni";
            this.L_dni.Size = new System.Drawing.Size(26, 13);
            this.L_dni.TabIndex = 3;
            this.L_dni.Text = "DNI";
            // 
            // L_nombrePaciente
            // 
            this.L_nombrePaciente.AutoSize = true;
            this.L_nombrePaciente.ForeColor = System.Drawing.Color.White;
            this.L_nombrePaciente.Location = new System.Drawing.Point(15, 30);
            this.L_nombrePaciente.Name = "L_nombrePaciente";
            this.L_nombrePaciente.Size = new System.Drawing.Size(92, 13);
            this.L_nombrePaciente.TabIndex = 2;
            this.L_nombrePaciente.Text = "Apellido y Nombre";
            // 
            // B_BuscarPaciente
            // 
            this.B_BuscarPaciente.BackColor = System.Drawing.Color.DodgerBlue;
            this.B_BuscarPaciente.ForeColor = System.Drawing.Color.White;
            this.B_BuscarPaciente.Location = new System.Drawing.Point(31, -1);
            this.B_BuscarPaciente.Name = "B_BuscarPaciente";
            this.B_BuscarPaciente.Size = new System.Drawing.Size(75, 23);
            this.B_BuscarPaciente.TabIndex = 0;
            this.B_BuscarPaciente.Text = "Buscar";
            this.B_BuscarPaciente.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.L_Especialidad);
            this.panel1.Controls.Add(this.L_Matricula);
            this.panel1.Controls.Add(this.L_nombreMedico);
            this.panel1.Controls.Add(this.B_BuscarMedico);
            this.panel1.Location = new System.Drawing.Point(139, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 13;
            // 
            // L_Especialidad
            // 
            this.L_Especialidad.AutoSize = true;
            this.L_Especialidad.ForeColor = System.Drawing.Color.White;
            this.L_Especialidad.Location = new System.Drawing.Point(25, 87);
            this.L_Especialidad.Name = "L_Especialidad";
            this.L_Especialidad.Size = new System.Drawing.Size(67, 13);
            this.L_Especialidad.TabIndex = 3;
            this.L_Especialidad.Text = "Especialidad";
            // 
            // L_Matricula
            // 
            this.L_Matricula.AutoSize = true;
            this.L_Matricula.ForeColor = System.Drawing.Color.White;
            this.L_Matricula.Location = new System.Drawing.Point(25, 66);
            this.L_Matricula.Name = "L_Matricula";
            this.L_Matricula.Size = new System.Drawing.Size(50, 13);
            this.L_Matricula.TabIndex = 2;
            this.L_Matricula.Text = "Matricula";
            // 
            // L_nombreMedico
            // 
            this.L_nombreMedico.AutoSize = true;
            this.L_nombreMedico.ForeColor = System.Drawing.Color.White;
            this.L_nombreMedico.Location = new System.Drawing.Point(25, 42);
            this.L_nombreMedico.Name = "L_nombreMedico";
            this.L_nombreMedico.Size = new System.Drawing.Size(92, 13);
            this.L_nombreMedico.TabIndex = 1;
            this.L_nombreMedico.Text = "Apellido y Nombre";
            // 
            // B_BuscarMedico
            // 
            this.B_BuscarMedico.BackColor = System.Drawing.Color.DodgerBlue;
            this.B_BuscarMedico.ForeColor = System.Drawing.Color.White;
            this.B_BuscarMedico.Location = new System.Drawing.Point(25, 12);
            this.B_BuscarMedico.Name = "B_BuscarMedico";
            this.B_BuscarMedico.Size = new System.Drawing.Size(75, 23);
            this.B_BuscarMedico.TabIndex = 0;
            this.B_BuscarMedico.Text = "Buscar";
            this.B_BuscarMedico.UseVisualStyleBackColor = false;
            // 
            // Agregar_turno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.L_horarios);
            this.Controls.Add(this.L_Fecha);
            this.Controls.Add(this.DT_Fecha);
            this.Controls.Add(this.B_Cancelar);
            this.Controls.Add(this.B_Guardar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.L_Paciente);
            this.Controls.Add(this.L_Medico);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Agregar_turno";
            this.Text = "Agregar_turno";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_horarios;
        private System.Windows.Forms.Label L_Fecha;
        private System.Windows.Forms.DateTimePicker DT_Fecha;
        private System.Windows.Forms.Button B_Cancelar;
        private System.Windows.Forms.Button B_Guardar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label L_Paciente;
        private System.Windows.Forms.Label L_Medico;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label L_cobertura;
        private System.Windows.Forms.Label L_dni;
        private System.Windows.Forms.Label L_nombrePaciente;
        private System.Windows.Forms.Button B_BuscarPaciente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label L_Especialidad;
        private System.Windows.Forms.Label L_Matricula;
        private System.Windows.Forms.Label L_nombreMedico;
        private System.Windows.Forms.Button B_BuscarMedico;
    }
}