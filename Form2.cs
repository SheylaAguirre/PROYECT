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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblFechaActual.Text = DateTime.Today.Date.ToString("d");
        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {
            lblLider.Text = textNombre.Text;
        }
    }
}
