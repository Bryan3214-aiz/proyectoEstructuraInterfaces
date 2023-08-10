﻿namespace proyectoEstructuraInterfaces
{
    partial class InterfacePostresEliminar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfacePostresEliminar));
            this.pedidoPostres = new System.Windows.Forms.Panel();
            this.IngresarIngredientes = new System.Windows.Forms.TextBox();
            this.IngresarPostre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BotonVolverInicio = new System.Windows.Forms.Button();
            this.BotonEliminarPedido = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pedidoPostres.SuspendLayout();
            this.SuspendLayout();
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
            this.pedidoPostres.Location = new System.Drawing.Point(70, 128);
            this.pedidoPostres.Name = "pedidoPostres";
            this.pedidoPostres.Size = new System.Drawing.Size(388, 154);
            this.pedidoPostres.TabIndex = 18;
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
            this.label3.Location = new System.Drawing.Point(127, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Eliminar el pedido";
            // 
            // BotonVolverInicio
            // 
            this.BotonVolverInicio.BackColor = System.Drawing.Color.SlateBlue;
            this.BotonVolverInicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BotonVolverInicio.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonVolverInicio.ForeColor = System.Drawing.Color.White;
            this.BotonVolverInicio.Location = new System.Drawing.Point(339, 373);
            this.BotonVolverInicio.Name = "BotonVolverInicio";
            this.BotonVolverInicio.Size = new System.Drawing.Size(191, 45);
            this.BotonVolverInicio.TabIndex = 17;
            this.BotonVolverInicio.Text = "Volver al inicio";
            this.BotonVolverInicio.UseVisualStyleBackColor = false;
            this.BotonVolverInicio.Click += new System.EventHandler(this.BotonVolverInicio_Click);
            // 
            // BotonEliminarPedido
            // 
            this.BotonEliminarPedido.BackColor = System.Drawing.Color.SlateBlue;
            this.BotonEliminarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BotonEliminarPedido.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonEliminarPedido.ForeColor = System.Drawing.Color.White;
            this.BotonEliminarPedido.Location = new System.Drawing.Point(534, 175);
            this.BotonEliminarPedido.Name = "BotonEliminarPedido";
            this.BotonEliminarPedido.Size = new System.Drawing.Size(201, 80);
            this.BotonEliminarPedido.TabIndex = 16;
            this.BotonEliminarPedido.Text = "Eliminar pedido";
            this.BotonEliminarPedido.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(197, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(461, 36);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nota importante:\r\nEl cliente debe ingresar el nombre del postre que desea elimina" +
    "r.\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // InterfacePostresEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.pedidoPostres);
            this.Controls.Add(this.BotonVolverInicio);
            this.Controls.Add(this.BotonEliminarPedido);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InterfacePostresEliminar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar pedidos";
            this.pedidoPostres.ResumeLayout(false);
            this.pedidoPostres.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pedidoPostres;
        private System.Windows.Forms.TextBox IngresarIngredientes;
        private System.Windows.Forms.TextBox IngresarPostre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BotonVolverInicio;
        private System.Windows.Forms.Button BotonEliminarPedido;
        private System.Windows.Forms.Label label2;
    }
}