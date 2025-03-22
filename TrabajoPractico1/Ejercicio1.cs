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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
                txtNombre.BackColor = Color.Red;
            else
                txtNombre.BackColor = System.Drawing.SystemColors.Control;

            if (txtNombre.Text != "")
            {
                if (!(nombreRepetido(txtNombre.Text.ToString())))
                    lbxIzquierda.Items.Add(txtNombre.Text);
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre");
            }

                txtNombre.Text = "";
        }

        private bool nombreRepetido(string nombre)
        {
            bool repetido = false;

            for (int i = 0; i < lbxIzquierda.Items.Count; i++)
            {
                if (lbxIzquierda.Items[i].ToString().ToUpper() == nombre.ToUpper())
                    repetido = true; 
            }

            return repetido;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

    }
}
