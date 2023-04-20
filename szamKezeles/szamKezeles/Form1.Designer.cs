
namespace szamKezeles
{
    partial class NumberFinder
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
            this.numberList1 = new System.Windows.Forms.ListBox();
            this.numGenerateButton = new System.Windows.Forms.Button();
            this.methodGroupBox = new System.Windows.Forms.GroupBox();
            this.squareCheck = new System.Windows.Forms.CheckBox();
            this.divisibleBy9NumberCheck = new System.Windows.Forms.CheckBox();
            this.divisibleBy6NumberCheck = new System.Windows.Forms.CheckBox();
            this.divisibleBy3NumberCheck = new System.Windows.Forms.CheckBox();
            this.oddNumbersCheck = new System.Windows.Forms.CheckBox();
            this.evenNumberCheck = new System.Windows.Forms.CheckBox();
            this.primeCheck = new System.Windows.Forms.CheckBox();
            this.numberList2 = new System.Windows.Forms.ListBox();
            this.showNumbers = new System.Windows.Forms.Label();
            this.countButton = new System.Windows.Forms.Button();
            this.methodGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // numberList1
            // 
            this.numberList1.FormattingEnabled = true;
            this.numberList1.ItemHeight = 16;
            this.numberList1.Location = new System.Drawing.Point(12, 41);
            this.numberList1.Name = "numberList1";
            this.numberList1.Size = new System.Drawing.Size(215, 532);
            this.numberList1.TabIndex = 0;
            // 
            // numGenerateButton
            // 
            this.numGenerateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numGenerateButton.Location = new System.Drawing.Point(12, 3);
            this.numGenerateButton.Name = "numGenerateButton";
            this.numGenerateButton.Size = new System.Drawing.Size(215, 33);
            this.numGenerateButton.TabIndex = 1;
            this.numGenerateButton.Text = "Generate";
            this.numGenerateButton.UseVisualStyleBackColor = true;
            this.numGenerateButton.Click += new System.EventHandler(this.numGenerateButton_Click);
            // 
            // methodGroupBox
            // 
            this.methodGroupBox.BackColor = System.Drawing.Color.White;
            this.methodGroupBox.Controls.Add(this.squareCheck);
            this.methodGroupBox.Controls.Add(this.divisibleBy9NumberCheck);
            this.methodGroupBox.Controls.Add(this.divisibleBy6NumberCheck);
            this.methodGroupBox.Controls.Add(this.divisibleBy3NumberCheck);
            this.methodGroupBox.Controls.Add(this.oddNumbersCheck);
            this.methodGroupBox.Controls.Add(this.evenNumberCheck);
            this.methodGroupBox.Controls.Add(this.primeCheck);
            this.methodGroupBox.Location = new System.Drawing.Point(271, 171);
            this.methodGroupBox.Name = "methodGroupBox";
            this.methodGroupBox.Size = new System.Drawing.Size(189, 225);
            this.methodGroupBox.TabIndex = 2;
            this.methodGroupBox.TabStop = false;
            this.methodGroupBox.Text = "Operation";
            // 
            // squareCheck
            // 
            this.squareCheck.AutoSize = true;
            this.squareCheck.Location = new System.Drawing.Point(7, 190);
            this.squareCheck.Name = "squareCheck";
            this.squareCheck.Size = new System.Drawing.Size(135, 21);
            this.squareCheck.TabIndex = 6;
            this.squareCheck.Text = "Square numbers";
            this.squareCheck.UseVisualStyleBackColor = true;
            this.squareCheck.CheckedChanged += new System.EventHandler(this.squareCheck_CheckedChanged);
            // 
            // divisibleBy9NumberCheck
            // 
            this.divisibleBy9NumberCheck.AutoSize = true;
            this.divisibleBy9NumberCheck.Location = new System.Drawing.Point(7, 162);
            this.divisibleBy9NumberCheck.Name = "divisibleBy9NumberCheck";
            this.divisibleBy9NumberCheck.Size = new System.Drawing.Size(160, 21);
            this.divisibleBy9NumberCheck.TabIndex = 5;
            this.divisibleBy9NumberCheck.Text = "Can be divisible by 9";
            this.divisibleBy9NumberCheck.UseVisualStyleBackColor = true;
            this.divisibleBy9NumberCheck.CheckedChanged += new System.EventHandler(this.divisibleBy9NumberCheck_CheckedChanged);
            // 
            // divisibleBy6NumberCheck
            // 
            this.divisibleBy6NumberCheck.AutoSize = true;
            this.divisibleBy6NumberCheck.Location = new System.Drawing.Point(7, 134);
            this.divisibleBy6NumberCheck.Name = "divisibleBy6NumberCheck";
            this.divisibleBy6NumberCheck.Size = new System.Drawing.Size(157, 21);
            this.divisibleBy6NumberCheck.TabIndex = 4;
            this.divisibleBy6NumberCheck.Text = "Can be divisble by 6";
            this.divisibleBy6NumberCheck.UseVisualStyleBackColor = true;
            this.divisibleBy6NumberCheck.CheckedChanged += new System.EventHandler(this.divisibleBy6NumberCheck_CheckedChanged);
            // 
            // divisibleBy3NumberCheck
            // 
            this.divisibleBy3NumberCheck.AutoSize = true;
            this.divisibleBy3NumberCheck.Location = new System.Drawing.Point(7, 106);
            this.divisibleBy3NumberCheck.Name = "divisibleBy3NumberCheck";
            this.divisibleBy3NumberCheck.Size = new System.Drawing.Size(160, 21);
            this.divisibleBy3NumberCheck.TabIndex = 3;
            this.divisibleBy3NumberCheck.Text = "Can be divisible by 3";
            this.divisibleBy3NumberCheck.UseVisualStyleBackColor = true;
            this.divisibleBy3NumberCheck.CheckedChanged += new System.EventHandler(this.divisibleBy3NumberCheck_CheckedChanged);
            // 
            // oddNumbersCheck
            // 
            this.oddNumbersCheck.AutoSize = true;
            this.oddNumbersCheck.Location = new System.Drawing.Point(7, 78);
            this.oddNumbersCheck.Name = "oddNumbersCheck";
            this.oddNumbersCheck.Size = new System.Drawing.Size(116, 21);
            this.oddNumbersCheck.TabIndex = 2;
            this.oddNumbersCheck.Text = "Odd numbers";
            this.oddNumbersCheck.UseVisualStyleBackColor = true;
            this.oddNumbersCheck.CheckedChanged += new System.EventHandler(this.oddNumbersCheck_CheckedChanged);
            // 
            // evenNumberCheck
            // 
            this.evenNumberCheck.AutoSize = true;
            this.evenNumberCheck.Location = new System.Drawing.Point(7, 50);
            this.evenNumberCheck.Name = "evenNumberCheck";
            this.evenNumberCheck.Size = new System.Drawing.Size(121, 21);
            this.evenNumberCheck.TabIndex = 1;
            this.evenNumberCheck.Text = "Even numbers";
            this.evenNumberCheck.UseVisualStyleBackColor = true;
            this.evenNumberCheck.CheckedChanged += new System.EventHandler(this.evenNumberCheck_CheckedChanged);
            // 
            // primeCheck
            // 
            this.primeCheck.AutoSize = true;
            this.primeCheck.Location = new System.Drawing.Point(7, 22);
            this.primeCheck.Name = "primeCheck";
            this.primeCheck.Size = new System.Drawing.Size(66, 21);
            this.primeCheck.TabIndex = 0;
            this.primeCheck.Text = "Prime";
            this.primeCheck.UseVisualStyleBackColor = true;
            this.primeCheck.CheckedChanged += new System.EventHandler(this.primeCheck_CheckedChanged);
            // 
            // numberList2
            // 
            this.numberList2.FormattingEnabled = true;
            this.numberList2.ItemHeight = 16;
            this.numberList2.Location = new System.Drawing.Point(503, 41);
            this.numberList2.Name = "numberList2";
            this.numberList2.Size = new System.Drawing.Size(215, 532);
            this.numberList2.TabIndex = 3;
            this.numberList2.SelectedIndexChanged += new System.EventHandler(this.numberList2_SelectedIndexChanged);
            // 
            // showNumbers
            // 
            this.showNumbers.AutoSize = true;
            this.showNumbers.Location = new System.Drawing.Point(344, 463);
            this.showNumbers.Name = "showNumbers";
            this.showNumbers.Size = new System.Drawing.Size(0, 17);
            this.showNumbers.TabIndex = 4;
            // 
            // countButton
            // 
            this.countButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countButton.Location = new System.Drawing.Point(306, 416);
            this.countButton.Name = "countButton";
            this.countButton.Size = new System.Drawing.Size(116, 33);
            this.countButton.TabIndex = 5;
            this.countButton.Text = "Count";
            this.countButton.UseVisualStyleBackColor = true;
            this.countButton.Click += new System.EventHandler(this.countButton_Click);
            // 
            // NumberFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(732, 584);
            this.Controls.Add(this.countButton);
            this.Controls.Add(this.showNumbers);
            this.Controls.Add(this.numberList2);
            this.Controls.Add(this.methodGroupBox);
            this.Controls.Add(this.numGenerateButton);
            this.Controls.Add(this.numberList1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NumberFinder";
            this.Text = "Number Finder";
            this.methodGroupBox.ResumeLayout(false);
            this.methodGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox numberList1;
        private System.Windows.Forms.GroupBox methodGroupBox;
        private System.Windows.Forms.ListBox numberList2;
        private System.Windows.Forms.CheckBox squareCheck;
        private System.Windows.Forms.CheckBox divisibleBy9NumberCheck;
        private System.Windows.Forms.CheckBox divisibleBy6NumberCheck;
        private System.Windows.Forms.CheckBox divisibleBy3NumberCheck;
        private System.Windows.Forms.CheckBox oddNumbersCheck;
        private System.Windows.Forms.CheckBox evenNumberCheck;
        private System.Windows.Forms.CheckBox primeCheck;
        private System.Windows.Forms.Label showNumbers;
        public System.Windows.Forms.Button numGenerateButton;
        private System.Windows.Forms.Button countButton;
    }
}

