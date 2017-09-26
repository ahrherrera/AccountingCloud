using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEstudianteMain.Models
{
    public class Categoria
    {
        public int idCategoria { get; set; }
        public string nombreCategoria { get; set; }

        public Categoria(int idCategoria)
        {
            this.idCategoria = idCategoria;
        }

        public Categoria(int idCategoria, string nombreCategoria)
        {
            this.idCategoria = idCategoria;
            this.nombreCategoria = nombreCategoria;
        }
    }
}
