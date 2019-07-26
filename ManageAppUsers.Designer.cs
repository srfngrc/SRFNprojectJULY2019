namespace SRFNprojectJULY2019proj
{
    partial class ManageAppUsers
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
            this.DataGridViewLOGINS = new System.Windows.Forms.DataGridView();
            this.loginId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passWord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LBLloginId = new System.Windows.Forms.Label();
            this.LBLUserName = new System.Windows.Forms.Label();
            this.LBLPassw = new System.Windows.Forms.Label();
            this.LBLdescrip = new System.Windows.Forms.Label();
            this.LBLisAdmin = new System.Windows.Forms.Label();
            this.TBloginId = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.PBupdateLogins = new System.Windows.Forms.PictureBox();
            this.PBdeleteLogins = new System.Windows.Forms.PictureBox();
            this.BTNok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewLOGINS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBupdateLogins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBdeleteLogins)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewLOGINS
            // 
            this.DataGridViewLOGINS.AllowUserToAddRows = false;
            this.DataGridViewLOGINS.AllowUserToDeleteRows = false;
            this.DataGridViewLOGINS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewLOGINS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.loginId,
            this.userName,
            this.passWord,
            this.description,
            this.isAdmin});
            this.DataGridViewLOGINS.Location = new System.Drawing.Point(38, 25);
            this.DataGridViewLOGINS.Name = "DataGridViewLOGINS";
            this.DataGridViewLOGINS.ReadOnly = true;
            this.DataGridViewLOGINS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewLOGINS.Size = new System.Drawing.Size(541, 271);
            this.DataGridViewLOGINS.TabIndex = 0;
            this.DataGridViewLOGINS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewLOGINS_CellContentClick);
            this.DataGridViewLOGINS.SelectionChanged += new System.EventHandler(this.SelectionChangetLOGINS);
            // 
            // loginId
            // 
            this.loginId.DataPropertyName = "loginId";
            this.loginId.HeaderText = "Login Id";
            this.loginId.Name = "loginId";
            this.loginId.ReadOnly = true;
            // 
            // userName
            // 
            this.userName.DataPropertyName = "userName";
            this.userName.HeaderText = "User Name";
            this.userName.Name = "userName";
            this.userName.ReadOnly = true;
            // 
            // passWord
            // 
            this.passWord.DataPropertyName = "passWord";
            this.passWord.HeaderText = "Password";
            this.passWord.Name = "passWord";
            this.passWord.ReadOnly = true;
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // isAdmin
            // 
            this.isAdmin.DataPropertyName = "isAdmin";
            this.isAdmin.HeaderText = "Type of User";
            this.isAdmin.Name = "isAdmin";
            this.isAdmin.ReadOnly = true;
            // 
            // LBLloginId
            // 
            this.LBLloginId.AutoSize = true;
            this.LBLloginId.Location = new System.Drawing.Point(42, 328);
            this.LBLloginId.Name = "LBLloginId";
            this.LBLloginId.Size = new System.Drawing.Size(48, 13);
            this.LBLloginId.TabIndex = 1;
            this.LBLloginId.Text = "LoginId: ";
            // 
            // LBLUserName
            // 
            this.LBLUserName.AutoSize = true;
            this.LBLUserName.Location = new System.Drawing.Point(42, 360);
            this.LBLUserName.Name = "LBLUserName";
            this.LBLUserName.Size = new System.Drawing.Size(63, 13);
            this.LBLUserName.TabIndex = 2;
            this.LBLUserName.Text = "User Name:";
            // 
            // LBLPassw
            // 
            this.LBLPassw.AutoSize = true;
            this.LBLPassw.Location = new System.Drawing.Point(42, 391);
            this.LBLPassw.Name = "LBLPassw";
            this.LBLPassw.Size = new System.Drawing.Size(59, 13);
            this.LBLPassw.TabIndex = 3;
            this.LBLPassw.Text = "Password: ";
            // 
            // LBLdescrip
            // 
            this.LBLdescrip.AutoSize = true;
            this.LBLdescrip.Location = new System.Drawing.Point(42, 421);
            this.LBLdescrip.Name = "LBLdescrip";
            this.LBLdescrip.Size = new System.Drawing.Size(63, 13);
            this.LBLdescrip.TabIndex = 4;
            this.LBLdescrip.Text = "Description:";
            // 
            // LBLisAdmin
            // 
            this.LBLisAdmin.AutoSize = true;
            this.LBLisAdmin.Location = new System.Drawing.Point(42, 455);
            this.LBLisAdmin.Name = "LBLisAdmin";
            this.LBLisAdmin.Size = new System.Drawing.Size(56, 13);
            this.LBLisAdmin.TabIndex = 5;
            this.LBLisAdmin.Text = "Is Admin? ";
            // 
            // TBloginId
            // 
            this.TBloginId.Location = new System.Drawing.Point(129, 325);
            this.TBloginId.Name = "TBloginId";
            this.TBloginId.Size = new System.Drawing.Size(100, 20);
            this.TBloginId.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(129, 360);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(129, 388);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(129, 418);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(151, 20);
            this.textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(129, 448);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 10;
            // 
            // PBupdateLogins
            // 
            this.PBupdateLogins.Image = global::SRFNprojectJULY2019proj.Properties.Resources.UPDATE_button;
            this.PBupdateLogins.Location = new System.Drawing.Point(337, 325);
            this.PBupdateLogins.Name = "PBupdateLogins";
            this.PBupdateLogins.Size = new System.Drawing.Size(85, 70);
            this.PBupdateLogins.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBupdateLogins.TabIndex = 11;
            this.PBupdateLogins.TabStop = false;
            this.PBupdateLogins.Click += new System.EventHandler(this.PBupdateLogins_Click);
            // 
            // PBdeleteLogins
            // 
            this.PBdeleteLogins.Image = global::SRFNprojectJULY2019proj.Properties.Resources.DELETE_button;
            this.PBdeleteLogins.Location = new System.Drawing.Point(471, 325);
            this.PBdeleteLogins.Name = "PBdeleteLogins";
            this.PBdeleteLogins.Size = new System.Drawing.Size(85, 70);
            this.PBdeleteLogins.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBdeleteLogins.TabIndex = 12;
            this.PBdeleteLogins.TabStop = false;
            this.PBdeleteLogins.Click += new System.EventHandler(this.PBdeleteLogins_Click);
            // 
            // BTNok
            // 
            this.BTNok.Location = new System.Drawing.Point(397, 445);
            this.BTNok.Name = "BTNok";
            this.BTNok.Size = new System.Drawing.Size(75, 23);
            this.BTNok.TabIndex = 13;
            this.BTNok.Text = "OK";
            this.BTNok.UseVisualStyleBackColor = true;
            this.BTNok.Click += new System.EventHandler(this.BTNok_Click);
            // 
            // ManageAppUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 482);
            this.Controls.Add(this.BTNok);
            this.Controls.Add(this.PBdeleteLogins);
            this.Controls.Add(this.PBupdateLogins);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.TBloginId);
            this.Controls.Add(this.LBLisAdmin);
            this.Controls.Add(this.LBLdescrip);
            this.Controls.Add(this.LBLPassw);
            this.Controls.Add(this.LBLUserName);
            this.Controls.Add(this.LBLloginId);
            this.Controls.Add(this.DataGridViewLOGINS);
            this.Name = "ManageAppUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageAppUsers";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewLOGINS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBupdateLogins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBdeleteLogins)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewLOGINS;
        private System.Windows.Forms.Label LBLloginId;
        private System.Windows.Forms.Label LBLUserName;
        private System.Windows.Forms.Label LBLPassw;
        private System.Windows.Forms.Label LBLdescrip;
        private System.Windows.Forms.Label LBLisAdmin;
        private System.Windows.Forms.TextBox TBloginId;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.PictureBox PBupdateLogins;
        private System.Windows.Forms.PictureBox PBdeleteLogins;
        private System.Windows.Forms.Button BTNok;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginId;
        private System.Windows.Forms.DataGridViewTextBoxColumn userName;
        private System.Windows.Forms.DataGridViewTextBoxColumn passWord;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn isAdmin;
    }
}