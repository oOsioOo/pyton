using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace szamKezeles
{
    public partial class NumberFinder : Form
    {
        public NumberFinder()
        {
            InitializeComponent();
        }
        public List<int> primeNumbers = new List<int>();
        public List<int> squareNumbers = new List<int>();
        public List<int> evenNumbers = new List<int>();
        public List<int> oddNumbers = new List<int>();
        public List<int> treeNumbers = new List<int>();
        public List<int> sixNumbers = new List<int>();
        public List<int> nineNumbers = new List<int>();
        private void numGenerateButton_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            for(int i = 0; i < 1000; i++) 
            {
                int random = r.Next(1, 10000);
                numberList1.Items.Add(random);
            }

        }
        
        private void primeCheck_CheckedChanged(object sender, EventArgs e)
        {
           
            if(primeCheck.Checked)
            {
                
                foreach (int number in numberList1.Items)
                {
                    Boolean prime = true;
                    for (int i = 2; i <= Math.Sqrt(number); i++)
                    {
                        if (number % i == 0)
                        {
                            prime = false;
                            break;
                        }
                    }
                    if (prime)
                    {
                        numberList2.Items.Add(number);
                        primeNumbers.Add(number);
                    }

                }
            }
            else 
            {
                for (int i = numberList2.Items.Count - 1; i >= 0; i--)
                {
                    int number = (int)numberList2.Items[i];
                    if (primeNumbers.Contains(number))
                    {
                        numberList2.Items.RemoveAt(i);
                    }
                }
            }
            
        }

        private void evenNumberCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (evenNumberCheck.Checked)
            {
                foreach (int number in numberList1.Items)
                {
                    if (number % 2 == 0)
                    {
                        evenNumbers.Add(number);
                        numberList2.Items.Add(number);
                    }
                }
            }
            else
            {
                for (int i = numberList2.Items.Count - 1; i >= 0; i--)
                {
                    int number = (int)numberList2.Items[i];
                    if (evenNumbers.Contains(number))
                    {
                        numberList2.Items.RemoveAt(i);
                    }
                }
            }
        }

        private void oddNumbersCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (oddNumbersCheck.Checked)
            {
                foreach (int number in numberList1.Items)
                {
                    if (number % 2 != 0)
                    {
                        oddNumbers.Add(number);
                        numberList2.Items.Add(number);
                    }
                }

            }
            else
            {
                for (int i = numberList2.Items.Count - 1; i >= 0; i--)
                {
                    int number = (int)numberList2.Items[i];
                    if (oddNumbers.Contains(number))
                    {
                        numberList2.Items.RemoveAt(i);
                    }
                }
            }
        }

        private void divisibleBy3NumberCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (divisibleBy3NumberCheck.Checked)
            {
                foreach (int number in numberList1.Items)
                {
                    if (number % 3 == 0)
                    {
                        treeNumbers.Add(number);
                        numberList2.Items.Add(number);
                    }
                }

            }
            else
            {
                for (int i = numberList2.Items.Count - 1; i >= 0; i--)
                {
                    int number = (int)numberList2.Items[i];
                    if (treeNumbers.Contains(number))
                    {
                        numberList2.Items.RemoveAt(i);
                    }
                }
            }
        }

        private void divisibleBy6NumberCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (divisibleBy6NumberCheck.Checked)
            {
                foreach (int number in numberList1.Items)
                {
                    if (number % 6 == 0)
                    {
                        sixNumbers.Add(number);
                        numberList2.Items.Add(number);
                    }
                }

            }
            else
            {
                for (int i = numberList2.Items.Count - 1; i >= 0; i--)
                {
                    int number = (int)numberList2.Items[i];
                    if (sixNumbers.Contains(number))
                    {
                        numberList2.Items.RemoveAt(i);
                    }
                }
            }
        }

        private void divisibleBy9NumberCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (divisibleBy9NumberCheck.Checked)
            {
                foreach (int number in numberList1.Items)
                {
                    if (number % 9 == 0)
                    {
                        nineNumbers.Add(number);
                        numberList2.Items.Add(number);
                    }
                }

            }
            else
            {
                for (int i = numberList2.Items.Count - 1; i >= 0; i--)
                {
                    int number = (int)numberList2.Items[i];
                    if (nineNumbers.Contains(number))
                    {
                        numberList2.Items.RemoveAt(i);
                    }
                }
            }
        }

        private void squareCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (squareCheck.Checked)
            {
                foreach (int number in numberList1.Items)
                {
                    if (Math.Sqrt(number) % 1 == 0)
                    {
                        squareNumbers.Add(number);
                        numberList2.Items.Add(number);
                    }
                }

            }
            else
            {
                for (int i = numberList2.Items.Count - 1; i >= 0; i--)
                {
                    int number = (int)numberList2.Items[i];
                    if (squareNumbers.Contains(number))
                    {
                        numberList2.Items.RemoveAt(i);
                    }
                }
            }
        }

        private void numberList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            showNumbers.Text = numberList2.Items.Count.ToString() + "/1000";
            MessageBox.Show(numberList2.Items.Count.ToString() + "/1000");
            
        }

        private void countButton_Click(object sender, EventArgs e)
        {
            showNumbers.Text = numberList2.Items.Count.ToString();
        }
    }
}
