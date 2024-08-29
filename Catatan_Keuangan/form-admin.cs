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
    public partial class form_admin : Form
    {
        SqlConnection connection = new SqlConnection(Database.getConnection());
        public form_admin()
        {
            InitializeComponent();
        }

        private void clearValue()
        {
            User_Data_Login.role = null;
        }

        private void btAddUser_Click(object sender, EventArgs e)
        {
            form_add_user addUser = new form_add_user();
            addUser.Show();
            this.Close();
        }

        private void form_admin_Load(object sender, EventArgs e)
        {
            try {
                connection.Open();
                connection.Close();
            }
            catch {
                MessageBox.Show("Connection to Database has been terminated! Please Try Again!");
            }
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            clearValue();
            Form1 frmLogin = new Form1();
            frmLogin.Show();
            this.Hide();
        }

        private void btDeleteUser_Click(object sender, EventArgs e)
        {

        }

        private void btListUsers_Click(object sender, EventArgs e)
        {
            form_list_user listUsers = new form_list_user();
            listUsers.Show();
            this.Hide();
        }
    }
}
