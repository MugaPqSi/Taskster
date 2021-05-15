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
    public partial class Form_Login : Form
    {
        String ingreso_user = "Admin";
        String ingreso_pass = "123";

        public Form_Login()
        {
            InitializeComponent();
            
        }
        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            String user = textbox_user.Text;
            String password = textbox_pass.Text;

            if (user == ingreso_user && password == ingreso_pass) {
                Form_menu menu = new Form_menu();
                menu.Show();
                this.Hide();
            } else {
                MessageBox.Show("Contraseña o usuario incorrecto");
            }
            
        }
    }
}
