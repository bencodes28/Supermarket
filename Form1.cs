using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        public static string sellername = "";
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-5I03T120\SQLEXPRESS;Initial Catalog=smarket;Integrated Security=True");

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Goodbye!");
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please enter user or password please.");
            }
            else
            {
                if (comboBox1.SelectedIndex > -1)
                {
                    if (comboBox1.SelectedItem.ToString() == "Admin")
                    {
                        if (textBox1.Text == "admin" && textBox2.Text == "pass")
                        {
                            product prod = new product();
                            prod.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("If you are the Admin, Enter the Correct Id and the Password please.");

                        }
                    }
                    else
                    {
                        MessageBox.Show("You're in the Seller Section.");
                        Con.Open();
                        SqlDataAdapter sda = new SqlDataAdapter("Select Count(8) from Seller where Sellername= '" + textBox1.Text + "' and Sellerpass= '" + textBox2.Text + "'", Con);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        //  if (dt.Rows[0][0].ToString() == "1")

                        sellername = textBox1.Text;
                        SellingForm sell = new SellingForm();
                        sell.Show();
                        this.Hide();
                        Con.Close();
                    
              
                        Con.Close();
                    }
                   
                }
                else
                {
                    MessageBox.Show("Select a role please");
                }
                }
        }
        
                
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.SelectedItem = "Admin";

        }
    }
}
