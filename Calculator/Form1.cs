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
        private bool clearDisplay;
        //private ref string strOperand;
        protected delegate double Operatia();
        Operatia operatia;

        public FormCalculator()
        {
            InitializeComponent();
            //labelOperand1.Text = "";
            //strOperand1 = "";
            //strOperand2 = "";
            //operatia = NoOp;
            //clearDisplay = true;
            ClearAll();
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

        protected double NoOp()
        {
            return Double.NaN;
        }

        private void buttonBkSp_Click(object sender, EventArgs e)
        {
            strOperand2 = textBoxAfisaj.Text;
            strOperand2 = strOperand2.Remove(strOperand2.Length - 1,1);
            textBoxAfisaj.Text = strOperand2;
        }

        private void ClearAll()
        {
            //labelOperand1.Text = "";
            //textBoxAfisaj.Text = "";
            //strOperand1 = "";
            //strOperand2 = "";
            //operatia = NoOp;
            //clearDisplay = true;
            operand1 = operand2 = 0;
            ClearAfisaj();
            ClearOperand1();
            clearDisplay = true;
            operatia = NoOp;
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            //operand1 = operand2 = 0;
            //ClearAfisaj();
            //ClearOperand1();
            //clearDisplay = false;
            ClearAll();
        }
        private void ClearAfisaj()
        {
            strOperand2 = "";
            textBoxAfisaj.Text = "";
        }
        private void ClearOperand1()
        {
            labelOperand1.Text = "";
            strOperand1 = "";
        }
        private void buttonMult_Click(object sender, EventArgs e)
        {
            Opereaza((Button)sender);
            //operatia = Multiply;
            SetOperatia((Button)sender);
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            Opereaza((Button)sender);
            //operatia = Divide;
            SetOperatia((Button)sender);
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            Opereaza((Button)sender);
            //operatia = Substract;
            SetOperatia((Button)sender);
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            Opereaza((Button)sender);
            //operatia = Add;
            //ArataOperatia((Button)sender);
            SetOperatia((Button)sender);
        }

        private void buttonOperator_Click(object sender, EventArgs e)
        {
            Opereaza((Button)sender);
            SetOperatia((Button)sender);
        }

        private void SetOperatia(Button sender)
        {
            if (sender.Text == "+") operatia = Add;
            if (sender.Text == "-") operatia = Substract;
            if (sender.Text == "*") operatia = Multiply;
            if (sender.Text == "/") operatia = Divide;

            ArataOperatia();
        }

        private void Opereaza(Button sender)
        {

            strOperand2 = textBoxAfisaj.Text;
            if (strOperand2 == "")
            {
                return;
            }

            if (strOperand1 == "")
            {
                TranfserDisplayToOperand1();
                ClearAfisaj();
            }
            else
            {
                CalculeazaAfiseaza();
                ClearOperand1();
                clearDisplay = true;
            }
        }

        private void ArataOperatia(Button sender)
        {
            if (labelOperand1.Text != "")
                labelOperand1.Text = strOperand1 + sender.Text;
        }

        private void ArataOperatia()
        {
            if (strOperand1 == "") return;
            if (operatia == Multiply) labelOperand1.Text = strOperand1 + "*";
            if (operatia == Divide) labelOperand1.Text = strOperand1 + "/";
            if (operatia == Add) labelOperand1.Text = strOperand1 + "+";
            if (operatia == Substract) labelOperand1.Text = strOperand1 + "-";
        }

        private bool BothOperands()
        {
            if (strOperand1 != "" && strOperand2 != "") return true;
            return false;
        }
        private double Calculeaza()
        {
            operand1 = double.Parse(strOperand1);
            operand2 = double.Parse(strOperand2);
            return operatia();
        }

        private void CalculeazaAfiseaza()
        {
            double rezultat = Calculeaza();
            textBoxAfisaj.Text = rezultat.ToString();
            strOperand2 = rezultat.ToString();
        }

        private void buttonEgal_Click(object sender, EventArgs e)
        {
            if (BothOperands()) { 
                CalculeazaAfiseaza();
                ClearOperand1();
                operatia = NoOp;
                clearDisplay = true;
            }
        }
        private void TranfserDisplayToOperand1()
        {
            strOperand1 = textBoxAfisaj.Text;
            labelOperand1.Text = strOperand1;
        }
        private void buttonCifra_Click(object sender, EventArgs e)
        {
            string strTasta = ((Button)sender).Text;
            if (clearDisplay && operatia != NoOp)
            {
                TranfserDisplayToOperand1();
                ArataOperatia();
                ClearAfisaj();
                clearDisplay = false;
            }
            if (clearDisplay && operatia == NoOp)
            {
                ClearAfisaj();
                ClearOperand1();
                clearDisplay = false;
            }
            if (strTasta.Equals(".")) {
                if (strOperand2.Contains("."))
                {
                    clearDisplay = false;
                    return;
                }
            }
            strOperand2 += strTasta;
            textBoxAfisaj.Text = strOperand2;
            //ref string strOp2;    //referinta trebuie initializata odata cu declararea ei
            clearDisplay = false;
        }
    }
}
