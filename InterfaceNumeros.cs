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
        private List<int> numerosLista = new List<int>(); //En esta lista global se guardan todos los numeros.
        public InterfaceNumeros()
        {
            InitializeComponent();
        }
        //
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
                EnviarNumeros.Enabled = true;
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
            int num1 = Convert.ToInt32(NumeroUno.Text);
            int num2 = Convert.ToInt32(NumeroDos.Text);
            int num3 = Convert.ToInt32(NumeroTres.Text);
            int num4 = Convert.ToInt32(NumeroCuatro.Text);
            int num5 = Convert.ToInt32(NumeroCinco.Text);
            numerosLista.Clear(); //Primero hace una limpieza de la lista, por si ya existia algun valor. Luego agrega los numeroos que se ingresaron a la lista. 
            numerosLista.Add(num1);
            numerosLista.Add(num2);
            numerosLista.Add(num3);
            numerosLista.Add(num4);
            numerosLista.Add(num5);
            // Encuentra el mayor y el menor
            int mayor = numerosLista.Max();
            int menor = numerosLista.Min();
            var intermedios = numerosLista.Where(num => num != mayor && num != menor).OrderBy(num => num).ToList();
            for (int i = menor; i <= mayor; i++)
            {
                if (!numerosLista.Contains(i))
                {
                    numerosLista.Add(i);
                }
            }
            // Ordena la lista
            numerosLista.Sort();

            // Mostrar los valores en la ListBox
            listaNumeros.Items.Clear();
            listaNumeros.Items.Add($"Mayor: {mayor}");
            listaNumeros.Items.Add($"Menor: {menor}");
            listaNumeros.Items.Add("Valores intermedios:");
            listaNumeros.Items.AddRange(intermedios.Select(num => num.ToString()).ToArray());
            listaNumeros.Items.Add("Números faltantes:");
            listaNumeros.Items.AddRange(numerosLista.Select(num => num.ToString()).ToArray());
        }

        private void InterfaceNumeros_Load(object sender, EventArgs e)
        {
            EnviarNumeros.Enabled = false;
        }
    }
}
