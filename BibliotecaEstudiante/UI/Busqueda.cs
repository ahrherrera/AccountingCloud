using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaEstudiante.Controllers;
using BibliotecaEstudiante.Models;
using BibliotecaEstudianteMain;
using BibliotecaEstudianteMain.Controllers;
using BibliotecaEstudianteMain.Models;
using Syncfusion.Windows.Forms.Grid;

namespace BibliotecaEstudiante.UI
{
    public partial class Busqueda : UserControl
    {
        private bool hidden;
        public MainPrincipal lastest;
        public bool customSearch = false;
        List<Temario> paraComparar = new List<Temario>();
        private int contador=0;
        public Busqueda(MainPrincipal last)
        {
            InitializeComponent();
            LlenarCombobox();
            txt_search.Text = "";
            
            lastest = last;
            
            cmb_Categoria.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public Busqueda(MainPrincipal last, string param)
        {
            InitializeComponent();
            LlenarCombobox();
            lastest = last;
            txt_search.Text = param;
           
            
            
            cmb_Categoria.DropDownStyle = ComboBoxStyle.DropDownList;
            bunifuFlatButton1_Click(null, EventArgs.Empty);
        }

        public void LlenarCombobox()
        {

            List<string> listaCategoria = new List<string>();
            listaCategoria.Add("Todas");
            DataSet ds = new DBUtilsController().ObtenerCategorias();
            foreach (DataRow dataRow in ds.Tables[0].Rows)
            {
                foreach (object value in dataRow.ItemArray)
                {
                    listaCategoria.Add(value.ToString());
                }
            }
            BindingSource bs1 = new BindingSource();
            
            bs1.DataSource = listaCategoria;
            cmb_Categoria.BindingContext = this.BindingContext;


            cmb_Categoria.DataSource = bs1.DataSource;
            cmb_Categoria.DisplayMember = "NombreCategoria";

            Items.HorizontalScroll.Visible = false;
        }

        public void AComparar(Temario t)
        {
            contador++;
            paraComparar.Add(t);
            if (contador>1 && contador<=3)
            {
                bunifuFlatButton2.Text = "Comparar (" + contador + ")";
                bunifuFlatButton2.Visible = true;
            }
            else
            {
                bunifuFlatButton2.Visible = false;
            }
            
        }

        public void NoComparar(Temario t)
        {
            contador--;
            paraComparar.Remove(t);
            if (contador > 1)
            {
                bunifuFlatButton2.Text = "Comparar (" + contador + ")";
                bunifuFlatButton2.Visible = true;
            }
            else
            {
                bunifuFlatButton2.Visible = false;
            }

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (cmb_Categoria.SelectedIndex==0) // Busqueda general
            {
                Items.Controls.Clear();
                List<Temario> listaTemarios = new BusquedaController().buscarTema(txt_search.Text);
                if (listaTemarios.Count > 0)
                {
                    foreach (Temario temario in listaTemarios)
                    {
                        Items.Controls.Add(new SearchItem(temario, txt_search.Text, Items, this, lastest));
                    }
                }
                else
                {
                    MessageBox.Show("No encontrado");
                }
            }
            else
            { // Busqueda personalizada
                MessageBox.Show("Busqueda personalizada");
                List<Temario> listaTemarios = new BusquedaController().buscarTemaPersonalizado(txt_search.Text,
                    new DBUtilsController().FindByNombreCategoria(
                        cmb_Categoria.GetItemText(cmb_Categoria.SelectedItem)));
                if (listaTemarios.Count > 0)
                {
                    foreach (Temario temario in listaTemarios)
                    {
                        Items.Controls.Add(new SearchItem(temario, txt_search.Text, Items, this, lastest));
                    }
                }
                else
                {
                    MessageBox.Show("No encontrado");
                }

            }
        }

        private void Busqueda_Load(object sender, EventArgs e)
        {
            panel3.Height = 0;
            lbl_toggle.Top = panel3.Top;
            hidden = true;
            lastest.currentView = "Busqueda";
        }

        private void lbl_toggle_Click(object sender, EventArgs e)
        {
            if (hidden)
            {
                panel3.Height = 60;
                lbl_toggle.Top = panel3.Top + panel3.Height + 10;
                hidden = false;
                lbl_toggle.Text = "Busqueda Avanzada ▲";
            }
            else
            {
                hidden = true;
                panel3.Height = 0;
                lbl_toggle.Top = panel3.Top;
                lbl_toggle.Text = "Busqueda Avanzada ▼";
            }
        }

        private void txt_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                bunifuFlatButton1_Click(null,EventArgs.Empty);
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            lastest.cambiarPanel(new Comparacion(paraComparar));
        }
    }
}
