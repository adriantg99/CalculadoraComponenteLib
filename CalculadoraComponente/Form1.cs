using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaCalculadora;

namespace CalculadoraComponente
{

    public partial class Form1 : Form
    {
        LibreriaCalculadora.CalculadoraLib.Aritmetica Libreria = new CalculadoraLib.Aritmetica();
        double aux;
        int c = 0;
        bool primerpunto;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnminus_Click(object sender, EventArgs e)
        {

            Libreria.Temporal1 = Convert.ToDouble(txtResultado.Text);
            txtResultado.Text = string.Empty;
            primerpunto = false;
            Libreria.UltimaOperacion = CalculadoraLib.Operacion.Resta;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            Libreria.Temporal1 = Convert.ToDouble(txtResultado.Text);
            txtResultado.Text = string.Empty;
            primerpunto = false;
            Libreria.UltimaOperacion = CalculadoraLib.Operacion.Suma;

            if (c > 0)
            {
                switch (Libreria.UltimaOperacion)
                {
                    case CalculadoraLib.Operacion.Suma:
                        var resultadoSuma = Libreria.Sumar(aux, Libreria.Temporal1);
                        txtResultado.Text = resultadoSuma.ToString();
                        Libreria.Temporal3 = resultadoSuma;
                        aux = Libreria.Temporal3;
                        break;
                }
            }
            c = 1;
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (primerpunto == false)
            {
                txtResultado.Text += ".";
                primerpunto = true;
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            Libreria.Temporal1 = Convert.ToDouble(txtResultado.Text);
            txtResultado.Text = string.Empty;
            primerpunto = false;
            Libreria.UltimaOperacion = CalculadoraLib.Operacion.Division;
        }

        private void btnmult_Click(object sender, EventArgs e)
        {
            Libreria.Temporal1 = Convert.ToDouble(txtResultado.Text);
            txtResultado.Text = string.Empty;
            primerpunto = false;
            Libreria.UltimaOperacion = CalculadoraLib.Operacion.Multiplicacion;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtResultado.Text = string.Empty;
            Libreria = new LibreriaCalculadora.CalculadoraLib.Aritmetica();
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            switch (Libreria.UltimaOperacion)
            {
                case CalculadoraLib.Operacion.Suma:
                    Libreria.Temporal2 = Convert.ToDouble(txtResultado.Text);
                    var resultadosuma = Libreria.Sumar(Libreria.Temporal1, Libreria.Temporal2);

                    txtResultado.Text = resultadosuma.ToString();
                    Libreria.Temporal3 = resultadosuma;
                    break;

                case CalculadoraLib.Operacion.Resta:
                    Libreria.Temporal2 = Convert.ToDouble(txtResultado.Text);
                    var resultadoResta = Libreria.Resta(Libreria.Temporal1, Libreria.Temporal2);
                    txtResultado.Text = resultadoResta.ToString();

                    break;

                case CalculadoraLib.Operacion.Multiplicacion:
                    Libreria.Temporal2 = Convert.ToDouble(txtResultado.Text);
                    var resultadoMulti = Libreria.Multiplicacion(Libreria.Temporal1, Libreria.Temporal2);

                    txtResultado.Text = resultadoMulti.ToString();

                    break;

                case CalculadoraLib.Operacion.Division:
                    Libreria.Temporal2 = Convert.ToDouble(txtResultado.Text);
                    var resultadoDiv = Libreria.Division(Libreria.Temporal1, Libreria.Temporal2);
                    txtResultado.Text = resultadoDiv.ToString();

                    break;

                default: break;
            }
        }
    }
}
