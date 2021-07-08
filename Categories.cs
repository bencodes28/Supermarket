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
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-5I03T120\SQLEXPRESS;Initial Catalog=smarket;Integrated Security=True");
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "insert into catTable (CatID, CatName, CatDesc)" +
                    " values(" + cattextBox1.Text + ",'" + cattextBox2.Text + "','" + cattextBox3.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("category Added Sucessfully");
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
            string query = "select * from catTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
                Con.Close();
            }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //
        }

        private void Categories_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridView dataGridView1 = new DataGridView();
            dataGridView1.ColumnCount = 5;

            cattextBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            cattextBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            cattextBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

        }

        private void button7_Click(object sender, EventArgs e)
        {


            try
            {
                if(cattextBox1.Text== "")
                {
                    MessageBox.Show("Please enter the ID number of category u wish to delete.");

                }
                else
                {
                    Con.Open();
                    string query = "delete from catTable where CatId=" + cattextBox1.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("category deleted successfuly");

                    Con.Close();
                    populate();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);


            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "update catTable set CatName'" + cattextBox2.Text + "' , CatDesc='" + cattextBox3.Text + "'where CatId=" + cattextBox1.Text + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category successfully Updated");
                Con.Close();
                populate();


            }catch(Exception ex)

            {
                MessageBox.Show(ex.Message);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            product prod = new product();
            prod.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
             this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            seller login = new seller();
            login.Show();

        }
    }
    }

