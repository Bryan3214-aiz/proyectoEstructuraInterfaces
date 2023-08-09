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
    public partial class InterfaceNumeros : Form
    {
        public InterfaceNumeros()
        {
            InitializeComponent();
        }
        //Metodos creados individualmente para cada textbox y asi detectar si se ingreso un valor diferente del que se solicita.
        private void controlBotones1()
        {
            if (int.TryParse(NumeroUno.Text.Trim(), out _))
            {
                errorProvider1.SetError(NumeroUno, "");
            }
            else
            {
                errorProvider1.SetError(NumeroUno, "El valor debe ser un número entero");
                NumeroUno.Focus();
            }
        }
        private void controlBotones2()
        {
            if (int.TryParse(NumeroDos.Text.Trim(), out _))
            {
                errorProvider1.SetError(NumeroDos, "");
            }
            else
            {
                errorProvider1.SetError(NumeroDos, "El valor debe ser un número entero");
                NumeroDos.Focus();
            }
        }
        private void controlBotones3()
        {
            if (int.TryParse(NumeroTres.Text.Trim(), out _))
            {
                errorProvider1.SetError(NumeroTres, "");
            }
            else
            {
                errorProvider1.SetError(NumeroTres, "El valor debe ser un número entero");
                NumeroTres.Focus();
            }
        }
        private void controlBotones4()
        {
            if (int.TryParse(NumeroCuatro.Text.Trim(), out _))
            {
                errorProvider1.SetError(NumeroCuatro, "");
            }
            else
            {
                errorProvider1.SetError(NumeroCuatro, "El valor debe ser un número entero");
                NumeroCuatro.Focus();
            }
        }
        private void ControlBotones5()
        {
            if (int.TryParse(NumeroCinco.Text.Trim(), out _))
            {
                errorProvider1.SetError(NumeroCinco, "");
            }
            else
            {
                errorProvider1.SetError(NumeroCinco, "El valor debe ser un número entero");
                NumeroCinco.Focus();
            }
        }
        //Metodos de llamada al control de errores
        private void NumeroUno_TextChanged(object sender, EventArgs e)
        {
            controlBotones1();
        }

        private void NumeroDos_TextChanged(object sender, EventArgs e)
        {
            controlBotones2();
        }

        private void NumeroTres_TextChanged(object sender, EventArgs e)
        {
            controlBotones3();
        }

        private void NumeroCuatro_TextChanged(object sender, EventArgs e)
        {
            controlBotones4();
        }

        private void NumeroCinco_TextChanged(object sender, EventArgs e)
        {
            ControlBotones5();
        }


        private void BotonVolverInicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
