namespace proyectoEstructuraInterfaces
{
    partial class InterfacePostresMostrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfacePostresMostrar));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BotonVolverInicio = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BotonMostrarPostres = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(59, 89);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(415, 173);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(180, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lista de postres";
            // 
            // BotonVolverInicio
            // 
            this.BotonVolverInicio.BackColor = System.Drawing.Color.SlateBlue;
            this.BotonVolverInicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BotonVolverInicio.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonVolverInicio.ForeColor = System.Drawing.Color.White;
            this.BotonVolverInicio.Location = new System.Drawing.Point(601, 410);
            this.BotonVolverInicio.Name = "BotonVolverInicio";
            this.BotonVolverInicio.Size = new System.Drawing.Size(191, 45);
            this.BotonVolverInicio.TabIndex = 19;
            this.BotonVolverInicio.Text = "Volver al inicio";
            this.BotonVolverInicio.UseVisualStyleBackColor = false;
            this.BotonVolverInicio.Click += new System.EventHandler(this.BotonVolverInicio_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Controls.Add(this.BotonMostrarPostres);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Location = new System.Drawing.Point(133, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 362);
            this.panel1.TabIndex = 20;
            // 
            // BotonMostrarPostres
            // 
            this.BotonMostrarPostres.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BotonMostrarPostres.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BotonMostrarPostres.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonMostrarPostres.ForeColor = System.Drawing.Color.White;
            this.BotonMostrarPostres.Location = new System.Drawing.Point(303, 268);
            this.BotonMostrarPostres.Name = "BotonMostrarPostres";
            this.BotonMostrarPostres.Size = new System.Drawing.Size(171, 46);
            this.BotonMostrarPostres.TabIndex = 20;
            this.BotonMostrarPostres.Text = "Mostrar postres";
            this.BotonMostrarPostres.UseVisualStyleBackColor = false;
            // 
            // InterfacePostresMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BotonVolverInicio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InterfacePostresMostrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BotonVolverInicio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BotonMostrarPostres;
    }
}