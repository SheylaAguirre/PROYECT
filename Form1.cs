using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyect
{
    public partial class Form1 : Form
    {
        String usuario = "Jesus";
        String contrasena = "jesus";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != usuario || txtContrasena.Text != contrasena)
            {
                if (txtUsuario.Text != usuario)
                {
                    MessageBox.Show("El usuario es incorrecto");
                    txtUsuario.Clear();
                    txtUsuario.Focus();
                    return;
                }
                if (txtContrasena.Text != contrasena)
                {
                    MessageBox.Show("La contraseña es incorrecta");
                    MessageBox.Show("Vuelve a intentarlo");
                    txtContrasena.Clear();
                    txtContrasena.Focus();
                    return;
                }
            }
            else
            {
                txtUsuario.Clear();
                txtContrasena.Clear();
                Form2 Form = new Form2();
                Form.ShowDialog();
            }
        }
    }
}
