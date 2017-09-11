namespace BibliotecaEstudiante.UI
{
    partial class Busqueda
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_toggle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_Autores = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.rb_todos = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.rb_Libro = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.rb_temario = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_Categoria = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Autores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rb_todos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rb_Libro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rb_temario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Categoria)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 543);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.lbl_toggle);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.bunifuFlatButton1);
            this.panel2.Controls.Add(this.txt_search);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(177, 81);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel2.Size = new System.Drawing.Size(618, 159);
            this.panel2.TabIndex = 2;
            // 
            // lbl_toggle
            // 
            this.lbl_toggle.AutoSize = true;
            this.lbl_toggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_toggle.Location = new System.Drawing.Point(256, 60);
            this.lbl_toggle.Name = "lbl_toggle";
            this.lbl_toggle.Size = new System.Drawing.Size(118, 13);
            this.lbl_toggle.TabIndex = 5;
            this.lbl_toggle.Text = "Búsqueda Avanzada ▼";
            this.lbl_toggle.Click += new System.EventHandler(this.lbl_toggle_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.cmb_Autores);
            this.panel3.Controls.Add(this.rb_todos);
            this.panel3.Controls.Add(this.rb_Libro);
            this.panel3.Controls.Add(this.rb_temario);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.cmb_Categoria);
            this.panel3.Location = new System.Drawing.Point(26, 76);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(566, 60);
            this.panel3.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(352, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Autor";
            // 
            // cmb_Autores
            // 
            this.cmb_Autores.BackColor = System.Drawing.Color.White;
            this.cmb_Autores.BeforeTouchSize = new System.Drawing.Size(142, 25);
            this.cmb_Autores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Autores.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Autores.Location = new System.Drawing.Point(405, 22);
            this.cmb_Autores.Name = "cmb_Autores";
            this.cmb_Autores.Size = new System.Drawing.Size(142, 25);
            this.cmb_Autores.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.cmb_Autores.TabIndex = 5;
            // 
            // rb_todos
            // 
            this.rb_todos.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.rb_todos.Checked = true;
            this.rb_todos.DrawFocusRectangle = false;
            this.rb_todos.Location = new System.Drawing.Point(259, 37);
            this.rb_todos.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.rb_todos.Name = "rb_todos";
            this.rb_todos.Size = new System.Drawing.Size(150, 21);
            this.rb_todos.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.rb_todos.TabIndex = 4;
            this.rb_todos.Text = "Todos";
            this.rb_todos.ThemesEnabled = false;
            // 
            // rb_Libro
            // 
            this.rb_Libro.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.rb_Libro.DrawFocusRectangle = false;
            this.rb_Libro.Location = new System.Drawing.Point(259, 19);
            this.rb_Libro.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.rb_Libro.Name = "rb_Libro";
            this.rb_Libro.Size = new System.Drawing.Size(150, 21);
            this.rb_Libro.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.rb_Libro.TabIndex = 3;
            this.rb_Libro.TabStop = false;
            this.rb_Libro.Text = "Libros";
            this.rb_Libro.ThemesEnabled = false;
            // 
            // rb_temario
            // 
            this.rb_temario.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.rb_temario.DrawFocusRectangle = false;
            this.rb_temario.Location = new System.Drawing.Point(259, 2);
            this.rb_temario.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.rb_temario.Name = "rb_temario";
            this.rb_temario.Size = new System.Drawing.Size(150, 21);
            this.rb_temario.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.rb_temario.TabIndex = 2;
            this.rb_temario.TabStop = false;
            this.rb_temario.Text = "Temarios";
            this.rb_temario.ThemesEnabled = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Disciplinas";
            // 
            // cmb_Categoria
            // 
            this.cmb_Categoria.BackColor = System.Drawing.Color.White;
            this.cmb_Categoria.BeforeTouchSize = new System.Drawing.Size(142, 25);
            this.cmb_Categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Categoria.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Categoria.Location = new System.Drawing.Point(99, 18);
            this.cmb_Categoria.Name = "cmb_Categoria";
            this.cmb_Categoria.Size = new System.Drawing.Size(142, 25);
            this.cmb_Categoria.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.cmb_Categoria.TabIndex = 0;
            this.cmb_Categoria.SelectedIndexChanged += new System.EventHandler(this.cmb_Categoria_SelectedIndexChanged);
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(527, 24);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(36, 34);
            this.bunifuFlatButton1.TabIndex = 3;
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F);
            this.txt_search.Location = new System.Drawing.Point(113, 24);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(406, 33);
            this.txt_search.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buscar :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Búsqueda";
            // 
            // Busqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Busqueda";
            this.Size = new System.Drawing.Size(914, 543);
            this.Load += new System.EventHandler(this.Busqueda_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Autores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rb_todos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rb_Libro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rb_temario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Categoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Label lbl_toggle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmb_Categoria;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv rb_todos;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv rb_Libro;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv rb_temario;
        private System.Windows.Forms.Label label4;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmb_Autores;
    }
}
