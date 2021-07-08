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
    public partial class product : Form
    {
        public product()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-5I03T120\SQLEXPRESS;Initial Catalog=smarket;Integrated Security=True");
        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("GoodBye!");
            Close();
            this.Hide();
            SellingForm sellers = new SellingForm();
            sellers.Show();

        }
        private void fillCombo()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select CatName from catTable", Con);
            SqlDataReader ndr;
            ndr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CatName", typeof(string));
            dt.Load(ndr);
            comboBox1.ValueMember = "CatName";
            comboBox1.DataSource = dt;

            Con.Close();
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

                string selected = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
                Con.Open();
                string query = "insert into [Table] (Prodid, Prodname, prodqty, prodprice, prodcat)" +
                    " values(" + textBox1.Text + ",'" + textBox2.Text + "','" + textBox3.Text + "', '" + textBox4.Text + "', '"+ selected +"')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("product Added Sucessfully");
                Con.Close();

                  populate();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Con.Close();
            }
        }

        private void populate()
        {
            Con.Open();
            string query = "select * from [Table]";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            prodGridView1.DataSource = ds.Tables[0];
            Con.Close();

        }
        private void product_Load(object sender, EventArgs e)
        {
            fillCombo();
            populate();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = prodGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = prodGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = prodGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = prodGridView1.SelectedRows[0].Cells[3].Value.ToString(); 
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
                    string query = "delete from [Table] where Prodid=" + textBox1.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("category deleted successfuly");

                    Con.Close();
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Con.Open();
            string query = "select * from [Table]";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            prodGridView1.DataSource = ds.Tables[0];
            Con.Close();
            populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
             seller  m= new seller();
            m.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }
    }
    }
