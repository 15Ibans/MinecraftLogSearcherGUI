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

        private readonly string defaultLogDirectoryText = "Log directory goes here...";
        private readonly string defaultSearchTermText = "Search text goes here...";
        
        public MainForm()
        {
            InitializeComponent();
            logDirectory.Click += logDirectoryClick;
            searchTerm.Click += searchTerm_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            searchTerm.Text = "Search text goes here...";
            logDirectory.Text = "Logs directory goes here...";
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
                _ = new SearchResultsForm(logDirectory.Text, searchTerm.Text);
            }
            if (!Directory.Exists(logDirectory.Text))
            {
                MessageBox.Show("Enter a valid directory in the directory text box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void logDirectoryClick(object sender, EventArgs e)
        {
            if (logDirectory.Text == defaultLogDirectoryText)
            {
                logDirectory.Text = "";
            }
        }

        private void searchTerm_Click(object sender, EventArgs e)
        {
            if (searchTerm.Text == defaultSearchTermText)
            {
                searchTerm.Text = "";
            }
        }
    }
}
