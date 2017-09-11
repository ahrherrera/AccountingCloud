using Syncfusion.Pdf;
using Syncfusion.Pdf.Parsing;
using Syncfusion.Windows.Forms.PdfViewer;

namespace BibliotecaEstudianteMain.Controllers
{
    public class ControlesPersonalizados
    {

        public static PdfViewerControl Visor(PdfViewerControl _visor, string path /*Cambiar a clase MostrarLibro*/)
        {
            //Ajusta las opciones del visor

            //Ajustar las paginas del PDF.
            _visor.ZoomMode = ZoomMode.FitPage;
            //Deshabilitar los marcadores que tenga el PDF para evitar la navegacion fuera del contenido
            _visor.IsBookmarkEnabled = false;
            //Deshabilitar el boton Abrir en el Visor para que no se puedan abrir otros PDF que el usuario elija
            _visor.ToolbarSettings.OpenButton.IsVisible = false;
            //Abre el documento completo sin mostrarlo
            PdfLoadedDocument loadedDocument = new PdfLoadedDocument(path);
            //Crea un nuevo PDF
            PdfDocument doc = new PdfDocument();
            //Importamos de un documento abierto, el rango de paginas que necesita mostrarse
            doc.ImportPageRange(loadedDocument, 4, 6);
            //Generar nombre temporal random
            doc.Save("temp\\doc1.pdf");
            _visor.Load("temp\\doc1.pdf");

            
            return _visor;
        }
    }
}