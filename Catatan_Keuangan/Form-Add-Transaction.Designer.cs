namespace Catatan_Keuangan
{
    partial class Form_Add_Transaction
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTransactionPrice = new System.Windows.Forms.TextBox();
            this.tbTransactionDetail = new System.Windows.Forms.TextBox();
            this.tbTransactionName = new System.Windows.Forms.TextBox();
            this.dtpTransactionDate = new System.Windows.Forms.DateTimePicker();
            this.btCancel = new System.Windows.Forms.Button();
            this.btSubmit = new System.Windows.Forms.Button();
            this.btChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transaction Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Transaction Detail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Transaction Date";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Transaction Price";
            // 
            // tbTransactionPrice
            // 
            this.tbTransactionPrice.Location = new System.Drawing.Point(162, 120);
            this.tbTransactionPrice.Name = "tbTransactionPrice";
            this.tbTransactionPrice.Size = new System.Drawing.Size(150, 20);
            this.tbTransactionPrice.TabIndex = 4;
            // 
            // tbTransactionDetail
            // 
            this.tbTransactionDetail.Location = new System.Drawing.Point(162, 82);
            this.tbTransactionDetail.Name = "tbTransactionDetail";
            this.tbTransactionDetail.Size = new System.Drawing.Size(150, 20);
            this.tbTransactionDetail.TabIndex = 5;
            // 
            // tbTransactionName
            // 
            this.tbTransactionName.Location = new System.Drawing.Point(162, 41);
            this.tbTransactionName.Name = "tbTransactionName";
            this.tbTransactionName.Size = new System.Drawing.Size(150, 20);
            this.tbTransactionName.TabIndex = 6;
            // 
            // dtpTransactionDate
            // 
            this.dtpTransactionDate.Location = new System.Drawing.Point(162, 162);
            this.dtpTransactionDate.Name = "dtpTransactionDate";
            this.dtpTransactionDate.Size = new System.Drawing.Size(200, 20);
            this.dtpTransactionDate.TabIndex = 7;
            this.dtpTransactionDate.ValueChanged += new System.EventHandler(this.dtpTransactionDate_ValueChanged);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(52, 213);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 8;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btSubmit
            // 
            this.btSubmit.Location = new System.Drawing.Point(237, 213);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(75, 23);
            this.btSubmit.TabIndex = 9;
            this.btSubmit.Text = "Submit";
            this.btSubmit.UseVisualStyleBackColor = true;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // btChange
            // 
            this.btChange.Location = new System.Drawing.Point(382, 162);
            this.btChange.Name = "btChange";
            this.btChange.Size = new System.Drawing.Size(63, 23);
            this.btChange.TabIndex = 10;
            this.btChange.Text = "Change";
            this.btChange.UseVisualStyleBackColor = true;
            this.btChange.Click += new System.EventHandler(this.btChange_Click);
            // 
            // Form_Add_Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 324);
            this.Controls.Add(this.btChange);
            this.Controls.Add(this.btSubmit);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.dtpTransactionDate);
            this.Controls.Add(this.tbTransactionName);
            this.Controls.Add(this.tbTransactionDetail);
            this.Controls.Add(this.tbTransactionPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Add_Transaction";
            this.Text = "Form_Add_Transaction";
            this.Load += new System.EventHandler(this.Form_Add_Transaction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTransactionPrice;
        private System.Windows.Forms.TextBox tbTransactionDetail;
        private System.Windows.Forms.TextBox tbTransactionName;
        private System.Windows.Forms.DateTimePicker dtpTransactionDate;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btSubmit;
        private System.Windows.Forms.Button btChange;
    }
}