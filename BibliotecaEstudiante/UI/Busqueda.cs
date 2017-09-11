using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaEstudianteMain;

namespace BibliotecaEstudiante.UI
{
    public partial class Busqueda : UserControl
    {
        private bool hidden;
        public MainPrincipal lastest;
        public bool customSearch = false;
        public Busqueda(MainPrincipal last)
        {
            InitializeComponent();
            txt_search.Text = "";
            cmb_Categoria.DropDownStyle = ComboBoxStyle.DropDownList;
            lastest = last;
        }

        public Busqueda(MainPrincipal last, string param)
        {
            InitializeComponent();
            lastest = last;
            txt_search.Text = param;
            bunifuFlatButton1_Click(null,EventArgs.Empty);
            cmb_Categoria.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (cmb_Categoria.SelectedIndex==0 && rb_todos.Checked && cmb_Autores.SelectedIndex==0) // Busqueda general
            {

            }
            else
            { // Busqueda personalizada
                
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

        private void cmb_Categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Categoria.SelectedIndex == 0)
            {
                customSearch = false;
            }
        }
    }
}
