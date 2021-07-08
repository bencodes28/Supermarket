namespace SuperMarket
{
    partial class SellingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellingForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Logout = new System.Windows.Forms.Label();
            this.totalerlbl = new System.Windows.Forms.Label();
            this.amtlbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ORDERgridview = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quanity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addProduct = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pricetextBox5 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.DATE = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.BillsGridView1 = new System.Windows.Forms.DataGridView();
            this.button7 = new System.Windows.Forms.Button();
            this.print = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.quanitytextBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nametextBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.billtextBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ORDERgridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillsGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Logout);
            this.panel1.Controls.Add(this.totalerlbl);
            this.panel1.Controls.Add(this.amtlbl);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.ORDERgridview);
            this.panel1.Controls.Add(this.addProduct);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pricetextBox5);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.DATE);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.BillsGridView1);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.print);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.quanitytextBox3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.nametextBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.billtextBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Maiandra GD", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 482);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Logout
            // 
            this.Logout.AutoSize = true;
            this.Logout.ForeColor = System.Drawing.Color.White;
            this.Logout.Location = new System.Drawing.Point(759, 456);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(64, 19);
            this.Logout.TabIndex = 33;
            this.Logout.Text = "Logout";
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // totalerlbl
            // 
            this.totalerlbl.AutoSize = true;
            this.totalerlbl.BackColor = System.Drawing.Color.Maroon;
            this.totalerlbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.totalerlbl.Location = new System.Drawing.Point(759, 185);
            this.totalerlbl.Name = "totalerlbl";
            this.totalerlbl.Size = new System.Drawing.Size(57, 19);
            this.totalerlbl.TabIndex = 32;
            this.totalerlbl.Text = "label9";
            // 
            // amtlbl
            // 
            this.amtlbl.AutoSize = true;
            this.amtlbl.ForeColor = System.Drawing.Color.GhostWhite;
            this.amtlbl.Location = new System.Drawing.Point(534, 182);
            this.amtlbl.Name = "amtlbl";
            this.amtlbl.Size = new System.Drawing.Size(73, 19);
            this.amtlbl.TabIndex = 31;
            this.amtlbl.Text = "Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.GhostWhite;
            this.label6.Location = new System.Drawing.Point(615, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 19);
            this.label6.TabIndex = 30;
            this.label6.Text = "Sells List";
            // 
            // ORDERgridview
            // 
            this.ORDERgridview.BackgroundColor = System.Drawing.Color.White;
            this.ORDERgridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.ORDERgridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ORDERgridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.PName,
            this.Price,
            this.Quanity,
            this.Total});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Maiandra GD", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ORDERgridview.DefaultCellStyle = dataGridViewCellStyle1;
            this.ORDERgridview.Location = new System.Drawing.Point(438, 44);
            this.ORDERgridview.Name = "ORDERgridview";
            this.ORDERgridview.Size = new System.Drawing.Size(390, 138);
            this.ORDERgridview.TabIndex = 29;
            // 
            // id
            // 
            this.id.HeaderText = "Prodid";
            this.id.Name = "id";
            // 
            // PName
            // 
            this.PName.HeaderText = "ProdName";
            this.PName.Name = "PName";
            // 
            // Price
            // 
            this.Price.HeaderText = "ProdPrice";
            this.Price.Name = "Price";
            // 
            // Quanity
            // 
            this.Quanity.HeaderText = "Quanity";
            this.Quanity.Name = "Quanity";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // addProduct
            // 
            this.addProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addProduct.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.addProduct.Location = new System.Drawing.Point(134, 182);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(118, 30);
            this.addProduct.TabIndex = 28;
            this.addProduct.Text = "Add Product";
            this.addProduct.UseVisualStyleBackColor = true;
            this.addProduct.Click += new System.EventHandler(this.addProduct_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(24, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 21);
            this.label5.TabIndex = 27;
            this.label5.Text = "DATE";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // pricetextBox5
            // 
            this.pricetextBox5.Location = new System.Drawing.Point(107, 118);
            this.pricetextBox5.Name = "pricetextBox5";
            this.pricetextBox5.Size = new System.Drawing.Size(137, 27);
            this.pricetextBox5.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(5, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 24);
            this.label8.TabIndex = 25;
            this.label8.Text = "Price:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(-2, 218);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(235, 257);
            this.dataGridView2.TabIndex = 24;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(670, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 21);
            this.label7.TabIndex = 23;
            this.label7.Text = "DATE";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // DATE
            // 
            this.DATE.AutoSize = true;
            this.DATE.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DATE.Location = new System.Drawing.Point(1081, -131);
            this.DATE.Name = "DATE";
            this.DATE.Size = new System.Drawing.Size(42, 19);
            this.DATE.TabIndex = 22;
            this.DATE.Text = "Date";
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(239, 438);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(74, 37);
            this.button8.TabIndex = 20;
            this.button8.Text = "Refresh";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.ForeColor = System.Drawing.Color.Maroon;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(3, 182);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(125, 27);
            this.comboBox2.TabIndex = 19;
            this.comboBox2.Text = "Choose Role:";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // BillsGridView1
            // 
            this.BillsGridView1.BackgroundColor = System.Drawing.Color.White;
            this.BillsGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.BillsGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BillsGridView1.Location = new System.Drawing.Point(427, 297);
            this.BillsGridView1.Name = "BillsGridView1";
            this.BillsGridView1.Size = new System.Drawing.Size(401, 138);
            this.BillsGridView1.TabIndex = 18;
            this.BillsGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BillsGridView1_CellContentClick);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(705, 254);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 37);
            this.button7.TabIndex = 17;
            this.button7.Text = "DELETE";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // print
            // 
            this.print.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print.Location = new System.Drawing.Point(619, 254);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(75, 37);
            this.print.TabIndex = 16;
            this.print.Text = "PRINT";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(538, 254);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 37);
            this.button5.TabIndex = 15;
            this.button5.Text = "ADD";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // quanitytextBox3
            // 
            this.quanitytextBox3.Location = new System.Drawing.Point(107, 151);
            this.quanitytextBox3.Name = "quanitytextBox3";
            this.quanitytextBox3.Size = new System.Drawing.Size(137, 27);
            this.quanitytextBox3.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(5, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Quanity";
            // 
            // nametextBox2
            // 
            this.nametextBox2.Location = new System.Drawing.Point(107, 83);
            this.nametextBox2.Name = "nametextBox2";
            this.nametextBox2.Size = new System.Drawing.Size(137, 27);
            this.nametextBox2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(5, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name:";
            // 
            // billtextBox1
            // 
            this.billtextBox1.Location = new System.Drawing.Point(106, 45);
            this.billtextBox1.Name = "billtextBox1";
            this.billtextBox1.Size = new System.Drawing.Size(137, 27);
            this.billtextBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "BillID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(281, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "Selling";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // SellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 484);
            this.Controls.Add(this.panel1);
            this.Name = "SellingForm";
            this.Text = "SellingForm";
            this.Load += new System.EventHandler(this.SellingForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ORDERgridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillsGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView BillsGridView1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox quanitytextBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nametextBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox billtextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pricetextBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label DATE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label amtlbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView ORDERgridview;
        private System.Windows.Forms.Button addProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quanity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label totalerlbl;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label Logout;
    }
}