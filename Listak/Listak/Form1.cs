using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listak
{
    public partial class List : Form
    {
        public List()
        {
            InitializeComponent();
        }

        private void addButton1_Click(object sender, EventArgs e)
        {
            wordListBox1.Items.Add(addTextBox1.Text);
            addTextBox1.Clear();
            addTextBox1.Select();
        }

        private void addButton2_Click(object sender, EventArgs e)
        {
            wordListBox2.Items.Add(addTextBox2.Text);
            addTextBox2.Clear();
            addTextBox2.Select();
        }

        private void topButton1_Click(object sender, EventArgs e)
        {
            int position = wordListBox1.SelectedIndex;
            if (position != -1)
            {
                string newword = wordListBox1.SelectedItem.ToString();
                wordListBox1.Items.RemoveAt(position);
                wordListBox1.Items.Insert(0, newword);
                wordListBox1.SetSelected(0, true);
            }
            else { wordListBox1.SetSelected(0, true); }
        }

        private void topButton2_Click(object sender, EventArgs e)
        {
            int position = wordListBox2.SelectedIndex;
            if (position != -1)
            {
                string newword = wordListBox2.SelectedItem.ToString();
                wordListBox2.Items.RemoveAt(position);
                wordListBox2.Items.Insert(0, newword);
                wordListBox2.SetSelected(0, true);
            }
            else { wordListBox2.SetSelected(0, true); }
        }

        private void upButton1_Click(object sender, EventArgs e)
        {
            int position = wordListBox1.SelectedIndex;
            if (position != -1)
            {
                int newposition = position - 1;
                if (newposition >= 0)
                {
                    string newword = wordListBox1.SelectedItem.ToString();
                    wordListBox1.Items.RemoveAt(position);
                    wordListBox1.Items.Insert(newposition, newword);
                    wordListBox1.SetSelected(newposition, true);
                }
            }
            else { wordListBox1.SetSelected(0, true); }
        }

        private void upButton2_Click(object sender, EventArgs e)
        {
            int position = wordListBox2.SelectedIndex;
            if (position != -1)
            {
                int newposition = position - 1;
                if (newposition >= 0)
                {
                    string newword = wordListBox2.SelectedItem.ToString();
                    wordListBox2.Items.RemoveAt(position);
                    wordListBox2.Items.Insert(newposition, newword);
                    wordListBox2.SetSelected(newposition, true);
                }
            }
            else { wordListBox2.SetSelected(0, true); }
        }

        private void downButton1_Click(object sender, EventArgs e)
        {
            int position = wordListBox1.SelectedIndex;
            if (position != -1)
            {   
                
                int newposition = position + 1;
                if (newposition >= 0 && newposition < wordListBox1.Items.Count)
                {
                    string newword = wordListBox1.SelectedItem.ToString();
                    wordListBox1.Items.RemoveAt(position);
                    wordListBox1.Items.Insert(newposition, newword);
                    wordListBox1.SetSelected(newposition, true);
                }
            }
            else { wordListBox1.SetSelected(wordListBox1.Items.Count-1, true); }
        }

        private void downButton2_Click(object sender, EventArgs e)
        {
            int position = wordListBox2.SelectedIndex;
            if (position != -1)
            {
                
                int newposition = position + 1;
                if (newposition >= 0 && newposition < wordListBox2.Items.Count)
                {
                    string newword = wordListBox2.SelectedItem.ToString();
                    wordListBox2.Items.RemoveAt(position);
                    wordListBox2.Items.Insert(newposition, newword);
                    wordListBox2.SetSelected(newposition, true);
                }
            }
            else { wordListBox2.SetSelected(wordListBox2.Items.Count - 1, true); }
        }

        private void botomButton1_Click(object sender, EventArgs e)
        {
            int position = wordListBox1.SelectedIndex;
            if (position != -1)
            {
                int newposition = wordListBox1.Items.Count -1;
                if (newposition >= 0 && newposition < wordListBox1.Items.Count)
                {
                    string newword = wordListBox1.SelectedItem.ToString();
                    wordListBox1.Items.RemoveAt(position);
                    wordListBox1.Items.Insert(newposition, newword);
                    wordListBox1.SetSelected(newposition, true);
                }
            }
            else { wordListBox1.SetSelected(wordListBox1.Items.Count - 1, true); }
        }

        private void botomButton2_Click(object sender, EventArgs e)
        {
            int position = wordListBox2.SelectedIndex;
            if (position != -1)
            {
                int newposition = wordListBox2.Items.Count - 1;
                if (newposition >= 0 && newposition < wordListBox2.Items.Count)
                {
                    string newword = wordListBox2.SelectedItem.ToString();
                    wordListBox2.Items.RemoveAt(position);
                    wordListBox2.Items.Insert(newposition, newword);
                    wordListBox2.SetSelected(newposition, true);
                }
            }
            else { wordListBox2.SetSelected(wordListBox2.Items.Count - 1, true); }
        }

        private void addToList1Button_Click(object sender, EventArgs e)
        {
            if (wordListBox2.SelectedIndex != -1)
            {
                wordListBox1.Items.Add(wordListBox2.SelectedItem);
                wordListBox2.Items.RemoveAt(wordListBox2.SelectedIndex);
                wordListBox1.SetSelected(wordListBox1.Items.Count - 1, true);
            }
        }

        private void addToList2Button_Click(object sender, EventArgs e)
        {
            if (wordListBox1.SelectedIndex != -1)
            {
                wordListBox2.Items.Add(wordListBox1.SelectedItem);
                wordListBox1.Items.RemoveAt(wordListBox1.SelectedIndex);
                wordListBox2.SetSelected(wordListBox2.Items.Count - 1, true);
            }
        }

        private void deleteButton1_Click(object sender, EventArgs e)
        {
            wordListBox1.Items.Clear();
        }

        private void deleteButton2_Click(object sender, EventArgs e)
        {
            wordListBox2.Items.Clear();
        }

        private void wordListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (wordListBox1.SelectedIndex == wordListBox1.Items.Count - 1)
            {
                downButton1.Enabled = false;
                botomButton1.Enabled = false;
                topButton1.Enabled = true;
                upButton1.Enabled = true;
            }
            else if (wordListBox1.SelectedIndex == 0)
            {
                downButton1.Enabled = true;
                botomButton1.Enabled = true;
                topButton1.Enabled = false;
                upButton1.Enabled = false;
            }
            else if (wordListBox1.SelectedIndex > 0 && wordListBox1.SelectedIndex < wordListBox1.Items.Count - 1)
            {
                downButton1.Enabled = true;
                botomButton1.Enabled = true;
                topButton1.Enabled = true;
                upButton1.Enabled = true;
            }

        }

        private void wordListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (wordListBox2.SelectedIndex == wordListBox2.Items.Count - 1)
            {
                downButton2.Enabled = false;
                botomButton2.Enabled = false;
                topButton2.Enabled = true;
                upButton2.Enabled = true;
            }
            else if (wordListBox2.SelectedIndex == 0)
            {
                downButton2.Enabled = true;
                botomButton2.Enabled = true;
                topButton2.Enabled = false;
                upButton2.Enabled = false;
            }
            else if (wordListBox2.SelectedIndex > 0 && wordListBox2.SelectedIndex < wordListBox2.Items.Count - 1)
            {
                downButton2.Enabled = true;
                botomButton2.Enabled = true;
                topButton2.Enabled = true;
                upButton2.Enabled = true;
            }
        }
    }
}
