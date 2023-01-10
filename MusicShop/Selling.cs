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

namespace MusicShop
{
    public partial class Selling : Form
    {
        public Selling()
        {
            InitializeComponent();
        }

        private SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mafte\Documents\MusicShopDatabase.mdf;Integrated Security=True;Connect Timeout=30");

        private void PopulateDGV()
        {
            Con.Open();
            String query = "select Name,Price from InstrumentsTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            InstrumentDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Selling_Load(object sender, EventArgs e)
        {
            PopulateDGV();
        }

        private void InstrumentDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NameTb.Text = InstrumentDGV.SelectedRows[0].Cells[0].Value.ToString();
            PriceTb.Text = InstrumentDGV.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void FilterSearch()
        {
            Con.Open();
            String query = "select Name,Price from InstrumentsTable where Brand='" + BrandSearch.SelectedItem.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            InstrumentDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void BrandSearch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FilterSearch();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            PopulateDGV();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide(); 
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            NameTb.Text = "";
            QtyTb.Text = "";
            PriceTb.Text = "";
        }

        int nRow = 0, GridTotal = 0;

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (NameTb.Text == "" || PriceTb.Text == "" || QtyTb.Text == "")
            {
                MessageBox.Show("Please select an item first and enter quantity");
            }
            else
            {
                int total = Convert.ToInt32(QtyTb.Text) * Convert.ToInt32(PriceTb.Text);
                DataGridViewRow newRow = new DataGridViewRow();

                newRow.CreateCells(billsDGV);
                newRow.Cells[0].Value = nRow + 1;
                newRow.Cells[1].Value = NameTb.Text;
                newRow.Cells[2].Value = PriceTb.Text;
                newRow.Cells[3].Value = QtyTb.Text;
                newRow.Cells[4].Value = total;
                billsDGV.Rows.Add(newRow);
                nRow++;

                GridTotal = GridTotal + total;
                AmountLabel.Text = "TOTAL BILL AMOUNT: " + GridTotal;
            }
        }

        private void sendBillToDatabase()
        {
            string date;
            date = DateTime.Today.Date.ToString();
            
            try
            {
                Con.Open();
                string query = "insert into BillTable values("+GridTotal+", '"+date+"')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Bill added successfully");
                Con.Close();
                PopulateDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } 

        private void btn_print_Click(object sender, EventArgs e)
        {
            printDocument.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("print", 300, 500);
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
            sendBillToDatabase();
        }

        int itemID, itemQty, itemPrice, total, pos = 60;
        string itemName;

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Music Shop Client Bill", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Crimson, new Point(80));
            e.Graphics.DrawString("ID  INSTRUMENT  PRICE  QUANTITY  TOTAL", new Font("Century Gothic", 10, FontStyle.Regular), Brushes.Black, new Point(5, 20));

            foreach(DataGridViewRow row in billsDGV.Rows)
            {
                itemID = Convert.ToInt32(row.Cells["Column1"].Value);
                itemName = "" + row.Cells["Column2"].Value;
                itemPrice = Convert.ToInt32(row.Cells["Column3"].Value);
                itemQty = Convert.ToInt32(row.Cells["Column4"].Value);
                total = Convert.ToInt32(row.Cells["Column5"].Value);

                e.Graphics.DrawString("" + itemID, new Font("Century Gothic", 10, FontStyle.Regular), Brushes.Black, new Point(5, pos));
                e.Graphics.DrawString("" + itemName, new Font("Century Gothic", 10, FontStyle.Regular), Brushes.Black, new Point(25, pos));
                e.Graphics.DrawString("" + itemPrice, new Font("Century Gothic", 10, FontStyle.Regular), Brushes.Black, new Point(125, pos));
                e.Graphics.DrawString("" + itemQty, new Font("Century Gothic", 10, FontStyle.Regular), Brushes.Black, new Point(200, pos));
                e.Graphics.DrawString("" + total, new Font("Century Gothic", 10, FontStyle.Regular), Brushes.Black, new Point(250, pos));

                pos = pos + 20;

            }
            e.Graphics.DrawString("Total Bill: " + GridTotal, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Crimson, new Point(80, 200));
            e.Graphics.DrawString("Thank you for shopping!", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Black, new Point(50, 230));
        }
    }
}
