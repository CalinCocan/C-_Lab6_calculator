namespace Calculator
{
    partial class FormCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalculator));
            this.labelOperand1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonCE = new System.Windows.Forms.Button();
            this.buttonBkSp = new System.Windows.Forms.Button();
            this.buttonMult = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonEgal = new System.Windows.Forms.Button();
            this.textBoxAfisaj = new System.Windows.Forms.TextBox();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonDecimalP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelOperand1
            // 
            this.labelOperand1.AutoSize = true;
            this.labelOperand1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOperand1.Location = new System.Drawing.Point(28, 19);
            this.labelOperand1.MinimumSize = new System.Drawing.Size(115, 0);
            this.labelOperand1.Name = "labelOperand1";
            this.labelOperand1.Size = new System.Drawing.Size(115, 17);
            this.labelOperand1.TabIndex = 0;
            this.labelOperand1.Text = "Operand1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonCifra_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(54, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonCifra_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(84, 152);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(24, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonCifra_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(24, 194);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(24, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonCifra_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(54, 194);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(24, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.buttonCifra_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(84, 194);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(24, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.buttonCifra_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(24, 234);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(24, 23);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.buttonCifra_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(54, 234);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(24, 23);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.buttonCifra_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(84, 234);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(24, 23);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.buttonCifra_Click);
            // 
            // buttonCE
            // 
            this.buttonCE.Location = new System.Drawing.Point(24, 110);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(40, 23);
            this.buttonCE.TabIndex = 11;
            this.buttonCE.Text = "CE";
            this.buttonCE.UseVisualStyleBackColor = true;
            this.buttonCE.Click += new System.EventHandler(this.buttonCE_Click);
            // 
            // buttonBkSp
            // 
            this.buttonBkSp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBkSp.Location = new System.Drawing.Point(70, 110);
            this.buttonBkSp.Name = "buttonBkSp";
            this.buttonBkSp.Size = new System.Drawing.Size(38, 23);
            this.buttonBkSp.TabIndex = 12;
            this.buttonBkSp.Text = "←";
            this.buttonBkSp.UseMnemonic = false;
            this.buttonBkSp.UseVisualStyleBackColor = true;
            this.buttonBkSp.Click += new System.EventHandler(this.buttonBkSp_Click);
            // 
            // buttonMult
            // 
            this.buttonMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMult.Location = new System.Drawing.Point(135, 110);
            this.buttonMult.Name = "buttonMult";
            this.buttonMult.Size = new System.Drawing.Size(26, 29);
            this.buttonMult.TabIndex = 13;
            this.buttonMult.Text = "*";
            this.buttonMult.UseVisualStyleBackColor = true;
            this.buttonMult.Click += new System.EventHandler(this.buttonOperator_Click);
            // 
            // buttonDiv
            // 
            this.buttonDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDiv.Location = new System.Drawing.Point(135, 163);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(26, 29);
            this.buttonDiv.TabIndex = 14;
            this.buttonDiv.Text = "/";
            this.buttonDiv.UseVisualStyleBackColor = true;
            this.buttonDiv.Click += new System.EventHandler(this.buttonOperator_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinus.Location = new System.Drawing.Point(135, 213);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(26, 33);
            this.buttonMinus.TabIndex = 15;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonOperator_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlus.Location = new System.Drawing.Point(135, 265);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(26, 33);
            this.buttonPlus.TabIndex = 16;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonOperator_Click);
            // 
            // buttonEgal
            // 
            this.buttonEgal.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEgal.Location = new System.Drawing.Point(180, 213);
            this.buttonEgal.Name = "buttonEgal";
            this.buttonEgal.Size = new System.Drawing.Size(30, 85);
            this.buttonEgal.TabIndex = 17;
            this.buttonEgal.Text = "=";
            this.buttonEgal.UseVisualStyleBackColor = true;
            this.buttonEgal.Click += new System.EventHandler(this.buttonEgal_Click);
            // 
            // textBoxAfisaj
            // 
            this.textBoxAfisaj.Enabled = false;
            this.textBoxAfisaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAfisaj.ForeColor = System.Drawing.Color.Black;
            this.textBoxAfisaj.Location = new System.Drawing.Point(24, 48);
            this.textBoxAfisaj.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAfisaj.Name = "textBoxAfisaj";
            this.textBoxAfisaj.Size = new System.Drawing.Size(183, 30);
            this.textBoxAfisaj.TabIndex = 18;
            this.textBoxAfisaj.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(24, 275);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(54, 23);
            this.button0.TabIndex = 10;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.buttonCifra_Click);
            // 
            // buttonDecimalP
            // 
            this.buttonDecimalP.Location = new System.Drawing.Point(84, 275);
            this.buttonDecimalP.Name = "buttonDecimalP";
            this.buttonDecimalP.Size = new System.Drawing.Size(24, 23);
            this.buttonDecimalP.TabIndex = 19;
            this.buttonDecimalP.Text = ".";
            this.buttonDecimalP.UseVisualStyleBackColor = true;
            this.buttonDecimalP.Click += new System.EventHandler(this.buttonCifra_Click);
            // 
            // FormCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 317);
            this.Controls.Add(this.buttonDecimalP);
            this.Controls.Add(this.textBoxAfisaj);
            this.Controls.Add(this.buttonEgal);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonDiv);
            this.Controls.Add(this.buttonMult);
            this.Controls.Add(this.buttonBkSp);
            this.Controls.Add(this.buttonCE);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelOperand1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOperand1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonCE;
        private System.Windows.Forms.Button buttonBkSp;
        private System.Windows.Forms.Button buttonMult;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonEgal;
        private System.Windows.Forms.TextBox textBoxAfisaj;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonDecimalP;
        private System.Windows.Forms.Button button1;
    }
}

