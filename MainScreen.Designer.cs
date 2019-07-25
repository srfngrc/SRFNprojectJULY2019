namespace SRFNprojectJULY2019proj
{
    partial class MainScreenForm
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
            this.label1operation = new System.Windows.Forms.Label();
            this.btnMFdataEnter = new System.Windows.Forms.Button();
            this.label2operation = new System.Windows.Forms.Label();
            this.label3operation = new System.Windows.Forms.Label();
            this.label4operation = new System.Windows.Forms.Label();
            this.btnDBconnect = new System.Windows.Forms.Button();
            this.btnReadDataFromDB = new System.Windows.Forms.Button();
            this.PBManageAppUsers = new System.Windows.Forms.PictureBox();
            this.PBmodifyPastOperats = new System.Windows.Forms.PictureBox();
            this.PBListOperations = new System.Windows.Forms.PictureBox();
            this.PBCloseWindow = new System.Windows.Forms.PictureBox();
            this.PBAcceptMS = new System.Windows.Forms.PictureBox();
            this.PBInsertNewOperat = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBManageAppUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBmodifyPastOperats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBListOperations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCloseWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBAcceptMS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBInsertNewOperat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1operation
            // 
            this.label1operation.AutoSize = true;
            this.label1operation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1operation.Location = new System.Drawing.Point(40, 223);
            this.label1operation.Name = "label1operation";
            this.label1operation.Size = new System.Drawing.Size(109, 15);
            this.label1operation.TabIndex = 0;
            this.label1operation.Text = "Insert New Operation";
            // 
            // btnMFdataEnter
            // 
            this.btnMFdataEnter.Location = new System.Drawing.Point(401, 292);
            this.btnMFdataEnter.Name = "btnMFdataEnter";
            this.btnMFdataEnter.Size = new System.Drawing.Size(131, 23);
            this.btnMFdataEnter.TabIndex = 12;
            this.btnMFdataEnter.Text = "Operation Data Enter";
            this.btnMFdataEnter.UseVisualStyleBackColor = true;
            this.btnMFdataEnter.Visible = false;
            this.btnMFdataEnter.Click += new System.EventHandler(this.BtnMFdataEnter_Click);
            // 
            // label2operation
            // 
            this.label2operation.AutoSize = true;
            this.label2operation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2operation.Location = new System.Drawing.Point(200, 223);
            this.label2operation.Name = "label2operation";
            this.label2operation.Size = new System.Drawing.Size(133, 15);
            this.label2operation.TabIndex = 15;
            this.label2operation.Text = "List All Entered Operations";
            // 
            // label3operation
            // 
            this.label3operation.AutoSize = true;
            this.label3operation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3operation.Location = new System.Drawing.Point(379, 223);
            this.label3operation.Name = "label3operation";
            this.label3operation.Size = new System.Drawing.Size(118, 15);
            this.label3operation.TabIndex = 16;
            this.label3operation.Text = "Modify Past Operations";
            // 
            // label4operation
            // 
            this.label4operation.AutoSize = true;
            this.label4operation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4operation.Location = new System.Drawing.Point(559, 223);
            this.label4operation.Name = "label4operation";
            this.label4operation.Size = new System.Drawing.Size(100, 15);
            this.label4operation.TabIndex = 17;
            this.label4operation.Text = "Manage App Users";
            // 
            // btnDBconnect
            // 
            this.btnDBconnect.Location = new System.Drawing.Point(418, 317);
            this.btnDBconnect.Name = "btnDBconnect";
            this.btnDBconnect.Size = new System.Drawing.Size(114, 64);
            this.btnDBconnect.TabIndex = 21;
            this.btnDBconnect.Text = "connect to DB NOW!";
            this.btnDBconnect.UseVisualStyleBackColor = true;
            this.btnDBconnect.Visible = false;
            this.btnDBconnect.Click += new System.EventHandler(this.BtnDBconnect_Click);
            // 
            // btnReadDataFromDB
            // 
            this.btnReadDataFromDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReadDataFromDB.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnReadDataFromDB.Location = new System.Drawing.Point(225, 317);
            this.btnReadDataFromDB.Name = "btnReadDataFromDB";
            this.btnReadDataFromDB.Size = new System.Drawing.Size(143, 37);
            this.btnReadDataFromDB.TabIndex = 22;
            this.btnReadDataFromDB.Text = "All operations entered";
            this.btnReadDataFromDB.UseVisualStyleBackColor = true;
            this.btnReadDataFromDB.Visible = false;
            this.btnReadDataFromDB.Click += new System.EventHandler(this.BtnReadDataFromDB_Click);
            // 
            // PBManageAppUsers
            // 
            this.PBManageAppUsers.Image = global::SRFNprojectJULY2019proj.Properties.Resources.configurationWheels;
            this.PBManageAppUsers.Location = new System.Drawing.Point(543, 50);
            this.PBManageAppUsers.Name = "PBManageAppUsers";
            this.PBManageAppUsers.Size = new System.Drawing.Size(127, 170);
            this.PBManageAppUsers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBManageAppUsers.TabIndex = 33;
            this.PBManageAppUsers.TabStop = false;
            this.PBManageAppUsers.Click += new System.EventHandler(this.PictureBox5_Click);
            // 
            // PBmodifyPastOperats
            // 
            this.PBmodifyPastOperats.Image = global::SRFNprojectJULY2019proj.Properties.Resources.editing_july18th;
            this.PBmodifyPastOperats.Location = new System.Drawing.Point(379, 50);
            this.PBmodifyPastOperats.Name = "PBmodifyPastOperats";
            this.PBmodifyPastOperats.Size = new System.Drawing.Size(118, 170);
            this.PBmodifyPastOperats.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBmodifyPastOperats.TabIndex = 32;
            this.PBmodifyPastOperats.TabStop = false;
            this.PBmodifyPastOperats.Click += new System.EventHandler(this.PictureBox4_Click);
            // 
            // PBListOperations
            // 
            this.PBListOperations.Image = global::SRFNprojectJULY2019proj.Properties.Resources.ListOfElements;
            this.PBListOperations.Location = new System.Drawing.Point(200, 50);
            this.PBListOperations.Name = "PBListOperations";
            this.PBListOperations.Size = new System.Drawing.Size(133, 170);
            this.PBListOperations.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBListOperations.TabIndex = 31;
            this.PBListOperations.TabStop = false;
            this.PBListOperations.Click += new System.EventHandler(this.PictureBox3_Click);
            // 
            // PBCloseWindow
            // 
            this.PBCloseWindow.Image = global::SRFNprojectJULY2019proj.Properties.Resources.switchOnOff;
            this.PBCloseWindow.Location = new System.Drawing.Point(57, 295);
            this.PBCloseWindow.Name = "PBCloseWindow";
            this.PBCloseWindow.Size = new System.Drawing.Size(101, 86);
            this.PBCloseWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBCloseWindow.TabIndex = 30;
            this.PBCloseWindow.TabStop = false;
            this.PBCloseWindow.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // PBAcceptMS
            // 
            this.PBAcceptMS.Image = global::SRFNprojectJULY2019proj.Properties.Resources.acceptButton;
            this.PBAcceptMS.Location = new System.Drawing.Point(559, 296);
            this.PBAcceptMS.Name = "PBAcceptMS";
            this.PBAcceptMS.Size = new System.Drawing.Size(111, 85);
            this.PBAcceptMS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBAcceptMS.TabIndex = 29;
            this.PBAcceptMS.TabStop = false;
            this.PBAcceptMS.Click += new System.EventHandler(this.PBAcceptMS_Click);
            // 
            // PBInsertNewOperat
            // 
            this.PBInsertNewOperat.Image = global::SRFNprojectJULY2019proj.Properties.Resources.savings;
            this.PBInsertNewOperat.Location = new System.Drawing.Point(29, 50);
            this.PBInsertNewOperat.Name = "PBInsertNewOperat";
            this.PBInsertNewOperat.Size = new System.Drawing.Size(129, 170);
            this.PBInsertNewOperat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBInsertNewOperat.TabIndex = 28;
            this.PBInsertNewOperat.TabStop = false;
            this.PBInsertNewOperat.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // MainScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 403);
            this.Controls.Add(this.PBManageAppUsers);
            this.Controls.Add(this.PBmodifyPastOperats);
            this.Controls.Add(this.PBListOperations);
            this.Controls.Add(this.PBCloseWindow);
            this.Controls.Add(this.PBAcceptMS);
            this.Controls.Add(this.PBInsertNewOperat);
            this.Controls.Add(this.btnReadDataFromDB);
            this.Controls.Add(this.btnDBconnect);
            this.Controls.Add(this.label4operation);
            this.Controls.Add(this.label3operation);
            this.Controls.Add(this.label2operation);
            this.Controls.Add(this.btnMFdataEnter);
            this.Controls.Add(this.label1operation);
            this.Name = "MainScreenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainScreen";
            ((System.ComponentModel.ISupportInitialize)(this.PBManageAppUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBmodifyPastOperats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBListOperations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCloseWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBAcceptMS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBInsertNewOperat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1operation;
        private System.Windows.Forms.Button btnMFdataEnter;
        private System.Windows.Forms.Label label2operation;
        private System.Windows.Forms.Label label3operation;
        private System.Windows.Forms.Label label4operation;
        private System.Windows.Forms.Button btnDBconnect;
        private System.Windows.Forms.Button btnReadDataFromDB;
        private System.Windows.Forms.PictureBox PBInsertNewOperat;
        private System.Windows.Forms.PictureBox PBAcceptMS;
        private System.Windows.Forms.PictureBox PBCloseWindow;
        private System.Windows.Forms.PictureBox PBListOperations;
        private System.Windows.Forms.PictureBox PBmodifyPastOperats;
        private System.Windows.Forms.PictureBox PBManageAppUsers;
    }
}