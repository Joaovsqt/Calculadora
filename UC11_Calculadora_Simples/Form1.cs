using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UC11_Calculadora_Simples
{
    public partial class Calculadora_Simples : Form
    {
        public Calculadora_Simples()
        {
            InitializeComponent();
        }

        private void buttonSOMA_Click(object sender, EventArgs e)
        {
            double N1 = 0;
            double N2 = 0;
            double resultado = 0;
            
           

            if (textBoxNUM1.Text == String.Empty || textBoxNUM2.Text == string.Empty)
            {
                labelRESULTADO.Text = "Campo(s) Vazio(s)!";

            } else
            {
                //Aqui converteremos os texto para numero (double)
                N1 = Convert.ToDouble(textBoxNUM1.Text.Replace(".", ","));
                N2 = Convert.ToDouble(textBoxNUM2.Text.Replace(".", ","));


                resultado = N1 + N2;
                // Aqui converteremos o resultado em double, para texto
                labelRESULTADO.Text = resultado.ToString();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxNUM1.Text != string.Empty && textBoxNUM2.Text != string.Empty) {
                double N1 = 0;
                double N2 = 0;
                double resultado = 0;

                //Aqui converteremos os texto para numero (double)
                N1 = Convert.ToDouble(textBoxNUM1.Text.Replace(".", ","));
                N2 = Convert.ToDouble(textBoxNUM2.Text.Replace(".", ","));


                resultado = N1 - N2;
                // Aqui converteremos o resultado em double, para texto
                labelRESULTADO.Text = resultado.ToString();
            } else
            {
                labelRESULTADO.Text = "Preenche os camps !";
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxNUM1.Text != string.Empty && textBoxNUM2.Text != string.Empty)
            {

                double N1 = 0;
                double N2 = 0;
                double resultado = 0;

                //Aqui converteremos os texto para numero (double)
                N1 = Convert.ToDouble(textBoxNUM1.Text.Replace(".", ","));
                N2 = Convert.ToDouble(textBoxNUM2.Text.Replace(".", ","));


                resultado = N1 * N2;
                // Aqui converteremos o resultado em double, para texto
                labelRESULTADO.Text = resultado.ToString();
            }
            else
            {
                labelRESULTADO.Text = "Preenche os camps !";
            }
            } 

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBoxNUM1.Text != string.Empty && textBoxNUM2.Text != string.Empty) { 
            double N1 = 0;
            double N2 = 0;
            double resultado = 0;

            //Aqui converteremos os texto para numero (double)
            N1 = Convert.ToDouble(textBoxNUM1.Text.Replace(".", ","));
            N2 = Convert.ToDouble(textBoxNUM2.Text.Replace(".", ","));


            resultado = N1 / N2;
            // Aqui converteremos o resultado em double, para texto
            labelRESULTADO.Text = resultado.ToString();
        }
            else
            {
                labelRESULTADO.Text = "Preenche os camps !";
            }
        }

        private void buttonCLEAR_Click(object sender, EventArgs e)
        {
            textBoxNUM1.Clear();
            textBoxNUM2.Clear();
            labelRESULTADO.Text = "0,0";
        }
    }
}
