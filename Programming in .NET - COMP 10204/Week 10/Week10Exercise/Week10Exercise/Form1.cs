using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week10Exercise
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();
        public Form1()
        {
            InitializeComponent();
            students.Add(new Student("Joe", "Smith", 75, 87));
            students.Add(new Student("Joanne", "Smith", 75, 88));
            students.Add(new Student("Harsh", "Patel", 55, 91));
            students.Add(new Student("Mitel", "Patel", 82, 66));
            students.Add(new Student("Ishwar", "Singh", 91, 93));
            students.Add(new Student("Amy", "Nguyen", 91, 65));

            foreach (Student student in students)
            {
                studentsListBox.Items.Add(student); 
            }
        }

        private void lastNameButton_Click(object sender, EventArgs e)
        {
            studentsListBox.Items.Clear();  
            students.Sort((s1, s2)=>s1.LName.CompareTo(s2.LName));
            foreach (Student student in students)
            {
                studentsListBox.Items.Add(student);     
            }
        }

        private void gradeOneButton_Click(object sender, EventArgs e)
        {
            studentsListBox.Items.Clear();
            students.Sort((s1, s2) => s1.Grade1.CompareTo(s2.Grade1));
            foreach (Student student in students)
            {
                studentsListBox.Items.Add(student);
            }
        }

        private void gradeTwoButton_Click(object sender, EventArgs e)
        {
            studentsListBox.Items.Clear();
            students.Sort((s1, s2) => s1.Grade2.CompareTo(s2.Grade2));
            foreach (Student student in students)
            {
                studentsListBox.Items.Add(student);
            }
        }

        private void averageButton_Click(object sender, EventArgs e)
        {
            studentsListBox.Items.Clear();
            students.Sort((s1, s2) => s1.Average.CompareTo(s2.Average));
            foreach (Student student in students)
            {
                studentsListBox.Items.Add(student);
            }
        }

        private void gradeOneGradeTwoButton_Click(object sender, EventArgs e)
        {
            studentsListBox.Items.Clear(); 

            students.Sort((student1, student2) =>
            {
                int gradeComparison = student1.Grade1.CompareTo(student2.Grade1);

                if (gradeComparison == 0)
                {
                    gradeComparison = student1.Grade2.CompareTo(student2.Grade2);
                }

                return gradeComparison;
            });

            foreach (Student student in students)
            {
                studentsListBox.Items.Add(student);
            }
        }
    }
}
