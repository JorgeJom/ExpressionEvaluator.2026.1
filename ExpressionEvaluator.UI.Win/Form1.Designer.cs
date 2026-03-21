namespace ExpressionEvaluator.UI.Win
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtDisplay = new TextBox();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btnSpot = new Button();
            btn0 = new Button();
            btnMinus = new Button();
            btnPlus = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            btnOpenParenthesis = new Button();
            btnCloseParenthesis = new Button();
            btnDelete = new Button();
            btnPow = new Button();
            btnResult = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDisplay.BackColor = SystemColors.WindowFrame;
            txtDisplay.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDisplay.ForeColor = Color.Transparent;
            txtDisplay.Location = new Point(24, 21);
            txtDisplay.Multiline = true;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(362, 94);
            txtDisplay.TabIndex = 0;
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // btn7
            // 
            btn7.BackColor = SystemColors.WindowFrame;
            btn7.FlatStyle = FlatStyle.Flat;
            btn7.Font = new Font("Yu Gothic UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn7.ForeColor = SystemColors.ButtonFace;
            btn7.Location = new Point(24, 223);
            btn7.Name = "btn7";
            btn7.Size = new Size(68, 74);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.TextAlign = ContentAlignment.TopRight;
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += button1_Click;
            // 
            // btn8
            // 
            btn8.BackColor = SystemColors.WindowFrame;
            btn8.FlatStyle = FlatStyle.Flat;
            btn8.Font = new Font("Yu Gothic UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn8.ForeColor = SystemColors.ButtonFace;
            btn8.Location = new Point(98, 223);
            btn8.Name = "btn8";
            btn8.Size = new Size(68, 74);
            btn8.TabIndex = 2;
            btn8.Text = "8";
            btn8.TextAlign = ContentAlignment.TopRight;
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.BackColor = SystemColors.WindowFrame;
            btn9.FlatStyle = FlatStyle.Flat;
            btn9.Font = new Font("Yu Gothic UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn9.ForeColor = SystemColors.ButtonFace;
            btn9.Location = new Point(172, 223);
            btn9.Name = "btn9";
            btn9.Size = new Size(68, 74);
            btn9.TabIndex = 3;
            btn9.Text = "9";
            btn9.TextAlign = ContentAlignment.TopRight;
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // btn6
            // 
            btn6.BackColor = SystemColors.WindowFrame;
            btn6.FlatStyle = FlatStyle.Flat;
            btn6.Font = new Font("Yu Gothic UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn6.ForeColor = SystemColors.ButtonFace;
            btn6.Location = new Point(172, 303);
            btn6.Name = "btn6";
            btn6.Size = new Size(68, 74);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.TextAlign = ContentAlignment.TopRight;
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.BackColor = SystemColors.WindowFrame;
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.Font = new Font("Yu Gothic UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn5.ForeColor = SystemColors.ButtonFace;
            btn5.Location = new Point(98, 303);
            btn5.Name = "btn5";
            btn5.Size = new Size(68, 74);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.TextAlign = ContentAlignment.TopRight;
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.BackColor = SystemColors.WindowFrame;
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.Font = new Font("Yu Gothic UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn4.ForeColor = SystemColors.ButtonFace;
            btn4.Location = new Point(24, 303);
            btn4.Name = "btn4";
            btn4.Size = new Size(68, 74);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.TextAlign = ContentAlignment.TopRight;
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btn3
            // 
            btn3.BackColor = SystemColors.WindowFrame;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Font = new Font("Yu Gothic UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn3.ForeColor = SystemColors.ButtonFace;
            btn3.Location = new Point(172, 383);
            btn3.Name = "btn3";
            btn3.Size = new Size(68, 74);
            btn3.TabIndex = 9;
            btn3.Text = "3";
            btn3.TextAlign = ContentAlignment.TopRight;
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.BackColor = SystemColors.WindowFrame;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("Yu Gothic UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn2.ForeColor = SystemColors.ButtonFace;
            btn2.Location = new Point(98, 383);
            btn2.Name = "btn2";
            btn2.Size = new Size(68, 74);
            btn2.TabIndex = 8;
            btn2.Text = "2";
            btn2.TextAlign = ContentAlignment.TopRight;
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            btn1.BackColor = SystemColors.WindowFrame;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Yu Gothic UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.ForeColor = SystemColors.ButtonFace;
            btn1.Location = new Point(24, 383);
            btn1.Name = "btn1";
            btn1.Size = new Size(68, 74);
            btn1.TabIndex = 7;
            btn1.Text = "1";
            btn1.TextAlign = ContentAlignment.TopRight;
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // btnSpot
            // 
            btnSpot.BackColor = SystemColors.WindowFrame;
            btnSpot.FlatStyle = FlatStyle.Flat;
            btnSpot.Font = new Font("Yu Gothic UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSpot.ForeColor = SystemColors.ButtonFace;
            btnSpot.Location = new Point(172, 463);
            btnSpot.Name = "btnSpot";
            btnSpot.Size = new Size(68, 74);
            btnSpot.TabIndex = 12;
            btnSpot.Text = ".";
            btnSpot.UseVisualStyleBackColor = false;
            btnSpot.Click += btnSpot_Click;
            // 
            // btn0
            // 
            btn0.BackColor = SystemColors.WindowFrame;
            btn0.FlatStyle = FlatStyle.Flat;
            btn0.Font = new Font("Yu Gothic UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn0.ForeColor = SystemColors.ButtonFace;
            btn0.Location = new Point(24, 463);
            btn0.Name = "btn0";
            btn0.Size = new Size(142, 74);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.TextAlign = ContentAlignment.TopRight;
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btn0_Click;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = Color.FromArgb(255, 128, 0);
            btnMinus.FlatStyle = FlatStyle.Flat;
            btnMinus.Font = new Font("Impact", 20.25F);
            btnMinus.ForeColor = Color.White;
            btnMinus.Location = new Point(317, 382);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(68, 74);
            btnMinus.TabIndex = 16;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = Color.FromArgb(255, 128, 0);
            btnPlus.FlatStyle = FlatStyle.Flat;
            btnPlus.Font = new Font("Impact", 20.25F);
            btnPlus.ForeColor = Color.White;
            btnPlus.Location = new Point(246, 383);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(68, 74);
            btnPlus.TabIndex = 15;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = Color.FromArgb(255, 128, 0);
            btnMultiply.FlatStyle = FlatStyle.Flat;
            btnMultiply.Font = new Font("Impact", 20.25F);
            btnMultiply.ForeColor = Color.White;
            btnMultiply.Location = new Point(317, 303);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(68, 74);
            btnMultiply.TabIndex = 14;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = Color.FromArgb(255, 128, 0);
            btnDivide.FlatStyle = FlatStyle.Flat;
            btnDivide.Font = new Font("Impact", 20.25F);
            btnDivide.ForeColor = Color.White;
            btnDivide.Location = new Point(246, 303);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(68, 74);
            btnDivide.TabIndex = 13;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnOpenParenthesis
            // 
            btnOpenParenthesis.BackColor = SystemColors.AppWorkspace;
            btnOpenParenthesis.FlatStyle = FlatStyle.Flat;
            btnOpenParenthesis.Font = new Font("Javanese Text", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOpenParenthesis.ForeColor = Color.White;
            btnOpenParenthesis.Location = new Point(24, 143);
            btnOpenParenthesis.Name = "btnOpenParenthesis";
            btnOpenParenthesis.Size = new Size(68, 74);
            btnOpenParenthesis.TabIndex = 17;
            btnOpenParenthesis.Text = "(";
            btnOpenParenthesis.UseVisualStyleBackColor = false;
            btnOpenParenthesis.Click += btnOpenParenthesis_Click;
            // 
            // btnCloseParenthesis
            // 
            btnCloseParenthesis.BackColor = SystemColors.AppWorkspace;
            btnCloseParenthesis.FlatStyle = FlatStyle.Flat;
            btnCloseParenthesis.Font = new Font("Javanese Text", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCloseParenthesis.ForeColor = Color.White;
            btnCloseParenthesis.Location = new Point(98, 144);
            btnCloseParenthesis.Name = "btnCloseParenthesis";
            btnCloseParenthesis.Size = new Size(68, 74);
            btnCloseParenthesis.TabIndex = 18;
            btnCloseParenthesis.Text = ")";
            btnCloseParenthesis.UseVisualStyleBackColor = false;
            btnCloseParenthesis.Click += btnCloseParenthesis_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(192, 0, 0);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Impact", 20.25F);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(246, 224);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(139, 74);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnPow
            // 
            btnPow.BackColor = SystemColors.AppWorkspace;
            btnPow.FlatStyle = FlatStyle.Flat;
            btnPow.Font = new Font("Impact", 20.25F);
            btnPow.ForeColor = Color.White;
            btnPow.Location = new Point(172, 144);
            btnPow.Name = "btnPow";
            btnPow.Size = new Size(68, 74);
            btnPow.TabIndex = 19;
            btnPow.Text = "^";
            btnPow.UseVisualStyleBackColor = false;
            btnPow.Click += btnPow_Click;
            // 
            // btnResult
            // 
            btnResult.BackColor = Color.FromArgb(255, 128, 0);
            btnResult.FlatStyle = FlatStyle.Flat;
            btnResult.Font = new Font("Impact", 20.25F);
            btnResult.ForeColor = Color.White;
            btnResult.Location = new Point(246, 462);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(139, 74);
            btnResult.TabIndex = 21;
            btnResult.Text = "=";
            btnResult.UseVisualStyleBackColor = false;
            btnResult.Click += btnResult_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(192, 0, 0);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Impact", 20.25F);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(246, 144);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(139, 74);
            btnClear.TabIndex = 22;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowText;
            ClientSize = new Size(400, 581);
            Controls.Add(btnClear);
            Controls.Add(btnResult);
            Controls.Add(btnDelete);
            Controls.Add(btnPow);
            Controls.Add(btnCloseParenthesis);
            Controls.Add(btnOpenParenthesis);
            Controls.Add(btnMinus);
            Controls.Add(btnPlus);
            Controls.Add(btnMultiply);
            Controls.Add(btnDivide);
            Controls.Add(btnSpot);
            Controls.Add(btn0);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(txtDisplay);
            Name = "Form1";
            Text = " Functions Evaluator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btnSpot;
        private Button btn0;
        private Button btnMinus;
        private Button btnPlus;
        private Button btnMultiply;
        private Button btnDivide;
        private Button btnOpenParenthesis;
        private Button btnCloseParenthesis;
        private Button btnDelete;
        private Button btnPow;
        private Button btnResult;
        private Button btnClear;
    }
}
