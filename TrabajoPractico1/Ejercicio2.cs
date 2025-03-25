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

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if(txtNombre.Text == "Ingrese un nombre")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Black;
            }
           
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Ingrese un nombre";
                txtNombre.ForeColor = Color.Gray;
            }
        }

        private void txtApellido_Enter(object sender, EventArgs e)
        {
            if (txtApellido.Text == "Ingrese un apellido")
            {
                txtApellido.Text = "";
                txtApellido.ForeColor = Color.Black;
            }
        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {
            if (txtApellido.Text == "")
            {   
                txtApellido.Text = "Ingrese un apellido";
                txtApellido.ForeColor = Color.Gray;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Ingrese un nombre" || txtApellido.Text == "Ingrese un apellido")
            {
                MessageBox.Show("Debe ingresar un nombre y un apellido", "Atención");
            }
            else
            {
                lbElementos.Items.Add(txtNombre.Text + " " + txtApellido.Text);
                txtNombre.Text = "Ingrese un nombre";
                txtNombre.ForeColor = Color.Gray;
                txtApellido.Text = "Ingrese un apellido";
                txtApellido.ForeColor = Color.Gray;
            }
        }
    }
}
