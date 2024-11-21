using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;


namespace Lab4B
{
    public partial class Form1 : Form
    {
        public string file = "";
        public string fileName = "";
        public string htmlContent;
        public Stack<string> stackTags = new Stack<string>();
        List<string> nonContainerTags = new List<string>
        {
            "<area>",
            "<base>",
            "<br>",
            "<col>",
            "<embed>",
            "<hr>",
            "<img>",
            "<input>",
            "<link>",
            "<meta>",
            "<source>",
            "<!doctype>"
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
        //private void checkTagsToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    tagsListBox.Items.Clear();
        //    string pattern = @"</?([a-zA-Z0-9]+)[^>]*>"; // source: https://learn.microsoft.com/en-us/dotnet/standard/base-types/regular-expression-language-quick-reference
        //    bool nonConTagFound = false;
        //    int tabCount = 10;

        //    var matchCollection = Regex.Matches(htmlContent, pattern);
        //    foreach (Match m in matchCollection)
        //    {
        //        string tagName = m.Groups[1].Value.ToLower();
        //        string fullTag = m.Value.ToLower();

        //        foreach (string nct in nonContainerTags)
        //        {
        //            if (nct.Equals(tagName))
        //            {
        //                string addItem = new string(' ', tabCount) + "Found Non-Container Tag: " + "<" + tagName + ">";
        //                tagsListBox.Items.Add(addItem);
        //                nonConTagFound = true;
        //                break;
        //            }

        //        }
        //        if (!nonConTagFound)
        //        {

        //            if (fullTag.StartsWith("</"))
        //            {
        //                tabCount -= 10;
        //                string addItem = new string(' ', tabCount) + "Found Closing Tag: " + "</" + tagName + ">";
        //                tagsListBox.Items.Add(addItem);
        //                tags.Pop();
        //            }
        //            else
        //            {
        //                string addItem = new string(' ', tabCount) + "Found Opening Tag: " + "<" + tagName + ">";
        //                tagsListBox.Items.Add(addItem);
        //                tabCount += 10;
        //                tags.Push(addItem);
        //            }
        //        }

        //        nonConTagFound = false;
        //    }
        //    if (tags.Count == 0)
        //    {
        //        headerTextBox.Text = fileName + ": is valid!";
        //    }
        //    else
        //    {
        //        headerTextBox.Text = fileName + ": is invalid!";
        //    }
        //    tags.Clear();
        //}


        private void checkTagsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tagsListBox.Items.Clear();
            string tag = "";
            List<string> tags = new List<string>();
            int tabCount = 0;
            bool nonConTagFound = false;

            for (int i = 0; i < htmlContent.Length; i++)
            {

                if (htmlContent[i] == '<')
                {
                    tag = "";
                    tag += '<';
                }
                else if (htmlContent[i] == '>')
                {
                    tag += '>';
                    tags.Add(tag.ToLower());
                    tag = "";
                }
                else
                {
                    tag += htmlContent[i];
                }

            }
            for (int i = 0; i < tags.Count; i++)
            {
                string updateTag = "";
                for (int j = 0; j < tags[i].Length; j++)
                {
                    if (tags[i][j] == ' ')
                    {
                        updateTag += ">";
                        tags[i] = updateTag;
                    }
                    else
                    {
                        updateTag += tags[i][j];
                    }
                    
                }
            }
            foreach (string t in tags)
            {
                foreach (string nct in nonContainerTags)
                {
                    if (nct.Equals(t))
                    {
                        string addItem = new string(' ', tabCount) + "Found Non-Container Tag: " + t;
                        tagsListBox.Items.Add(addItem);
                        nonConTagFound = true;
                        break;
                    }
                }
                if (!nonConTagFound)
                {

                    if (t.StartsWith("</"))
                    {
                        tabCount -= 6;
                        string addItem = new string(' ', tabCount) + "Found Closing Tag: " + t;
                        tagsListBox.Items.Add(addItem);
                        if (stackTags.Peek().Substring(1) == t.Substring(2))
                        {

                            stackTags.Pop();
                        }
                        else
                        {

                            break;
                        }
                    }
                    else
                    {
                        string addItem = new string(' ', tabCount) + "Found Opening Tag: " + t;
                        tagsListBox.Items.Add(addItem);
                        tabCount += 6;
                        stackTags.Push(t);
                    }
                }

                nonConTagFound = false;
            }
            if (stackTags.Count == 0)
            {
                headerTextBox.Text = fileName + ": is valid!";
            }
            else
            {
                headerTextBox.Text = fileName + ": is invalid!";
            }
            stackTags.Clear();
        }
    }
}






