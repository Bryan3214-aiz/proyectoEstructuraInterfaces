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
    public partial class InterfacePostres : Form
    {
        public InterfacePostres()
        {
            InitializeComponent();
        }

        private void InterfacePostres_Load(object sender, EventArgs e)
        {
            BotonFinalizarPedido.Enabled = false;
        }
        private void controlBotones1()
        {
            if (IngresarPostre.Text.Trim() != string.Empty && IngresarPostre.Text.All(char.IsLetter))
            {
                BotonFinalizarPedido.Enabled = true;
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
                BotonFinalizarPedido.Enabled = false;
                IngresarPostre.Focus();
            }
        }

        private void IngresarPostre_TextChanged(object sender, EventArgs e)
        {
            controlBotones1();
        }

        private void BotonVolverInicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //private void controlBotones2()
        //{
        //    if (IngresarIngredientes.Text.Trim() != string.Empty && IngresarIngredientes.Text.All(char.IsLetter))
        //    {
        //        BotonFinalizarPedido.Enabled = true;
        //        errorProvider1.SetError(IngresarPostre, "");
        //    }
        //    else
        //    {
        //        if (!(IngresarIngredientes.Text.All(char.IsLetter)))
        //        {
        //            errorProvider1.SetError(IngresarIngredientes, "El postre debe contener solo letras");
        //        }
        //        else
        //        {
        //            errorProvider1.SetError(IngresarIngredientes, "Error al introducir el postre");
        //        }
        //        BotonFinalizarPedido.Enabled = false;
        //        IngresarIngredientes.Focus();
        //    }
        //}
        //private void IngresarIngredientes_TextChanged(object sender, EventArgs e)
        //{
        //    controlBotones2();
        //}
    }
}
