using System;
using System.Windows.Forms;

namespace Week9Exercise
{
    public partial class Form1 : Form
    {
        private const string TEXT = "Hamilton, from the point at which it was first colonized "
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
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = TEXT;
            textBox1.SelectionStart = 0;    
        }

        private void findButton_Click(object sender, EventArgs e)
        {

            textBox1.SelectionStart = 15;
            textBox1.SelectionLength = 50;

        }
    }
}
