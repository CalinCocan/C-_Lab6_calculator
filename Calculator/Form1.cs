using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class FormCalculator : Form
    {
        private double operand1, operand2;
        private string strOperand1, strOperand2;
        //private ref string strOperand;
        //protected delegate double Operatia(double op1, double op2);
        protected delegate double Operatia();
        Operatia operatia;

        public FormCalculator()
        {
            InitializeComponent();
            labelOperand1.Text = "";
            strOperand1 = "";
            strOperand2 = "";
        }

        protected double Add()
        {
            return operand1 + operand2;
        }

        protected double Substract()
        {
            return operand1 - operand2;
        }

        protected double Multiply()
        {
            return operand1 * operand2;
        }

        protected double Divide()
        {
            return operand1 / operand2;
        }

        private void buttonBkSp_Click(object sender, EventArgs e)
        {

        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            labelOperand1.Text ="";
            textBoxAfisaj.Text = "";
            operand1 = operand2 = 0;
            strOperand1 = "";
            strOperand2 = "";
        }
        private void ClearAfisaj()
        {
            strOperand2 = "";
            textBoxAfisaj.Text = "";
        }
        private void buttonMult_Click(object sender, EventArgs e)
        {
            operatia = Multiply;
            strOperand1 = textBoxAfisaj.Text;
            labelOperand1.Text = textBoxAfisaj.Text + "*";
            ClearAfisaj();
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            operatia = Divide;
            strOperand1 = textBoxAfisaj.Text;
            labelOperand1.Text = textBoxAfisaj.Text + "/";
            ClearAfisaj();
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            operatia = Substract;
            strOperand1 = textBoxAfisaj.Text;
            labelOperand1.Text = textBoxAfisaj.Text + "-";
            ClearAfisaj();
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            operatia = Add;
            strOperand1 = textBoxAfisaj.Text;
            labelOperand1.Text = textBoxAfisaj.Text + "+";
            ClearAfisaj();
        }

        private double Calculeaza()
        {
            operand1 = double.Parse(strOperand1);
            operand2 = double.Parse(strOperand2);
            //double rezultat = operatia();
            //return rezultat;
            return operatia();
        }

        private void buttonEgal_Click(object sender, EventArgs e)
        {
            //operand1 = double.Parse(strOperand1);
            //operand2 = double.Parse(strOperand2);
            double rezultat = Calculeaza();
            textBoxAfisaj.Text = rezultat.ToString();
            //labelOperand1.Text = rezultat.ToString();
            labelOperand1.Text = "";
            //strOperand1 = strOperand2;
            strOperand1 = "";
            strOperand2 = "";
            //strOperand2 = rezultat.ToString();
        }

        private void buttonCifra_Click(object sender, EventArgs e)
        {
            //Button b = (Button)sender;
            //strOperand1 += b.Text;
            string strTasta = ((Button)sender).Text;
            if (strTasta.Equals(",")) { 
                if(strOperand2.Contains(",")) return;
            }
            strOperand2 += strTasta;
            textBoxAfisaj.Text = strOperand2;
            //ref string strOp2;    //referinta trebuie initializata odata cu declararea ei
        }
    }
}
