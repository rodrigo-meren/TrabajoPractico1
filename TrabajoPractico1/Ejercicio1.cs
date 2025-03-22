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
    public partial class Ejercicio1: Form
    {
        inicio inicio;
        public Ejercicio1(inicio inicio)
        {
            InitializeComponent();
            this.inicio = inicio;
        }

        private void Ejercicio1_FormClosed(object sender, FormClosedEventArgs e)
        {
            inicio.Show();
        }
    }
}
