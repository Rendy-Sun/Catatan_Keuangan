namespace Catatan_Keuangan
{
    partial class Form_Transaction
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvTransaction = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIDUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTransactionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTransactionDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTransactionPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTransactionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTransaction
            // 
            this.dgvTransaction.AllowUserToAddRows = false;
            this.dgvTransaction.AllowUserToDeleteRows = false;
            this.dgvTransaction.AllowUserToOrderColumns = true;
            this.dgvTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnIDUser,
            this.ColumnTransactionName,
            this.ColumnTransactionDetail,
            this.ColumnTransactionPrice,
            this.ColumnTransactionDate});
            this.dgvTransaction.Location = new System.Drawing.Point(210, 27);
            this.dgvTransaction.Name = "dgvTransaction";
            this.dgvTransaction.Size = new System.Drawing.Size(450, 356);
            this.dgvTransaction.TabIndex = 0;
            // 
            // ColumnID
            // 
            this.ColumnID.DataPropertyName = "id_transaction";
            this.ColumnID.HeaderText = "Transaction ID";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            this.ColumnID.Visible = false;
            // 
            // ColumnIDUser
            // 
            this.ColumnIDUser.DataPropertyName = "id_user";
            this.ColumnIDUser.HeaderText = "ID User";
            this.ColumnIDUser.Name = "ColumnIDUser";
            this.ColumnIDUser.ReadOnly = true;
            this.ColumnIDUser.Visible = false;
            // 
            // ColumnTransactionName
            // 
            this.ColumnTransactionName.DataPropertyName = "transaction_name";
            this.ColumnTransactionName.HeaderText = "Transaction Name";
            this.ColumnTransactionName.Name = "ColumnTransactionName";
            this.ColumnTransactionName.ReadOnly = true;
            // 
            // ColumnTransactionDetail
            // 
            this.ColumnTransactionDetail.DataPropertyName = "transaction_detail";
            this.ColumnTransactionDetail.HeaderText = "Transaction Detail";
            this.ColumnTransactionDetail.Name = "ColumnTransactionDetail";
            this.ColumnTransactionDetail.ReadOnly = true;
            // 
            // ColumnTransactionPrice
            // 
            this.ColumnTransactionPrice.DataPropertyName = "transaction_price";
            this.ColumnTransactionPrice.HeaderText = "Transaction Price";
            this.ColumnTransactionPrice.Name = "ColumnTransactionPrice";
            this.ColumnTransactionPrice.ReadOnly = true;
            // 
            // ColumnTransactionDate
            // 
            this.ColumnTransactionDate.DataPropertyName = "transaction_date";
            this.ColumnTransactionDate.HeaderText = "Transaction Date";
            this.ColumnTransactionDate.Name = "ColumnTransactionDate";
            this.ColumnTransactionDate.ReadOnly = true;
            // 
            // Form_Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 450);
            this.Controls.Add(this.dgvTransaction);
            this.Name = "Form_Transaction";
            this.Text = "Form_Transaction";
            this.Load += new System.EventHandler(this.Form_Transaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTransaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIDUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTransactionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTransactionDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTransactionPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTransactionDate;
    }
}