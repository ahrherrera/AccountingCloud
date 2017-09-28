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
using BibliotecaEstudianteMain.Controllers;
using Syncfusion.Windows.Forms.PdfViewer;

namespace BibliotecaEstudiante.UI
{
    public partial class Comparacion : UserControl
    {
        public Comparacion(List<Temario> temas)
        {
            InitializeComponent();

            foreach (Temario tema in temas)
            {
                TabPage tab = new TabPage(tema.nombreTema);
                PdfViewerControl control = new PdfViewerControl();
                control.Dock = DockStyle.Fill;
                tab.Controls.Add(ControlesPersonalizados.Visor(control, tema, new SearchItemController().getLibro(tema)));
                tabControl1.TabPages.Add(tab);
            }


        }
    }
}
