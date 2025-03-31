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
    public partial class Ejercicio3 : Form
    {
        private readonly Inicio inicio;
        public Ejercicio3(Inicio inicio)
        {
            InitializeComponent();
            this.inicio = inicio;
        }

        private void Ejercicio3_FormClosed(object sender, FormClosedEventArgs e)
        {
            inicio.Show();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lblMostrar.Text = "Usted seleccionó los siguientes elementos:";
            if (rbFemenino.Checked)
            {
                lblSexo.Text = "Sexo: Femenino";
                if (rbCasado.Checked)
                {
                    lblEstCivil.Text = "Estado Civil: Casada";
                }
                else
                {
                    lblEstCivil.Text = "Estado Civil: Soltera";
                }
            }
            else
            {
                if (rbMasculino.Checked)
                {
                    lblSexo.Text = "Sexo: Masculino";
                    if (rbCasado.Checked)
                    {
                        lblEstCivil.Text = "Estado Civil: Casado";
                    }
                    else
                    {
                        lblEstCivil.Text = "Estado Civil: Soltero";
                    }
                }

            }
            lbOficios.Items.Clear();
            lblOficio.Text = "Oficio: ";
            foreach (string oficio in chkLbOficios.CheckedItems)
            {
                lbOficios.Items.Add("* " + oficio);
            }
        }
    }
}
