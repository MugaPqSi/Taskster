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
    public partial class Form_administrar_proyectos : Form
    {
        public Form_administrar_proyectos()
        {
            InitializeComponent();
        }

        private void equiposBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.equiposBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.admin_proyectosDataSet);

        }

        private void Form_administrar_proyectos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'admin_proyectosDataSet.proyectos' Puede moverla o quitarla según sea necesario.
            this.proyectosTableAdapter.Fill(this.admin_proyectosDataSet.proyectos);
            // TODO: esta línea de código carga datos en la tabla 'admin_proyectosDataSet.equipos' Puede moverla o quitarla según sea necesario.
            this.equiposTableAdapter.Fill(this.admin_proyectosDataSet.equipos);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            Form_menu menu_principal = new Form_menu();
            menu_principal.Show();
            this.Hide();
        }
    }
}
