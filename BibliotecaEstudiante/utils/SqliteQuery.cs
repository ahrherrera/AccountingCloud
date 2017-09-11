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
                    SQLiteCommand sqlcomd = new SQLiteCommand(query, c);
                    DS = new DataSet();

                    DB.Fill(DSt;
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

        public SQLiteDataReader ExecQueryReader(string query){
            SQLiteDataReader reader = null;
             if (checkConnection())
            {
                try
                {
                    SQLiteCommand sqlcmd = new SQLiteCommand(query, c);
                    reader = sqlcmd.ExecuteReader();
                    return reader;
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
