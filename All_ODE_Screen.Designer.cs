namespace SRFNprojectJULY2019proj
{
    partial class All_ODE_Screen
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
            this.btn_EODE_add = new System.Windows.Forms.Button();
            this.btn_EODE_OK = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.operationId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLoadDataFromDBcust = new System.Windows.Forms.Button();
            this.btnTRY = new System.Windows.Forms.Button();
            this.LBLtotalAmount = new System.Windows.Forms.Label();
            this.TBsumatory = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_EODE_add
            // 
            this.btn_EODE_add.AutoSize = true;
            this.btn_EODE_add.Location = new System.Drawing.Point(146, 460);
            this.btn_EODE_add.Name = "btn_EODE_add";
            this.btn_EODE_add.Size = new System.Drawing.Size(85, 23);
            this.btn_EODE_add.TabIndex = 2;
            this.btn_EODE_add.Text = "Edit Operation";
            this.btn_EODE_add.UseVisualStyleBackColor = true;
            this.btn_EODE_add.Visible = false;
            this.btn_EODE_add.Click += new System.EventHandler(this.Btn_EODE_add_Click);
            // 
            // btn_EODE_OK
            // 
            this.btn_EODE_OK.AutoSize = true;
            this.btn_EODE_OK.Location = new System.Drawing.Point(317, 460);
            this.btn_EODE_OK.Name = "btn_EODE_OK";
            this.btn_EODE_OK.Size = new System.Drawing.Size(104, 23);
            this.btn_EODE_OK.TabIndex = 5;
            this.btn_EODE_OK.Text = "OK";
            this.btn_EODE_OK.UseVisualStyleBackColor = true;
            this.btn_EODE_OK.Click += new System.EventHandler(this.Btn_EODE_Cancel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.operationId,
            this.isin,
            this.purchaseDate,
            this.sellDate,
            this.amount,
            this.description});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(659, 413);
            this.dataGridView1.TabIndex = 6;
            // 
            // operationId
            // 
            this.operationId.DataPropertyName = "operationId";
            this.operationId.HeaderText = "Operation Id";
            this.operationId.Name = "operationId";
            this.operationId.ReadOnly = true;
            // 
            // isin
            // 
            this.isin.DataPropertyName = "isin";
            this.isin.HeaderText = "Isin Number";
            this.isin.Name = "isin";
            this.isin.ReadOnly = true;
            // 
            // purchaseDate
            // 
            this.purchaseDate.DataPropertyName = "purchaseDate";
            this.purchaseDate.HeaderText = "Date of Purchase";
            this.purchaseDate.Name = "purchaseDate";
            this.purchaseDate.ReadOnly = true;
            // 
            // sellDate
            // 
            this.sellDate.DataPropertyName = "sellDate";
            this.sellDate.HeaderText = "Date of Sale";
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
            // btnLoadDataFromDBcust
            // 
            this.btnLoadDataFromDBcust.Location = new System.Drawing.Point(12, 431);
            this.btnLoadDataFromDBcust.Name = "btnLoadDataFromDBcust";
            this.btnLoadDataFromDBcust.Size = new System.Drawing.Size(219, 23);
            this.btnLoadDataFromDBcust.TabIndex = 7;
            this.btnLoadDataFromDBcust.Text = "Load Data from customer table";
            this.btnLoadDataFromDBcust.UseVisualStyleBackColor = true;
            this.btnLoadDataFromDBcust.Visible = false;
            // 
            // btnTRY
            // 
            this.btnTRY.Location = new System.Drawing.Point(12, 460);
            this.btnTRY.Name = "btnTRY";
            this.btnTRY.Size = new System.Drawing.Size(75, 23);
            this.btnTRY.TabIndex = 14;
            this.btnTRY.Text = "try";
            this.btnTRY.UseVisualStyleBackColor = true;
            this.btnTRY.Visible = false;
            // 
            // LBLtotalAmount
            // 
            this.LBLtotalAmount.AutoSize = true;
            this.LBLtotalAmount.Location = new System.Drawing.Point(369, 431);
            this.LBLtotalAmount.Name = "LBLtotalAmount";
            this.LBLtotalAmount.Size = new System.Drawing.Size(76, 13);
            this.LBLtotalAmount.TabIndex = 15;
            this.LBLtotalAmount.Text = "Total Amount: ";
            // 
            // TBsumatory
            // 
            this.TBsumatory.Location = new System.Drawing.Point(451, 428);
            this.TBsumatory.Name = "TBsumatory";
            this.TBsumatory.ReadOnly = true;
            this.TBsumatory.Size = new System.Drawing.Size(100, 20);
            this.TBsumatory.TabIndex = 16;
            // 
            // All_ODE_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 495);
            this.Controls.Add(this.TBsumatory);
            this.Controls.Add(this.LBLtotalAmount);
            this.Controls.Add(this.btnTRY);
            this.Controls.Add(this.btnLoadDataFromDBcust);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_EODE_OK);
            this.Controls.Add(this.btn_EODE_add);
            this.Name = "All_ODE_Screen";
            this.Text = "EachODE";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_EODE_add;
        private System.Windows.Forms.Button btn_EODE_OK;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLoadDataFromDBcust;
        private System.Windows.Forms.Button btnTRY;
        private System.Windows.Forms.DataGridViewTextBoxColumn operationId;
        private System.Windows.Forms.DataGridViewTextBoxColumn isin;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.Label LBLtotalAmount;
        private System.Windows.Forms.TextBox TBsumatory;
    }
}