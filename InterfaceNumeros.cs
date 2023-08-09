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
        //
        //Metodos creados individualmente para cada textbox y asi detectar si se ingreso un valor diferente del que se solicita.
        private void controlBotones1()
        {
            if (int.TryParse(NumeroUnoI.Text.Trim(), out _))
            {
                errorProvider1.SetError(NumeroUnoI, "");
            }
            else
            {
                errorProvider1.SetError(NumeroUnoI, "El valor debe ser un número entero");
                NumeroUnoI.Focus();
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
        private void EnviarNumeros_Click(object sender, EventArgs e)
        {

        }
        public class Ejercicio23
        {
            public int num1, num2, num3, num4, num5;
            public int mayor, medio1, medio2, medio3, menor;
            public int numeroIngresado;
            public void CalculoNumeros()
            {
                // Aquí puedes interactuar con los controles de Windows Forms
                List<int> list = new List<int>();

                for (int i = 1; i <= 5; i++)
                {
                    numeroIngresado = int.Parse(Console.ReadLine());
                    if (i == 1)
                    {
                        num1 = numeroIngresado;
                    }
                    else if (i == 2)
                    {
                        num2 = numeroIngresado;
                    }
                    else if (i == 3)
                    {
                        num3 = numeroIngresado;
                    }
                    else if (i == 4)
                    {
                        num4 = numeroIngresado;
                    }
                    else if (i == 5)
                    {
                        num5 = numeroIngresado;
                    }
                }
                //ver cual es número mayor, menor y el del medio
                int menor = Math.Min(Math.Min(Math.Min(Math.Min(num1, num2), num3), num4), num5);
                int mayor = Math.Max(Math.Max(Math.Max(Math.Max(num1, num2), num3), num4), num5);

                int medio1 = Math.Min(Math.Max(Math.Min(num1, num2), Math.Min(num3, num4)), Math.Min(Math.Max(num1, num2), num5));
                int medio2 = Math.Min(Math.Max(Math.Min(num1, num3), Math.Min(num2, num4)), Math.Min(Math.Max(num1, num3), num5));
                int medio3 = Math.Min(Math.Max(Math.Min(num1, num4), Math.Min(num2, num3)), Math.Min(Math.Max(num1, num4), num5));

                // Por ejemplo, en lugar de Console.WriteLine, puedes usar MessageBox.Show
                MessageBox.Show("Cálculos realizados. Ver resultados en la lista.");
            }
        }
    }
}
