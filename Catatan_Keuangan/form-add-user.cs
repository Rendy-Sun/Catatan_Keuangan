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
    public partial class form_add_user : Form
    {
        SqlConnection conn = new SqlConnection(Database.getConnection());
        public form_add_user()
        {
            InitializeComponent();
        }

        private void form_add_user_Load(object sender, EventArgs e)
        {
            if (User_Data_Login.role == "Admin")
            {
                lbRole.Enabled = true;
                cbRole.Enabled = true;
                lbLogin.Enabled = false;
                lbLogin.Hide();

                string[] roleArray = { "Admin", "User" };
                for (int i = 0; i < roleArray.Length; i++)
                {
                    cbRole.Items.Add(roleArray[i]);
                }
            }
            else if (User_Data_Login.role == "User")
            {
                lbRole.Enabled = false;
                cbRole.Enabled = false;
                cbRole.Hide();
                lbLogin.Enabled = false;
                lbRole.Hide();
                lbLogin.Hide();
            }
            else if (User_Data_Login.role == "" || User_Data_Login.role == null)
            {
                lbLogin.Enabled = true;
                cbRole.Enabled= false;
                cbRole.Hide();
                lbRole.Hide();
                lbLogin.Show();
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void clearValue()
        {
            tbName.Text = string.Empty;
            tbPassword.Text = string.Empty; 
            cbRole.Text = string.Empty;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            string query="";
            if (User_Data_Login.role == "Admin" && tbName.Text != "" || tbPassword.Text != "" || cbRole.Text != "")
            {
                query = "INSERT INTO Users (name, password, role) VALUES ('"+tbName.Text+"','"+tbPassword.Text+"','"+cbRole.Text+"')";
                SqlCommand cmd = new SqlCommand(query,conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Buat Akun Berhasil!");
                clearValue();
                query = "";
            }
            else if (User_Data_Login.role == "User" && tbName.Text != "" || tbPassword.Text != "" || cbRole.Text != "")
            {
                string valueRole = "User";
                query = "INSERT INTO Users (name, password, role) VALUES ('" + tbName.Text + "', '" + tbPassword.Text + "', '" + valueRole + "')";
                SqlCommand cmd = new SqlCommand(query,conn);
                conn.Open();
                cmd.ExecuteNonQuery(); 
                conn.Close();
                MessageBox.Show("Buat Akun Berhasil!");
                clearValue();
                query = "";
            }
            else
            {
                MessageBox.Show("Tidak boleh kosong!");
            }
        }

        private void lbLogin_Click(object sender, EventArgs e)
        {
            Form1 frmLogin = new Form1();
            frmLogin.Show();
            this.Hide();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            if (User_Data_Login.role == "Admin")
            {
                form_admin frmAdmin = new form_admin();
                frmAdmin.Show();
                this.Hide();
            }
            else if (User_Data_Login.role == "User")
            {

            }
            else if (User_Data_Login.role == "" || User_Data_Login.role == null)
            { 
                Form1 frmlogin= new Form1();
                frmlogin.Show();
                this.Hide();
            }
        }
    }
}
