namespace proyectoEstructuraInterfaces
{
    partial class MenuPanaderia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPanaderia));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.MostrarPedidos = new System.Windows.Forms.Button();
            this.menuEliminar = new System.Windows.Forms.Button();
            this.menuOrdenar = new System.Windows.Forms.Button();
            this.VolverInicio = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(81, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(631, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "BIENVENIDO A LA REPOSTERIA UH";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.MostrarPedidos);
            this.panel1.Controls.Add(this.menuEliminar);
            this.panel1.Controls.Add(this.menuOrdenar);
            this.panel1.Location = new System.Drawing.Point(82, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 186);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(159, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "SELECCIONE UNA OPCION DEL MENU";
            // 
            // MostrarPedidos
            // 
            this.MostrarPedidos.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.MostrarPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MostrarPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MostrarPedidos.ForeColor = System.Drawing.Color.White;
            this.MostrarPedidos.Location = new System.Drawing.Point(480, 59);
            this.MostrarPedidos.Name = "MostrarPedidos";
            this.MostrarPedidos.Size = new System.Drawing.Size(116, 69);
            this.MostrarPedidos.TabIndex = 3;
            this.MostrarPedidos.Text = "MOSTRAR PEDIDOS";
            this.MostrarPedidos.UseVisualStyleBackColor = false;
            this.MostrarPedidos.Click += new System.EventHandler(this.MostrarPedidos_Click);
            // 
            // menuEliminar
            // 
            this.menuEliminar.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.menuEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.menuEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuEliminar.ForeColor = System.Drawing.Color.White;
            this.menuEliminar.Location = new System.Drawing.Point(248, 59);
            this.menuEliminar.Name = "menuEliminar";
            this.menuEliminar.Size = new System.Drawing.Size(116, 69);
            this.menuEliminar.TabIndex = 1;
            this.menuEliminar.Text = "ELIMINAR POSTRE";
            this.menuEliminar.UseVisualStyleBackColor = false;
            this.menuEliminar.Click += new System.EventHandler(this.menuEliminar_Click);
            // 
            // menuOrdenar
            // 
            this.menuOrdenar.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.menuOrdenar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.menuOrdenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuOrdenar.ForeColor = System.Drawing.Color.White;
            this.menuOrdenar.Location = new System.Drawing.Point(24, 59);
            this.menuOrdenar.Name = "menuOrdenar";
            this.menuOrdenar.Size = new System.Drawing.Size(116, 69);
            this.menuOrdenar.TabIndex = 0;
            this.menuOrdenar.Text = "ORDENAR POSTRE";
            this.menuOrdenar.UseVisualStyleBackColor = false;
            this.menuOrdenar.Click += new System.EventHandler(this.menuOrdenar_Click);
            // 
            // VolverInicio
            // 
            this.VolverInicio.BackColor = System.Drawing.Color.SlateBlue;
            this.VolverInicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.VolverInicio.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VolverInicio.ForeColor = System.Drawing.Color.White;
            this.VolverInicio.Location = new System.Drawing.Point(660, 387);
            this.VolverInicio.Name = "VolverInicio";
            this.VolverInicio.Size = new System.Drawing.Size(128, 51);
            this.VolverInicio.TabIndex = 7;
            this.VolverInicio.Text = "Volver al inicio";
            this.VolverInicio.UseVisualStyleBackColor = false;
            this.VolverInicio.Click += new System.EventHandler(this.VolverInicio_Click);
            // 
            // MenuPanaderia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.VolverInicio);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuPanaderia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPanaderia";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button MostrarPedidos;
        private System.Windows.Forms.Button menuEliminar;
        private System.Windows.Forms.Button menuOrdenar;
        private System.Windows.Forms.Button VolverInicio;
    }
}