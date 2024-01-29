using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Medico;

namespace Vista.Administrador
{
    public partial class Menu_administrador : Form
    {
        public Menu_administrador()
        {
            InitializeComponent();
            L_mensaje.Text = "";

        }

        private void B_AgregarMedico_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Agregar_medico);
            if (frm == null)
            {
                Agregar_medico medico = new Agregar_medico();
                medico.TopLevel = false;
                medico.Dock = DockStyle.Fill;
                splitContainer1.Panel2.Controls.Add(medico);
                medico.BringToFront();
                medico.Show();
                L_mensaje.Text = "";
            }
            else
            {
                L_mensaje.Text = "*La ventana esta abierta";

            }
        }

        private void B_AgregarSecretario_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Agregar_secretario);
            if (frm == null)
            {
                Agregar_secretario secretario = new Agregar_secretario();
                secretario.TopLevel = false;
                secretario.Dock = DockStyle.Fill;
                splitContainer1.Panel2.Controls.Add(secretario);
                secretario.BringToFront();
                secretario.Show();
                L_mensaje.Text = "";
            }
            else
            {
                L_mensaje.Text = "*La ventana esta abierta";

            }
        }

        private void B_modificarMedico_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Modificar_medico);
            if (frm == null)
            {
                Modificar_medico medico = new Modificar_medico();
                medico.TopLevel = false;
                medico.Dock = DockStyle.Fill;
                splitContainer1.Panel2.Controls.Add(medico);
                medico.BringToFront();
                medico.Show();
                L_mensaje.Text = "";
            }
            else
            {
                L_mensaje.Text = "*La ventana esta abierta";

            }
        }

        private void B_ModificarSecretario_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Modificar_secretario);
            if (frm == null)
            {
                Modificar_secretario secretario = new Modificar_secretario();
                secretario.TopLevel = false;
                secretario.Dock = DockStyle.Fill;
                splitContainer1.Panel2.Controls.Add(secretario);
                secretario.BringToFront();
                secretario.Show();
                L_mensaje.Text = "";
            }
            else
            {
                L_mensaje.Text = "*La ventana esta abierta";

            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
