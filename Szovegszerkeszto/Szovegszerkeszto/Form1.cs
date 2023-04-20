using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szovegszerkeszto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void betuGomb_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                szovegdoboz.Font = fontDialog1.Font;
                szovegdoboz.ForeColor = fontDialog1.Color;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void sorkozpipa_CheckedChanged(object sender, EventArgs e)
        {
            if (!sorkozpipa.Checked)
            {
                szovegdoboz.WordWrap = false;
            }
            else szovegdoboz.WordWrap = true;
        }

        private void hatterGomb_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                szovegdoboz.BackColor = colorDialog1.Color;
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            szovegdoboz.Clear();
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog megnyitas = new OpenFileDialog();
            if(megnyitas.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader olvas = new System.IO.StreamReader(megnyitas.FileName);
                while (!olvas.EndOfStream)
                {
                    szovegdoboz.Text = olvas.ReadLine();
                }
                olvas.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (szovegdoboz.Text == "")
                Environment.Exit(0);
            else
            {
                DialogResult result = MessageBox.Show("Az ablak tartalma nem üres\n\nBiztosam kilép?",
                    "Kérdés", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    Environment.Exit(0);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Szöveges állomány (*.txt)|*.txt|Minden fájl (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter mentes = new System.IO.StreamWriter(saveFileDialog.FileName);
                mentes.WriteLine(szovegdoboz.Text);
                mentes.Flush();
                mentes.Close();
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            szovegdoboz.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            szovegdoboz.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            szovegdoboz.Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            szovegdoboz.SelectedText = "";
        }

        private void datumBeszurGomb_Click(object sender, EventArgs e)
        {
            szovegdoboz.Text += (datum.Value).ToString();
        }

        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float jelenlegiMeret;
            jelenlegiMeret = szovegdoboz.Font.Size;
            jelenlegiMeret += 2.0f;
            szovegdoboz.Font = new Font(szovegdoboz.Font.Name, jelenlegiMeret,szovegdoboz.Font.Style, szovegdoboz.Font.Unit);

        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float jelenlegiMeret;
            jelenlegiMeret = szovegdoboz.Font.Size;
            jelenlegiMeret -= 2.0f;
            szovegdoboz.Font = new Font(szovegdoboz.Font.Name, jelenlegiMeret, szovegdoboz.Font.Style, szovegdoboz.Font.Unit);
        }

        private void restoreDefoultZoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            szovegdoboz.Font =  DefaultFont;
        }
    }
}
