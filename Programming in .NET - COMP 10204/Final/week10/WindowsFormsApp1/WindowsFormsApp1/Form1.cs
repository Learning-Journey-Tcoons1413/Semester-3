using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<Student> students;
        public Form1()
        {
            InitializeComponent();
            listBox1.Items.Add($"{"Firstname",-15} {"Lastname",-15} {"Grade 1",-15} {"Grade 2",-15} {"Average",-15}");
            listBox1.Items.Add(""); 
            students = new List<Student>
            {
                new Student("Joe", "Smith", 75, 87),
                new Student("Joanne", "Smith", 75, 88),
                new Student("Harsh", "Patel", 55, 91),
                new Student("Mitel", "Patel", 82, 66),
                new Student("Ishwar", "Singh", 91, 93),
                new Student("Amy", "Nguyen", 91, 65)
            };

            foreach (Student student in students)
            {
                listBox1.Items.Add(student);
            }

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add($"{"Firstname",-15} {"Lastname",-15} {"Grade 1",-15} {"Grade 2",-15} {"Average",-15}");
            listBox1.Items.Add("");

            students.Sort((s1, s2)=>s1.LastName.CompareTo(s2.LastName)); // sort with labmda

            foreach (Student student in students)
            {
                listBox1.Items.Add(student);   
            }
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add($"{"Firstname",-15} {"Lastname",-15} {"Grade 1",-15} {"Grade 2",-15} {"Average",-15}");
            listBox1.Items.Add("");
            students.Sort((s1, s2) => s1.Grade1.CompareTo(s2.Grade1)); // sort with labmda 
            foreach (Student student in students)
            {
                listBox1.Items.Add(student);
            }
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add($"{"Firstname",-15} {"Lastname",-15} {"Grade 1",-15} {"Grade 2",-15} {"Average",-15}");
            listBox1.Items.Add("");

            students.Sort((s1, s2) => s1.Grade2.CompareTo(s2.Grade2)); // sort with labmda

            foreach (Student student in students)
            {
                listBox1.Items.Add(student);
            }
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add($"{"Firstname",-15} {"Lastname",-15} {"Grade 1",-15} {"Grade 2",-15} {"Average",-15}");
            listBox1.Items.Add("");
            students.Sort((s1, s2) => s1.Average.CompareTo(s2.Average));
            foreach (Student student in students)
            {
                listBox1.Items.Add(student);
            }
        }

        private void button5_Click(object sender, System.EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add($"{"Firstname",-15} {"Lastname",-15} {"Grade 1",-15} {"Grade 2",-15} {"Average",-15}");
            listBox1.Items.Add("");

            var results =
                from s in students
                orderby s.Grade1, s.Grade2
                select s;

            foreach(var result in results)
            {
                listBox1.Items.Add(result); 
            }

        }
    }
}
