namespace proyectoEstructuraInterfaces
{
    partial class menuInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menuInicio));
            this.label1 = new System.Windows.Forms.Label();
            this.botonPostres = new System.Windows.Forms.Button();
            this.botonNumeros = new System.Windows.Forms.Button();
            this.botonSalir = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // botonPostres
            // 
            this.botonPostres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            resources.ApplyResources(this.botonPostres, "botonPostres");
            this.botonPostres.Name = "botonPostres";
            this.botonPostres.UseVisualStyleBackColor = false;
            this.botonPostres.Click += new System.EventHandler(this.botonPostres_Click);
            // 
            // botonNumeros
            // 
            this.botonNumeros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            resources.ApplyResources(this.botonNumeros, "botonNumeros");
            this.botonNumeros.Name = "botonNumeros";
            this.botonNumeros.UseVisualStyleBackColor = false;
            this.botonNumeros.Click += new System.EventHandler(this.botonNumeros_Click);
            // 
            // botonSalir
            // 
            this.botonSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            resources.ApplyResources(this.botonSalir, "botonSalir");
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.UseVisualStyleBackColor = false;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // listBox1
            // 
            this.listBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Cursor = System.Windows.Forms.Cursors.No;
            resources.ApplyResources(this.listBox1, "listBox1");
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            resources.GetString("listBox1.Items"),
            resources.GetString("listBox1.Items1"),
            resources.GetString("listBox1.Items2"),
            resources.GetString("listBox1.Items3"),
            resources.GetString("listBox1.Items4")});
            this.listBox1.Name = "listBox1";
            // 
            // menuInicio
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.botonNumeros);
            this.Controls.Add(this.botonPostres);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "menuInicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonPostres;
        private System.Windows.Forms.Button botonNumeros;
        private System.Windows.Forms.Button botonSalir;
        private System.Windows.Forms.ListBox listBox1;
    }
}

