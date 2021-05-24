using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form_nuevo_proyecto : Form
    {
        public Form_nuevo_proyecto()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-32OA3Q1\SQLEXPRESS;Initial Catalog=admin_proyectos;Integrated Security=True");

        private void btn_crear_proyecto_Click(object sender, EventArgs e)
        {
            string nombre = txt_nombre_proyecto.Text;
            string descripcion = txt_descripcion.Text;
            int tipo = Convert.ToInt32(list_tipo_proyecto.SelectedValue);

            string sql = "INSERT INTO proyectos (nombre,descripcion,tipo) " +
                            "VALUES( ' " + nombre + " ','" +descripcion + "','" + tipo + "' )";
            try
            {
                if (nombre == "" || tipo == 0)
                {
                    MessageBox.Show("Ingresar un nombre y tipo de proyecto");
                }
                else
                {
                    Console.WriteLine(sql);
                    SqlCommand cmdinsert = new SqlCommand(sql, con);
                    con.Open();
                    cmdinsert.CommandType = CommandType.Text;
                    cmdinsert.ExecuteNonQuery();
                    MessageBox.Show("Proyecto creado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void Form_nuevo_proyecto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'admin_proyectosDataSet.tipos_proyectos' Puede moverla o quitarla según sea necesario.
            this.tipos_proyectosTableAdapter.Fill(this.admin_proyectosDataSet.tipos_proyectos);

        }
    }
}
