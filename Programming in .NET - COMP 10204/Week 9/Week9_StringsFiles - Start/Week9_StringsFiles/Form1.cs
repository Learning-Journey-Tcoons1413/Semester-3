using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;

namespace Week9_StringsFiles
{
    public partial class Form1 : Form
    {
        const string DATA_FILE = "Products.txt";
        const string DATA_FILE_SER = "Products.ser";
        List<Product> products;
        public Form1()
        {
            InitializeComponent();

            // Create an empty set of products 
            products = new List<Product>();

            try
            {
                StreamReader reader = new StreamReader(DATA_FILE);
                while (!reader.EndOfStream)
                {
                    string[] fields = reader.ReadLine().Split(',');  // split is part of string class 
                    Product p = new Product(int.Parse(fields[0]), fields[1], fields[2], decimal.Parse(fields[3]), int.Parse(fields[4]));
                    products.Add(p);
                    ProductsListBox.Items.Add(p);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                // Should only use Error Icon for more severe errors
                MessageBox.Show($"Error processign the file : {ex.Message} ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CalculateTotalValue();
        }

        private void ProductsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ProductsListBox.SelectedIndex;
            if (index >= 0)
            {
                Product p = products[index];
                // Update all ofthe textboxes on screen with the Model data 
                // The Number value will be used as the "KEY" field for updating the information in the record 
                NumberTextBox.Text = p.Number.ToString();
                TitleTextBox1.Text = p.Title;
                TypeTextBox.Text = p.Type;
                UnitPriceTextBox.Text = p.UnitPrice.ToString();
                QuantityTextBox.Text = p.UnitsSold.ToString();
                ValueTextBox.Text = $"{p.ProductValue().ToString("C")}";
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            int index = ProductsListBox.SelectedIndex;
            Product p = products[index];
            p.UnitPrice = decimal.Parse(UnitPriceTextBox.Text);
            p.UnitsSold = int.Parse(QuantityTextBox.Text);
            StreamWriter write = new StreamWriter(DATA_FILE);
            foreach (Product prod in products)
            {
                write.WriteLine(prod.ToCsv());  
            }
            write.Close();
            UpdateListbox();
            ProductsListBox.SelectedIndex = index;
        }

        private void UpdateListbox()
        {
            ProductsListBox.Items.Clear();  
            foreach (Product p in products)
            {
                ProductsListBox.Items.Add(p);
            }
            CalculateTotalValue();
        }

        private void CalculateTotalValue()
        {
            decimal total = 0m;
            foreach (Product p in products)
            {
                total += p.ProductValue();
            }
            TotalValueTextBox.Text = total.ToString("c");
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int index = ProductsListBox.SelectedIndex;
            products.Remove(products[index]);
            UpdateListbox();
            ProductsListBox.SelectedIndex = 0;
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StreamWriter write = new StreamWriter(DATA_FILE);
            foreach (Product prod in products)
            {
                write.WriteLine(prod.ToCsv());
            }
            write.Close();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
