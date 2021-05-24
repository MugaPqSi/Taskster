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
    public partial class Form_crear_equipo : Form
    {
        public Form_crear_equipo()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-32OA3Q1\SQLEXPRESS;Initial Catalog=admin_proyectos;Integrated Security=True");

        private void btn_crear_equipo_Click(object sender, EventArgs e)
        {
            string nombre_equipo = text_nombre_equipo.Text;
            int categoria = Convert.ToInt32(list_categoria.SelectedValue);
            string descripcion = text_descripcion.Text;

            string sql = "INSERT INTO equipos(nombre,categoria,descripcion) " +
                "           VALUES( ' " + nombre_equipo + " ','" + categoria + "','" + descripcion + "' )";
            try
            {
                if (nombre_equipo == "" || categoria == 0)
                {
                    MessageBox.Show("Ingresar un nombre y categoria");
                }
                else
                {
                    Console.WriteLine(sql);
                    SqlCommand cmdinsert = new SqlCommand(sql, con);
                    con.Open();
                    cmdinsert.CommandType = CommandType.Text;
                    cmdinsert.ExecuteNonQuery();
                    MessageBox.Show("Equipo creado");
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

        private void Form_crear_equipo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'admin_proyectosDataSet1.categorias' Puede moverla o quitarla según sea necesario.
            this.categoriasTableAdapter.Fill(this.admin_proyectosDataSet1.categorias);
        }
    }
}
