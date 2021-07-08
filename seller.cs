using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SuperMarket
{
    public partial class seller : Form
    {
        public seller()
        {
            InitializeComponent();
            populate();
        }
        int flag = 0;
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-5I03T120\SQLEXPRESS;Initial Catalog=smarket;Integrated Security=True");

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void populate()
        {
            Con.Open();
            string query = "select * from Seller";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();


        }
        private void seller_Load(object sender, EventArgs e)
        {

            populate();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            product prod = new product();
            prod.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Categories cat = new Categories();
            cat.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "insert into Seller (sellerId, Sellername, SellerAge, Sellerphone, Sellerpass)" +
                    " values(" + textBox1.Text + ",'" + textBox2.Text + "','" + textBox3.Text + "', '" + textBox5.Text + "', '" + textBox4.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item Added Sucessfully");
                Con.Close();

                  populate();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Please enter the ID number of product u wish to delete.");

                }
               
                else
                {
                    Con.Open();
                    string query = "delete from Seller where sellerId=" + textBox1.Text + "";

                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("item deleted successfuly");

                    Con.Close();
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }
    }
    }
