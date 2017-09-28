using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaEstudiante.UI;
using Bunifu.Framework.UI;

namespace BibliotecaEstudianteMain.UI
{
    public partial class Contabilidad : UserControl
    {
        private MainPrincipal par;
        public Contabilidad(MainPrincipal parent)
        {
            InitializeComponent();
            par = parent;
        }

        

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            
                par.btn_Busqueda_Click(null, EventArgs.Empty);
                
                    //Mostrar panel de Busqueda
                    par.cambiarPanel(new Busqueda(par, (sender as BunifuTileButton).LabelText));
                
            }
        
    }
}
