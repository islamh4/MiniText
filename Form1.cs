using System;
using System.Text;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MiniWord
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "(*.txt)|*.txt";
            saveFileDialog1.Filter = "(*.txt)|*.txt";
            ComboBoxShrift.Items.AddRange(FontFamily.Families.Select(a => a.Name).ToArray());
            Sizes.Items.AddRange(new object[] { 8,9,10,11,12,14,16,18,20,22,24,26,28,36,48,72});
        }

        FontStyle style;
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            tbMessage.Text = File.ReadAllText(openFileDialog1.FileName);
            MessageBox.Show("File open!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            var font = new FontConverter();
            string inforh = font.ConvertToInvariantString(tbMessage.Text);
            File.WriteAllText(saveFileDialog1.FileName, tbMessage.Text + inforh);
            MessageBox.Show("File save!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Bold_Click(object sender, EventArgs e)
        {
            style = tbMessage.Font.Style;
            if (tbMessage.Font.Bold)
            {
                style = style & ~FontStyle.Bold;
            }
            else
            {
                style = style | FontStyle.Bold;
            }
            tbMessage.Font = new Font(tbMessage.Font, style);
        }
         
        private void Italics_Click(object sender, EventArgs e)
        {
            style = tbMessage.Font.Style;
            if (tbMessage.Font.Italic)
            {
                style = style & ~FontStyle.Italic;
            }
            else
            {
                style = style | FontStyle.Italic;
            }
            tbMessage.Font = new Font(tbMessage.Font, style);
        }

        private void Underline_Click(object sender, EventArgs e)
        {
            style = tbMessage.Font.Style;
            if (tbMessage.Font.Underline)
            {
                style = style & ~FontStyle.Underline;
            }
            else
            {
                style = style | FontStyle.Underline;
            }
            tbMessage.Font = new Font(tbMessage.Font, style);
        }
        private string str;

        private void ComboBoxShrift_SelectedIndexChanged(object sender, EventArgs e)
        {
            str = ComboBoxShrift.SelectedItem.ToString();
            tbMessage.Font = new Font(str, float.Parse(sizess));
        }

        private string sizess = "8,25";

        private void Sizes_SelectedIndexChanged(object sender, EventArgs e)
        {
            sizess = Sizes.SelectedItem.ToString();
            tbMessage.Font = new Font(str, float.Parse(sizess));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbMessage.Font = new Font("Times New Roman", 48f);
        }
    }
}
