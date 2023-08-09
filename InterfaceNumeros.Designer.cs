namespace proyectoEstructuraInterfaces
{
    partial class InterfaceNumeros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfaceNumeros));
            this.label1 = new System.Windows.Forms.Label();
            this.PanelNumeros = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.listaNumeros = new System.Windows.Forms.ListBox();
            this.NumeroCinco = new System.Windows.Forms.TextBox();
            this.NumeroCuatro = new System.Windows.Forms.TextBox();
            this.NumeroTres = new System.Windows.Forms.TextBox();
            this.NumeroDos = new System.Windows.Forms.TextBox();
            this.NumeroUnoI = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BotonVolverInicio = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.EnviarNumeros = new System.Windows.Forms.Button();
            this.PanelNumeros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(176, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "PROGRAMA DE NUMEROS UH";
            this.label1.UseWaitCursor = true;
            // 
            // PanelNumeros
            // 
            this.PanelNumeros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(120)))));
            this.PanelNumeros.Controls.Add(this.EnviarNumeros);
            this.PanelNumeros.Controls.Add(this.label8);
            this.PanelNumeros.Controls.Add(this.listaNumeros);
            this.PanelNumeros.Controls.Add(this.NumeroCinco);
            this.PanelNumeros.Controls.Add(this.NumeroCuatro);
            this.PanelNumeros.Controls.Add(this.NumeroTres);
            this.PanelNumeros.Controls.Add(this.NumeroDos);
            this.PanelNumeros.Controls.Add(this.NumeroUnoI);
            this.PanelNumeros.Controls.Add(this.label6);
            this.PanelNumeros.Controls.Add(this.label5);
            this.PanelNumeros.Controls.Add(this.label4);
            this.PanelNumeros.Controls.Add(this.label3);
            this.PanelNumeros.Controls.Add(this.label2);
            this.PanelNumeros.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelNumeros.ForeColor = System.Drawing.Color.White;
            this.PanelNumeros.Location = new System.Drawing.Point(79, 142);
            this.PanelNumeros.Name = "PanelNumeros";
            this.PanelNumeros.Size = new System.Drawing.Size(644, 256);
            this.PanelNumeros.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(377, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 14);
            this.label8.TabIndex = 15;
            this.label8.Text = "LISTA DE NUMEROS";
            // 
            // listaNumeros
            // 
            this.listaNumeros.FormattingEnabled = true;
            this.listaNumeros.ItemHeight = 14;
            this.listaNumeros.Location = new System.Drawing.Point(260, 35);
            this.listaNumeros.Name = "listaNumeros";
            this.listaNumeros.Size = new System.Drawing.Size(356, 172);
            this.listaNumeros.TabIndex = 12;
            // 
            // NumeroCinco
            // 
            this.NumeroCinco.Location = new System.Drawing.Point(103, 179);
            this.NumeroCinco.Name = "NumeroCinco";
            this.NumeroCinco.Size = new System.Drawing.Size(100, 20);
            this.NumeroCinco.TabIndex = 11;
            this.NumeroCinco.TextChanged += new System.EventHandler(this.NumeroCinco_TextChanged);
            // 
            // NumeroCuatro
            // 
            this.NumeroCuatro.Location = new System.Drawing.Point(103, 141);
            this.NumeroCuatro.Name = "NumeroCuatro";
            this.NumeroCuatro.Size = new System.Drawing.Size(100, 20);
            this.NumeroCuatro.TabIndex = 10;
            this.NumeroCuatro.TextChanged += new System.EventHandler(this.NumeroCuatro_TextChanged);
            // 
            // NumeroTres
            // 
            this.NumeroTres.Location = new System.Drawing.Point(103, 110);
            this.NumeroTres.Name = "NumeroTres";
            this.NumeroTres.Size = new System.Drawing.Size(100, 20);
            this.NumeroTres.TabIndex = 9;
            this.NumeroTres.TextChanged += new System.EventHandler(this.NumeroTres_TextChanged);
            // 
            // NumeroDos
            // 
            this.NumeroDos.Location = new System.Drawing.Point(103, 72);
            this.NumeroDos.Name = "NumeroDos";
            this.NumeroDos.Size = new System.Drawing.Size(100, 20);
            this.NumeroDos.TabIndex = 8;
            this.NumeroDos.TextChanged += new System.EventHandler(this.NumeroDos_TextChanged);
            // 
            // NumeroUnoI
            // 
            this.NumeroUnoI.Location = new System.Drawing.Point(103, 35);
            this.NumeroUnoI.Name = "NumeroUnoI";
            this.NumeroUnoI.Size = new System.Drawing.Size(100, 20);
            this.NumeroUnoI.TabIndex = 7;
            this.NumeroUnoI.TextChanged += new System.EventHandler(this.NumeroUno_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 14);
            this.label6.TabIndex = 5;
            this.label6.Text = "Numero 5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "Numero 4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Numero 3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero 2:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero 1:";
            // 
            // BotonVolverInicio
            // 
            this.BotonVolverInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(120)))));
            this.BotonVolverInicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BotonVolverInicio.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonVolverInicio.ForeColor = System.Drawing.Color.White;
            this.BotonVolverInicio.Location = new System.Drawing.Point(601, 404);
            this.BotonVolverInicio.Name = "BotonVolverInicio";
            this.BotonVolverInicio.Size = new System.Drawing.Size(191, 45);
            this.BotonVolverInicio.TabIndex = 13;
            this.BotonVolverInicio.Text = "Volver al inicio";
            this.BotonVolverInicio.UseVisualStyleBackColor = false;
            this.BotonVolverInicio.Click += new System.EventHandler(this.BotonVolverInicio_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(127, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(525, 48);
            this.label7.TabIndex = 14;
            this.label7.Text = "Instrucciones:\r\nIngrese 5 numeros diferentes y se generara automaticamente una li" +
    "sta completando\r\nlos rangos de dichos numeros desde el más pequeño hasta el más " +
    "grande.";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EnviarNumeros
            // 
            this.EnviarNumeros.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EnviarNumeros.ForeColor = System.Drawing.Color.White;
            this.EnviarNumeros.Location = new System.Drawing.Point(103, 205);
            this.EnviarNumeros.Name = "EnviarNumeros";
            this.EnviarNumeros.Size = new System.Drawing.Size(100, 39);
            this.EnviarNumeros.TabIndex = 16;
            this.EnviarNumeros.Text = "Enviar numeros";
            this.EnviarNumeros.UseVisualStyleBackColor = true;
            this.EnviarNumeros.Click += new System.EventHandler(this.EnviarNumeros_Click);
            // 
            // InterfaceNumeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BotonVolverInicio);
            this.Controls.Add(this.PanelNumeros);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InterfaceNumeros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InterfaceNumeros";
            this.PanelNumeros.ResumeLayout(false);
            this.PanelNumeros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelNumeros;
        private System.Windows.Forms.Button BotonVolverInicio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listaNumeros;
        private System.Windows.Forms.TextBox NumeroCinco;
        private System.Windows.Forms.TextBox NumeroCuatro;
        private System.Windows.Forms.TextBox NumeroTres;
        private System.Windows.Forms.TextBox NumeroDos;
        private System.Windows.Forms.TextBox NumeroUnoI;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button EnviarNumeros;
    }
}