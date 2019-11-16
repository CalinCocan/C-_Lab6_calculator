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
        int operand1, operand2;
        protected delegate int operatia(int op1, int op2);

        public FormCalculator()
        {
            InitializeComponent();
        }

        protected int Add()
        {
            return operand1 + operand2;
        }

        protected int Substract()
        {
            return operand1 - operand2;
        }

        protected int Multiply()
        {
            return operand1 * operand2;
        }

        protected int Divide()
        {
            return operand1 / operand2;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {

        }
    }
}
