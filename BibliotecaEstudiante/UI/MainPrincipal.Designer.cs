using Syncfusion.Windows.Forms.Tools;

namespace BibliotecaEstudianteMain
{
    partial class MainPrincipal
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void
            InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPrincipal));
            this.drawerMenuItem6 = new Syncfusion.Windows.Forms.Tools.DrawerMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.HeaderLeft = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MenuLeft = new System.Windows.Forms.Panel();
            this.btn_Auditoria = new System.Windows.Forms.Button();
            this.btn_Busqueda = new System.Windows.Forms.Button();
            this.btn_Mercadeo = new System.Windows.Forms.Button();
            this.btn_AdminEmp = new System.Windows.Forms.Button();
            this.btn_Economia = new System.Windows.Forms.Button();
            this.btn_Contabilidad = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Inicio = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.HeaderLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MenuLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // drawerMenuItem6
            // 
            this.drawerMenuItem6.BackColor = System.Drawing.Color.White;
            this.drawerMenuItem6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawerMenuItem6.Location = new System.Drawing.Point(0, 0);
            this.drawerMenuItem6.Name = "drawerMenuItem6";
            this.drawerMenuItem6.Size = new System.Drawing.Size(200, 50);
            this.drawerMenuItem6.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 9);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 499F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 499F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 499F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(890, 499);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.HeaderLeft, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.MenuLeft, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(178, 499);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // HeaderLeft
            // 
            this.HeaderLeft.BackColor = System.Drawing.Color.MintCream;
            this.HeaderLeft.Controls.Add(this.pictureBox1);
            this.HeaderLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeaderLeft.Location = new System.Drawing.Point(0, 0);
            this.HeaderLeft.Margin = new System.Windows.Forms.Padding(0);
            this.HeaderLeft.Name = "HeaderLeft";
            this.HeaderLeft.Size = new System.Drawing.Size(178, 99);
            this.HeaderLeft.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::BibliotecaEstudiante.Properties.Resources.accounting_Cloud;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // MenuLeft
            // 
            this.MenuLeft.BackColor = System.Drawing.Color.White;
            this.MenuLeft.Controls.Add(this.btn_Auditoria);
            this.MenuLeft.Controls.Add(this.btn_Busqueda);
            this.MenuLeft.Controls.Add(this.btn_Mercadeo);
            this.MenuLeft.Controls.Add(this.btn_AdminEmp);
            this.MenuLeft.Controls.Add(this.btn_Economia);
            this.MenuLeft.Controls.Add(this.btn_Contabilidad);
            this.MenuLeft.Controls.Add(this.label3);
            this.MenuLeft.Controls.Add(this.label2);
            this.MenuLeft.Controls.Add(this.btn_Inicio);
            this.MenuLeft.Controls.Add(this.label4);
            this.MenuLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuLeft.Location = new System.Drawing.Point(0, 99);
            this.MenuLeft.Margin = new System.Windows.Forms.Padding(0);
            this.MenuLeft.Name = "MenuLeft";
            this.MenuLeft.Size = new System.Drawing.Size(178, 400);
            this.MenuLeft.TabIndex = 1;
            // 
            // btn_Auditoria
            // 
            this.btn_Auditoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Auditoria.FlatAppearance.BorderSize = 0;
            this.btn_Auditoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Auditoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Auditoria.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Auditoria.Image = global::BibliotecaEstudiante.Properties.Resources.System_Task_23px;
            this.btn_Auditoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Auditoria.Location = new System.Drawing.Point(0, 245);
            this.btn_Auditoria.Name = "btn_Auditoria";
            this.btn_Auditoria.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Auditoria.Size = new System.Drawing.Size(178, 43);
            this.btn_Auditoria.TabIndex = 24;
            this.btn_Auditoria.Text = "Auditoría";
            this.btn_Auditoria.UseVisualStyleBackColor = true;
            this.btn_Auditoria.Click += new System.EventHandler(this.btn_Auditoria_Click);
            // 
            // btn_Busqueda
            // 
            this.btn_Busqueda.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Busqueda.FlatAppearance.BorderSize = 0;
            this.btn_Busqueda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Busqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Busqueda.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Busqueda.Image = global::BibliotecaEstudiante.Properties.Resources.Search_100px;
            this.btn_Busqueda.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Busqueda.Location = new System.Drawing.Point(0, 357);
            this.btn_Busqueda.Name = "btn_Busqueda";
            this.btn_Busqueda.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btn_Busqueda.Size = new System.Drawing.Size(178, 43);
            this.btn_Busqueda.TabIndex = 23;
            this.btn_Busqueda.Text = "Búsqueda";
            this.btn_Busqueda.UseVisualStyleBackColor = true;
            this.btn_Busqueda.Click += new System.EventHandler(this.btn_Busqueda_Click);
            // 
            // btn_Mercadeo
            // 
            this.btn_Mercadeo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Mercadeo.FlatAppearance.BorderSize = 0;
            this.btn_Mercadeo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(176)))), ((int)(((byte)(63)))));
            this.btn_Mercadeo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Mercadeo.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Mercadeo.Image = global::BibliotecaEstudiante.Properties.Resources.Increase_100px;
            this.btn_Mercadeo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Mercadeo.Location = new System.Drawing.Point(0, 202);
            this.btn_Mercadeo.Name = "btn_Mercadeo";
            this.btn_Mercadeo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Mercadeo.Size = new System.Drawing.Size(178, 43);
            this.btn_Mercadeo.TabIndex = 22;
            this.btn_Mercadeo.Text = "Mercadeo";
            this.btn_Mercadeo.UseVisualStyleBackColor = true;
            this.btn_Mercadeo.Click += new System.EventHandler(this.btn_Mercadeo_Click);
            // 
            // btn_AdminEmp
            // 
            this.btn_AdminEmp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_AdminEmp.FlatAppearance.BorderSize = 0;
            this.btn_AdminEmp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(176)))), ((int)(((byte)(63)))));
            this.btn_AdminEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AdminEmp.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AdminEmp.Image = global::BibliotecaEstudiante.Properties.Resources.Services_100px;
            this.btn_AdminEmp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AdminEmp.Location = new System.Drawing.Point(0, 159);
            this.btn_AdminEmp.Name = "btn_AdminEmp";
            this.btn_AdminEmp.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_AdminEmp.Size = new System.Drawing.Size(178, 43);
            this.btn_AdminEmp.TabIndex = 21;
            this.btn_AdminEmp.Text = "     Admin. Empresas";
            this.btn_AdminEmp.UseVisualStyleBackColor = true;
            this.btn_AdminEmp.Click += new System.EventHandler(this.btn_AdminEmp_Click);
            // 
            // btn_Economia
            // 
            this.btn_Economia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Economia.FlatAppearance.BorderSize = 0;
            this.btn_Economia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(176)))), ((int)(((byte)(63)))));
            this.btn_Economia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Economia.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Economia.Image = global::BibliotecaEstudiante.Properties.Resources.Money_100px;
            this.btn_Economia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Economia.Location = new System.Drawing.Point(0, 116);
            this.btn_Economia.Name = "btn_Economia";
            this.btn_Economia.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Economia.Size = new System.Drawing.Size(178, 43);
            this.btn_Economia.TabIndex = 20;
            this.btn_Economia.Text = "Economía";
            this.btn_Economia.UseVisualStyleBackColor = true;
            this.btn_Economia.Click += new System.EventHandler(this.btn_Economia_Click);
            // 
            // btn_Contabilidad
            // 
            this.btn_Contabilidad.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Contabilidad.FlatAppearance.BorderSize = 0;
            this.btn_Contabilidad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(176)))), ((int)(((byte)(63)))));
            this.btn_Contabilidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Contabilidad.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Contabilidad.Image = global::BibliotecaEstudiante.Properties.Resources.Accounting_100px;
            this.btn_Contabilidad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Contabilidad.Location = new System.Drawing.Point(0, 73);
            this.btn_Contabilidad.Name = "btn_Contabilidad";
            this.btn_Contabilidad.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Contabilidad.Size = new System.Drawing.Size(178, 43);
            this.btn_Contabilidad.TabIndex = 19;
            this.btn_Contabilidad.Text = "Contabilidad";
            this.btn_Contabilidad.UseVisualStyleBackColor = true;
            this.btn_Contabilidad.Click += new System.EventHandler(this.btnContabilidad_Click_1);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 2);
            this.label3.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 26);
            this.label2.TabIndex = 16;
            this.label2.Text = "Disciplinas";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Inicio
            // 
            this.btn_Inicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Inicio.FlatAppearance.BorderSize = 0;
            this.btn_Inicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(176)))), ((int)(((byte)(63)))));
            this.btn_Inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Inicio.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Inicio.Image = ((System.Drawing.Image)(resources.GetObject("btn_Inicio.Image")));
            this.btn_Inicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Inicio.Location = new System.Drawing.Point(0, 2);
            this.btn_Inicio.Name = "btn_Inicio";
            this.btn_Inicio.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Inicio.Size = new System.Drawing.Size(178, 43);
            this.btn_Inicio.TabIndex = 17;
            this.btn_Inicio.Text = "Inicio";
            this.btn_Inicio.UseVisualStyleBackColor = true;
            this.btn_Inicio.Click += new System.EventHandler(this.Inicio_Click);
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 2);
            this.label4.TabIndex = 15;
            // 
            // MainPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(908, 517);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPrincipal";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accounting Cloud";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainPrincipal_Load);
            this.Shown += new System.EventHandler(this.MainPrincipal_Shown);
            this.Resize += new System.EventHandler(this.MainPrincipal_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.HeaderLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MenuLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion
        private Syncfusion.Windows.Forms.Tools.DrawerMenuItem drawerMenuItem6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel HeaderLeft;
        private System.Windows.Forms.Panel MenuLeft;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Mercadeo;
        private System.Windows.Forms.Button btn_AdminEmp;
        private System.Windows.Forms.Button btn_Economia;
        private System.Windows.Forms.Button btn_Contabilidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Inicio;
        private System.Windows.Forms.Button btn_Auditoria;
        private System.Windows.Forms.Button btn_Busqueda;
    }
}