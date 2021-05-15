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
    public partial class Form_menu : Form
    {
        public Form_menu()
        {
            InitializeComponent();
        }

        private void btn_ir_avance_tareas_Click(object sender, EventArgs e)
        {
            Form_admin_equipos menu_administrar_equipos = new Form_admin_equipos();
            menu_administrar_equipos.Show();
        }

        private void lbl_ir_avance_tareas_Click(object sender, EventArgs e)
        {

        }

        private void lbl_ir_anadir_tareas_Click(object sender, EventArgs e)
        {

        }

        private void btn_ir_crear_proyecto_Click(object sender, EventArgs e)
        {
            Form_nuevo_proyecto menu_nuevo_proyecto = new Form_nuevo_proyecto();
            menu_nuevo_proyecto.Show();
        }

        private void btn_ir_anadir_tareas_Click(object sender, EventArgs e)
        {
            Form_administrar_proyectos menu_administrar_proyectos = new Form_administrar_proyectos();
            menu_administrar_proyectos.Show();
        }
    }
}
