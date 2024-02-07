using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
=======
using Vista.Secretario;
>>>>>>> d25650e098d44ccb0a9d70f5211efe0806ee0877

namespace Vista.Medico
{
    public partial class Menu_medico : Form
    {
        public Menu_medico()
        {
            InitializeComponent();
<<<<<<< HEAD
=======
            L_mensaje.Text = "";
        }

        private void B_guardarConsulta_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Guardar_consulta);
            if (frm == null)
            {
                Guardar_consulta consulta = new Guardar_consulta();
                consulta.TopLevel = false;
                consulta.Dock = DockStyle.Fill;
                splitContainer1.Panel2.Controls.Add(consulta);
                consulta.BringToFront();
                consulta.Show();
                L_mensaje.Text = "";
            }
            else
            {
                L_mensaje.Text = "*La ventana esta abierta";

            }
        }

        private void B_historialPaciente_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Historial_paciente);
            if (frm == null)
            {
                Historial_paciente historial = new Historial_paciente();
                historial.TopLevel = false;
                historial.Dock = DockStyle.Fill;
                splitContainer1.Panel2.Controls.Add(historial);
                historial.BringToFront();
                historial.Show();
                L_mensaje.Text = "";
            }
            else
            {
                L_mensaje.Text = "*La ventana esta abierta";

            }
>>>>>>> d25650e098d44ccb0a9d70f5211efe0806ee0877
        }
    }
}
