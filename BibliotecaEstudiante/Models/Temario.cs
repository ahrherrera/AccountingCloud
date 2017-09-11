using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEstudianteMain.Models
{
    class Temario
    {
        public int idTemario { get; set; }
        public int idLibro { get; set; }
        public string nombreTema { get; set; }
        public string Descripcion { get; set; }
        public int pagInicial { get; set; }
        public int pagFinal { get; set; }

        public Temario(int idLibro, string nombreTema, string descripcion, int pagInicial, int oagFinal)
        {
            this.idLibro = idLibro;
            this.nombreTema = nombreTema;
            Descripcion = descripcion;
            this.pagInicial = pagInicial;
            this.pagFinal = oagFinal;
        }
    }
}
