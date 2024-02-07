namespace Vista.Medico
{
    partial class Menu_medico
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
<<<<<<< HEAD
            this.B_historialPaciente = new System.Windows.Forms.Button();
            this.B_guardarConsulta = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.SuspendLayout();
            // 
            // B_historialPaciente
            // 
            this.B_historialPaciente.Location = new System.Drawing.Point(44, 133);
            this.B_historialPaciente.Name = "B_historialPaciente";
            this.B_historialPaciente.Size = new System.Drawing.Size(129, 27);
            this.B_historialPaciente.TabIndex = 5;
            this.B_historialPaciente.Text = "Ver historial";
            this.B_historialPaciente.UseVisualStyleBackColor = true;
            // 
            // B_guardarConsulta
            // 
            this.B_guardarConsulta.Location = new System.Drawing.Point(44, 77);
            this.B_guardarConsulta.Name = "B_guardarConsulta";
            this.B_guardarConsulta.Size = new System.Drawing.Size(129, 27);
            this.B_guardarConsulta.TabIndex = 4;
            this.B_guardarConsulta.Text = "Guardar Consulta";
            this.B_guardarConsulta.UseVisualStyleBackColor = true;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(199, 450);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
=======
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.L_mensaje = new System.Windows.Forms.Label();
            this.B_historialPaciente = new System.Windows.Forms.Button();
            this.B_guardarConsulta = new System.Windows.Forms.Button();
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
            this.splitContainer1.Panel1.Controls.Add(this.B_historialPaciente);
            this.splitContainer1.Panel1.Controls.Add(this.B_guardarConsulta);
            this.splitContainer1.Size = new System.Drawing.Size(984, 711);
            this.splitContainer1.SplitterDistance = 171;
            this.splitContainer1.TabIndex = 0;
            // 
            // L_mensaje
            // 
            this.L_mensaje.AutoSize = true;
            this.L_mensaje.ForeColor = System.Drawing.Color.Red;
            this.L_mensaje.Location = new System.Drawing.Point(31, 292);
            this.L_mensaje.Name = "L_mensaje";
            this.L_mensaje.Size = new System.Drawing.Size(47, 13);
            this.L_mensaje.TabIndex = 8;
            this.L_mensaje.Text = "Mensaje";
            // 
            // B_historialPaciente
            // 
            this.B_historialPaciente.Location = new System.Drawing.Point(31, 241);
            this.B_historialPaciente.Name = "B_historialPaciente";
            this.B_historialPaciente.Size = new System.Drawing.Size(129, 23);
            this.B_historialPaciente.TabIndex = 7;
            this.B_historialPaciente.Text = "Ver historial";
            this.B_historialPaciente.UseVisualStyleBackColor = true;
            this.B_historialPaciente.Click += new System.EventHandler(this.B_historialPaciente_Click);
            // 
            // B_guardarConsulta
            // 
            this.B_guardarConsulta.Location = new System.Drawing.Point(31, 185);
            this.B_guardarConsulta.Name = "B_guardarConsulta";
            this.B_guardarConsulta.Size = new System.Drawing.Size(129, 23);
            this.B_guardarConsulta.TabIndex = 6;
            this.B_guardarConsulta.Text = "Guardar Consulta";
            this.B_guardarConsulta.UseVisualStyleBackColor = true;
            this.B_guardarConsulta.Click += new System.EventHandler(this.B_guardarConsulta_Click);
>>>>>>> d25650e098d44ccb0a9d70f5211efe0806ee0877
            // 
            // Menu_medico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.B_historialPaciente);
            this.Controls.Add(this.B_guardarConsulta);
            this.Controls.Add(this.splitter1);
            this.Name = "Menu_medico";
            this.Text = "Menu_medico";
=======
            this.ClientSize = new System.Drawing.Size(984, 711);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Menu_medico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu_medico";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
>>>>>>> d25650e098d44ccb0a9d70f5211efe0806ee0877
            this.ResumeLayout(false);

        }

        #endregion

<<<<<<< HEAD
        private System.Windows.Forms.Button B_historialPaciente;
        private System.Windows.Forms.Button B_guardarConsulta;
        private System.Windows.Forms.Splitter splitter1;
=======
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button B_historialPaciente;
        private System.Windows.Forms.Button B_guardarConsulta;
        private System.Windows.Forms.Label L_mensaje;
>>>>>>> d25650e098d44ccb0a9d70f5211efe0806ee0877
    }
}