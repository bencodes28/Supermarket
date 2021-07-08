using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace SuperMarket
{
    public partial class SellingForm : Form
    {
        public SellingForm()
        {
            InitializeComponent();
        }
        int flag = 0;
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-5I03T120\SQLEXPRESS;Initial Catalog=smarket;Integrated Security=True");

        private void populate()
        {

            Con.Open();
            string query = "select Prodname, prodqty from [Table]";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            Con.Close();

        }
        private void populatebills()
        {
            Con.Open();
            string query = "select * from Extra";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BillsGridView1.DataSource = ds.Tables[0];
            Con.Close();

        }

        private void SellingForm_Load(object sender, EventArgs e)
        {
            populate();
            populatebills();
            fillCombo();
            label5.Text = Form1.sellername;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //textBox2.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            //textBox3.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            label7.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/ " + DateTime.Today.Year.ToString();
            //  label5.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/ " + DateTime.Today.Year.ToString();

            label5.Text = Form1.sellername;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void addProduct_Click(object sender, EventArgs e)
        {
            int n = 0, total= Convert.ToInt32(pricetextBox5.Text)* Convert.ToInt32(quanitytextBox3.Text);
           
            int grandtotal = 0;
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.CreateCells(ORDERgridview);

            newRow.Cells[0].Value = n + 1;
            newRow.Cells[1].Value = billtextBox1.Text;
            newRow.Cells[2].Value = nametextBox2.Text;
            newRow.Cells[3].Value = pricetextBox5.Text;
            newRow.Cells[4].Value = Convert.ToInt32(quanitytextBox3.Text)* Convert.ToInt32(pricetextBox5.Text);

            ORDERgridview.Rows.Add(newRow);
            n++;
            grandtotal = total;
            
            totalerlbl.Text  = "" +grandtotal ;
            grandtotal = total;


        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "insert into Extra (Billid, SellerName, BillDate, TotAmt)" +
                    " values(" + billtextBox1.Text + ",'" + label5.Text + "','" + label7.Text + "', '" + quanitytextBox3.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("order Added Sucessfully");
                Con.Close();
                populate();
                populatebills();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Con.Close();
            }
        }

        private void print_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                

                printDocument1.Print();

            }
        }

        private void BillsGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            flag = 1;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("The Super Markert", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.CornflowerBlue, new Point(230));

            e.Graphics.DrawString("Bill ID:"+BillsGridView1.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century Gothic", 25, FontStyle.Bold), Brushes.CornflowerBlue, new Point(100,70));

            e.Graphics.DrawString("Seller Name:" + BillsGridView1.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century Gothic", 25, FontStyle.Bold), Brushes.CornflowerBlue, new Point(100, 100));
            e.Graphics.DrawString("Date:" + BillsGridView1.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century Gothic", 25, FontStyle.Bold), Brushes.CornflowerBlue, new Point(100, 130));
            e.Graphics.DrawString("Total Amount:" + BillsGridView1.SelectedRows[0].Cells[3].Value.ToString(), new Font("Century Gothic", 25, FontStyle.Bold), Brushes.CornflowerBlue, new Point(100, 160));



        }

        private void button8_Click(object sender, EventArgs e)
        {
            populate();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Con.Open();
            string query = "select * from [Table]";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            Con.Close();
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
          //  comboBox1.ValueMember = "CatName";
           // comboBox1.DataSource = dt;

            Con.Close();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
               try
            {
                if(billtextBox1.Text== "")
                {
                    MessageBox.Show("Please enter the ID number of category u wish to delete.");

                }
                else
                {
                    Con.Open();
                    string query = "delete from Extra where Billid=" + billtextBox1.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("item deleted successfuly");

                    Con.Close();
                    populatebills();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);


            }
        }
    }

}
