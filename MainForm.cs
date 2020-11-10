using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinecraftLogSearcherGUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fileDialog_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog result = new FolderBrowserDialog();
            
            if (result.ShowDialog() == DialogResult.OK)
            {
                logDirectory.Text = result.SelectedPath;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(logDirectory.Text) && searchTerm.Text.Length > 0)
            {
                _ = new Form2(logDirectory.Text, searchTerm.Text);
            }
            if (!Directory.Exists(logDirectory.Text))
            {
                MessageBox.Show("Enter a valid directory in the directory text box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
