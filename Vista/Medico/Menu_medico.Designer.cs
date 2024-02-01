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
            // 
            // Menu_medico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.B_historialPaciente);
            this.Controls.Add(this.B_guardarConsulta);
            this.Controls.Add(this.splitter1);
            this.Name = "Menu_medico";
            this.Text = "Menu_medico";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button B_historialPaciente;
        private System.Windows.Forms.Button B_guardarConsulta;
        private System.Windows.Forms.Splitter splitter1;
    }
}