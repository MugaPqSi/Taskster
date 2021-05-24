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

        private void equiposBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.equiposBindingSource.EndEdit();

        }

        private void Form_admin_equipos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'admin_proyectosDataSet1.vista_equipos' Puede moverla o quitarla según sea necesario.
            this.vista_equiposTableAdapter.Fill(this.admin_proyectosDataSet1.vista_equipos);
            // TODO: esta línea de código carga datos en la tabla 'admin_proyectosDataSet.equipos' Puede moverla o quitarla según sea necesario.
            this.equiposTableAdapter.Fill(this.admin_proyectosDataSet.equipos);

        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            Form_menu menu_principal = new Form_menu();
            menu_principal.Show();
            this.Hide();
        }
    }
}
