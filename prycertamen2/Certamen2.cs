using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prycertamen2
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btningresar_Click(object sender, EventArgs e)
        {

        }

        private void txb1_TextChanged(object sender, EventArgs e)
        {
            string nombre = txb1.Text;
          
           
        }

        private void lbl7_Click(object sender, EventArgs e)
        {

        }

        private void txb2_TextChanged(object sender, EventArgs e)
        {
         
        }
        int contador = 0;
        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (txb2.Text.Length < 9 || txb2.Text.Length > 9)
            {
                MessageBox.Show("Debe tener 9 digitos", "Error");
            }
            else
            {


                if (ltb1.Items.Count <= 6)
                {


                    string nombre = (txb1.Text).ToString();
                    int telefono = int.Parse(txb2.Text);
                    string usuario = ("Nombre: " + nombre + " Teléfono: " + telefono);
                    ltb1.Items.Add(usuario);

                    contador++;
                    lblcontador.Text = contador.ToString();


                    nombre = txb1.Text;
                    MessageBox.Show("Has agregado a  " + nombre);

                    txb1.Clear();
                    txb2.Clear();

                }
                else
                {
                    MessageBox.Show("Limite de contactos", "ERROR");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (ltb1.SelectedItems.Count >0)

            {


                ltb1.Items.Remove(ltb1.Text);
                contador--;
                lblcontador.Text = contador.ToString();
                MessageBox.Show("Se ha eliminado un contacto", "ERROR");
            }
            else
            {
                MessageBox.Show("Seleccione un contacto", "ERROR");
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
