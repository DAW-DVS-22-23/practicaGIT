using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVS_22_23_Telegrama
{
    public partial class txtPrecio : Form
    {
        public txtPrecio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textoTelegrama;
            char tipoTelegrama = ' ';
            int numPalabras = 1;
            int i = 0;
            int letras = txtTelegrama.Text.Length;
            double coste;
            //Leo el telegrama DVS 22 23
            textoTelegrama = txtTelegrama.Text;
            // telegrama urgente?
            if (rbUrgente.Checked)
                tipoTelegrama = 'u';
            else
                tipoTelegrama = 'o';
            //Obtengo el número de palabras que forma el telegrama DVS 22 23
            while (i < letras)
            {
                if (textoTelegrama[i] == ' ')
                {
                    numPalabras++;
                }
                i++;
            }
            //Si el telegrama es ordinario DVS 22 23
            if (tipoTelegrama == 'o')
            {
                if (numPalabras <= 10)
                    coste = 2.5;
                else
                    coste = 2.5 + 0.5 * (numPalabras - 10);
            }
            else if (tipoTelegrama == 'u')
            {
                if (numPalabras <= 10)
                    coste = 5;
                else
                    coste = 5 + 0.75 * (numPalabras - 10); //DVS 22 23
            }     
            else
                coste = 0;
            textBox1.Text = coste.ToString() + " euros";
        }

        private void txtPrecio_Load(object sender, EventArgs e)
        {

        }
    }
}
