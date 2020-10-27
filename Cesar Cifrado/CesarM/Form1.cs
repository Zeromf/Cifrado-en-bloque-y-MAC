using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CesarM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCifrar_Click(object sender, EventArgs e)
        {
            Lim();
            CifrarCadena();
            label2.Text = "Cifrado";

        }

        private void btnDesifrar_Click(object sender, EventArgs e)
        {
            Lim();
            DecifrarCadena();
            label2.Text = "Decifrado";

        }

        void CifrarCadena()
        {
            int t, letras;
            string cadena = txtCadena.Text;
            letras = cadena.Length;
            char[] ch = new char[letras];
            for (int i = 0; i < letras; i++)
            {
                t = (int)cadena[i];
                ch[i] = (char)(t + 3);
                txtlistas.Items.Add(ch[i]);
            }
        }
        void DecifrarCadena()
        {
            int t, letras;
            string cadena = txtCadena.Text;
            letras = cadena.Length;
            char[] ch = new char[letras];
            for (int i = 0; i < letras; i++)
            {
                t = (int)cadena[i];
                ch[i] = (char)(t - 3);
                txtlistas.Items.Add(ch[i]);
            }
        }

        void Lim()
        {
            txtlistas.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtlistas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Eliminar(object sender, EventArgs e)
        {
            txtlistas.Items.Clear();
            
        }

        public void BorrarCampos(Control control)
        {


            foreach (var txt in control.Controls)
            {

                if (txt is TextBox)
                {
                    ((TextBox)txt).Clear();
                }
                else if (txt is ComboBox)
                {
                    ((ComboBox)txt).SelectedIndex = 0;
                }

            }
            txtlistas.Items.Clear();






        }

        private void Salir(object sender, EventArgs e)
        {
            Close();
        }

        private void Limpiar(object sender, EventArgs e)
        {
            BorrarCampos(this);
        }
    }
}
