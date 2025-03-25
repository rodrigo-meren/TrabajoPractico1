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
            {
                txtNombre.BackColor = Color.Red;
                MessageBox.Show("Debe ingresar un nombre", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.BackColor = System.Drawing.SystemColors.Window;
            }
            else
            {
                if (!(nombreRepetido(txtNombre.Text.ToString())))
                    lbxIzquierda.Items.Add(txtNombre.Text);
                else
                {
                    txtNombre.BackColor = Color.Red;
                    MessageBox.Show("Ya existe un registro con ese nombre.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNombre.BackColor = System.Drawing.SystemColors.Window;
                }
            }
            txtNombre.Text = "";
        }


        private bool nombreRepetido(string nombre)
        {
            for (int i = 0; i < lbxIzquierda.Items.Count; i++)
                if (lbxIzquierda.Items[i].ToString().ToUpper() == nombre.ToUpper())
                    return true; 
            
            for (int i = 0; i < lbxDerecha.Items.Count; i++)
                if (lbxDerecha.Items[i].ToString().ToUpper() == nombre.ToUpper())
                    return true;

            return false;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            if(lbxIzquierda.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un nombre.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lbxDerecha.Items.Add(lbxIzquierda.SelectedItem);
            lbxIzquierda.Items.Remove(lbxIzquierda.SelectedItem);
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            if (lbxIzquierda.Items.Count == 0)
            {
                MessageBox.Show("Por favor ingrese un nombre primero", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (string nombre in lbxIzquierda.Items)
            {
                lbxDerecha.Items.Add(nombre);
            }

            lbxIzquierda.Items.Clear();
        }
    }
}
