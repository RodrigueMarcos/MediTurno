using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.Secretario
{
    public partial class Menu_secretario : Form
    {
        public Menu_secretario()
        {
            InitializeComponent();
<<<<<<< HEAD
=======
            L_mensaje.Text = "";
        }

        private void B_NuevoTurno_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Agregar_turno);
            if (frm == null)
            {
                Agregar_turno turno = new Agregar_turno();
                turno.TopLevel = false;
                turno.Dock = DockStyle.Fill;
                splitContainer1.Panel2.Controls.Add(turno);
                turno.BringToFront();
                turno.Show();
                L_mensaje.Text = "";
            }
            else
            {
                L_mensaje.Text = "*La ventana esta abierta";
                
            }
        }

        private void B_NuevoPaciente_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Alta_paciente);
            if (frm == null)
            {
                Alta_paciente paciente = new Alta_paciente();
                paciente.TopLevel = false;
                paciente.Dock = DockStyle.Fill;
                splitContainer1.Panel2.Controls.Add(paciente);
                paciente.BringToFront();
                paciente.Show();
                L_mensaje.Text = "";
            }
            else
            {
                L_mensaje.Text = "*La ventana esta abierta";

            }
        }

        private void B_ModificarTurno_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Modificar_turno);
            if (frm == null)
            {
                Modificar_turno turno_m = new Modificar_turno();
                turno_m.TopLevel = false;
                turno_m.Dock = DockStyle.Fill;
                splitContainer1.Panel2.Controls.Add(turno_m);
                turno_m.BringToFront();
                turno_m.Show();
                L_mensaje.Text = "";
            }
            else
            {
                L_mensaje.Text = "*La ventana esta abierta";

            }
        }

        private void B_ModificarPaciente_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Modificar_paciente);
            if (frm == null)
            {
                Modificar_paciente paciente_m = new Modificar_paciente();
                paciente_m.TopLevel = false;
                paciente_m.Dock = DockStyle.Fill;
                splitContainer1.Panel2.Controls.Add(paciente_m);
                paciente_m.BringToFront();
                paciente_m.Show();
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
