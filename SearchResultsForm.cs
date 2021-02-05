using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Windows.Forms;

namespace MinecraftLogSearcherGUI
{
    public partial class Form2 : Form
    {
        private string searchTerm;
        private DirectoryInfo directory;

        public Form2(string directory, string searchTerm)
        {
            InitializeComponent();

            Text = "Search Results";

            results.View = View.Details;
            results.Columns.Add("File", -2);
            results.Columns.Add("Line", -2);
            results.Columns.Add("Result", -2);

            this.directory = new DirectoryInfo(directory);
            this.searchTerm = searchTerm;

            results.MouseClick += SearchTerm_Click;

            Show();

            GetResults();
        }

        private void GetResults()
        {
            var files = directory.EnumerateFiles().Where(file => file.Name.ToLower().EndsWith(".log.gz")).ToList();

            foreach (FileInfo file in files)
            {
                using (FileStream fs = file.OpenRead())
                {
                    using (GZipStream gs = new GZipStream(fs, CompressionMode.Decompress, true))
                    {
                        using (StreamReader reader = new StreamReader(gs))
                        {
                            int lineNumber = 1;
                            while (!reader.EndOfStream)
                            {
                                string line = reader.ReadLine();
                                if (line.ToLower().Contains(searchTerm.ToLower()))
                                {
                                    string[] result = { lineNumber.ToString(), line };          // wtf
                                    results.Items.Add(file.Name).SubItems.AddRange(result);
                                    
                                }
                                lineNumber++;
                            }
                        }
                    }
                }
            }
        }

        private void SearchTerm_Click(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < results.Items.Count; i++)
            {
                var rectangle = results.GetItemRect(i);
                if (rectangle.Contains(e.Location))
                {
                    string fileName = results.Items[i].Text;
                    _ = new Log(directory.EnumerateFiles().First(file => file.Name == fileName)); 
                    return;
                }
            }
        }
    }
}
