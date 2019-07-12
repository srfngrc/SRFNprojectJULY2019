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
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnTRY = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblISIN
            // 
            this.lblISIN.AutoSize = true;
            this.lblISIN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblISIN.Location = new System.Drawing.Point(27, 44);
            this.lblISIN.Name = "lblISIN";
            this.lblISIN.Size = new System.Drawing.Size(76, 15);
            this.lblISIN.TabIndex = 0;
            this.lblISIN.Text = "ISIN Number: ";
            this.lblISIN.Click += new System.EventHandler(this.Label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(144, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btn_EODE_add
            // 
            this.btn_EODE_add.AutoSize = true;
            this.btn_EODE_add.Location = new System.Drawing.Point(308, 421);
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
            this.lbl_Date_Buy.Size = new System.Drawing.Size(84, 15);
            this.lbl_Date_Buy.TabIndex = 3;
            this.lbl_Date_Buy.Text = "Purchase date: ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(144, 71);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(188, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // btn_EODE_Cancel
            // 
            this.btn_EODE_Cancel.AutoSize = true;
            this.btn_EODE_Cancel.Location = new System.Drawing.Point(27, 421);
            this.btn_EODE_Cancel.Name = "btn_EODE_Cancel";
            this.btn_EODE_Cancel.Size = new System.Drawing.Size(104, 23);
            this.btn_EODE_Cancel.TabIndex = 5;
            this.btn_EODE_Cancel.Text = "Cancel Data Enter";
            this.btn_EODE_Cancel.UseVisualStyleBackColor = true;
            this.btn_EODE_Cancel.Click += new System.EventHandler(this.Btn_EODE_Cancel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 187);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(336, 180);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // btnLoadDataFromDBcust
            // 
            this.btnLoadDataFromDBcust.Location = new System.Drawing.Point(93, 373);
            this.btnLoadDataFromDBcust.Name = "btnLoadDataFromDBcust";
            this.btnLoadDataFromDBcust.Size = new System.Drawing.Size(219, 23);
            this.btnLoadDataFromDBcust.TabIndex = 7;
            this.btnLoadDataFromDBcust.Text = "Load Data from customer table";
            this.btnLoadDataFromDBcust.UseVisualStyleBackColor = true;
            this.btnLoadDataFromDBcust.Click += new System.EventHandler(this.BtnLoadDataFromDBcust_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(27, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sell date: ";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(144, 97);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(188, 20);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(27, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Operation Amount: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(27, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Operation Description:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(144, 125);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(144, 151);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(208, 20);
            this.textBox3.TabIndex = 13;
            // 
            // btnTRY
            // 
            this.btnTRY.Location = new System.Drawing.Point(369, 287);
            this.btnTRY.Name = "btnTRY";
            this.btnTRY.Size = new System.Drawing.Size(75, 23);
            this.btnTRY.TabIndex = 14;
            this.btnTRY.Text = "try";
            this.btnTRY.UseVisualStyleBackColor = true;
            this.btnTRY.Click += new System.EventHandler(this.BtnTRY_Click);
            // 
            // EachODE_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 484);
            this.Controls.Add(this.btnTRY);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnTRY;
    }
}