using System;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

namespace MinecraftLogSearcherGUI
{
    public partial class Log : Form
    {
        public Log(FileInfo file)
        {
            InitializeComponent();
            logText.ScrollBars = ScrollBars.Vertical;
            logText.Font = new Font("Courier New", logText.Font.Size);

            AddTextToTextBox(file);
            Show();
        }

        private void AddTextToTextBox(FileInfo log)
        {
            using (FileStream fs = log.OpenRead())
            {
                using (GZipStream gs = new GZipStream(fs, CompressionMode.Decompress, true))
                {
                    using (StreamReader reader = new StreamReader(gs))
                    {
                        int i = 1;
                        int xPos = lineNumber.Location.X;
                        int yPos = lineNumber.Location.Y + 20;
                        while (!reader.EndOfStream)
                        {
                            string currentLine = reader.ReadLine();
                            if (currentLine != null)
                            {
                                logText.AppendText(currentLine);
                                logText.AppendText(Environment.NewLine);
                                Label lineNum = new Label();
                                lineNum.Text = i.ToString();
                                lineNum.Location = new Point(xPos, yPos);
                            }
                            i++;
                            yPos += 20;
                        }
                    }
                }
            }
        }
    }
}
