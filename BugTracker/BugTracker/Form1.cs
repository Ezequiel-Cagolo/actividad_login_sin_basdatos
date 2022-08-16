using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if((txtUsuario.Text == ""))
            {
                MessageBox.Show("Ingrese un usuario: ");
                return;
            }

            if ((txtContraseña.Text == ""))
            {
                MessageBox.Show("Ingrese una contraseña: ");
                return;
            }

            if (ValidarCampos(txtUsuario.Text, txtContraseña.Text))
            {
                MessageBox.Show("Usted ha ingresado al sistema");
                this.Close();

            }
            else
            {
                txtUsuario.Text = "";
                txtContraseña.Text = "";
                MessageBox.Show("Debe ingresar un usuario y/0 contraseña validos");
            }

        }

        private bool ValidarCampos(string usuario, string password)
        {
            if (usuario.Equals("") || password.Equals(""))
            {
                return false;
            }
            return true;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if ((txtUsuario.Text == ""))
            {
                MessageBox.Show("Ingrese un usuario: ");
                return;
            }

            if ((txtContraseña.Text == ""))
            {
                MessageBox.Show("Ingrese una contraseña: ");
                return;
            }

            MessageBox.Show("Usted ingreso al sistema ");
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
