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
    public partial class Form_Edit_User : Form
    {
        SqlConnection conn = new SqlConnection(Database.getConnection());
        public Form_Edit_User()
        {
            InitializeComponent();
        }

        private void UpdateData() {
            if (User_Data_Login.role == "Admin")
            {
                string idUser = Edit_User_Data.getSelectedId;
                string query = "UPDATE Users SET name='" + tbName.Text + "', password='" + tbPassword.Text + "', role='" + cbRole.Text + "' WHERE id = '" + Convert.ToInt32(idUser) + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            else if (User_Data_Login.role == "User")
            {
                string idUser = Edit_User_Data.getSelectedId;
                string query = "UPDATE Users SET name='" + tbName.Text + "', password='" + tbPassword.Text + "', role='User' WHERE id = '" + Convert.ToInt32(idUser) + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            else {
                MessageBox.Show("Error Update");
            }
            
        }

        private void roleItems() {
            string[] role = { "Admin","User"};
            for (int i = 0; i<role.Length;i++) {
                cbRole.Items.Add(role[i]);
            }
        }
        private void Form_Edit_User_Load(object sender, EventArgs e)
        {
            roleItems();
            if (User_Data_Login.role == "Admin")
            {
                tbName.Text = Edit_User_Data.getSelectedName;
                lbRole.Enabled = true;
                cbRole.Enabled = true;
            }
            else if (User_Data_Login.role == "User")
            {
                tbName.Text = Edit_User_Data.getSelectedName;
                lbRole.Enabled = false;
                cbRole.Enabled = false;
            }
            else {
                MessageBox.Show("Error");
            }
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || tbPassword.Text == "" || cbRole.Text == "" && User_Data_Login.role == "Admin")
            {
                MessageBox.Show("Nama, Password dan Role tidak boleh kosong!");
            }
            else if (tbName.Text == "" || tbPassword.Text == "" && User_Data_Login.role == "User")
            {
                MessageBox.Show("Nama dan Password tidak boleh kosong!");
            }
            else {
                var confirmation = MessageBox.Show("Are you sure want to edit this user data?", "Confirmation", MessageBoxButtons.YesNo);
                if (confirmation == DialogResult.Yes)
                {
                    UpdateData();
                    form_list_user listUser = new form_list_user();
                    listUser.Show();
                    this.Hide();

                }
                else if (confirmation == DialogResult.No)
                {

                }
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_list_user form = new form_list_user();
            form.Show();
        }
    }
}
