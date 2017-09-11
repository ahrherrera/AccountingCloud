using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace BibliotecaEstudianteMain.utils
{
    class SqliteQuery
    {
        public static string connString = "data source=" + variables.dbnombre;
        private SQLiteConnection conn = new SQLiteConnection(connString);
        /*private string createQuery = @"CREATE TABLE IF NOT EXISTS [USUARIO] (
                             [ID] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                             [Name] NVARCHAR(2048) NULL,
                             [Genero] NVARCHAR(2048) NULL)";*/

        public SqliteQuery()
        {
            
        }

        public Boolean checkConnection()
        {
            try
            {
                conn.Open();
                conn.Close();
                //MessageBox.Show("Conexion Establecida");
                return true;
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error en abrir la Conexion a la BD +\n" + ex.StackTrace);
                return false;
            }
        }

        public int ExecQuery(string query)
        {
            using (SQLiteConnection conect = new SQLiteConnection(connString))
            {
                using (SQLiteCommand cmd = new SQLiteCommand(query, conect))
                {
                    try
                    {
                        conect.Open();
                        int rows = cmd.ExecuteNonQuery();
                        conect.Close();
                        return rows;
                    }
                    catch (SQLiteException ex)
                    {
                        MessageBox.Show(ex.Message);
                        conect.Close();
                        return 0;
                    }
                }
            }
        }

        public DataSet ExecQueryReturn(string query)
        {
            DataSet DS;
            if (checkConnection())
            {
                try
                {
                    SQLiteDataAdapter DB = new SQLiteDataAdapter(query, conn);
                    DS = new DataSet();

                    DB.Fill(DS);
                    return DS;
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }
            else
            {
                MessageBox.Show("No hay Conexion");
                return null;
            }

        }






    }
}
