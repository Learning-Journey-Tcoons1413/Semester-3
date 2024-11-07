using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        private int currentIndex = 0;
        private const string STORY_TEXT = "Hamilton, from the point at which it was first colonized "
                                        + "settlers, has benefited from its geographical proximity to major land and water " +
                                        "transportation routes along the Niagara Peninsula and Lake Ontario. " +
                                        "Its strategic importance has created, by Canadian standards, a rich military " +
                                        "history which the city preserves. Tension between maximizing economic growth " +
                                        "and minimizing environmental damage was evident, even from the city's early " +
                                        "development. The area between Burlington Bay (also known as Hamilton Harbour) " +
                                        "and the Niagara Escarpment has been greatly altered for residential, industrial " +
                                        "and recreational purposes. Cootes Paradise in Dundas also known as the Dundas Marsh " +
                                        ", was a very rich wetland with plenty of fish, birds and other game. Cootes Paradise " +
                                        "was named after Captain Thomas Coote\r\n\r\n" +
                                         "https://en.wikipedia.org/wiki/History_of_Hamilton,_Ontario";
        private List<string> list = new List<string>();
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = STORY_TEXT;
            textBox1.SelectionStart = 0;
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            string search = findTextBox.Text.Trim();
            int index = STORY_TEXT.IndexOf(search, StringComparison.OrdinalIgnoreCase);
            textBox1.SelectionStart = index;
            textBox1.SelectionLength = search.Length;
            textBox1.Focus();   
        }

        private void findNextButton_Click(object sender, EventArgs e)
        {
            string search = findTextBox.Text.Trim();
            int index = STORY_TEXT.IndexOf(search,currentIndex, StringComparison.OrdinalIgnoreCase);
            textBox1.SelectionStart = index;
            textBox1.SelectionLength = search.Length;
            textBox1.Focus();
            currentIndex += index + search.Length;
        }

        private void replaceButton_Click(object sender, EventArgs e)
        {
            string replaceWord = replaceTextBox.Text.Trim();
            string searchPattern = findTextBox.Text.Trim();
            string resultText = Regex.Replace(STORY_TEXT, Regex.Escape(searchPattern), replaceWord, RegexOptions.IgnoreCase);
            textBox1.Text = resultText;
        }
    }
}
