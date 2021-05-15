using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form_admin_equipos : Form
    {
        public Form_admin_equipos()
        {
            InitializeComponent();
        }

        private void btn_crear_equipo_Click(object sender, EventArgs e)
        {
            Form_crear_equipo menu_crear_equipo = new Form_crear_equipo();
            menu_crear_equipo.Show();
        }
    }
}
