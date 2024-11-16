using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace Lab4B
{
    public partial class Form1 : Form
    {
        public string file = "";
        public string fileName = "";
        public string htmlContent;
        public Stack<string> tags = new Stack<string>();
        List<string> nonContainerTags = new List<string>
        {
            "area",
            "base",
            "br",
            "col",
            "embed",
            "hr",
            "img",
            "input",
            "link",
            "meta",
            "source",
            "track",
            "wbr",
        };
        public Form1()
        {
            InitializeComponent();
            checkTagsToolStripMenuItem.Enabled = false;
        }

        /// <summary>
        /// Opens a dialog box with the user to open only HTML files
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "HTML files (*.html, *.htm)|*.html;*.htm";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                file = openFileDialog.FileName;
                fileName = Path.GetFileName(file);
            }
            headerTextBox.Text = "File Name: " + fileName;
            ReadFile();

        }

        /// <summary>
        /// Reads the selected HTML file
        /// </summary>
        private void ReadFile()
        {
            tagsListBox.Items.Clear();
            try
            {
                htmlContent = File.ReadAllText(file);
                checkTagsToolStripMenuItem.Enabled = true;
            }
            catch (Exception ex)
            {
                checkTagsToolStripMenuItem.Enabled = false;
                MessageBox.Show("An error has occurred.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        /// <summary>
        /// Closes the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Loops through the HTML file and creates a MatchCollection of only valid HTML tags. Pushes and Pops items out of a Stack to verify 
        /// valid opening and closing of tags.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkTagsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string pattern = @"<[^>]+>"; // source: https://learn.microsoft.com/en-us/dotnet/standard/base-types/regular-expression-language-quick-reference

            var t = Regex.Matches(htmlContent, pattern);
            bool ntagFound = false;
            int tabCount = 10;

            foreach (var item in t)
            {

                if (!string.IsNullOrWhiteSpace("" + item))
                {
                    string sItem = "" + item;
                    string stringitem = sItem.ToLower();



                    foreach (string tag in nonContainerTags)
                    {
                        if (stringitem.Contains(tag) && !stringitem.Contains("href") && !stringitem.Contains("td") || stringitem.Contains("doctype"))
                        {
                            string addItem = new string(' ', tabCount) + "Found Non-Container Tag: " + stringitem;
                            tagsListBox.Items.Add(addItem);
                            ntagFound = true;
                            break;
                        }
                    }

                    if (!ntagFound)
                    {

                        if (stringitem.StartsWith("</"))
                        {
                            tabCount -= 10;
                            string addItem = new string(' ', tabCount) + "Found Closing Tag: " + stringitem;
                            tagsListBox.Items.Add(addItem);
                            tags.Pop();
                        }
                        else
                        {
                            string addItem = new string(' ', tabCount) + "Found Opening Tag: " + stringitem;
                            tagsListBox.Items.Add(addItem);
                            tabCount += 10;
                            tags.Push(addItem);
                        }
                    }

                    ntagFound = false;
                }
            }
            if (tags.Count == 0)
            {
                headerTextBox.Text = fileName + ": is valid!";
            }
            else
            {
                headerTextBox.Text = fileName + ": is invalid!";
            }
            tags.Clear();
        }
    }
}


