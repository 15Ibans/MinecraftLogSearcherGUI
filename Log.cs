using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MinecraftLogSearcherGUI
{
    public partial class Log : Form
    {
        public Log(string fileName, List<string> lines, int lineNum)
        {
            Text = fileName;
            InitializeComponent();
            logText.ScrollBars = ScrollBars.Both;
            logText.Font = new Font("Courier New", logText.Font.Size);
            logText.ReadOnly = true;
            logText.WordWrap = false;

            logText.Lines = lines.ToArray();
            
            Show();

            logText.SelectionStart = logText.GetFirstCharIndexFromLine(lineNum - 1);
            logText.SelectionLength = logText.Lines[lineNum - 1].Length;
            logText.ScrollToCaret();
        }
    }
}
