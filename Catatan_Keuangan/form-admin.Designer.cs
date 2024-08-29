namespace Catatan_Keuangan
{
    partial class form_admin
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
            this.btListUsers = new System.Windows.Forms.Button();
            this.btAddUser = new System.Windows.Forms.Button();
            this.btLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btListUsers
            // 
            this.btListUsers.Location = new System.Drawing.Point(48, 55);
            this.btListUsers.Name = "btListUsers";
            this.btListUsers.Size = new System.Drawing.Size(75, 23);
            this.btListUsers.TabIndex = 0;
            this.btListUsers.Text = "List Users";
            this.btListUsers.UseVisualStyleBackColor = true;
            this.btListUsers.Click += new System.EventHandler(this.btListUsers_Click);
            // 
            // btAddUser
            // 
            this.btAddUser.Location = new System.Drawing.Point(48, 100);
            this.btAddUser.Name = "btAddUser";
            this.btAddUser.Size = new System.Drawing.Size(75, 23);
            this.btAddUser.TabIndex = 1;
            this.btAddUser.Text = "Add User";
            this.btAddUser.UseVisualStyleBackColor = true;
            this.btAddUser.Click += new System.EventHandler(this.btAddUser_Click);
            // 
            // btLogout
            // 
            this.btLogout.Location = new System.Drawing.Point(48, 147);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(75, 23);
            this.btLogout.TabIndex = 4;
            this.btLogout.Text = "Log Out";
            this.btLogout.UseVisualStyleBackColor = true;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // form_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 387);
            this.Controls.Add(this.btLogout);
            this.Controls.Add(this.btAddUser);
            this.Controls.Add(this.btListUsers);
            this.Name = "form_admin";
            this.Text = "form_admin";
            this.Load += new System.EventHandler(this.form_admin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btListUsers;
        private System.Windows.Forms.Button btAddUser;
        private System.Windows.Forms.Button btLogout;
    }
}