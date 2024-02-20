using  System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Windows.Forms;

namespace MinecraftLogSearcherGUI
{
    public partial class SearchResultsForm : Form
    {
        private readonly string _searchTerm;
        private DirectoryInfo _directory;
        private LogCache cache = new LogCache();

        private bool isCaseSensitive = false;

        public SearchResultsForm(string directory, string searchTerm)
        {
            InitializeComponent();

            Text = "Search Results";

            results.View = View.Details;
            results.Columns.Add("File", -2);
            results.Columns.Add("Line", -2);
            results.Columns.Add("Result", -2);

            _directory = new DirectoryInfo(directory);
            _searchTerm = searchTerm;

            results.MouseDoubleClick += SearchTerm_Click;

            Show();

            GetResults();
        }

        private void GetResults()
        {
            var files = _directory.EnumerateFiles().Where(file => file.Name.ToLower().EndsWith(".log.gz")).ToList();

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
                                bool isSubstring = isCaseSensitive
                                    ? line?.Contains(_searchTerm) ?? false
                                    : line?.Contains(_searchTerm, StringComparison.OrdinalIgnoreCase) ?? false;
                                if (isSubstring)
                                {
                                    string[] result = { lineNumber.ToString(), line };          // wtf
                                    results.Items.Add(file.Name).SubItems.AddRange(result);
                                }
                                cache.AddLine(file.Name, line);
                                lineNumber++;
                            }
                        }
                    }
                }
            }

            results.Columns[0].Width = -2;
            results.Columns[1].Width = -2;
        }

        private void SearchTerm_Click(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < results.Items.Count; i++)
            {
                var rectangle = results.GetItemRect(i);
                if (rectangle.Contains(e.Location))
                {
                    string fileName = results.Items[i].Text;
                    int lineNum = Int32.Parse(results.Items[i].SubItems[1].Text);
                    _ = new Log(fileName, cache.GetLines(fileName), lineNum); 
                    return;
                }
            }
        }
    }
}
