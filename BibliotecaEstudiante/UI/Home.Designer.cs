namespace BibliotecaEstudianteMain.UI
{
    partial class Home
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_InicioMercadeo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_InicioAdminEmp = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_InicioEconomia = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_InicioContabilidad = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(959, 565);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bunifuFlatButton1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(738, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 37);
            this.panel2.TabIndex = 2;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuFlatButton1.BorderRadius = 1;
            this.bunifuFlatButton1.ButtonText = "";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::BibliotecaEstudiante.Properties.Resources.Search_23px;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 50D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(245, 3);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(36, 34);
            this.bunifuFlatButton1.TabIndex = 1;
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(242, 33);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btn_InicioMercadeo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_InicioAdminEmp, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_InicioEconomia, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_InicioContabilidad, 0, 0);
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(198, 143);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(604, 285);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btn_InicioMercadeo
            // 
            this.btn_InicioMercadeo.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(32)))), ((int)(((byte)(162)))));
            this.btn_InicioMercadeo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(32)))), ((int)(((byte)(162)))));
            this.btn_InicioMercadeo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_InicioMercadeo.BorderRadius = 1;
            this.btn_InicioMercadeo.ButtonText = "Mercadeo";
            this.btn_InicioMercadeo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_InicioMercadeo.DisabledColor = System.Drawing.Color.Gray;
            this.btn_InicioMercadeo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_InicioMercadeo.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_InicioMercadeo.Iconimage = null;
            this.btn_InicioMercadeo.Iconimage_right = global::BibliotecaEstudiante.Properties.Resources.Increase_100px1;
            this.btn_InicioMercadeo.Iconimage_right_Selected = null;
            this.btn_InicioMercadeo.Iconimage_Selected = null;
            this.btn_InicioMercadeo.IconMarginLeft = 0;
            this.btn_InicioMercadeo.IconMarginRight = 0;
            this.btn_InicioMercadeo.IconRightVisible = true;
            this.btn_InicioMercadeo.IconRightZoom = 0D;
            this.btn_InicioMercadeo.IconVisible = true;
            this.btn_InicioMercadeo.IconZoom = 90D;
            this.btn_InicioMercadeo.IsTab = false;
            this.btn_InicioMercadeo.Location = new System.Drawing.Point(305, 145);
            this.btn_InicioMercadeo.Name = "btn_InicioMercadeo";
            this.btn_InicioMercadeo.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(32)))), ((int)(((byte)(162)))));
            this.btn_InicioMercadeo.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(22)))), ((int)(((byte)(152)))));
            this.btn_InicioMercadeo.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_InicioMercadeo.selected = false;
            this.btn_InicioMercadeo.Size = new System.Drawing.Size(296, 137);
            this.btn_InicioMercadeo.TabIndex = 3;
            this.btn_InicioMercadeo.Text = "Mercadeo";
            this.btn_InicioMercadeo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_InicioMercadeo.Textcolor = System.Drawing.Color.White;
            this.btn_InicioMercadeo.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InicioMercadeo.Click += new System.EventHandler(this.btn_InicioMercadeo_Click);
            // 
            // btn_InicioAdminEmp
            // 
            this.btn_InicioAdminEmp.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(64)))), ((int)(((byte)(30)))));
            this.btn_InicioAdminEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(64)))), ((int)(((byte)(30)))));
            this.btn_InicioAdminEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_InicioAdminEmp.BorderRadius = 1;
            this.btn_InicioAdminEmp.ButtonText = "Administración de Empresas";
            this.btn_InicioAdminEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_InicioAdminEmp.DisabledColor = System.Drawing.Color.Gray;
            this.btn_InicioAdminEmp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_InicioAdminEmp.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_InicioAdminEmp.Iconimage = null;
            this.btn_InicioAdminEmp.Iconimage_right = global::BibliotecaEstudiante.Properties.Resources.Services_100pxStart;
            this.btn_InicioAdminEmp.Iconimage_right_Selected = null;
            this.btn_InicioAdminEmp.Iconimage_Selected = null;
            this.btn_InicioAdminEmp.IconMarginLeft = 0;
            this.btn_InicioAdminEmp.IconMarginRight = 0;
            this.btn_InicioAdminEmp.IconRightVisible = true;
            this.btn_InicioAdminEmp.IconRightZoom = 0D;
            this.btn_InicioAdminEmp.IconVisible = true;
            this.btn_InicioAdminEmp.IconZoom = 90D;
            this.btn_InicioAdminEmp.IsTab = false;
            this.btn_InicioAdminEmp.Location = new System.Drawing.Point(3, 145);
            this.btn_InicioAdminEmp.Name = "btn_InicioAdminEmp";
            this.btn_InicioAdminEmp.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(64)))), ((int)(((byte)(30)))));
            this.btn_InicioAdminEmp.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(54)))), ((int)(((byte)(20)))));
            this.btn_InicioAdminEmp.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_InicioAdminEmp.selected = false;
            this.btn_InicioAdminEmp.Size = new System.Drawing.Size(296, 137);
            this.btn_InicioAdminEmp.TabIndex = 2;
            this.btn_InicioAdminEmp.Text = "Administración de Empresas";
            this.btn_InicioAdminEmp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_InicioAdminEmp.Textcolor = System.Drawing.Color.White;
            this.btn_InicioAdminEmp.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InicioAdminEmp.Click += new System.EventHandler(this.btn_InicioAdminEmp_Click);
            // 
            // btn_InicioEconomia
            // 
            this.btn_InicioEconomia.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(86)))), ((int)(((byte)(152)))));
            this.btn_InicioEconomia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(86)))), ((int)(((byte)(152)))));
            this.btn_InicioEconomia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_InicioEconomia.BorderRadius = 1;
            this.btn_InicioEconomia.ButtonText = "Economía";
            this.btn_InicioEconomia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_InicioEconomia.DisabledColor = System.Drawing.Color.Gray;
            this.btn_InicioEconomia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_InicioEconomia.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_InicioEconomia.Iconimage = null;
            this.btn_InicioEconomia.Iconimage_right = global::BibliotecaEstudiante.Properties.Resources.Money_100pxStart;
            this.btn_InicioEconomia.Iconimage_right_Selected = null;
            this.btn_InicioEconomia.Iconimage_Selected = null;
            this.btn_InicioEconomia.IconMarginLeft = 0;
            this.btn_InicioEconomia.IconMarginRight = 0;
            this.btn_InicioEconomia.IconRightVisible = true;
            this.btn_InicioEconomia.IconRightZoom = 0D;
            this.btn_InicioEconomia.IconVisible = true;
            this.btn_InicioEconomia.IconZoom = 90D;
            this.btn_InicioEconomia.IsTab = false;
            this.btn_InicioEconomia.Location = new System.Drawing.Point(305, 3);
            this.btn_InicioEconomia.Name = "btn_InicioEconomia";
            this.btn_InicioEconomia.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(86)))), ((int)(((byte)(152)))));
            this.btn_InicioEconomia.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(76)))), ((int)(((byte)(142)))));
            this.btn_InicioEconomia.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_InicioEconomia.selected = false;
            this.btn_InicioEconomia.Size = new System.Drawing.Size(296, 136);
            this.btn_InicioEconomia.TabIndex = 1;
            this.btn_InicioEconomia.Text = "Economía";
            this.btn_InicioEconomia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_InicioEconomia.Textcolor = System.Drawing.Color.White;
            this.btn_InicioEconomia.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InicioEconomia.Click += new System.EventHandler(this.btn_InicioEconomia_Click);
            // 
            // btn_InicioContabilidad
            // 
            this.btn_InicioContabilidad.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_InicioContabilidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_InicioContabilidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_InicioContabilidad.BorderRadius = 1;
            this.btn_InicioContabilidad.ButtonText = "Contabilidad";
            this.btn_InicioContabilidad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_InicioContabilidad.DisabledColor = System.Drawing.Color.Gray;
            this.btn_InicioContabilidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_InicioContabilidad.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_InicioContabilidad.Iconimage = null;
            this.btn_InicioContabilidad.Iconimage_right = ((System.Drawing.Image)(resources.GetObject("btn_InicioContabilidad.Iconimage_right")));
            this.btn_InicioContabilidad.Iconimage_right_Selected = null;
            this.btn_InicioContabilidad.Iconimage_Selected = null;
            this.btn_InicioContabilidad.IconMarginLeft = 0;
            this.btn_InicioContabilidad.IconMarginRight = 0;
            this.btn_InicioContabilidad.IconRightVisible = true;
            this.btn_InicioContabilidad.IconRightZoom = 0D;
            this.btn_InicioContabilidad.IconVisible = true;
            this.btn_InicioContabilidad.IconZoom = 90D;
            this.btn_InicioContabilidad.IsTab = false;
            this.btn_InicioContabilidad.Location = new System.Drawing.Point(3, 3);
            this.btn_InicioContabilidad.Name = "btn_InicioContabilidad";
            this.btn_InicioContabilidad.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_InicioContabilidad.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_InicioContabilidad.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_InicioContabilidad.selected = false;
            this.btn_InicioContabilidad.Size = new System.Drawing.Size(296, 136);
            this.btn_InicioContabilidad.TabIndex = 0;
            this.btn_InicioContabilidad.Text = "Contabilidad";
            this.btn_InicioContabilidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_InicioContabilidad.Textcolor = System.Drawing.Color.White;
            this.btn_InicioContabilidad.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InicioContabilidad.Click += new System.EventHandler(this.btn_InicioContabilidad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inicio";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(959, 565);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_InicioContabilidad;
        private Bunifu.Framework.UI.BunifuFlatButton btn_InicioMercadeo;
        private Bunifu.Framework.UI.BunifuFlatButton btn_InicioAdminEmp;
        private Bunifu.Framework.UI.BunifuFlatButton btn_InicioEconomia;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.TextBox textBox1;
    }
}
