using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MusicShop
{
    public partial class Instruments : Form
    {
        public Instruments()
        {
            InitializeComponent();
        }

        private SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mafte\Documents\MusicShopDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        private int InstKey;

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (NameTb.Text == "" || PriceTb.Text == "" || QtyTb.Text == "")
            {
                MessageBox.Show("Please complete all fields");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into InstrumentsTable values('" + NameTb.Text + "', '" + BrandTb.SelectedItem.ToString() + "', " + QtyTb.Text + ", " + PriceTb.Text + ", '" + CatTb.SelectedItem.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Instrument added successfully");
                    Con.Close();
                    PopulateDGV();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (NameTb.Text == "")
            {
                MessageBox.Show("Please select instrument to delete");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from InstrumentsTable where Id=" + InstKey + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Instrument deleted successfully");
                    Con.Close();
                    PopulateDGV();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void InstrumentDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            InstKey = Convert.ToInt32(InstrumentDGV.SelectedRows[0].Cells[0].Value.ToString());
            NameTb.Text = InstrumentDGV.SelectedRows[0].Cells[1].Value.ToString();
            BrandTb.Text = InstrumentDGV.SelectedRows[0].Cells[2].Value.ToString();
            QtyTb.Text = InstrumentDGV.SelectedRows[0].Cells[3].Value.ToString();
            PriceTb.Text = InstrumentDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void PopulateDGV()
        {
            Con.Open();
            String query = "select * from InstrumentsTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            InstrumentDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Instruments_Load(object sender, EventArgs e)
        {
            PopulateDGV();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (NameTb.Text == "" || PriceTb.Text == "" || QtyTb.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update InstrumentsTable set Name='" + NameTb.Text + "', Brand='" + BrandTb.SelectedItem.ToString() + "', Quantity='" + QtyTb.Text + "', Price='" + PriceTb.Text + "', Category='" + CatTb.SelectedItem.ToString() + "' where Id=" + InstKey + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Instrument updated successfully");
                    Con.Close();
                    PopulateDGV();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void FilterSearch()
        {
            Con.Open();
            String query = "select * from InstrumentsTable where Brand='" + BrandSearch.SelectedItem.ToString() + "'";
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

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (newPass.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update AdminTable set AdminPassword='" + newPass.Text + "' where Id=" + 1 + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Password updated successfully");
                    Con.Close();
                    Login log = new Login();
                    log.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
    }
}