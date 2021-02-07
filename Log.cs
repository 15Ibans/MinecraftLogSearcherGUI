using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MinecraftLogSearcherGUI
{
    public partial class Log : Form
    {
        List<Label> lineLabels = new List<Label>();
        
        public Log(string fileName, List<string> lines)
        {
            Text = fileName;
            InitializeComponent();
            logText.ScrollBars = ScrollBars.Vertical;
            logText.Font = new Font("Courier New", logText.Font.Size);
            logText.ReadOnly = true;

            foreach (string line in lines)
            {
                logText.AppendText(line);
                logText.AppendText(Environment.NewLine);
            }
            Show();
        }

        private void UpdateLineLabel()
        {
            lineNumLabel.Text = logText.GetLineFromCharIndex(logText.Text.IndexOf(logText.SelectedText)).ToString();
        }
    }
}
