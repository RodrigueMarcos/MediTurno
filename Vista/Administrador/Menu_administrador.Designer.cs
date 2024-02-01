namespace Vista.Administrador
{
    partial class Menu_administrador
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
            this.B_ModificarSecretario = new System.Windows.Forms.Button();
            this.B_modificarMedico = new System.Windows.Forms.Button();
            this.B_AgregarSecretario = new System.Windows.Forms.Button();
            this.B_AgregarMedico = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.SuspendLayout();
            // 
            // B_ModificarSecretario
            // 
            this.B_ModificarSecretario.Location = new System.Drawing.Point(12, 194);
            this.B_ModificarSecretario.Name = "B_ModificarSecretario";
            this.B_ModificarSecretario.Size = new System.Drawing.Size(136, 23);
            this.B_ModificarSecretario.TabIndex = 9;
            this.B_ModificarSecretario.Text = "Modificar Secretario";
            this.B_ModificarSecretario.UseVisualStyleBackColor = true;
            // 
            // B_modificarMedico
            // 
            this.B_modificarMedico.Location = new System.Drawing.Point(12, 155);
            this.B_modificarMedico.Name = "B_modificarMedico";
            this.B_modificarMedico.Size = new System.Drawing.Size(136, 23);
            this.B_modificarMedico.TabIndex = 8;
            this.B_modificarMedico.Text = "Modificar Médico";
            this.B_modificarMedico.UseVisualStyleBackColor = true;
            // 
            // B_AgregarSecretario
            // 
            this.B_AgregarSecretario.Location = new System.Drawing.Point(12, 116);
            this.B_AgregarSecretario.Name = "B_AgregarSecretario";
            this.B_AgregarSecretario.Size = new System.Drawing.Size(136, 23);
            this.B_AgregarSecretario.TabIndex = 7;
            this.B_AgregarSecretario.Text = "Agregar Secretario";
            this.B_AgregarSecretario.UseVisualStyleBackColor = true;
            // 
            // B_AgregarMedico
            // 
            this.B_AgregarMedico.Location = new System.Drawing.Point(12, 72);
            this.B_AgregarMedico.Name = "B_AgregarMedico";
            this.B_AgregarMedico.Size = new System.Drawing.Size(136, 23);
            this.B_AgregarMedico.TabIndex = 6;
            this.B_AgregarMedico.Text = "Agregar Médico";
            this.B_AgregarMedico.UseVisualStyleBackColor = true;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(174, 450);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // Menu_administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.B_ModificarSecretario);
            this.Controls.Add(this.B_modificarMedico);
            this.Controls.Add(this.B_AgregarSecretario);
            this.Controls.Add(this.B_AgregarMedico);
            this.Controls.Add(this.splitter1);
            this.Name = "Menu_administrador";
            this.Text = "Menu_administrador";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button B_ModificarSecretario;
        private System.Windows.Forms.Button B_modificarMedico;
        private System.Windows.Forms.Button B_AgregarSecretario;
        private System.Windows.Forms.Button B_AgregarMedico;
        private System.Windows.Forms.Splitter splitter1;
    }
}