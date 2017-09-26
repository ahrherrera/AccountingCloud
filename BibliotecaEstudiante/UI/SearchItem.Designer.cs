namespace BibliotecaEstudiante.UI
{
    partial class SearchItem
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
            this.txt_Temario = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_Descripcion = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Comparar = new Bunifu.Framework.UI.BunifuCheckbox();
            this.SuspendLayout();
            // 
            // txt_Temario
            // 
            this.txt_Temario.AutoEllipsis = true;
            this.txt_Temario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_Temario.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Temario.Location = new System.Drawing.Point(15, 10);
            this.txt_Temario.Name = "txt_Temario";
            this.txt_Temario.Size = new System.Drawing.Size(736, 23);
            this.txt_Temario.TabIndex = 2;
            this.txt_Temario.Text = "bunifuCustomLabel1";
            this.txt_Temario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_Temario.Click += new System.EventHandler(this.SearchItem_Click);
            // 
            // btn_Descripcion
            // 
            this.btn_Descripcion.AutoEllipsis = true;
            this.btn_Descripcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Descripcion.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btn_Descripcion.Location = new System.Drawing.Point(15, 33);
            this.btn_Descripcion.Name = "btn_Descripcion";
            this.btn_Descripcion.Size = new System.Drawing.Size(736, 67);
            this.btn_Descripcion.TabIndex = 3;
            this.btn_Descripcion.Text = "bunifuCustomLabel2";
            this.btn_Descripcion.Click += new System.EventHandler(this.SearchItem_Click);
            // 
            // Comparar
            // 
            this.Comparar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Comparar.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Comparar.Checked = false;
            this.Comparar.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.Comparar.ForeColor = System.Drawing.Color.White;
            this.Comparar.Location = new System.Drawing.Point(773, 66);
            this.Comparar.Name = "Comparar";
            this.Comparar.Size = new System.Drawing.Size(20, 20);
            this.Comparar.TabIndex = 4;
            this.Comparar.OnChange += new System.EventHandler(this.bunifuCheckbox1_OnChange);
            // 
            // SearchItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.Comparar);
            this.Controls.Add(this.btn_Descripcion);
            this.Controls.Add(this.txt_Temario);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "SearchItem";
            this.Size = new System.Drawing.Size(819, 121);
            this.Click += new System.EventHandler(this.SearchItem_Click);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomLabel txt_Temario;
        private Bunifu.Framework.UI.BunifuCustomLabel btn_Descripcion;
        private Bunifu.Framework.UI.BunifuCheckbox Comparar;
    }
}
