using BibliotecaEstudiante.Models;
using BibliotecaEstudianteMain.Models;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Parsing;
using Syncfusion.Windows.Forms.PdfViewer;

namespace BibliotecaEstudianteMain.Controllers
{
    public class ControlesPersonalizados
    {

        public static PdfViewerControl Visor(PdfViewerControl _visor, Temario tema, Libro libro)
        {
            //Ajusta las opciones del visor

            //Ajustar las paginas del PDF.
            _visor.ZoomMode = ZoomMode.FitWidth;
            //Deshabilitar los marcadores que tenga el PDF para evitar la navegacion fuera del contenido
            _visor.IsBookmarkEnabled = false;
            //Deshabilitar el boton Abrir en el Visor para que no se puedan abrir otros PDF que el usuario elija
            _visor.ToolbarSettings.OpenButton.IsVisible = false;
            //Abre el documento completo sin mostrarlo
            PdfLoadedDocument loadedDocument = new PdfLoadedDocument("Libros\\" + libro.Ruta);
            //Crea un nuevo PDF
            PdfDocument doc = new PdfDocument();
            //Importamos de un documento abierto, el rango de paginas que necesita mostrarse
            doc.ImportPageRange(loadedDocument, tema.pagInicial, tema.pagFinal);
            //Generar nombre temporal random
            doc.Save("temp\\doc1.pdf");
            _visor.Load("temp\\doc1.pdf");

            
            return _visor;
        }
    }
}