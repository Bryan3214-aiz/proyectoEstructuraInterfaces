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
    public partial class menuInicio : Form
    {
        public menuInicio()
        {
            InitializeComponent();
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonPostres_Click(object sender, EventArgs e)
        {

            using (InterfacePostres ventanaPostres = new InterfacePostres())
                ventanaPostres.ShowDialog();
        }

        private void botonNumeros_Click(object sender, EventArgs e)
        {
            using (InterfaceNumeros ventanaNumeros = new InterfaceNumeros())
                ventanaNumeros.ShowDialog();
        }
    }
}
