using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaEstudiante.UI;
using BibliotecaEstudianteMain.utils;
using BibliotecaEstudianteMain.UI;

namespace BibliotecaEstudianteMain
{
    public partial class MainPrincipal : Form
    {

        [DllImport("user32.dll")]
        static extern bool LockWindowUpdate(IntPtr hWndLock);

        public String currentView = "Inicio";

        public Color Coloriginal;
        public Color seleccionado = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(115)))), ((int)(((byte)(186)))));
        public MainPrincipal()
        {
            InitializeComponent();
            Coloriginal = btn_Inicio.BackColor;
            tableLayoutPanel1.Dock = DockStyle.Fill;
            //Revisa Conexion
            new SqliteQuery().checkConnection();
            tableLayoutPanel2.BorderStyle = BorderStyle.None;
            Inicio_Click(null, EventArgs.Empty);
            //this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
            
        }
        
        private void MainPrincipal_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new System.Drawing.Size(this.Width, this.Height);

            
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void MainPrincipal_Resize(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
        }

        public void Inicio_Click(object sender, EventArgs e)
        {
            
                CambiarSeleccionado(btn_Inicio, btn_Contabilidad, btn_AdminEmp, btn_Economia, btn_Mercadeo, btn_Busqueda);
                tableLayoutPanel1.Controls.Remove(tableLayoutPanel1.GetControlFromPosition(1, 0));
                tableLayoutPanel1.Controls.Add(new Home(this), 1, 0);
                Acoplar();
            
            
        }

        public void btnContabilidad_Click_1(object sender, EventArgs e)
        {
            CambiarSeleccionado(btn_Contabilidad, btn_Inicio, btn_AdminEmp, btn_Economia, btn_Mercadeo, btn_Busqueda);
            tableLayoutPanel1.Controls.Remove(tableLayoutPanel1.GetControlFromPosition(1,0));
            tableLayoutPanel1.Controls.Add(new Contabilidad(), 1, 0);
            Acoplar();
        }
        public void btn_Economia_Click(object sender, EventArgs e)
        {
            CambiarSeleccionado(btn_Economia, btn_Inicio, btn_AdminEmp, btn_Contabilidad, btn_Mercadeo, btn_Busqueda);
            tableLayoutPanel1.Controls.Remove(tableLayoutPanel1.GetControlFromPosition(1, 0));
            tableLayoutPanel1.Controls.Add(new Economia(), 1, 0);
            Acoplar();
        }

        public void btn_AdminEmp_Click(object sender, EventArgs e)
        {
            CambiarSeleccionado(btn_AdminEmp, btn_Inicio, btn_Economia, btn_Contabilidad, btn_Mercadeo, btn_Busqueda);
            tableLayoutPanel1.Controls.Remove(tableLayoutPanel1.GetControlFromPosition(1, 0));
            tableLayoutPanel1.Controls.Add(new AdminEmp(), 1, 0);
            Acoplar();
        }

        public void btn_Mercadeo_Click(object sender, EventArgs e)
        {
            CambiarSeleccionado(btn_Mercadeo, btn_Inicio, btn_Economia, btn_Contabilidad, btn_AdminEmp,btn_Busqueda);
            tableLayoutPanel1.Controls.Remove(tableLayoutPanel1.GetControlFromPosition(1, 0));
            tableLayoutPanel1.Controls.Add(new Mercadeo(), 1, 0);
            Acoplar();
        }

        public void Acoplar()
        {
            tableLayoutPanel1.GetControlFromPosition(1,0).Dock = DockStyle.Fill;
        }

        public void cambiarPanel(UserControl obj)
        {
            tableLayoutPanel1.Controls.Remove(tableLayoutPanel1.GetControlFromPosition(1, 0));
            tableLayoutPanel1.Controls.Add(obj, 1, 0);
            Acoplar();
        }

        public void CambiarSeleccionado(Button botonS, Button boton1, Button boton2, Button boton3, Button boton4, Button boton5)
        {
            //Seleccionado
            botonS.BackColor = seleccionado;
            botonS.ForeColor = Color.White;
            
            //No Seleccionados
            boton1.BackColor = Coloriginal;
            boton1.ForeColor = Color.Black;
            boton2.BackColor = Coloriginal;
            boton2.ForeColor = Color.Black;
            boton3.BackColor = Coloriginal;
            boton3.ForeColor = Color.Black;
            boton4.BackColor = Coloriginal;
            boton4.ForeColor = Color.Black;
            boton5.BackColor = Coloriginal;
            boton5.ForeColor = Color.Black;
        }

        public void btn_Busqueda_Click(object sender, EventArgs e)
        {
            if (!currentView.Equals("Busqueda"))
            {
                CambiarSeleccionado(btn_Busqueda, btn_Inicio, btn_Contabilidad, btn_AdminEmp, btn_Economia,
                    btn_Mercadeo);
                tableLayoutPanel1.Controls.Remove(tableLayoutPanel1.GetControlFromPosition(1, 0));
                tableLayoutPanel1.Controls.Add(new Busqueda(this), 1, 0);
                Acoplar();
            }
        }

        private void MainPrincipal_Shown(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }
    }
}
