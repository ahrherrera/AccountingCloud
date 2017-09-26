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
using BibliotecaEstudianteMain.Models;
using Bunifu.Framework.UI;

namespace BibliotecaEstudiante.UI
{
    public partial class SearchItem : UserControl
    {
        public Temario prop;
        public Busqueda busquedaParent;
        public MainPrincipal rec;
        private Temario tema1;

        public SearchItem(Temario tema, string busqueda, FlowLayoutPanel parent, Busqueda busquedaC, MainPrincipal principal)
        {
            InitializeComponent();
            //this.Dock = DockStyle.Top;
            prop = tema;
            txt_Temario.Text = prop.nombreTema;
            btn_Descripcion.Text = prop.Descripcion;
            this.Width = parent.Width;
            busquedaParent = busquedaC;
            rec = principal;
            tema1 = tema;
        }

        private void SearchItem_Click(object sender, EventArgs e)
        {
            rec.cambiarPanel(new VistaSingular(rec,tema1, new SearchItemController().getLibro(tema1),busquedaParent));
        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
            if (Comparar.Checked)
            {
                busquedaParent.AComparar(prop);
            }
            else
            {
                busquedaParent.NoComparar(prop);
            }
        }

        
    }
}
