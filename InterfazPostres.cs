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
    public partial class MenuPanaderia : Form
    {
        string[] postres = new string[10];
        List<LinkedList<string>> ingredientes = new List<LinkedList<string>>();
        public MenuPanaderia()
        {
            InitializeComponent();
            // Inicializar el array de postres y la lista de ingredientes
            for (int i = 0; i < 10; i++)
            {
                postres[i] = null;
                ingredientes.Add(new LinkedList<string>());
            }
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void ControlBotones1()
        {
            if (nuevoPostreTextBox.Text.Trim() != string.Empty && nuevoPostreTextBox.Text.All(char.IsLetter))
            {
                DarDeAltaButton.Enabled = true;
                errorProvider1.SetError(nuevoPostreTextBox, "");
            }
            else
            {
                if (!(nuevoPostreTextBox.Text.All(char.IsLetter)))
                {
                    errorProvider1.SetError(nuevoPostreTextBox, "El postre debe contener solo letras");
                }
                else
                {
                    errorProvider1.SetError(nuevoPostreTextBox, "Error al introducir el postre");
                }
                DarDeAltaButton.Enabled = false;
            }
        }

        private void DarDeBajaButton_Click(object sender, EventArgs e)
        {
            string postreBaja = postresListBox.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(postreBaja))
            {
                int indice = Array.IndexOf(postres, postreBaja);

                postres[indice] = null;
                ingredientes[indice].Clear();

                postresListBox.Items.Remove(postreBaja);
                ingredientesListBox.Items.Clear();

                MessageBox.Show("Postre dado de baja exitosamente");
            }
            else
            {
                MessageBox.Show("Seleccione un postre para dar de baja");
            }
        }

        private void nuevoPostreTextBox_TextChanged(object sender, EventArgs e)
        {
            ControlBotones1();
        }

        private void DarDeAltaButton_Click_1(object sender, EventArgs e)
        {
            string nuevoPostre = nuevoPostreTextBox.Text;

            if (!string.IsNullOrEmpty(nuevoPostre) && Array.IndexOf(postres, nuevoPostre) == -1)
            {
                int indice = Array.IndexOf(postres, null);

                if (indice != -1)
                {
                    postres[indice] = nuevoPostre;
                    ingredientes[indice] = new LinkedList<string>();

                    postresListBox.Items.Add(nuevoPostre);
                    postresComboBox.Items.Add(nuevoPostre);
                    MessageBox.Show("Postre dado de alta exitosamente");

                    AgregarIngredientesButton.Focus();
                }
                else
                {
                    MessageBox.Show("No hay espacio para más postres");
                }
            }
            else
            {
                MessageBox.Show("El postre ya existe o el nombre es inválido");
            }
        }

        private void AgregarIngredientesButton_Click_1(object sender, EventArgs e)
        {
            string nombrePostre = postresListBox.SelectedItem.ToString();

            if (!string.IsNullOrEmpty(nombrePostre))
            {
                int indice = Array.IndexOf(postres, nombrePostre);

                string nuevosIngredientes = nuevosIngredientesTextBox.Text;
                string[] nuevosIngredientesArray = nuevosIngredientes.Split(',');

                foreach (var ingrediente in nuevosIngredientesArray)
                {
                    ingredientes[indice].AddLast(ingrediente.Trim());
                }

                MessageBox.Show("Ingredientes agregados exitosamente");

                nuevosIngredientesTextBox.Clear();
            }
        }

        private void EliminarIngredientesButton_Click_1(object sender, EventArgs e)
        {
            string nombrePostre = postresListBox.SelectedItem.ToString();

            if (!string.IsNullOrEmpty(nombrePostre))
            {
                int indice = Array.IndexOf(postres, nombrePostre);

                string ingredienteEliminar = ingredientesListBox.SelectedItem?.ToString();

                if (!string.IsNullOrEmpty(ingredienteEliminar) && ingredientes[indice].Remove(ingredienteEliminar))
                {
                    MessageBox.Show("Ingrediente eliminado exitosamente");
                    ingredientesListBox.Items.Remove(ingredienteEliminar);
                }
                else
                {
                    MessageBox.Show("Ingrediente no encontrado");
                }
            }
        }
    }
}

       