using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oraiMunka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int start;
        int finish;
        int interval;
        private void startNumber_TextChanged(object sender, EventArgs e)
        {
            if (startNumber.Text.Any())
            {
                try
                {
                    start = int.Parse(startNumber.Text);
                }
                catch 
                {
                    MessageBox.Show("Not a number! Please enter a valid number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    startNumber.Clear();
                }
            }
        }

        private void finishNumber_TextChanged(object sender, EventArgs e)
        {
            if (finishNumber.Text.Any())
            {
                try
                {
                    finish = int.Parse(finishNumber.Text);
                }
                catch
                {
                    MessageBox.Show("Not a number! Please enter a valid number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    finishNumber.Clear();                
                }
            }
        }

        private void intervalNumber_TextChanged(object sender, EventArgs e)
        {
            if (intervalNumber.Text.Any())
            {
                try
                {
                    interval = int.Parse(intervalNumber.Text);
                }
                catch
                {
                    MessageBox.Show("Not a number! Please enter a valid number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    intervalNumber.Clear();
                }
            }
        }
        private void executeButton_Click(object sender, EventArgs e)
        {
            if (startNumber.Text.Any() && finishNumber.Text.Any() && intervalNumber.Text.Any())
            {
                Random r = new Random();
                for (int i = 0; i <= interval; i++)
                {
                    numberListBox.Items.Add(r.Next(start, finish + 1));
                }
            }
            else 
            {
                MessageBox.Show("Please provide all the information to execute!\nCannot leave empty fields!", "Not all fields are filled in correctly", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void evenRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            operationListBox.Items.Clear();
            foreach (int num in numberListBox.Items)
            {
                if (num % 2 == 0)
                {
                    operationListBox.Items.Add(num);
                }
            }
        }

        private void oddRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            operationListBox.Items.Clear();
            foreach (int num in numberListBox.Items)
            {
                if (num % 2 != 0)
                {
                    operationListBox.Items.Add(num);
                }
            }
        }

        private void divisibleByTreeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            operationListBox.Items.Clear();
            foreach (int num in numberListBox.Items)
            {
                if (num % 3 == 0)
                {
                    operationListBox.Items.Add(num);
                }
            }
        }

        private void divisibleByFiveRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            operationListBox.Items.Clear();
            foreach (int num in numberListBox.Items)
            {
                if (num % 5 == 0)
                {
                    operationListBox.Items.Add(num);
                }
            }
        }

        private void divisibleBySevenRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            operationListBox.Items.Clear();
            foreach (int num in numberListBox.Items)
            {
                if (num % 7 == 0)
                {
                    operationListBox.Items.Add(num);
                }
            }
        }

        private void numSelectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (numSelectComboBox.SelectedIndex > 0)
            {
                int selected = Convert.ToInt32(numSelectComboBox.SelectedItem);
                operationListBox.Items.Clear();
                foreach (int num in numberListBox.Items)
                {

                    if (num % selected == 0)
                    {
                        operationListBox.Items.Add(num);
                    }
                }
            }
        }

        private void chooseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (chooseCheckBox.Checked)
            {
                operationListBox.Items.Clear();
                numSelectComboBox.Enabled = true;
                operationGroupBox.Enabled = false;
            }
            else
            {
                operationListBox.Items.Clear();
                numSelectComboBox.SelectedIndex = 0;
                numSelectComboBox.Enabled = false;
                operationGroupBox.Enabled = true;
            }
        }
    }
}
