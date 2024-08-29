namespace Catatan_Keuangan
{
    partial class form_users
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
            this.tbTransactionList = new System.Windows.Forms.Button();
            this.btAddTransaction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbTransactionList
            // 
            this.tbTransactionList.Location = new System.Drawing.Point(39, 36);
            this.tbTransactionList.Name = "tbTransactionList";
            this.tbTransactionList.Size = new System.Drawing.Size(119, 23);
            this.tbTransactionList.TabIndex = 0;
            this.tbTransactionList.Text = "Transaction List";
            this.tbTransactionList.UseVisualStyleBackColor = true;
            this.tbTransactionList.Click += new System.EventHandler(this.tbTransactionMenu_Click);
            // 
            // btAddTransaction
            // 
            this.btAddTransaction.Location = new System.Drawing.Point(39, 81);
            this.btAddTransaction.Name = "btAddTransaction";
            this.btAddTransaction.Size = new System.Drawing.Size(119, 23);
            this.btAddTransaction.TabIndex = 1;
            this.btAddTransaction.Text = "Add Transaction";
            this.btAddTransaction.UseVisualStyleBackColor = true;
            this.btAddTransaction.Click += new System.EventHandler(this.btAddTransaction_Click);
            // 
            // form_users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 206);
            this.Controls.Add(this.btAddTransaction);
            this.Controls.Add(this.tbTransactionList);
            this.Name = "form_users";
            this.Text = "form_users";
            this.Load += new System.EventHandler(this.form_users_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tbTransactionList;
        private System.Windows.Forms.Button btAddTransaction;
    }
}