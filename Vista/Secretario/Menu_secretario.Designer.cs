namespace Vista.Secretario
{
    partial class Menu_secretario
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
            this.B_ModificarPaciente = new System.Windows.Forms.Button();
            this.B_ModificarTurno = new System.Windows.Forms.Button();
            this.B_NuevoPaciente = new System.Windows.Forms.Button();
            this.B_NuevoTurno = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.SuspendLayout();
            // 
            // B_ModificarPaciente
            // 
            this.B_ModificarPaciente.Location = new System.Drawing.Point(32, 198);
            this.B_ModificarPaciente.Name = "B_ModificarPaciente";
            this.B_ModificarPaciente.Size = new System.Drawing.Size(130, 23);
            this.B_ModificarPaciente.TabIndex = 9;
            this.B_ModificarPaciente.Text = "Modificar Paciente";
            this.B_ModificarPaciente.UseVisualStyleBackColor = true;
            // 
            // B_ModificarTurno
            // 
            this.B_ModificarTurno.Location = new System.Drawing.Point(31, 151);
            this.B_ModificarTurno.Name = "B_ModificarTurno";
            this.B_ModificarTurno.Size = new System.Drawing.Size(131, 23);
            this.B_ModificarTurno.TabIndex = 8;
            this.B_ModificarTurno.Text = "Modificar Turno";
            this.B_ModificarTurno.UseVisualStyleBackColor = true;
            // 
            // B_NuevoPaciente
            // 
            this.B_NuevoPaciente.Location = new System.Drawing.Point(32, 106);
            this.B_NuevoPaciente.Name = "B_NuevoPaciente";
            this.B_NuevoPaciente.Size = new System.Drawing.Size(130, 23);
            this.B_NuevoPaciente.TabIndex = 7;
            this.B_NuevoPaciente.Text = "Agregar Paciente";
            this.B_NuevoPaciente.UseVisualStyleBackColor = true;
            // 
            // B_NuevoTurno
            // 
            this.B_NuevoTurno.Location = new System.Drawing.Point(32, 67);
            this.B_NuevoTurno.Name = "B_NuevoTurno";
            this.B_NuevoTurno.Size = new System.Drawing.Size(130, 23);
            this.B_NuevoTurno.TabIndex = 6;
            this.B_NuevoTurno.Text = "Nuevo Turno";
            this.B_NuevoTurno.UseVisualStyleBackColor = true;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(185, 450);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // Menu_secretario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.B_ModificarPaciente);
            this.Controls.Add(this.B_ModificarTurno);
            this.Controls.Add(this.B_NuevoPaciente);
            this.Controls.Add(this.B_NuevoTurno);
            this.Controls.Add(this.splitter1);
            this.Name = "Menu_secretario";
            this.Text = "Menu_secretario";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button B_ModificarPaciente;
        private System.Windows.Forms.Button B_ModificarTurno;
        private System.Windows.Forms.Button B_NuevoPaciente;
        private System.Windows.Forms.Button B_NuevoTurno;
        private System.Windows.Forms.Splitter splitter1;
    }
}