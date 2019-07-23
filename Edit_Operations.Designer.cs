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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.TBoperationId = new System.Windows.Forms.TextBox();
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
            this.dataGridView87.Location = new System.Drawing.Point(12, 21);
            this.dataGridView87.Name = "dataGridView87";
            this.dataGridView87.ReadOnly = true;
            this.dataGridView87.Size = new System.Drawing.Size(661, 357);
            this.dataGridView87.TabIndex = 0;
            this.dataGridView87.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView87_CellContentClick);
            // 
            // PBdelete
            // 
            this.PBdelete.Image = global::SRFNprojectJULY2019proj.Properties.Resources.DELETE_button;
            this.PBdelete.Location = new System.Drawing.Point(529, 423);
            this.PBdelete.Name = "PBdelete";
            this.PBdelete.Size = new System.Drawing.Size(135, 95);
            this.PBdelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBdelete.TabIndex = 3;
            this.PBdelete.TabStop = false;
            this.PBdelete.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // PBupdate
            // 
            this.PBupdate.Image = global::SRFNprojectJULY2019proj.Properties.Resources.UPDATE_button;
            this.PBupdate.Location = new System.Drawing.Point(371, 423);
            this.PBupdate.Name = "PBupdate";
            this.PBupdate.Size = new System.Drawing.Size(132, 95);
            this.PBupdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBupdate.TabIndex = 2;
            this.PBupdate.TabStop = false;
            this.PBupdate.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(135, 394);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(135, 472);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(135, 420);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(135, 446);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(135, 498);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 8;
            this.textBox3.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // TBoperationId
            // 
            this.TBoperationId.Location = new System.Drawing.Point(12, 449);
            this.TBoperationId.Name = "TBoperationId";
            this.TBoperationId.Size = new System.Drawing.Size(100, 20);
            this.TBoperationId.TabIndex = 9;
            // 
            // operationId
            // 
            this.operationId.DataPropertyName = "operationId";
            this.operationId.HeaderText = "ID";
            this.operationId.Name = "operationId";
            this.operationId.ReadOnly = true;
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
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // Edit_Operations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 540);
            this.Controls.Add(this.TBoperationId);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PBdelete);
            this.Controls.Add(this.PBupdate);
            this.Controls.Add(this.dataGridView87);
            this.Name = "Edit_Operations";
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox TBoperationId;
        private System.Windows.Forms.DataGridViewTextBoxColumn operationId;
        private System.Windows.Forms.DataGridViewTextBoxColumn isin;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
    }
}