using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MusicShop
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mafte\Documents\MusicShopDatabase.mdf;Integrated Security=True;Connect Timeout=30");

        private void bnt_resetUserInfo_Click(object sender, EventArgs e)
        {
            txt_username.Text = "";
            txt_password.Text = "";
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from AdminTable where AdminName='" + txt_username.Text + "' and AdminPassword='" + txt_password.Text + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                Instruments inst = new Instruments();
                inst.Show();
                this.Hide();
                Con.Close();
            }
            else
            {
                MessageBox.Show("Incorrect username/password");
            }

            Con.Close();
        }

        private void continueAsSeller_label_Click(object sender, EventArgs e)
        {
            Selling sel = new Selling();
            sel.Show();
            this.Hide();
        }
    }
}