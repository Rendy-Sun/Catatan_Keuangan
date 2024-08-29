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
    public partial class Form_Transaction : Form
    {
        SqlConnection conn = new SqlConnection(Database.getConnection());
        public Form_Transaction()
        {
            InitializeComponent();
        }
        public void showData()
        {
            string query = "SELECT * FROM User_Transaction";
            SqlDataAdapter adapter = new SqlDataAdapter(query,conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvTransaction.DataSource = dt;
        }

        private void Form_Transaction_Load(object sender, EventArgs e)
        {
            showData();
        }
    }
}
