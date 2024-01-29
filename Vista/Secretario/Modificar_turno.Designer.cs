namespace Vista.Secretario
{
    partial class Modificar_turno
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
            this.L_filtro = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.L_Estado = new System.Windows.Forms.Label();
            this.DT_fecha = new System.Windows.Forms.DateTimePicker();
            this.L_fecha = new System.Windows.Forms.Label();
            this.CB_estado = new System.Windows.Forms.ComboBox();
            this.B_Cambiar = new System.Windows.Forms.Button();
            this.CB_EstadoSeleccionado = new System.Windows.Forms.ComboBox();
            this.L_EstadoSeleccionado = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // L_filtro
            // 
            this.L_filtro.AutoSize = true;
            this.L_filtro.ForeColor = System.Drawing.Color.White;
            this.L_filtro.Location = new System.Drawing.Point(169, 69);
            this.L_filtro.Name = "L_filtro";
            this.L_filtro.Size = new System.Drawing.Size(29, 13);
            this.L_filtro.TabIndex = 16;
            this.L_filtro.Text = "Filtro";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.L_Estado);
            this.panel1.Controls.Add(this.DT_fecha);
            this.panel1.Controls.Add(this.L_fecha);
            this.panel1.Controls.Add(this.CB_estado);
            this.panel1.Location = new System.Drawing.Point(161, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 100);
            this.panel1.TabIndex = 15;
            // 
            // L_Estado
            // 
            this.L_Estado.AutoSize = true;
            this.L_Estado.ForeColor = System.Drawing.Color.White;
            this.L_Estado.Location = new System.Drawing.Point(8, 27);
            this.L_Estado.Name = "L_Estado";
            this.L_Estado.Size = new System.Drawing.Size(40, 13);
            this.L_Estado.TabIndex = 1;
            this.L_Estado.Text = "Estado";
            // 
            // DT_fecha
            // 
            this.DT_fecha.Location = new System.Drawing.Point(158, 63);
            this.DT_fecha.Name = "DT_fecha";
            this.DT_fecha.Size = new System.Drawing.Size(200, 20);
            this.DT_fecha.TabIndex = 8;
            // 
            // L_fecha
            // 
            this.L_fecha.AutoSize = true;
            this.L_fecha.ForeColor = System.Drawing.Color.White;
            this.L_fecha.Location = new System.Drawing.Point(193, 27);
            this.L_fecha.Name = "L_fecha";
            this.L_fecha.Size = new System.Drawing.Size(37, 13);
            this.L_fecha.TabIndex = 2;
            this.L_fecha.Text = "Fecha";
            // 
            // CB_estado
            // 
            this.CB_estado.FormattingEnabled = true;
            this.CB_estado.Location = new System.Drawing.Point(11, 62);
            this.CB_estado.Name = "CB_estado";
            this.CB_estado.Size = new System.Drawing.Size(121, 21);
            this.CB_estado.TabIndex = 7;
            // 
            // B_Cambiar
            // 
            this.B_Cambiar.BackColor = System.Drawing.Color.DodgerBlue;
            this.B_Cambiar.ForeColor = System.Drawing.Color.White;
            this.B_Cambiar.Location = new System.Drawing.Point(518, 300);
            this.B_Cambiar.Name = "B_Cambiar";
            this.B_Cambiar.Size = new System.Drawing.Size(75, 23);
            this.B_Cambiar.TabIndex = 14;
            this.B_Cambiar.Text = "Cambiar";
            this.B_Cambiar.UseVisualStyleBackColor = false;
            // 
            // CB_EstadoSeleccionado
            // 
            this.CB_EstadoSeleccionado.FormattingEnabled = true;
            this.CB_EstadoSeleccionado.Location = new System.Drawing.Point(518, 242);
            this.CB_EstadoSeleccionado.Name = "CB_EstadoSeleccionado";
            this.CB_EstadoSeleccionado.Size = new System.Drawing.Size(121, 21);
            this.CB_EstadoSeleccionado.TabIndex = 13;
            // 
            // L_EstadoSeleccionado
            // 
            this.L_EstadoSeleccionado.AutoSize = true;
            this.L_EstadoSeleccionado.ForeColor = System.Drawing.Color.White;
            this.L_EstadoSeleccionado.Location = new System.Drawing.Point(515, 202);
            this.L_EstadoSeleccionado.Name = "L_EstadoSeleccionado";
            this.L_EstadoSeleccionado.Size = new System.Drawing.Size(40, 13);
            this.L_EstadoSeleccionado.TabIndex = 12;
            this.L_EstadoSeleccionado.Text = "Estado";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(161, 231);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 11;
            // 
            // Modificar_turno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.L_filtro);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.B_Cambiar);
            this.Controls.Add(this.CB_EstadoSeleccionado);
            this.Controls.Add(this.L_EstadoSeleccionado);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Modificar_turno";
            this.Text = "Modificar_turno";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_filtro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label L_Estado;
        private System.Windows.Forms.DateTimePicker DT_fecha;
        private System.Windows.Forms.Label L_fecha;
        private System.Windows.Forms.ComboBox CB_estado;
        private System.Windows.Forms.Button B_Cambiar;
        private System.Windows.Forms.ComboBox CB_EstadoSeleccionado;
        private System.Windows.Forms.Label L_EstadoSeleccionado;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}