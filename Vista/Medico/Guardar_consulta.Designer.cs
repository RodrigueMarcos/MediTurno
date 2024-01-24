namespace Vista.Medico
{
    partial class Guardar_consulta
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
            this.L_nombreCompleto = new System.Windows.Forms.Label();
            this.L_cobertura = new System.Windows.Forms.Label();
            this.L_dni = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.L_Diagnostico = new System.Windows.Forms.Label();
            this.L_Observaciones = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // L_nombreCompleto
            // 
            this.L_nombreCompleto.AutoSize = true;
            this.L_nombreCompleto.Location = new System.Drawing.Point(146, 74);
            this.L_nombreCompleto.Name = "L_nombreCompleto";
            this.L_nombreCompleto.Size = new System.Drawing.Size(98, 13);
            this.L_nombreCompleto.TabIndex = 0;
            this.L_nombreCompleto.Text = "Apellido y Nombre :";
            // 
            // L_cobertura
            // 
            this.L_cobertura.AutoSize = true;
            this.L_cobertura.Location = new System.Drawing.Point(149, 107);
            this.L_cobertura.Name = "L_cobertura";
            this.L_cobertura.Size = new System.Drawing.Size(59, 13);
            this.L_cobertura.TabIndex = 1;
            this.L_cobertura.Text = "Cobertura :";
            // 
            // L_dni
            // 
            this.L_dni.AutoSize = true;
            this.L_dni.Location = new System.Drawing.Point(152, 142);
            this.L_dni.Name = "L_dni";
            this.L_dni.Size = new System.Drawing.Size(32, 13);
            this.L_dni.TabIndex = 2;
            this.L_dni.Text = "DNI :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // L_Diagnostico
            // 
            this.L_Diagnostico.AutoSize = true;
            this.L_Diagnostico.Location = new System.Drawing.Point(227, 256);
            this.L_Diagnostico.Name = "L_Diagnostico";
            this.L_Diagnostico.Size = new System.Drawing.Size(63, 13);
            this.L_Diagnostico.TabIndex = 4;
            this.L_Diagnostico.Text = "Diagnostico";
            // 
            // L_Observaciones
            // 
            this.L_Observaciones.AutoSize = true;
            this.L_Observaciones.Location = new System.Drawing.Point(130, 256);
            this.L_Observaciones.Name = "L_Observaciones";
            this.L_Observaciones.Size = new System.Drawing.Size(78, 13);
            this.L_Observaciones.TabIndex = 5;
            this.L_Observaciones.Text = "Observaciones";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(230, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(227, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(230, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "label9";
            // 
            // Guardar_consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.L_Observaciones);
            this.Controls.Add(this.L_Diagnostico);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.L_dni);
            this.Controls.Add(this.L_cobertura);
            this.Controls.Add(this.L_nombreCompleto);
            this.Name = "Guardar_consulta";
            this.Text = "Guardar_consulta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_nombreCompleto;
        private System.Windows.Forms.Label L_cobertura;
        private System.Windows.Forms.Label L_dni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label L_Diagnostico;
        private System.Windows.Forms.Label L_Observaciones;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}