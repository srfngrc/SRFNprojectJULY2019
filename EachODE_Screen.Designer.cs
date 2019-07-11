namespace SRFNprojectJULY2019proj
{
    partial class EachODE_Screen
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
            this.lblISIN = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_EODE_add = new System.Windows.Forms.Button();
            this.lbl_Date_Buy = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_EODE_Cancel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnLoadDataFromDBcust = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblISIN
            // 
            this.lblISIN.AutoSize = true;
            this.lblISIN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblISIN.Location = new System.Drawing.Point(27, 44);
            this.lblISIN.Name = "lblISIN";
            this.lblISIN.Size = new System.Drawing.Size(36, 15);
            this.lblISIN.TabIndex = 0;
            this.lblISIN.Text = "ISIN: ";
            this.lblISIN.Click += new System.EventHandler(this.Label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btn_EODE_add
            // 
            this.btn_EODE_add.AutoSize = true;
            this.btn_EODE_add.Location = new System.Drawing.Point(255, 381);
            this.btn_EODE_add.Name = "btn_EODE_add";
            this.btn_EODE_add.Size = new System.Drawing.Size(85, 23);
            this.btn_EODE_add.TabIndex = 2;
            this.btn_EODE_add.Text = "Add Operation";
            this.btn_EODE_add.UseVisualStyleBackColor = true;
            this.btn_EODE_add.Click += new System.EventHandler(this.Btn_EODE_add_Click);
            // 
            // lbl_Date_Buy
            // 
            this.lbl_Date_Buy.AutoSize = true;
            this.lbl_Date_Buy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Date_Buy.Location = new System.Drawing.Point(27, 76);
            this.lbl_Date_Buy.Name = "lbl_Date_Buy";
            this.lbl_Date_Buy.Size = new System.Drawing.Size(57, 15);
            this.lbl_Date_Buy.TabIndex = 3;
            this.lbl_Date_Buy.Text = "Buy date: ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(93, 76);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(188, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // btn_EODE_Cancel
            // 
            this.btn_EODE_Cancel.AutoSize = true;
            this.btn_EODE_Cancel.Location = new System.Drawing.Point(38, 381);
            this.btn_EODE_Cancel.Name = "btn_EODE_Cancel";
            this.btn_EODE_Cancel.Size = new System.Drawing.Size(104, 23);
            this.btn_EODE_Cancel.TabIndex = 5;
            this.btn_EODE_Cancel.Text = "Cancel Data Enter";
            this.btn_EODE_Cancel.UseVisualStyleBackColor = true;
            this.btn_EODE_Cancel.Click += new System.EventHandler(this.Btn_EODE_Cancel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // btnLoadDataFromDBcust
            // 
            this.btnLoadDataFromDBcust.Location = new System.Drawing.Point(48, 313);
            this.btnLoadDataFromDBcust.Name = "btnLoadDataFromDBcust";
            this.btnLoadDataFromDBcust.Size = new System.Drawing.Size(219, 23);
            this.btnLoadDataFromDBcust.TabIndex = 7;
            this.btnLoadDataFromDBcust.Text = "Load Data from customer table";
            this.btnLoadDataFromDBcust.UseVisualStyleBackColor = true;
            this.btnLoadDataFromDBcust.Click += new System.EventHandler(this.BtnLoadDataFromDBcust_Click);
            // 
            // EachODE_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 430);
            this.Controls.Add(this.btnLoadDataFromDBcust);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_EODE_Cancel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbl_Date_Buy);
            this.Controls.Add(this.btn_EODE_add);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblISIN);
            this.Name = "EachODE_Screen";
            this.Text = "EachODE";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblISIN;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_EODE_add;
        private System.Windows.Forms.Label lbl_Date_Buy;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_EODE_Cancel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLoadDataFromDBcust;
    }
}