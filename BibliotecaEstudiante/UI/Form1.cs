using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Parsing;
using Syncfusion.Windows.Forms.PdfViewer;
using Syncfusion.Windows.PdfViewer;

namespace BibliotecaEstudianteMain
{
    public partial class Form1 : Form { 
    

        /*Este Form es una plantilla para ver como funciona el visor de PDF*/
        private String path = "";
        public Form1()
        {
            InitializeComponent();
            //Obtener la ruta del PDF, los PDF se encontraran en la variable LibrosDir
            path = "C:\\Users\\ahrhe\\Downloads\\Fiabilidad.pdf";
            //Formatear el visor e ingresar la ruta del PDF con el metodo Visor(control, ruta)
            pdfViewerControl1 = Controllers.ControlesPersonalizados.Visor(pdfViewerControl1, path);
            //Acoplar al contenedor parent
            pdfViewerControl1.Dock= DockStyle.Fill;


        }
    }
}
