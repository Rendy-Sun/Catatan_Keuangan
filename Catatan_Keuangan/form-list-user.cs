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
    public partial class form_list_user : Form
    {
        SqlConnection conn = new SqlConnection(Database.getConnection());
        string idSelected, nameSelected;
        public form_list_user()
        {
            InitializeComponent();
        }

        private void ShowData()
        {
            string query = "SELECT * FROM Users";
            SqlDataAdapter sda = new SqlDataAdapter(query,conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvListUsers.DataSource = dt;
        }

        private void form_list_user_Load(object sender, EventArgs e)
        {
            ShowData();    
        }

        private void DeleteData()
        {
            if (idSelected != null || idSelected == "")
            {
                string query = "DELETE FROM Users WHERE id='" + Convert.ToInt32(idSelected) + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            else
            {
                MessageBox.Show("Error Delete Data! User tidak boleh kosong!");
            }
          
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            form_admin frmAdmin = new form_admin();
            frmAdmin.Show();
            this.Hide();
        }

        private void dgvListUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idSelected = dgvListUsers.CurrentRow.Cells["ColumnId"].Value.ToString();
            nameSelected = dgvListUsers.CurrentRow.Cells["ColumnName"].Value.ToString();
            int editButton = 0;
            int deleteButton = 1;
            if (e.ColumnIndex == editButton)
            {
                Form_Edit_User frmEdit = new Form_Edit_User();
                Edit_User_Data.getSelectedId = idSelected;
                Edit_User_Data.getSelectedName = nameSelected;
                this.Hide();
                frmEdit.Show();
            }
            else if (e.ColumnIndex == deleteButton)
            {
                var confirmation = MessageBox.Show("Are you sure want to edit this user?", "Confirmation", MessageBoxButtons.YesNo);
                if (confirmation == DialogResult.Yes)
                {
                    DeleteData();
                    ShowData();
                }
                else if(confirmation == DialogResult.No)
                {

                }
            }
        }
    }
}
