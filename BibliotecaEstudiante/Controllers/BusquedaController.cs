using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaEstudiante.Models;
using BibliotecaEstudianteMain.Models;
using BibliotecaEstudianteMain.utils;

namespace BibliotecaEstudiante.Controllers
{
    class BusquedaController
    {
        public BusquedaController()
        {
        }

        public List<Temario> buscarTema(string qryTema)
        {
            List<Temario> temasEncontrados = new List<Temario>();
            SqliteQuery cql = new SqliteQuery();

            cql.ExecQuery(
                "DROP TABLE IF EXISTS Busqueda;" +
                "Create virtual table Busqueda using FTS3(idTema, idLibro, NombreTema, NombreTemaN, Descripcion, DescripcionN, pagInicial, pagFinal);");
            cql.ExecQuery(
                "Insert into Busqueda Select idTema, idLibro, NombreTema, replace(replace(replace(replace(replace(replace(replace(replace(replace(replace(replace(lower(NombreTema), 'á', 'a'), 'ã', 'a'), 'â', 'a'), 'é', 'e'), 'ê', 'e'), 'í', 'i'), 'ó', 'o'), 'õ', 'o'), 'ô', 'o'), 'ú', 'u'), 'ç', 'c'), Descripcion, replace(replace(replace(replace(replace(replace(replace(replace(replace(replace(replace(lower(Descripcion), 'á', 'a'), 'ã', 'a'), 'â', 'a'), 'é', 'e'), 'ê', 'e'), 'í', 'i'), 'ó', 'o'), 'õ', 'o'), 'ô', 'o'), 'ú', 'u'), 'ç', 'c'), pagInicial, pagFinal from Temario; ");

            String[] palabras = qryTema.Split(' ');

            string match = "";

            for (int i = 0; i < palabras.Length; i++)
            {
                if (i == (palabras.Length - 1))
                {
                    match = match + palabras[i];
                }
                else
                {
                    match = match + palabras[i] + " OR ";
                }
            }
            string query = "Select idTema, idLibro, NombreTema, Descripcion, pagInicial, pagFinal from Busqueda where Busqueda match '"+ match +"'";

            SQLiteDataReader read = cql.ExecQueryReader(query);

            while (read.Read())
            {
                temasEncontrados.Add(new Temario(read.GetInt32(0),read.GetInt32(1),read.GetString(2),read.GetString(3),read.GetInt32(4),read.GetInt32(5)));
            }

            return temasEncontrados;
        }
    }
}
