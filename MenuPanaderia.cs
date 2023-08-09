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
        public MenuPanaderia()
        {
            InitializeComponent();
        }

        private void menuOrdenar_Click(object sender, EventArgs e)
        {
            using (InterfacePostres ventanaPostres = new InterfacePostres())
                ventanaPostres.ShowDialog();
        }

        private void VolverInicio_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
