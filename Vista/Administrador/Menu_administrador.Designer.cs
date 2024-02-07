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
<<<<<<< HEAD
=======
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.L_mensaje = new System.Windows.Forms.Label();
>>>>>>> d25650e098d44ccb0a9d70f5211efe0806ee0877
            this.B_ModificarSecretario = new System.Windows.Forms.Button();
            this.B_modificarMedico = new System.Windows.Forms.Button();
            this.B_AgregarSecretario = new System.Windows.Forms.Button();
            this.B_AgregarMedico = new System.Windows.Forms.Button();
<<<<<<< HEAD
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
=======
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
            this.splitContainer1.Panel1.Controls.Add(this.B_ModificarSecretario);
            this.splitContainer1.Panel1.Controls.Add(this.B_modificarMedico);
            this.splitContainer1.Panel1.Controls.Add(this.B_AgregarSecretario);
            this.splitContainer1.Panel1.Controls.Add(this.B_AgregarMedico);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(984, 711);
            this.splitContainer1.SplitterDistance = 178;
            this.splitContainer1.TabIndex = 10;
            // 
            // L_mensaje
            // 
            this.L_mensaje.AutoSize = true;
            this.L_mensaje.ForeColor = System.Drawing.Color.Red;
            this.L_mensaje.Location = new System.Drawing.Point(10, 355);
            this.L_mensaje.Name = "L_mensaje";
            this.L_mensaje.Size = new System.Drawing.Size(47, 13);
            this.L_mensaje.TabIndex = 14;
            this.L_mensaje.Text = "Mensaje";
            // 
            // B_ModificarSecretario
            // 
            this.B_ModificarSecretario.Location = new System.Drawing.Point(10, 310);
            this.B_ModificarSecretario.Name = "B_ModificarSecretario";
            this.B_ModificarSecretario.Size = new System.Drawing.Size(136, 23);
            this.B_ModificarSecretario.TabIndex = 13;
            this.B_ModificarSecretario.Text = "Modificar Secretario";
            this.B_ModificarSecretario.UseVisualStyleBackColor = true;
            this.B_ModificarSecretario.Click += new System.EventHandler(this.B_ModificarSecretario_Click);
            // 
            // B_modificarMedico
            // 
            this.B_modificarMedico.Location = new System.Drawing.Point(10, 271);
            this.B_modificarMedico.Name = "B_modificarMedico";
            this.B_modificarMedico.Size = new System.Drawing.Size(136, 23);
            this.B_modificarMedico.TabIndex = 12;
            this.B_modificarMedico.Text = "Modificar Médico";
            this.B_modificarMedico.UseVisualStyleBackColor = true;
            this.B_modificarMedico.Click += new System.EventHandler(this.B_modificarMedico_Click);
            // 
            // B_AgregarSecretario
            // 
            this.B_AgregarSecretario.Location = new System.Drawing.Point(10, 232);
            this.B_AgregarSecretario.Name = "B_AgregarSecretario";
            this.B_AgregarSecretario.Size = new System.Drawing.Size(136, 23);
            this.B_AgregarSecretario.TabIndex = 11;
            this.B_AgregarSecretario.Text = "Agregar Secretario";
            this.B_AgregarSecretario.UseVisualStyleBackColor = true;
            this.B_AgregarSecretario.Click += new System.EventHandler(this.B_AgregarSecretario_Click);
            // 
            // B_AgregarMedico
            // 
            this.B_AgregarMedico.Location = new System.Drawing.Point(10, 188);
            this.B_AgregarMedico.Name = "B_AgregarMedico";
            this.B_AgregarMedico.Size = new System.Drawing.Size(136, 23);
            this.B_AgregarMedico.TabIndex = 10;
            this.B_AgregarMedico.Text = "Agregar Médico";
            this.B_AgregarMedico.UseVisualStyleBackColor = true;
            this.B_AgregarMedico.Click += new System.EventHandler(this.B_AgregarMedico_Click);
>>>>>>> d25650e098d44ccb0a9d70f5211efe0806ee0877
            // 
            // Menu_administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.B_ModificarSecretario);
            this.Controls.Add(this.B_modificarMedico);
            this.Controls.Add(this.B_AgregarSecretario);
            this.Controls.Add(this.B_AgregarMedico);
            this.Controls.Add(this.splitter1);
            this.Name = "Menu_administrador";
            this.Text = "Menu_administrador";
=======
            this.ClientSize = new System.Drawing.Size(984, 711);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Menu_administrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu_administrador";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
>>>>>>> d25650e098d44ccb0a9d70f5211efe0806ee0877
            this.ResumeLayout(false);

        }

        #endregion

<<<<<<< HEAD
=======
        private System.Windows.Forms.SplitContainer splitContainer1;
>>>>>>> d25650e098d44ccb0a9d70f5211efe0806ee0877
        private System.Windows.Forms.Button B_ModificarSecretario;
        private System.Windows.Forms.Button B_modificarMedico;
        private System.Windows.Forms.Button B_AgregarSecretario;
        private System.Windows.Forms.Button B_AgregarMedico;
<<<<<<< HEAD
        private System.Windows.Forms.Splitter splitter1;
=======
        private System.Windows.Forms.Label L_mensaje;
>>>>>>> d25650e098d44ccb0a9d70f5211efe0806ee0877
    }
}