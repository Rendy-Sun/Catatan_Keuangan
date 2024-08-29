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

namespace Catatan_Keuangan
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection(Database.getConnection());
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try {
                connection.Open();
                connection.Close();
            }
            catch {
                MessageBox.Show("Gagal Menghubungkan Database");
            }
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Name and Password Cannot be Empty!");
            }
            else
            {
                string query = "SELECT * FROM Users WHERE name='" + tbName.Text + "' AND password='" + tbPassword.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    string roleUser = dt.Rows[0]["role"].ToString();
                    User_Data_Login.name = dt.Rows[0]["name"].ToString();
                    User_Data_Login.password = dt.Rows[0]["password"].ToString();
                    User_Data_Login.role = roleUser;
                    if (roleUser == "Admin")
                    {
                        form_admin form_Admin = new form_admin();
                        form_Admin.Show();
                        this.Hide();
                    }
                    else if (roleUser == "User")
                    {
                        form_users form_Users = new form_users();
                        form_Users.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("User tidak di temukan");
                };
            }
        }

        private void lbRegisterAccount_Click(object sender, EventArgs e)
        {
            form_add_user frmAddUser = new form_add_user();
            frmAddUser.Show();
            this.Hide();
        }
    }
}
