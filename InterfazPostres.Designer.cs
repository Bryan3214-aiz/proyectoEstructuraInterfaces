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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPanaderia));
            this.label4 = new System.Windows.Forms.Label();
            this.EliminarIngredientesButton = new System.Windows.Forms.Button();
            this.nuevoPostreTextBox = new System.Windows.Forms.TextBox();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.DarDeBajaButton = new System.Windows.Forms.Button();
            this.DarDeAltaButton = new System.Windows.Forms.Button();
            this.AgregarIngredientesButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MostrarTablas = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.postresListBox = new System.Windows.Forms.ListBox();
            this.ingredientesListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.nuevosIngredientesTextBox = new System.Windows.Forms.TextBox();
            this.postresComboBox = new System.Windows.Forms.ComboBox();
            this.comboBoxIngredientes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(42, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "Ingresa el postre:";
            // 
            // EliminarIngredientesButton
            // 
            this.EliminarIngredientesButton.BackColor = System.Drawing.Color.CadetBlue;
            this.EliminarIngredientesButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EliminarIngredientesButton.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarIngredientesButton.ForeColor = System.Drawing.Color.White;
            this.EliminarIngredientesButton.Location = new System.Drawing.Point(176, 397);
            this.EliminarIngredientesButton.Name = "EliminarIngredientesButton";
            this.EliminarIngredientesButton.Size = new System.Drawing.Size(130, 52);
            this.EliminarIngredientesButton.TabIndex = 25;
            this.EliminarIngredientesButton.Text = "Eliminar ingredientes";
            this.EliminarIngredientesButton.UseVisualStyleBackColor = false;
            // 
            // nuevoPostreTextBox
            // 
            this.nuevoPostreTextBox.Location = new System.Drawing.Point(182, 151);
            this.nuevoPostreTextBox.Name = "nuevoPostreTextBox";
            this.nuevoPostreTextBox.Size = new System.Drawing.Size(146, 20);
            this.nuevoPostreTextBox.TabIndex = 23;
            this.nuevoPostreTextBox.TextChanged += new System.EventHandler(this.nuevoPostreTextBox_TextChanged);
            // 
            // buttonSalir
            // 
            this.buttonSalir.BackColor = System.Drawing.Color.CadetBlue;
            this.buttonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSalir.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalir.ForeColor = System.Drawing.Color.White;
            this.buttonSalir.Location = new System.Drawing.Point(688, 408);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(117, 41);
            this.buttonSalir.TabIndex = 22;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = false;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // DarDeBajaButton
            // 
            this.DarDeBajaButton.BackColor = System.Drawing.Color.CadetBlue;
            this.DarDeBajaButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DarDeBajaButton.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DarDeBajaButton.ForeColor = System.Drawing.Color.White;
            this.DarDeBajaButton.Location = new System.Drawing.Point(176, 324);
            this.DarDeBajaButton.Name = "DarDeBajaButton";
            this.DarDeBajaButton.Size = new System.Drawing.Size(130, 52);
            this.DarDeBajaButton.TabIndex = 21;
            this.DarDeBajaButton.Text = "Eliminar postre";
            this.DarDeBajaButton.UseVisualStyleBackColor = false;
            this.DarDeBajaButton.Click += new System.EventHandler(this.DarDeBajaButton_Click);
            // 
            // DarDeAltaButton
            // 
            this.DarDeAltaButton.BackColor = System.Drawing.Color.CadetBlue;
            this.DarDeAltaButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DarDeAltaButton.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DarDeAltaButton.ForeColor = System.Drawing.Color.White;
            this.DarDeAltaButton.Location = new System.Drawing.Point(32, 324);
            this.DarDeAltaButton.Name = "DarDeAltaButton";
            this.DarDeAltaButton.Size = new System.Drawing.Size(130, 52);
            this.DarDeAltaButton.TabIndex = 20;
            this.DarDeAltaButton.Text = "Agregar postre ";
            this.DarDeAltaButton.UseVisualStyleBackColor = false;
            this.DarDeAltaButton.Click += new System.EventHandler(this.DarDeAltaButton_Click_1);
            // 
            // AgregarIngredientesButton
            // 
            this.AgregarIngredientesButton.BackColor = System.Drawing.Color.CadetBlue;
            this.AgregarIngredientesButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AgregarIngredientesButton.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarIngredientesButton.ForeColor = System.Drawing.Color.White;
            this.AgregarIngredientesButton.Location = new System.Drawing.Point(30, 397);
            this.AgregarIngredientesButton.Name = "AgregarIngredientesButton";
            this.AgregarIngredientesButton.Size = new System.Drawing.Size(130, 52);
            this.AgregarIngredientesButton.TabIndex = 19;
            this.AgregarIngredientesButton.Text = "Agregar ingredientes";
            this.AgregarIngredientesButton.UseVisualStyleBackColor = false;
            this.AgregarIngredientesButton.Click += new System.EventHandler(this.AgregarIngredientesButton_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CadetBlue;
            this.panel2.Controls.Add(this.MostrarTablas);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.postresListBox);
            this.panel2.Controls.Add(this.ingredientesListBox);
            this.panel2.Location = new System.Drawing.Point(343, 114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(462, 272);
            this.panel2.TabIndex = 17;
            // 
            // MostrarTablas
            // 
            this.MostrarTablas.BackColor = System.Drawing.Color.DarkSlateGray;
            this.MostrarTablas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MostrarTablas.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MostrarTablas.ForeColor = System.Drawing.Color.White;
            this.MostrarTablas.Location = new System.Drawing.Point(166, 218);
            this.MostrarTablas.Name = "MostrarTablas";
            this.MostrarTablas.Size = new System.Drawing.Size(139, 41);
            this.MostrarTablas.TabIndex = 23;
            this.MostrarTablas.Text = "Mostrar postres";
            this.MostrarTablas.UseVisualStyleBackColor = false;
            this.MostrarTablas.Click += new System.EventHandler(this.MostrarTablas_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(252, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Listas de ingredientes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Listas de postres";
            // 
            // postresListBox
            // 
            this.postresListBox.FormattingEnabled = true;
            this.postresListBox.ItemHeight = 14;
            this.postresListBox.Location = new System.Drawing.Point(23, 40);
            this.postresListBox.Name = "postresListBox";
            this.postresListBox.Size = new System.Drawing.Size(208, 172);
            this.postresListBox.TabIndex = 19;
            // 
            // ingredientesListBox
            // 
            this.ingredientesListBox.FormattingEnabled = true;
            this.ingredientesListBox.ItemHeight = 14;
            this.ingredientesListBox.Location = new System.Drawing.Point(237, 40);
            this.ingredientesListBox.Name = "ingredientesListBox";
            this.ingredientesListBox.Size = new System.Drawing.Size(208, 172);
            this.ingredientesListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(54, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(659, 72);
            this.label1.TabIndex = 29;
            this.label1.Text = "Bienvenido a panaderia UH\r\n\r\nNota importante:\r\nEl cliente debe ser claro, con el " +
    "postre e ingredientes que desea para su pedido.\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(6, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 16);
            this.label7.TabIndex = 31;
            this.label7.Text = "Ingresa el ingrediente:";
            // 
            // nuevosIngredientesTextBox
            // 
            this.nuevosIngredientesTextBox.Location = new System.Drawing.Point(182, 180);
            this.nuevosIngredientesTextBox.Name = "nuevosIngredientesTextBox";
            this.nuevosIngredientesTextBox.Size = new System.Drawing.Size(146, 20);
            this.nuevosIngredientesTextBox.TabIndex = 30;
            // 
            // postresComboBox
            // 
            this.postresComboBox.FormattingEnabled = true;
            this.postresComboBox.Location = new System.Drawing.Point(182, 216);
            this.postresComboBox.Name = "postresComboBox";
            this.postresComboBox.Size = new System.Drawing.Size(146, 22);
            this.postresComboBox.TabIndex = 16;
            // 
            // comboBoxIngredientes
            // 
            this.comboBoxIngredientes.FormattingEnabled = true;
            this.comboBoxIngredientes.Location = new System.Drawing.Point(182, 259);
            this.comboBoxIngredientes.Name = "comboBoxIngredientes";
            this.comboBoxIngredientes.Size = new System.Drawing.Size(146, 22);
            this.comboBoxIngredientes.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Seleccione el postre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(70, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "Ingredientes:";
            // 
            // MenuPanaderia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(817, 461);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nuevosIngredientesTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EliminarIngredientesButton);
            this.Controls.Add(this.comboBoxIngredientes);
            this.Controls.Add(this.postresComboBox);
            this.Controls.Add(this.nuevoPostreTextBox);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.DarDeBajaButton);
            this.Controls.Add(this.DarDeAltaButton);
            this.Controls.Add(this.AgregarIngredientesButton);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MenuPanaderia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panaderia UH";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button EliminarIngredientesButton;
        private System.Windows.Forms.TextBox nuevoPostreTextBox;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Button DarDeBajaButton;
        private System.Windows.Forms.Button DarDeAltaButton;
        private System.Windows.Forms.Button AgregarIngredientesButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ingredientesListBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox postresListBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nuevosIngredientesTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxIngredientes;
        private System.Windows.Forms.ComboBox postresComboBox;
        private System.Windows.Forms.Button MostrarTablas;
    }
}