namespace SRFNprojectJULY2019proj
{
    partial class Edit_Operations
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
            this.dataGridView87 = new System.Windows.Forms.DataGridView();
            this.PBdelete = new System.Windows.Forms.PictureBox();
            this.PBupdate = new System.Windows.Forms.PictureBox();
            this.TBisin = new System.Windows.Forms.TextBox();
            this.TBamount = new System.Windows.Forms.TextBox();
            this.DTPpurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.DTPsellDate = new System.Windows.Forms.DateTimePicker();
            this.TBdescription = new System.Windows.Forms.TextBox();
            this.TBoperationId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.operationId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView87)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBdelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBupdate)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView87
            // 
            this.dataGridView87.AllowUserToAddRows = false;
            this.dataGridView87.AllowUserToDeleteRows = false;
            this.dataGridView87.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView87.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.operationId,
            this.isin,
            this.purchaseDate,
            this.sellDate,
            this.amount,
            this.description});
            this.dataGridView87.Location = new System.Drawing.Point(12, 12);
            this.dataGridView87.Name = "dataGridView87";
            this.dataGridView87.ReadOnly = true;
            this.dataGridView87.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView87.Size = new System.Drawing.Size(634, 363);
            this.dataGridView87.TabIndex = 0;
            this.dataGridView87.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView87_CellContentClick);
            this.dataGridView87.SelectionChanged += new System.EventHandler(this.SelectionChanget);
            // 
            // PBdelete
            // 
            this.PBdelete.Image = global::SRFNprojectJULY2019proj.Properties.Resources.DELETE_button;
            this.PBdelete.Location = new System.Drawing.Point(519, 415);
            this.PBdelete.Name = "PBdelete";
            this.PBdelete.Size = new System.Drawing.Size(127, 93);
            this.PBdelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBdelete.TabIndex = 3;
            this.PBdelete.TabStop = false;
            this.PBdelete.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // PBupdate
            // 
            this.PBupdate.Image = global::SRFNprojectJULY2019proj.Properties.Resources.UPDATE_button;
            this.PBupdate.Location = new System.Drawing.Point(352, 415);
            this.PBupdate.Name = "PBupdate";
            this.PBupdate.Size = new System.Drawing.Size(132, 93);
            this.PBupdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBupdate.TabIndex = 2;
            this.PBupdate.TabStop = false;
            this.PBupdate.Click += new System.EventHandler(this.PBUpdate_Click);
            // 
            // TBisin
            // 
            this.TBisin.Location = new System.Drawing.Point(131, 415);
            this.TBisin.Name = "TBisin";
            this.TBisin.Size = new System.Drawing.Size(100, 20);
            this.TBisin.TabIndex = 4;
            // 
            // TBamount
            // 
            this.TBamount.Location = new System.Drawing.Point(131, 492);
            this.TBamount.Name = "TBamount";
            this.TBamount.Size = new System.Drawing.Size(100, 20);
            this.TBamount.TabIndex = 5;
            // 
            // DTPpurchaseDate
            // 
            this.DTPpurchaseDate.Location = new System.Drawing.Point(131, 441);
            this.DTPpurchaseDate.Name = "DTPpurchaseDate";
            this.DTPpurchaseDate.Size = new System.Drawing.Size(200, 20);
            this.DTPpurchaseDate.TabIndex = 6;
            // 
            // DTPsellDate
            // 
            this.DTPsellDate.Location = new System.Drawing.Point(131, 466);
            this.DTPsellDate.Name = "DTPsellDate";
            this.DTPsellDate.Size = new System.Drawing.Size(200, 20);
            this.DTPsellDate.TabIndex = 7;
            // 
            // TBdescription
            // 
            this.TBdescription.Location = new System.Drawing.Point(131, 518);
            this.TBdescription.Name = "TBdescription";
            this.TBdescription.Size = new System.Drawing.Size(100, 20);
            this.TBdescription.TabIndex = 8;
            // 
            // TBoperationId
            // 
            this.TBoperationId.Location = new System.Drawing.Point(131, 389);
            this.TBoperationId.Name = "TBoperationId";
            this.TBoperationId.ReadOnly = true;
            this.TBoperationId.Size = new System.Drawing.Size(100, 20);
            this.TBoperationId.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "IN Number: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 447);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Purchase Date: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 472);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Sell Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 495);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Operat Amount: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 521);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Operat Description:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 396);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Operation Id:";
            // 
            // operationId
            // 
            this.operationId.DataPropertyName = "operationId";
            this.operationId.HeaderText = "ID";
            this.operationId.Name = "operationId";
            this.operationId.ReadOnly = true;
            this.operationId.Width = 50;
            // 
            // isin
            // 
            this.isin.DataPropertyName = "isin";
            this.isin.HeaderText = "ISI number";
            this.isin.Name = "isin";
            this.isin.ReadOnly = true;
            // 
            // purchaseDate
            // 
            this.purchaseDate.DataPropertyName = "purchaseDate";
            this.purchaseDate.HeaderText = "Purchase Date";
            this.purchaseDate.Name = "purchaseDate";
            this.purchaseDate.ReadOnly = true;
            this.purchaseDate.Width = 105;
            // 
            // sellDate
            // 
            this.sellDate.DataPropertyName = "sellDate";
            this.sellDate.HeaderText = "Sale Date";
            this.sellDate.Name = "sellDate";
            this.sellDate.ReadOnly = true;
            // 
            // amount
            // 
            this.amount.DataPropertyName = "amount";
            this.amount.HeaderText = "Amount";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            // 
            // description
            // 
            this.description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // Edit_Operations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 551);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBoperationId);
            this.Controls.Add(this.TBdescription);
            this.Controls.Add(this.DTPsellDate);
            this.Controls.Add(this.DTPpurchaseDate);
            this.Controls.Add(this.TBamount);
            this.Controls.Add(this.TBisin);
            this.Controls.Add(this.PBdelete);
            this.Controls.Add(this.PBupdate);
            this.Controls.Add(this.dataGridView87);
            this.Name = "Edit_Operations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit_Operations";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView87)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBdelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBupdate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView87;
        private System.Windows.Forms.PictureBox PBupdate;
        private System.Windows.Forms.PictureBox PBdelete;
        private System.Windows.Forms.TextBox TBisin;
        private System.Windows.Forms.TextBox TBamount;
        private System.Windows.Forms.DateTimePicker DTPpurchaseDate;
        private System.Windows.Forms.DateTimePicker DTPsellDate;
        private System.Windows.Forms.TextBox TBdescription;
        private System.Windows.Forms.TextBox TBoperationId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn operationId;
        private System.Windows.Forms.DataGridViewTextBoxColumn isin;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
    }
}