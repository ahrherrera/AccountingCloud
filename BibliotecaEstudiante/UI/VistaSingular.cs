using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaEstudiante.Models;
using BibliotecaEstudianteMain;
using BibliotecaEstudianteMain.Controllers;
using BibliotecaEstudianteMain.Models;

namespace BibliotecaEstudiante.UI
{
    public partial class VistaSingular : UserControl
    {
        private MainPrincipal padre;
        private Busqueda parent;
        public VistaSingular(MainPrincipal parent, Temario tema, Libro libro, Busqueda parent_Busqueda)
        {
            InitializeComponent();
            padre = parent;
            pdfViewerControl1 = ControlesPersonalizados.Visor(pdfViewerControl1, tema, libro);
            this.parent = parent_Busqueda;
            lbl_Tema.Text = tema.nombreTema;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            padre.cambiarPanel(this.parent);
        }
    }
}
