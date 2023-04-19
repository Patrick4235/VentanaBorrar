using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            String nombreContacto = txtNombre.Text;

            try
            {
                EliminarContacto(nombreContacto);
            }
            catch(DirectoryNotFoundException error)
            {
                Console.WriteLine(error);
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void EliminarContacto(String nombreContacto)
        {
            TextReader leer = new StreamReader("Texto.txt");
            String contactoABorrar = leer.ReadLine();

            if (nombreContacto.Equals(contactoABorrar))
            {
                MessageBox.Show("Contacto Eliminado");
            }
            else
            {
                MessageBox.Show("Contacto No Encontrado");
            }

            leer.Close();
        }
    }
}
