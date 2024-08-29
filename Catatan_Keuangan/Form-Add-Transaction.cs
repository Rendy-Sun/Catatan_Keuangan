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
    public partial class Form_Add_Transaction : Form
    {
        SqlConnection conn = new SqlConnection(Database.getConnection());
        string idUser;
        public Form_Add_Transaction()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btChange_Click(object sender, EventArgs e)
        {
            dtpTransactionDate.Enabled = true;
        }

        private void Form_Add_Transaction_Load(object sender, EventArgs e)
        {
            dtpTransactionDate.Enabled = false;
            string query = "SELECT id FROM Users WHERE name='" + User_Data_Login.name + "' AND password='"+User_Data_Login.password+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable(); 
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                idUser = dt.Rows[0].ToString();
            }
            else {
                MessageBox.Show("Id User tidak di temukan");
            }
        }

        private void dtpTransactionDate_ValueChanged(object sender, EventArgs e)
        {
            dtpTransactionDate.Enabled = false;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            form_users form_Users = new form_users();
            form_Users.Show();
            this.Hide();
        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            if (tbTransactionName.Text == "" || tbTransactionDetail.Text == "" || tbTransactionPrice.Text == "")
            {
                MessageBox.Show("Data tidak boleh Kosong");
            }
            else if (idUser == null)
            {
                MessageBox.Show("Id User tidak di temukan!");
            }
            else {
                string query = "INSERT INTO User_Transaction (id_user,transaction_name, transaction_detail, transaction_price, transaction_date) " +
                    "VALUES('"+Convert.ToInt32(idUser)+"', '"+tbTransactionName.Text+"', '"+tbTransactionDetail.Text+"','"+tbTransactionPrice.Text+"', '"+Convert.ToDateTime(dtpTransactionDate.Text)+"')";
                SqlCommand cmd = new SqlCommand(query,conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Berhasil!");

            }
        }
    }
}
