using System.Data;
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

            this.Text = "Search Results";

            results.View = View.Details;
            results.Columns.Add("File", -2);
            results.Columns.Add("Line", -2);
            results.Columns.Add("Result", -2);

            this.directory = new DirectoryInfo(directory);
            this.searchTerm = searchTerm;

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
    }
}
