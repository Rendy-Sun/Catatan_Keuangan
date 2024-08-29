using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catatan_Keuangan
{
    public partial class form_users : Form
    {
        public form_users()
        {
            InitializeComponent();
        }

        private void tbTransactionMenu_Click(object sender, EventArgs e)
        {
            Form_Transaction form_Transaction = new Form_Transaction();
            form_Transaction.Show();
            this.Hide();
        }

        private void form_users_Load(object sender, EventArgs e)
        {

        }

        private void btAddTransaction_Click(object sender, EventArgs e)
        {
            Form_Add_Transaction frm = new Form_Add_Transaction();
            frm.Show();
            this.Hide();

        }
    }
}
