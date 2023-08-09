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
            this.BotonFinalizarPedido = new System.Windows.Forms.Button();
            this.BotonVolverInicio = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pedidoPostres = new System.Windows.Forms.Panel();
            this.IngresarIngredientes = new System.Windows.Forms.TextBox();
            this.IngresarPostre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.pedidoPostres.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(84, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(631, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "BIENVENIDO A LA REPOSTERIA UH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(122, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(559, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nota importante:\r\nEl cliente debe ser claro, con el postre e ingredientes que des" +
    "ea para su pedido.\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BotonFinalizarPedido
            // 
            this.BotonFinalizarPedido.BackColor = System.Drawing.Color.SlateBlue;
            this.BotonFinalizarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BotonFinalizarPedido.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonFinalizarPedido.ForeColor = System.Drawing.Color.White;
            this.BotonFinalizarPedido.Location = new System.Drawing.Point(514, 206);
            this.BotonFinalizarPedido.Name = "BotonFinalizarPedido";
            this.BotonFinalizarPedido.Size = new System.Drawing.Size(201, 80);
            this.BotonFinalizarPedido.TabIndex = 11;
            this.BotonFinalizarPedido.Text = "Finalizar pedido ";
            this.BotonFinalizarPedido.UseVisualStyleBackColor = false;
            // 
            // BotonVolverInicio
            // 
            this.BotonVolverInicio.BackColor = System.Drawing.Color.SlateBlue;
            this.BotonVolverInicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BotonVolverInicio.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonVolverInicio.ForeColor = System.Drawing.Color.White;
            this.BotonVolverInicio.Location = new System.Drawing.Point(319, 404);
            this.BotonVolverInicio.Name = "BotonVolverInicio";
            this.BotonVolverInicio.Size = new System.Drawing.Size(191, 45);
            this.BotonVolverInicio.TabIndex = 12;
            this.BotonVolverInicio.Text = "Volver al inicio";
            this.BotonVolverInicio.UseVisualStyleBackColor = false;
            this.BotonVolverInicio.Click += new System.EventHandler(this.BotonVolverInicio_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pedidoPostres
            // 
            this.pedidoPostres.BackColor = System.Drawing.Color.SlateBlue;
            this.pedidoPostres.Controls.Add(this.IngresarIngredientes);
            this.pedidoPostres.Controls.Add(this.IngresarPostre);
            this.pedidoPostres.Controls.Add(this.label5);
            this.pedidoPostres.Controls.Add(this.label4);
            this.pedidoPostres.Controls.Add(this.label3);
            this.pedidoPostres.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pedidoPostres.ForeColor = System.Drawing.Color.White;
            this.pedidoPostres.Location = new System.Drawing.Point(50, 159);
            this.pedidoPostres.Name = "pedidoPostres";
            this.pedidoPostres.Size = new System.Drawing.Size(388, 154);
            this.pedidoPostres.TabIndex = 14;
            // 
            // IngresarIngredientes
            // 
            this.IngresarIngredientes.Location = new System.Drawing.Point(180, 96);
            this.IngresarIngredientes.Name = "IngresarIngredientes";
            this.IngresarIngredientes.Size = new System.Drawing.Size(185, 22);
            this.IngresarIngredientes.TabIndex = 5;
            // 
            // IngresarPostre
            // 
            this.IngresarPostre.Location = new System.Drawing.Point(180, 47);
            this.IngresarPostre.Name = "IngresarPostre";
            this.IngresarPostre.Size = new System.Drawing.Size(185, 22);
            this.IngresarPostre.TabIndex = 4;
            this.IngresarPostre.TextChanged += new System.EventHandler(this.IngresarPostre_TextChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ingrese el postre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ingrese los ingredientes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Comenzar con el pedido";
            // 
            // InterfacePostres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.pedidoPostres);
            this.Controls.Add(this.BotonVolverInicio);
            this.Controls.Add(this.BotonFinalizarPedido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InterfacePostres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panaderia UH";
            this.Load += new System.EventHandler(this.InterfacePostres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.pedidoPostres.ResumeLayout(false);
            this.pedidoPostres.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BotonFinalizarPedido;
        private System.Windows.Forms.Button BotonVolverInicio;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel pedidoPostres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IngresarPostre;
        private System.Windows.Forms.TextBox IngresarIngredientes;
    }
}