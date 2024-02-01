using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.Administrador
{
    public partial class Agregar_medico : Form
    {
        public Agregar_medico()
        {
            InitializeComponent();
            L_mensaje.Text = "";
        }

        private void B_Guardar_Click(object sender, EventArgs e)
        {
            //Primero verificamos
            //Armamos el objeto
            //Pasamos a la capa de datos
        }

        private void solo_numeros(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                L_mensaje.Text = "";

            }
            else
            {
                e.Handled = true;
                L_mensaje.Text = "*DEBES INGRESAR SOLO DATOS NUMERICOS";

            }
        }
    }
}
