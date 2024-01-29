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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.L_mensaje = new System.Windows.Forms.Label();
            this.B_ModificarPaciente = new System.Windows.Forms.Button();
            this.B_ModificarTurno = new System.Windows.Forms.Button();
            this.B_NuevoPaciente = new System.Windows.Forms.Button();
            this.B_NuevoTurno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.L_mensaje);
            this.splitContainer1.Panel1.Controls.Add(this.B_ModificarPaciente);
            this.splitContainer1.Panel1.Controls.Add(this.B_ModificarTurno);
            this.splitContainer1.Panel1.Controls.Add(this.B_NuevoPaciente);
            this.splitContainer1.Panel1.Controls.Add(this.B_NuevoTurno);
            this.splitContainer1.Size = new System.Drawing.Size(984, 711);
            this.splitContainer1.SplitterDistance = 185;
            this.splitContainer1.TabIndex = 0;
            // 
            // L_mensaje
            // 
            this.L_mensaje.AutoSize = true;
            this.L_mensaje.ForeColor = System.Drawing.Color.Red;
            this.L_mensaje.Location = new System.Drawing.Point(19, 339);
            this.L_mensaje.Name = "L_mensaje";
            this.L_mensaje.Size = new System.Drawing.Size(47, 13);
            this.L_mensaje.TabIndex = 14;
            this.L_mensaje.Text = "Mensaje";
            // 
            // B_ModificarPaciente
            // 
            this.B_ModificarPaciente.Location = new System.Drawing.Point(20, 282);
            this.B_ModificarPaciente.Name = "B_ModificarPaciente";
            this.B_ModificarPaciente.Size = new System.Drawing.Size(130, 23);
            this.B_ModificarPaciente.TabIndex = 13;
            this.B_ModificarPaciente.Text = "Modificar Paciente";
            this.B_ModificarPaciente.UseVisualStyleBackColor = true;
            this.B_ModificarPaciente.Click += new System.EventHandler(this.B_ModificarPaciente_Click);
            // 
            // B_ModificarTurno
            // 
            this.B_ModificarTurno.Location = new System.Drawing.Point(19, 235);
            this.B_ModificarTurno.Name = "B_ModificarTurno";
            this.B_ModificarTurno.Size = new System.Drawing.Size(131, 23);
            this.B_ModificarTurno.TabIndex = 12;
            this.B_ModificarTurno.Text = "Modificar Turno";
            this.B_ModificarTurno.UseVisualStyleBackColor = true;
            this.B_ModificarTurno.Click += new System.EventHandler(this.B_ModificarTurno_Click);
            // 
            // B_NuevoPaciente
            // 
            this.B_NuevoPaciente.Location = new System.Drawing.Point(20, 190);
            this.B_NuevoPaciente.Name = "B_NuevoPaciente";
            this.B_NuevoPaciente.Size = new System.Drawing.Size(130, 23);
            this.B_NuevoPaciente.TabIndex = 11;
            this.B_NuevoPaciente.Text = "Agregar Paciente";
            this.B_NuevoPaciente.UseVisualStyleBackColor = true;
            this.B_NuevoPaciente.Click += new System.EventHandler(this.B_NuevoPaciente_Click);
            // 
            // B_NuevoTurno
            // 
            this.B_NuevoTurno.Location = new System.Drawing.Point(20, 151);
            this.B_NuevoTurno.Name = "B_NuevoTurno";
            this.B_NuevoTurno.Size = new System.Drawing.Size(130, 23);
            this.B_NuevoTurno.TabIndex = 10;
            this.B_NuevoTurno.Text = "Nuevo Turno";
            this.B_NuevoTurno.UseVisualStyleBackColor = true;
            this.B_NuevoTurno.Click += new System.EventHandler(this.B_NuevoTurno_Click);
            // 
            // Menu_secretario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(984, 711);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Menu_secretario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu_secretario";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button B_ModificarPaciente;
        private System.Windows.Forms.Button B_ModificarTurno;
        private System.Windows.Forms.Button B_NuevoPaciente;
        private System.Windows.Forms.Button B_NuevoTurno;
        private System.Windows.Forms.Label L_mensaje;
    }
}