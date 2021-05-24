using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Equipo
    {
        private string nombre_equipo;
        private int categoria;
        private string descripcion;

        public Equipo(string nombre_equipo, int categoria, string descripcion)
        {
            this.Nombre_equipo = nombre_equipo;
            this.Categoria = categoria;
            this.Descripcion = descripcion;
        }

        public string Nombre_equipo { get => nombre_equipo; set => nombre_equipo = value; }
        public int Categoria { get => categoria; set => categoria = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public string toString()
        {
            return Nombre_equipo + " " + Categoria + " " + Descripcion;
        }
    }
}
