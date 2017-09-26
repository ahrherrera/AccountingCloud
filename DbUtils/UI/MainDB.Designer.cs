namespace BibliotecaEstudianteMain.UI
{
    partial class MainDB
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainDB));
            this.label1 = new System.Windows.Forms.Label();
            this.gridListControl1 = new Syncfusion.Windows.Forms.Grid.GridListControl();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.paginaFinal = new System.Windows.Forms.NumericUpDown();
            this.paginaInicial = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_NombreTema = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gridListControl2 = new Syncfusion.Windows.Forms.Grid.GridListControl();
            this.btn_NuevoLibro = new System.Windows.Forms.Button();
            this.popupControlContainer1 = new Syncfusion.Windows.Forms.PopupControlContainer(this.components);
            this.btn_agregar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_ruta = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmb_Categoria = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_NombreAutor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_nombreLibro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridListControl1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paginaFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paginaInicial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridListControl2)).BeginInit();
            this.popupControlContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de Libros";
            // 
            // gridListControl1
            // 
            this.gridListControl1.BackColor = System.Drawing.SystemColors.Control;
            this.gridListControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridListControl1.ItemHeight = 17;
            this.gridListControl1.Location = new System.Drawing.Point(12, 37);
            this.gridListControl1.Name = "gridListControl1";
            this.gridListControl1.Properties.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridListControl1.SelectedIndex = -1;
            this.gridListControl1.Size = new System.Drawing.Size(797, 206);
            this.gridListControl1.TabIndex = 2;
            this.gridListControl1.TopIndex = 0;
            this.gridListControl1.DoubleClick += new System.EventHandler(this.gridListControl1_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Para Agregar un tema, selecciona un libro de la tabla";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(450, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Libro Seleccionado";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.gridListControl2);
            this.panel1.Location = new System.Drawing.Point(15, 280);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 209);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Guardar);
            this.panel2.Controls.Add(this.paginaFinal);
            this.panel2.Controls.Add(this.paginaInicial);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txt_Descripcion);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txt_NombreTema);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(82, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(309, 192);
            this.panel2.TabIndex = 7;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(127, 149);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_Guardar.TabIndex = 9;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // paginaFinal
            // 
            this.paginaFinal.Location = new System.Drawing.Point(227, 120);
            this.paginaFinal.Maximum = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            this.paginaFinal.Name = "paginaFinal";
            this.paginaFinal.Size = new System.Drawing.Size(44, 20);
            this.paginaFinal.TabIndex = 8;
            // 
            // paginaInicial
            // 
            this.paginaInicial.Location = new System.Drawing.Point(100, 123);
            this.paginaInicial.Maximum = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            this.paginaInicial.Name = "paginaInicial";
            this.paginaInicial.Size = new System.Drawing.Size(44, 20);
            this.paginaInicial.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(164, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Pagina Fin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Pagina Inicio";
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(112, 49);
            this.txt_Descripcion.Multiline = true;
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(180, 65);
            this.txt_Descripcion.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Descripcion";
            // 
            // txt_NombreTema
            // 
            this.txt_NombreTema.Location = new System.Drawing.Point(112, 20);
            this.txt_NombreTema.Name = "txt_NombreTema";
            this.txt_NombreTema.Size = new System.Drawing.Size(180, 20);
            this.txt_NombreTema.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nombre del tema";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(18, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 37);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gridListControl2
            // 
            this.gridListControl2.BackColor = System.Drawing.SystemColors.Control;
            this.gridListControl2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridListControl2.ItemHeight = 17;
            this.gridListControl2.Location = new System.Drawing.Point(416, 1);
            this.gridListControl2.Name = "gridListControl2";
            this.gridListControl2.Properties.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridListControl2.SelectedIndex = -1;
            this.gridListControl2.Size = new System.Drawing.Size(385, 205);
            this.gridListControl2.TabIndex = 3;
            this.gridListControl2.TopIndex = 0;
            // 
            // btn_NuevoLibro
            // 
            this.btn_NuevoLibro.Location = new System.Drawing.Point(304, 249);
            this.btn_NuevoLibro.Name = "btn_NuevoLibro";
            this.btn_NuevoLibro.Size = new System.Drawing.Size(75, 23);
            this.btn_NuevoLibro.TabIndex = 6;
            this.btn_NuevoLibro.Text = "Nuevo Libro";
            this.btn_NuevoLibro.UseVisualStyleBackColor = true;
            this.btn_NuevoLibro.Click += new System.EventHandler(this.btn_NuevoLibro_Click);
            // 
            // popupControlContainer1
            // 
            this.popupControlContainer1.Controls.Add(this.btn_agregar);
            this.popupControlContainer1.Controls.Add(this.button2);
            this.popupControlContainer1.Controls.Add(this.txt_ruta);
            this.popupControlContainer1.Controls.Add(this.label11);
            this.popupControlContainer1.Controls.Add(this.cmb_Categoria);
            this.popupControlContainer1.Controls.Add(this.label10);
            this.popupControlContainer1.Controls.Add(this.txt_NombreAutor);
            this.popupControlContainer1.Controls.Add(this.label9);
            this.popupControlContainer1.Controls.Add(this.txt_nombreLibro);
            this.popupControlContainer1.Controls.Add(this.label8);
            this.popupControlContainer1.Location = new System.Drawing.Point(159, 107);
            this.popupControlContainer1.Name = "popupControlContainer1";
            this.popupControlContainer1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.popupControlContainer1.Size = new System.Drawing.Size(468, 236);
            this.popupControlContainer1.TabIndex = 7;
            this.popupControlContainer1.BeforeCloseUp += new System.ComponentModel.CancelEventHandler(this.popupControlContainer1_BeforeCloseUp);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(206, 190);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 9;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(294, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Examinar...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_ruta
            // 
            this.txt_ruta.Enabled = false;
            this.txt_ruta.Location = new System.Drawing.Point(140, 139);
            this.txt_ruta.Name = "txt_ruta";
            this.txt_ruta.Size = new System.Drawing.Size(145, 20);
            this.txt_ruta.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(102, 142);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Libro";
            // 
            // cmb_Categoria
            // 
            this.cmb_Categoria.FormattingEnabled = true;
            this.cmb_Categoria.Location = new System.Drawing.Point(140, 107);
            this.cmb_Categoria.Name = "cmb_Categoria";
            this.cmb_Categoria.Size = new System.Drawing.Size(200, 21);
            this.cmb_Categoria.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(82, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Categoria";
            // 
            // txt_NombreAutor
            // 
            this.txt_NombreAutor.Location = new System.Drawing.Point(140, 72);
            this.txt_NombreAutor.Name = "txt_NombreAutor";
            this.txt_NombreAutor.Size = new System.Drawing.Size(123, 20);
            this.txt_NombreAutor.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Nombre del Autor";
            // 
            // txt_nombreLibro
            // 
            this.txt_nombreLibro.Location = new System.Drawing.Point(140, 42);
            this.txt_nombreLibro.Name = "txt_nombreLibro";
            this.txt_nombreLibro.Size = new System.Drawing.Size(295, 20);
            this.txt_nombreLibro.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Nombre del libro";
            // 
            // MainDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 501);
            this.Controls.Add(this.popupControlContainer1);
            this.Controls.Add(this.btn_NuevoLibro);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridListControl1);
            this.Controls.Add(this.label1);
            this.Name = "MainDB";
            this.Text = "DBUtils";
            ((System.ComponentModel.ISupportInitialize)(this.gridListControl1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paginaFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paginaInicial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridListControl2)).EndInit();
            this.popupControlContainer1.ResumeLayout(false);
            this.popupControlContainer1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.Grid.GridListControl gridListControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private Syncfusion.Windows.Forms.Grid.GridListControl gridListControl2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_NombreTema;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.NumericUpDown paginaFinal;
        private System.Windows.Forms.NumericUpDown paginaInicial;
        private System.Windows.Forms.Button btn_NuevoLibro;
        private Syncfusion.Windows.Forms.PopupControlContainer popupControlContainer1;
        private System.Windows.Forms.ComboBox cmb_Categoria;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_NombreAutor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_nombreLibro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_ruta;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_agregar;
    }
}