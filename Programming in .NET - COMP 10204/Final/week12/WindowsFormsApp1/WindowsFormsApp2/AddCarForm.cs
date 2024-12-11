using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace WindowsFormsApp2
{
    public partial class AddCarForm : Form
    {
        MainForm parentForm;
        public AddCarForm(MainForm parent)
        {
            InitializeComponent();
            parentForm = parent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Build the SQL string to calculate the average Milege
            SqlCommand command = new SqlCommand("INSERT INTO CARS (make, model, modelyear)" +
            "VALUES (@ParamMake, @ParamModel, @ParamYear)", parentForm.Connection);
            SqlParameter make = new SqlParameter("@ParamMake", SqlDbType.VarChar);
            SqlParameter model = new SqlParameter("@ParamModel", SqlDbType.VarChar);
            SqlParameter modelYear = new SqlParameter("@ParamYear", SqlDbType.Int);
            make.Value = textBox1.Text;
            model.Value = textBox2.Text;
            modelYear.Value = numericUpDown1.Value;
            command.Parameters.Add(make);
            command.Parameters.Add(model);
            command.Parameters.Add(modelYear);
            // Create new SqlDataReader object and read data from the command.
            int result = command.ExecuteNonQuery();
            if (result != 1)
                MessageBox.Show("No record was added to Database ", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
