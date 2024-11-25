using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
//I, Thomas Coons, 000317961 certify that this material is my original work.
//No other person's work has been used without due acknowledgement.

namespace Lab4B
{
    /// <summary>
    /// Form Application to Check HTML Balanced Tags
    /// </summary>
    public partial class Form1 : Form
    {
        public bool fileLoaded = false;
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

        /// <summary>
        /// Main Initialization 
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            checkTagsToolStripMenuItem.Enabled = false;
        }

        /// <summary>
        /// Calls the LoadFile() Function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFile();
        }

        /// <summary>
        /// Tries to read the selected HTML file and places the content into htmlContent variable. Clears tagsListBox each time.
        /// </summary>
        private void ReadFile()
        {
            tagsListBox.Items.Clear();
            try
            {
                htmlContent = File.ReadAllText(file);
                checkTagsToolStripMenuItem.Enabled = true;
                fileLoaded = true;
            }
            catch (Exception ex)
            {
                fileLoaded = false;
                checkTagsToolStripMenuItem.Enabled = false;
                MessageBox.Show($"An error has occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        /// Calls the CheckTags() Function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkTagsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckTags();
        }

        /// <summary>
        /// Loops through the HTML file and creates a List of only valid HTML tags. Pushes and Pops items out of a Stack to verify 
        /// valid opening and closing of tags.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckTags()
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
                headerLabel.ForeColor = Color.Green;
                headerLabel.Text = fileName + ": has balanced tags";
            }
            else
            {
                headerLabel.ForeColor = Color.Red;    
                headerLabel.Text = fileName + ": does not have balanced tags";
            }
            stackTags.Clear();
        }

        /// <summary>
        /// Opens a dialog box with the user and attempts to open only HTML files
        /// </summary>
        private void LoadFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "HTML files (*.html, *.htm)|*.html;*.htm";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                file = openFileDialog.FileName;
                fileName = Path.GetFileName(file);
                headerLabel.ForeColor= Color.Black;
                headerLabel.Text = "File Name: " + fileName;
                ReadFile();
            }
        }

        /// <summary>
        /// Keyboard ShortCuts
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if (e.KeyCode == Keys.L)
                {
                    LoadFile();
                }
                if (e.KeyCode == Keys.C && fileLoaded == true)
                {
                    CheckTags();
                }
                if (e.KeyCode == Keys.Q)
                {
                    Close();
                }
            }
        }
    }
}






