using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaEstudianteMain.Controllers;
using BibliotecaEstudianteMain.Models;
using BibliotecaEstudianteMain.utils;
using Syncfusion.Windows.Forms;

namespace BibliotecaEstudianteMain.UI
{
    public partial class MainDB : Form
    {
        private int idLibro = 0;
        public MainDB()
        {
            InitializeComponent();
            gridListControl1.MultiColumn = true;
            gridListControl1.ShowColumnHeader = true;
            gridListControl1.ThemesEnabled = true;
            gridListControl1.GridVisualStyles = GridVisualStyles.Metro;
            gridListControl1.SelectionMode = SelectionMode.One;
            //gridListControl1.AllowResizeColumns = true;
            gridListControl1.AutoSizeColumns = true;
            panel1.Visible = false;
            panel2.Visible = false;
            gridListControl1.BorderStyle = BorderStyle.FixedSingle;
            cmb_Categoria.DropDownStyle = ComboBoxStyle.DropDownList;
            gridListControl2.MultiColumn = true;
            gridListControl2.ShowColumnHeader = true;
            gridListControl2.ThemesEnabled = true;
            gridListControl2.GridVisualStyles = GridVisualStyles.Metro;
            gridListControl2.SelectionMode = SelectionMode.One;
            //gridListControl1.AllowResizeColumns = true;
            gridListControl2.AutoSizeColumns = true;
            gridListControl2.BorderStyle = BorderStyle.FixedSingle;
            /*dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            */
            popupControlContainer1.CloseOnTab = false;
            popupControlContainer1.Visible = false;
            popupControlContainer1.BorderStyle = BorderStyle.FixedSingle;
            LlenaLibros();


        }

        private void LlenaLibros()
        {
            gridListControl1.DataSource = new DBUtilsController().RellenaLibros().Tables[0];
        }

        private void gridListControl1_DoubleClick(object sender, EventArgs e)
        {
            int rowSelected = gridListControl1.SelectedIndex;
            if (rowSelected < 0)
            {
                panel1.Visible = false;
            }
            else
            {
                DataRowView drv = (DataRowView)gridListControl1.SelectedItem;

                label3.Text = "Libro Seleccionado: " + drv[1];

                idLibro = Int32.Parse(drv[0] + "");
                panel1.Visible = true;
                gridListControl2.DataSource = new DBUtilsController().ObtenerTemario(idLibro).Tables[0];
            }
            }

        public void ActualizaTablaLibros()
        {
            gridListControl2.DataSource = null;
            gridListControl2.DataSource = new DBUtilsController().ObtenerTemario(idLibro).Tables[0];
        }

        public void LlenarCategoria()
        {
            cmb_Categoria.DisplayMember = "NombreCategoria";
            cmb_Categoria.DataSource = new DBUtilsController().ObtenerCategorias().Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }


        private void btn_NuevoLibro_Click(object sender, EventArgs e)
        {
            ruta = "";
            nombre = "";
            panel1.Visible = false;
            Point loc = DesktopLocation;
            popupControlContainer1.ShowPopup(new Point(loc.X + 200, loc.Y + 150));
            LlenarCategoria();
        }

        private string ruta;
        private string nombre;

        private void button2_Click(object sender, EventArgs e)
        {
            using (FileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.Title = "Agrega un libro al catalogo";
                fileDialog.Filter = "Archivos PDF|*.pdf";
                if (DialogResult.OK == fileDialog.ShowDialog())
                {
                    ruta = fileDialog.FileName;
                    nombre = System.IO.Path.GetFileName(fileDialog.FileName);
                    txt_ruta.Text = fileDialog.FileName;
                    if (fileDialog.CheckFileExists)
                    {
                        System.IO.Directory.CreateDirectory(variables.LibrosDir);
                        System.IO.File.Copy(ruta, variables.LibrosDir + nombre, true);
                        MessageBox.Show(nombre);

                        }
                    else
                    {
                        MessageBox.Show("El archivo no existe");
                    }
                    
                    
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!txt_nombreLibro.Text.Equals("") && !txt_NombreAutor.Text.Equals("") && !txt_ruta.Text.Equals(""))
            {
                MessageBox.Show(new DBUtilsController().InsertarLibro(new Libro(0,txt_nombreLibro.Text,txt_NombreAutor.Text, nombre, new DBUtilsController().FindByNombreCategoria(cmb_Categoria.GetItemText(cmb_Categoria.SelectedItem)))));
            }
            popupControlContainer1.Visible = false;
            LlenaLibros();
            
        }


        private void popupControlContainer1_BeforeCloseUp(object sender, CancelEventArgs e)
        {
            if (!nombre.Equals(""))
            {
                System.IO.File.Delete(variables.LibrosDir+nombre);
            }

            txt_nombreLibro.Text = "";
            txt_NombreAutor.Text = "";
            txt_ruta.Text = "";

        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (idLibro>=1)
            {
                string nombreTema;
                string descripcion;
                int pagInicial;
                int pagFinal;

                nombreTema = txt_NombreTema.Text;
                descripcion = txt_Descripcion.Text;
                pagInicial = Convert.ToInt32(paginaInicial.Value);
                pagFinal = Convert.ToInt32(paginaFinal.Value);

                if (pagInicial <= pagFinal)
                {
                    MessageBox.Show(new DBUtilsController().InsertarTemario(new Temario(idLibro,nombreTema,descripcion,pagInicial,pagFinal)));
                    txt_NombreTema.Text = "";
                    txt_Descripcion.Text = "";
                    paginaInicial.Value = 0;
                    paginaFinal.Value = 0;
                    ActualizaTablaLibros();
                }


            }
        }
    }
}
