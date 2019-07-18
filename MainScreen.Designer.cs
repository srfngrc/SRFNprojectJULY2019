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
            this.textBox1ISIN = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnMFdataEnter = new System.Windows.Forms.Button();
            this.MFCancelbtn = new System.Windows.Forms.Button();
            this.MFokbtn = new System.Windows.Forms.Button();
            this.label2operation = new System.Windows.Forms.Label();
            this.label3operation = new System.Windows.Forms.Label();
            this.label4operation = new System.Windows.Forms.Label();
            this.label5operation = new System.Windows.Forms.Label();
            this.label6operation = new System.Windows.Forms.Label();
            this.btnDBconnect = new System.Windows.Forms.Button();
            this.btnReadDataFromDB = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1operation
            // 
            this.label1operation.AutoSize = true;
            this.label1operation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1operation.Location = new System.Drawing.Point(31, 69);
            this.label1operation.Name = "label1operation";
            this.label1operation.Size = new System.Drawing.Size(71, 15);
            this.label1operation.TabIndex = 0;
            this.label1operation.Text = "Operation #1";
            // 
            // textBox1ISIN
            // 
            this.textBox1ISIN.Location = new System.Drawing.Point(137, 64);
            this.textBox1ISIN.Name = "textBox1ISIN";
            this.textBox1ISIN.Size = new System.Drawing.Size(151, 20);
            this.textBox1ISIN.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(137, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(137, 133);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(151, 20);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(137, 161);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(151, 20);
            this.textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(137, 194);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(151, 20);
            this.textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(137, 223);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(151, 20);
            this.textBox5.TabIndex = 11;
            // 
            // btnMFdataEnter
            // 
            this.btnMFdataEnter.Location = new System.Drawing.Point(327, 62);
            this.btnMFdataEnter.Name = "btnMFdataEnter";
            this.btnMFdataEnter.Size = new System.Drawing.Size(131, 23);
            this.btnMFdataEnter.TabIndex = 12;
            this.btnMFdataEnter.Text = "Operation Data Enter";
            this.btnMFdataEnter.UseVisualStyleBackColor = true;
            this.btnMFdataEnter.Click += new System.EventHandler(this.BtnMFdataEnter_Click);
            // 
            // MFCancelbtn
            // 
            this.MFCancelbtn.Location = new System.Drawing.Point(31, 278);
            this.MFCancelbtn.Name = "MFCancelbtn";
            this.MFCancelbtn.Size = new System.Drawing.Size(75, 23);
            this.MFCancelbtn.TabIndex = 13;
            this.MFCancelbtn.Text = "Cancel";
            this.MFCancelbtn.UseVisualStyleBackColor = true;
            this.MFCancelbtn.Click += new System.EventHandler(this.MFCancelbtn_Click);
            // 
            // MFokbtn
            // 
            this.MFokbtn.Location = new System.Drawing.Point(519, 278);
            this.MFokbtn.Name = "MFokbtn";
            this.MFokbtn.Size = new System.Drawing.Size(75, 23);
            this.MFokbtn.TabIndex = 14;
            this.MFokbtn.Text = "OK";
            this.MFokbtn.UseVisualStyleBackColor = true;
            // 
            // label2operation
            // 
            this.label2operation.AutoSize = true;
            this.label2operation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2operation.Location = new System.Drawing.Point(31, 100);
            this.label2operation.Name = "label2operation";
            this.label2operation.Size = new System.Drawing.Size(71, 15);
            this.label2operation.TabIndex = 15;
            this.label2operation.Text = "Operation #2";
            // 
            // label3operation
            // 
            this.label3operation.AutoSize = true;
            this.label3operation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3operation.Location = new System.Drawing.Point(31, 133);
            this.label3operation.Name = "label3operation";
            this.label3operation.Size = new System.Drawing.Size(71, 15);
            this.label3operation.TabIndex = 16;
            this.label3operation.Text = "Operation #3";
            // 
            // label4operation
            // 
            this.label4operation.AutoSize = true;
            this.label4operation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4operation.Location = new System.Drawing.Point(31, 161);
            this.label4operation.Name = "label4operation";
            this.label4operation.Size = new System.Drawing.Size(71, 15);
            this.label4operation.TabIndex = 17;
            this.label4operation.Text = "Operation #4";
            // 
            // label5operation
            // 
            this.label5operation.AutoSize = true;
            this.label5operation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5operation.Location = new System.Drawing.Point(31, 194);
            this.label5operation.Name = "label5operation";
            this.label5operation.Size = new System.Drawing.Size(71, 15);
            this.label5operation.TabIndex = 18;
            this.label5operation.Text = "Operation #5";
            // 
            // label6operation
            // 
            this.label6operation.AutoSize = true;
            this.label6operation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6operation.Location = new System.Drawing.Point(31, 223);
            this.label6operation.Name = "label6operation";
            this.label6operation.Size = new System.Drawing.Size(71, 15);
            this.label6operation.TabIndex = 20;
            this.label6operation.Text = "Operation #6";
            // 
            // btnDBconnect
            // 
            this.btnDBconnect.Location = new System.Drawing.Point(519, 110);
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
            this.btnReadDataFromDB.Location = new System.Drawing.Point(269, 264);
            this.btnReadDataFromDB.Name = "btnReadDataFromDB";
            this.btnReadDataFromDB.Size = new System.Drawing.Size(143, 37);
            this.btnReadDataFromDB.TabIndex = 22;
            this.btnReadDataFromDB.Text = "All operations entered";
            this.btnReadDataFromDB.UseVisualStyleBackColor = true;
            this.btnReadDataFromDB.Click += new System.EventHandler(this.BtnReadDataFromDB_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(327, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Operation Data Enter";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(327, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Operation Data Enter";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(327, 160);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 23);
            this.button3.TabIndex = 25;
            this.button3.Text = "Operation Data Enter";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(327, 192);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(131, 23);
            this.button4.TabIndex = 26;
            this.button4.Text = "Operation Data Enter";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(327, 220);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(131, 23);
            this.button5.TabIndex = 27;
            this.button5.Text = "Operation Data Enter";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // MainScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 316);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnReadDataFromDB);
            this.Controls.Add(this.btnDBconnect);
            this.Controls.Add(this.label6operation);
            this.Controls.Add(this.label5operation);
            this.Controls.Add(this.label4operation);
            this.Controls.Add(this.label3operation);
            this.Controls.Add(this.label2operation);
            this.Controls.Add(this.MFokbtn);
            this.Controls.Add(this.MFCancelbtn);
            this.Controls.Add(this.btnMFdataEnter);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox1ISIN);
            this.Controls.Add(this.label1operation);
            this.Name = "MainScreenForm";
            this.Text = "MainScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1operation;
        private System.Windows.Forms.TextBox textBox1ISIN;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btnMFdataEnter;
        private System.Windows.Forms.Button MFCancelbtn;
        private System.Windows.Forms.Button MFokbtn;
        private System.Windows.Forms.Label label2operation;
        private System.Windows.Forms.Label label3operation;
        private System.Windows.Forms.Label label4operation;
        private System.Windows.Forms.Label label5operation;
        private System.Windows.Forms.Label label6operation;
        private System.Windows.Forms.Button btnDBconnect;
        private System.Windows.Forms.Button btnReadDataFromDB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}