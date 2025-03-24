using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPractico1
{
    public partial class Ejercicio2: Form
    {
        private readonly inicio inicio;
        public Ejercicio2(inicio inicio)
        {
            InitializeComponent();
            this.inicio = inicio;
        }

        private void Ejercicio2_FormClosed(object sender, FormClosedEventArgs e)
        {
            inicio.Show();
        }
    }
}
