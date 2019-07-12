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
            this.btn_EODE_Cancel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnLoadDataFromDBcust = new System.Windows.Forms.Button();
            this.btnTRY = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_EODE_add
            // 
            this.btn_EODE_add.AutoSize = true;
            this.btn_EODE_add.Location = new System.Drawing.Point(308, 421);
            this.btn_EODE_add.Name = "btn_EODE_add";
            this.btn_EODE_add.Size = new System.Drawing.Size(85, 23);
            this.btn_EODE_add.TabIndex = 2;
            this.btn_EODE_add.Text = "Edit Operation";
            this.btn_EODE_add.UseVisualStyleBackColor = true;
            this.btn_EODE_add.Click += new System.EventHandler(this.Btn_EODE_add_Click);
            // 
            // btn_EODE_Cancel
            // 
            this.btn_EODE_Cancel.AutoSize = true;
            this.btn_EODE_Cancel.Location = new System.Drawing.Point(27, 421);
            this.btn_EODE_Cancel.Name = "btn_EODE_Cancel";
            this.btn_EODE_Cancel.Size = new System.Drawing.Size(104, 23);
            this.btn_EODE_Cancel.TabIndex = 5;
            this.btn_EODE_Cancel.Text = "Cancel";
            this.btn_EODE_Cancel.UseVisualStyleBackColor = true;
            this.btn_EODE_Cancel.Click += new System.EventHandler(this.Btn_EODE_Cancel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(381, 322);
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
            // btnTRY
            // 
            this.btnTRY.Location = new System.Drawing.Point(318, 373);
            this.btnTRY.Name = "btnTRY";
            this.btnTRY.Size = new System.Drawing.Size(75, 23);
            this.btnTRY.TabIndex = 14;
            this.btnTRY.Text = "try";
            this.btnTRY.UseVisualStyleBackColor = true;
            this.btnTRY.Click += new System.EventHandler(this.BtnTRY_Click);
            // 
            // All_ODE_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 462);
            this.Controls.Add(this.btnTRY);
            this.Controls.Add(this.btnLoadDataFromDBcust);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_EODE_Cancel);
            this.Controls.Add(this.btn_EODE_add);
            this.Name = "All_ODE_Screen";
            this.Text = "EachODE";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_EODE_add;
        private System.Windows.Forms.Button btn_EODE_Cancel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLoadDataFromDBcust;
        private System.Windows.Forms.Button btnTRY;
    }
}