
namespace oraiMunka
{
    partial class Form1
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
            this.numberListBox = new System.Windows.Forms.ListBox();
            this.executeButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startNumber = new System.Windows.Forms.TextBox();
            this.finishNumber = new System.Windows.Forms.TextBox();
            this.intervalNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.operationListBox = new System.Windows.Forms.ListBox();
            this.operationGroupBox = new System.Windows.Forms.GroupBox();
            this.evenRadioButton = new System.Windows.Forms.RadioButton();
            this.oddRadioButton = new System.Windows.Forms.RadioButton();
            this.divisibleByTreeRadioButton = new System.Windows.Forms.RadioButton();
            this.divisibleByFiveRadioButton = new System.Windows.Forms.RadioButton();
            this.divisibleBySevenRadioButton = new System.Windows.Forms.RadioButton();
            this.numSelectComboBox = new System.Windows.Forms.ComboBox();
            this.chooseCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.operationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // numberListBox
            // 
            this.numberListBox.FormattingEnabled = true;
            this.numberListBox.ItemHeight = 16;
            this.numberListBox.Location = new System.Drawing.Point(13, 79);
            this.numberListBox.Name = "numberListBox";
            this.numberListBox.Size = new System.Drawing.Size(176, 356);
            this.numberListBox.TabIndex = 0;
            // 
            // executeButton
            // 
            this.executeButton.BackColor = System.Drawing.Color.OrangeRed;
            this.executeButton.Location = new System.Drawing.Point(195, 12);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(94, 61);
            this.executeButton.TabIndex = 1;
            this.executeButton.Text = "Execute";
            this.executeButton.UseVisualStyleBackColor = false;
            this.executeButton.Click += new System.EventHandler(this.executeButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.intervalNumber);
            this.groupBox1.Controls.Add(this.finishNumber);
            this.groupBox1.Controls.Add(this.startNumber);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 66);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(5, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Start";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(55, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Finish";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startNumber
            // 
            this.startNumber.Location = new System.Drawing.Point(6, 32);
            this.startNumber.Name = "startNumber";
            this.startNumber.Size = new System.Drawing.Size(37, 22);
            this.startNumber.TabIndex = 3;
            this.startNumber.TextChanged += new System.EventHandler(this.startNumber_TextChanged);
            // 
            // finishNumber
            // 
            this.finishNumber.Location = new System.Drawing.Point(58, 32);
            this.finishNumber.Name = "finishNumber";
            this.finishNumber.Size = new System.Drawing.Size(37, 22);
            this.finishNumber.TabIndex = 4;
            this.finishNumber.TextChanged += new System.EventHandler(this.finishNumber_TextChanged);
            // 
            // intervalNumber
            // 
            this.intervalNumber.Location = new System.Drawing.Point(118, 32);
            this.intervalNumber.Name = "intervalNumber";
            this.intervalNumber.Size = new System.Drawing.Size(52, 22);
            this.intervalNumber.TabIndex = 5;
            this.intervalNumber.TextChanged += new System.EventHandler(this.intervalNumber_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(116, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Interval";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // operationListBox
            // 
            this.operationListBox.FormattingEnabled = true;
            this.operationListBox.ItemHeight = 16;
            this.operationListBox.Location = new System.Drawing.Point(425, 79);
            this.operationListBox.Name = "operationListBox";
            this.operationListBox.Size = new System.Drawing.Size(176, 356);
            this.operationListBox.TabIndex = 3;
            // 
            // operationGroupBox
            // 
            this.operationGroupBox.BackColor = System.Drawing.Color.White;
            this.operationGroupBox.Controls.Add(this.divisibleBySevenRadioButton);
            this.operationGroupBox.Controls.Add(this.divisibleByFiveRadioButton);
            this.operationGroupBox.Controls.Add(this.divisibleByTreeRadioButton);
            this.operationGroupBox.Controls.Add(this.oddRadioButton);
            this.operationGroupBox.Controls.Add(this.evenRadioButton);
            this.operationGroupBox.Location = new System.Drawing.Point(209, 129);
            this.operationGroupBox.Name = "operationGroupBox";
            this.operationGroupBox.Size = new System.Drawing.Size(200, 161);
            this.operationGroupBox.TabIndex = 4;
            this.operationGroupBox.TabStop = false;
            this.operationGroupBox.Text = "Operation";
            // 
            // evenRadioButton
            // 
            this.evenRadioButton.AutoSize = true;
            this.evenRadioButton.Location = new System.Drawing.Point(7, 22);
            this.evenRadioButton.Name = "evenRadioButton";
            this.evenRadioButton.Size = new System.Drawing.Size(120, 21);
            this.evenRadioButton.TabIndex = 0;
            this.evenRadioButton.TabStop = true;
            this.evenRadioButton.Text = "Even numbers";
            this.evenRadioButton.UseVisualStyleBackColor = true;
            this.evenRadioButton.CheckedChanged += new System.EventHandler(this.evenRadioButton_CheckedChanged);
            // 
            // oddRadioButton
            // 
            this.oddRadioButton.AutoSize = true;
            this.oddRadioButton.Location = new System.Drawing.Point(7, 50);
            this.oddRadioButton.Name = "oddRadioButton";
            this.oddRadioButton.Size = new System.Drawing.Size(115, 21);
            this.oddRadioButton.TabIndex = 1;
            this.oddRadioButton.TabStop = true;
            this.oddRadioButton.Text = "Odd numbers";
            this.oddRadioButton.UseVisualStyleBackColor = true;
            this.oddRadioButton.CheckedChanged += new System.EventHandler(this.oddRadioButton_CheckedChanged);
            // 
            // divisibleByTreeRadioButton
            // 
            this.divisibleByTreeRadioButton.AutoSize = true;
            this.divisibleByTreeRadioButton.Location = new System.Drawing.Point(7, 78);
            this.divisibleByTreeRadioButton.Name = "divisibleByTreeRadioButton";
            this.divisibleByTreeRadioButton.Size = new System.Drawing.Size(112, 21);
            this.divisibleByTreeRadioButton.TabIndex = 2;
            this.divisibleByTreeRadioButton.TabStop = true;
            this.divisibleByTreeRadioButton.Text = "Divisible by 3";
            this.divisibleByTreeRadioButton.UseVisualStyleBackColor = true;
            this.divisibleByTreeRadioButton.CheckedChanged += new System.EventHandler(this.divisibleByTreeRadioButton_CheckedChanged);
            // 
            // divisibleByFiveRadioButton
            // 
            this.divisibleByFiveRadioButton.AutoSize = true;
            this.divisibleByFiveRadioButton.Location = new System.Drawing.Point(7, 106);
            this.divisibleByFiveRadioButton.Name = "divisibleByFiveRadioButton";
            this.divisibleByFiveRadioButton.Size = new System.Drawing.Size(112, 21);
            this.divisibleByFiveRadioButton.TabIndex = 3;
            this.divisibleByFiveRadioButton.TabStop = true;
            this.divisibleByFiveRadioButton.Text = "Divisible by 5";
            this.divisibleByFiveRadioButton.UseVisualStyleBackColor = true;
            this.divisibleByFiveRadioButton.CheckedChanged += new System.EventHandler(this.divisibleByFiveRadioButton_CheckedChanged);
            // 
            // divisibleBySevenRadioButton
            // 
            this.divisibleBySevenRadioButton.AutoSize = true;
            this.divisibleBySevenRadioButton.Location = new System.Drawing.Point(7, 134);
            this.divisibleBySevenRadioButton.Name = "divisibleBySevenRadioButton";
            this.divisibleBySevenRadioButton.Size = new System.Drawing.Size(112, 21);
            this.divisibleBySevenRadioButton.TabIndex = 4;
            this.divisibleBySevenRadioButton.TabStop = true;
            this.divisibleBySevenRadioButton.Text = "Divisible by 7";
            this.divisibleBySevenRadioButton.UseVisualStyleBackColor = true;
            this.divisibleBySevenRadioButton.CheckedChanged += new System.EventHandler(this.divisibleBySevenRadioButton_CheckedChanged);
            // 
            // numSelectComboBox
            // 
            this.numSelectComboBox.Enabled = false;
            this.numSelectComboBox.FormattingEnabled = true;
            this.numSelectComboBox.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.numSelectComboBox.Location = new System.Drawing.Point(427, 31);
            this.numSelectComboBox.Name = "numSelectComboBox";
            this.numSelectComboBox.Size = new System.Drawing.Size(176, 24);
            this.numSelectComboBox.TabIndex = 5;
            this.numSelectComboBox.SelectedIndexChanged += new System.EventHandler(this.numSelectComboBox_SelectedIndexChanged);
            // 
            // chooseCheckBox
            // 
            this.chooseCheckBox.AutoSize = true;
            this.chooseCheckBox.Location = new System.Drawing.Point(427, 4);
            this.chooseCheckBox.Name = "chooseCheckBox";
            this.chooseCheckBox.Size = new System.Drawing.Size(155, 21);
            this.chooseCheckBox.TabIndex = 6;
            this.chooseCheckBox.Text = "Choose from the list";
            this.chooseCheckBox.UseVisualStyleBackColor = true;
            this.chooseCheckBox.CheckedChanged += new System.EventHandler(this.chooseCheckBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(615, 450);
            this.Controls.Add(this.chooseCheckBox);
            this.Controls.Add(this.numSelectComboBox);
            this.Controls.Add(this.operationGroupBox);
            this.Controls.Add(this.operationListBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.executeButton);
            this.Controls.Add(this.numberListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Operation selector";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.operationGroupBox.ResumeLayout(false);
            this.operationGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox numberListBox;
        private System.Windows.Forms.Button executeButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox intervalNumber;
        private System.Windows.Forms.TextBox finishNumber;
        private System.Windows.Forms.TextBox startNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox operationListBox;
        private System.Windows.Forms.GroupBox operationGroupBox;
        private System.Windows.Forms.RadioButton divisibleBySevenRadioButton;
        private System.Windows.Forms.RadioButton divisibleByFiveRadioButton;
        private System.Windows.Forms.RadioButton divisibleByTreeRadioButton;
        private System.Windows.Forms.RadioButton oddRadioButton;
        private System.Windows.Forms.RadioButton evenRadioButton;
        private System.Windows.Forms.ComboBox numSelectComboBox;
        private System.Windows.Forms.CheckBox chooseCheckBox;
    }
}

