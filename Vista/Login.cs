using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Administrador;
using Vista.Medico;
using Vista.Secretario;

namespace Vista
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void B_iniciarSesion_Click(object sender, EventArgs e)
        {
            if (TB_Usuario.Text == "a")
            {
                Menu_administrador menu_a = new Menu_administrador();
                this.Hide();
                menu_a.ShowDialog();
                this.Show();

            }
            if (TB_Usuario.Text == "s")
            {
                Menu_secretario menu_s = new Menu_secretario();
                this.Hide(); //oculta el form actual
                menu_s.ShowDialog();
                this.Show();


            }
            if (TB_Usuario.Text == "m")
            {
                Menu_medico menu_s = new Menu_medico();
                this.Hide(); //oculta el form actual
                menu_s.ShowDialog();
                this.Show();


            }
        }
    }
}
