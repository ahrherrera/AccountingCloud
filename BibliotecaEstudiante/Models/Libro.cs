using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEstudianteMain.Models
{
    class Libro
    {
        private int idLibro;
        private string nombreLibro;
        private string nombreAutor;
        private string ruta;
        private Categoria Categoria;

        public Libro(int idLibro, string nombreLibro, string nombreAutor, string ruta, Categoria caty)
        {
            this.idLibro = idLibro;
            this.nombreLibro = nombreLibro;
            this.nombreAutor = nombreAutor;
            this.ruta = ruta;
            this.Categoria = caty;
        }

        public Categoria Categoria1
        {
            get => Categoria;
            set => Categoria = value;
        }

        public int IdLibro
        {
            get => idLibro;
            set => idLibro = value;
        }

        public string NombreLibro
        {
            get => nombreLibro;
            set => nombreLibro = value;
        }

        public string NombreAutor
        {
            get => nombreAutor;
            set => nombreAutor = value;
        }

        public string Ruta
        {
            get => ruta;
            set => ruta = value;
        }
    }
}
