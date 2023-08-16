using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoEstructuraInterfaces
{
    public partial class InterfacePostresEliminar : Form
    {
        public InterfacePostresEliminar()
        {
            InitializeComponent();
        }

        private void BotonVolverInicio_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BotonEliminarPedido_Click(object sender, EventArgs e)
        {
            //DWQ
        }

        private void IngresarPostre_TextChanged(object sender, EventArgs e)
        {
            controlBotones1();
        }
        private void controlBotones1()
        {
            if (IngresarPostre.Text.Trim() != string.Empty && IngresarPostre.Text.All(char.IsLetter))
            {
                BotonEliminarPedido.Enabled = true;
                errorProvider1.SetError(IngresarPostre, "");
            }
            else
            {
                if (!(IngresarPostre.Text.All(char.IsLetter)))
                {
                    errorProvider1.SetError(IngresarPostre, "El postre debe contener solo letras");
                }
                else
                {
                    errorProvider1.SetError(IngresarPostre, "Error al introducir el postre");
                }
                BotonEliminarPedido.Enabled = false;
                IngresarPostre.Focus();
            }
        }

        private void InterfacePostresEliminar_Load(object sender, EventArgs e)
        {
            BotonEliminarPedido.Enabled = false;
        }
    }
}
