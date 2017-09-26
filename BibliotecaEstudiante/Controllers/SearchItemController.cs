using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaEstudiante.Models;
using BibliotecaEstudianteMain.Models;
using BibliotecaEstudianteMain.utils;

namespace BibliotecaEstudiante.Controllers
{
    class SearchItemController
    {
        public SearchItemController()
        {
        }

        public Libro getLibro(Temario tema)
        {
            Libro encontrado = null;
            SqliteQuery cql = new SqliteQuery();
            string query = "Select Nombre, Autor, idCategoria, NombreLocal from Libros where idLibro= "+ tema.idLibro +";";
            SQLiteDataReader read = cql.ExecQueryReader(query);

            while (read.Read())
            {
                encontrado = new Libro(tema.idLibro, read.GetString(0), read.GetString(1), read.GetString(3), new Categoria(read.GetInt32(2)));
            }
            return encontrado;
        }
    }
}
