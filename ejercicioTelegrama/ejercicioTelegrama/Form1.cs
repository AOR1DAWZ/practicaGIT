using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicioTelegrama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void btnCalcularPrecio_Click(object sender, EventArgs e)
        {
            string textoTelegrama;
            int numPalabras = 0;
            double coste;
            bool Ordinario = rdOrdinario.Checked;
            bool Urgente = rdUrgente.Checked;
            //Leo el telegrama
            textoTelegrama = txtTelegrama.Text;
            //Obtengo el número de palabras que forma el telegrama
            string[] palabras = textoTelegrama.Split(' ');
            numPalabras = palabras.Length;
            //Si el telegrama es ordinario
            if (Ordinario == true)
            {
                if (numPalabras <= 10)
                {
                    coste = 2.5;
                }
                else
                {
                    coste = 2.5 + (0.5 * (numPalabras - 10));
                }
            }
            else
            //Si el telegrama es urgente
            {
                if (Urgente == true)
                {
                    if (numPalabras <= 10)
                    {
                        coste = 5;
                    }
                    else
                    {
                        coste = 5 + (0.75 * (numPalabras - 10));
                    }
                }
                else
                {
                    coste = 0;
                }
            }
            txtPrecio.Text = coste.ToString() + " euros";
        }
    }
}
