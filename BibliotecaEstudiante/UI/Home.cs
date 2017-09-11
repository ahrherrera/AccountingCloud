using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaEstudiante.UI;
using Syncfusion.Windows.Forms;

namespace BibliotecaEstudianteMain.UI
{
    public partial class Home : UserControl
    {
        private Form theParent;
        public Home(Form parent)
        {
            InitializeComponent();
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            theParent = parent;
            ((MainPrincipal) theParent).currentView = "Inicio";
        }

        private void btn_InicioContabilidad_Click(object sender, EventArgs e)
        {

            ((MainPrincipal)theParent).btnContabilidad_Click_1(null,EventArgs.Empty);
        }

        private void btn_InicioEconomia_Click(object sender, EventArgs e)
        {
            ((MainPrincipal)theParent).btn_Economia_Click(null, EventArgs.Empty);
        }

        private void btn_InicioAdminEmp_Click(object sender, EventArgs e)
        {
            ((MainPrincipal)theParent).btn_AdminEmp_Click(null, EventArgs.Empty);
        }

        private void btn_InicioMercadeo_Click(object sender, EventArgs e)
        {
            ((MainPrincipal)theParent).btn_Mercadeo_Click(null, EventArgs.Empty);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Buscar(textBox1.Text);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Buscar(textBox1.Text);
            }
        }

        public void Buscar(string query)
        {
            ((MainPrincipal)theParent).btn_Busqueda_Click(null, EventArgs.Empty);
            if (!query.Equals(""))
            {
                //Mostrar panel de Busqueda
                ((MainPrincipal)theParent).cambiarPanel(new Busqueda((MainPrincipal)theParent, textBox1.Text));
            }
            else
            {
                ((MainPrincipal)theParent).cambiarPanel(new Busqueda((MainPrincipal)theParent));
            }
        }
    }
}
