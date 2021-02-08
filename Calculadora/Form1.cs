using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Os parametros abaixo será utilizaos em todo o contexto da nossa classe
        /// </summary>
        private double Numero1 { get; set; }
        private double Numero2 { get; set; }
        private string Operacao { get; set; }
        bool segundo = false;
        bool igual = false;
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Cada metódo será responsável por adicionar mais um valor no display
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "1";
            PreencheNumeros();
        }
        /// <summary>
        /// Metodo preenche numeros irá preencher os valores declarados a cima
        /// </summary>
        private void PreencheNumeros()
        {
            if(igual)
            {
                txtDisplay.Text = txtDisplay.Text.Substring(txtDisplay.Text.Length - 1);
                igual = false;
            }
            if (!segundo)
            {
                Numero1 = Convert.ToDouble(txtDisplay.Text);                
            }
            else 
            {
                Numero2 = Convert.ToDouble(txtDisplay.Text);                
            }
        }
        /// <summary>
        /// Quando Clicar no igual chama o metodo calcular resultado
        /// </summary>
        private void CalculaResultado()
        {
            switch (Operacao)
            {
                case "+":
                    txtDisplay.Text = (Numero1 + Numero2).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (Numero1 - Numero2).ToString();
                    break;
                case "*":
                    txtDisplay.Text = (Numero1 * Numero2).ToString();
                    break;
                case "/":
                    txtDisplay.Text = (Numero1 / Numero2).ToString();
                    break;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "2";
            PreencheNumeros();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "3";
            PreencheNumeros();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "4";
            PreencheNumeros();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "5";
            PreencheNumeros();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "6";
            PreencheNumeros();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "7";
            PreencheNumeros();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "8";
            PreencheNumeros();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "9";
            PreencheNumeros();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "0";
            PreencheNumeros();
        }
        /// <summary>
        /// Quando clicar nas operações salveremos a operação em memoria
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSoma_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Operacao))
            {
                Operacao = "+";
            }
            PreencheNumeros();
            segundo = true;
            txtDisplay.Text = "";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            Operacao = "-";
            this.btnSoma_Click(sender, e);
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            Operacao = "/";
            this.btnSoma_Click(sender, e);
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            Operacao = "*";
            this.btnSoma_Click(sender, e);
        }
        /// <summary>
        /// Quando clica no igual chamaos a funação calcula resultado e alteramos o nosso display
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIgual_Click(object sender, EventArgs e)
        {
            CalculaResultado();
            segundo = false;
            igual = true;
        }
    }
}
