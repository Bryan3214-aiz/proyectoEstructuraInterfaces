namespace proyectoEstructuraInterfaces
{
    partial class InterfacePostres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfacePostres));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IngresarPostre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.IngresarIngredientes = new System.Windows.Forms.TextBox();
            this.BotonFinalizarPedido = new System.Windows.Forms.Button();
            this.BotonVolverInicio = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.InfoPostre = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.InfoPostre.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Font = new System.Drawing.Font("Georgia", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(84, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(620, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "BIENVENIDO A LA REPOSTERIA UH";
            this.label1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.CausesValidation = false;
            this.label2.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(116, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(559, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nota importante:\r\nEl cliente debe ser claro, con el postre e ingredientes que des" +
    "ea para su pedido.\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SlateBlue;
            this.label3.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(62, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingrese el postre: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.UseWaitCursor = true;
            // 
            // IngresarPostre
            // 
            this.IngresarPostre.BackColor = System.Drawing.SystemColors.Window;
            this.IngresarPostre.Location = new System.Drawing.Point(194, 66);
            this.IngresarPostre.Name = "IngresarPostre";
            this.IngresarPostre.Size = new System.Drawing.Size(159, 20);
            this.IngresarPostre.TabIndex = 3;
            this.IngresarPostre.UseWaitCursor = true;
            this.IngresarPostre.TextChanged += new System.EventHandler(this.IngresarPostre_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.SlateBlue;
            this.label4.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(76, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ingrese los ingredientes:";
            this.label4.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.SlateBlue;
            this.label5.Font = new System.Drawing.Font("Georgia", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(58, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Comenzar con el pedido";
            this.label5.UseWaitCursor = true;
            // 
            // IngresarIngredientes
            // 
            this.IngresarIngredientes.BackColor = System.Drawing.SystemColors.Window;
            this.IngresarIngredientes.ForeColor = System.Drawing.SystemColors.WindowText;
            this.IngresarIngredientes.Location = new System.Drawing.Point(251, 309);
            this.IngresarIngredientes.Name = "IngresarIngredientes";
            this.IngresarIngredientes.Size = new System.Drawing.Size(159, 20);
            this.IngresarIngredientes.TabIndex = 6;
            this.IngresarIngredientes.UseWaitCursor = true;
            // 
            // BotonFinalizarPedido
            // 
            this.BotonFinalizarPedido.BackColor = System.Drawing.Color.SlateBlue;
            this.BotonFinalizarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BotonFinalizarPedido.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonFinalizarPedido.ForeColor = System.Drawing.Color.White;
            this.BotonFinalizarPedido.Location = new System.Drawing.Point(503, 232);
            this.BotonFinalizarPedido.Name = "BotonFinalizarPedido";
            this.BotonFinalizarPedido.Size = new System.Drawing.Size(201, 80);
            this.BotonFinalizarPedido.TabIndex = 7;
            this.BotonFinalizarPedido.Text = "Finalizar pedido";
            this.BotonFinalizarPedido.UseVisualStyleBackColor = false;
            this.BotonFinalizarPedido.UseWaitCursor = true;
            // 
            // BotonVolverInicio
            // 
            this.BotonVolverInicio.BackColor = System.Drawing.Color.SlateBlue;
            this.BotonVolverInicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BotonVolverInicio.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonVolverInicio.ForeColor = System.Drawing.Color.White;
            this.BotonVolverInicio.Location = new System.Drawing.Point(309, 418);
            this.BotonVolverInicio.Name = "BotonVolverInicio";
            this.BotonVolverInicio.Size = new System.Drawing.Size(191, 45);
            this.BotonVolverInicio.TabIndex = 8;
            this.BotonVolverInicio.Text = "Volver al inicio";
            this.BotonVolverInicio.UseVisualStyleBackColor = false;
            this.BotonVolverInicio.UseWaitCursor = true;
            this.BotonVolverInicio.Click += new System.EventHandler(this.BotonVolverInicio_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // InfoPostre
            // 
            this.InfoPostre.AutoSize = true;
            this.InfoPostre.BackColor = System.Drawing.Color.SlateBlue;
            this.InfoPostre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InfoPostre.Controls.Add(this.IngresarPostre);
            this.InfoPostre.Controls.Add(this.label3);
            this.InfoPostre.Controls.Add(this.label5);
            this.InfoPostre.Location = new System.Drawing.Point(57, 193);
            this.InfoPostre.Name = "InfoPostre";
            this.InfoPostre.Size = new System.Drawing.Size(368, 163);
            this.InfoPostre.TabIndex = 9;
            // 
            // InterfacePostres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(804, 511);
            this.Controls.Add(this.BotonVolverInicio);
            this.Controls.Add(this.BotonFinalizarPedido);
            this.Controls.Add(this.IngresarIngredientes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InfoPostre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InterfacePostres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Reposteria los tres chiflados";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.InterfacePostres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.InfoPostre.ResumeLayout(false);
            this.InfoPostre.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IngresarPostre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox IngresarIngredientes;
        private System.Windows.Forms.Button BotonFinalizarPedido;
        private System.Windows.Forms.Button BotonVolverInicio;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel InfoPostre;
    }
}