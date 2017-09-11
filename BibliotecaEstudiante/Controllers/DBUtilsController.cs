using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaEstudianteMain.Models;
using BibliotecaEstudianteMain.utils;

namespace BibliotecaEstudianteMain.Controllers
{
    class DBUtilsController
    {
        public DBUtilsController()
        {
        }

        public DataSet RellenaLibros()
        {
            SqliteQuery cql = new SqliteQuery();
            DataSet ds = cql.ExecQueryReturn("Select l.idLibro as 'ID libro', l.Nombre as 'Nombre del Libro', l.Autor, c.NombreCategoria as 'Categoria', (Select count(*) from Temario where idLibro = l.idLibro) as 'Numero de Temas' from Libros l  inner join Categoria c on c.idCategoria = l.idCategoria;");
            

            if (ds != null)
            {
                //tabla.DataSource = ds.Tables[0];

                if (ds.Tables[0].Rows.Count <= 0)
                {
                    MessageBox.Show("Tabla Vacia");
                    return ds;
                }
                else
                {
                    return ds;
                }
            }
            else
            {
                return null;
            }
        }

        public DataSet ObtenerTemario(int idLibro)
        {
            SqliteQuery cql = new SqliteQuery();
            DataSet ds = cql.ExecQueryReturn("Select idTema as 'ID de Tema', NombreTema as 'Nombre del Tema', pagInicial as 'Inicio de Pagina', pagFinal as 'Fin de Pagina' from Temario where idLibro =" + idLibro);
            if (ds != null)
            {
                if (ds.Tables[0].Rows.Count <= 0)
                {
                    MessageBox.Show("Libro Sin Temas");
                    return ds;
                }
                else
                {
                    return ds;
                }
            }
            else
            {
                return null;
            }

        }

        public Categoria FindByNombreCategoria(string nombre)
        {
            //MessageBox.Show(nombre);
            SqliteQuery cql = new SqliteQuery();
            string query = "Select idCategoria from Categoria where nombreCategoria = '"+ nombre+"'";
            DataSet ds = cql.ExecQueryReturn(query);

            return new Categoria(Int32.Parse(ds.Tables[0].Rows[0].ItemArray[0].ToString()));
            
        }


        public string InsertarLibro(Libro libro)
        {
            SqliteQuery cql = new SqliteQuery();
            string query = String.Format("insert into Libros(Nombre,Autor,idCategoria,NombreLocal) values ('{0}','{1}',{2},'{3}');", libro.NombreLibro,libro.NombreAutor, libro.Categoria1.idCategoria,libro.Ruta);
            if (cql.ExecQuery(query) >= 1)
            {
                return "Se ha insertado exitosamente.";
            }
            else
            {
                return "No se ha insertado.";
            }
        }

        public string InsertarTemario(Temario temario)
        {
            SqliteQuery cql = new SqliteQuery();
            string query = String.Format("insert into Temario(idLibro, NombreTema,Descripcion,pagInicial,pagFinal) " +
                                         "values({0},'{1}','{2}',{3},{4})",temario.idLibro,temario.nombreTema,temario.Descripcion, 
                                         temario.pagInicial, temario.pagFinal);
            if (cql.ExecQuery(query) >= 1)
            {
                return "Se ha insertado exitosamente.";
            }
            else
            {
                return "No se ha insertado.";
            }
        }

        public DataSet ObtenerCategorias()
        {
            SqliteQuery cql = new SqliteQuery();
            DataSet ds = cql.ExecQueryReturn("Select NombreCategoria from Categoria;");
            if (ds != null)
            {
                if (ds.Tables[0].Rows.Count <= 0)
                {
                    MessageBox.Show("Sin Categorias");
                    return ds;
                }
                else
                {
                    return ds;
                }
            }
            else
            {
                return null;
            }

        }



    }
}
