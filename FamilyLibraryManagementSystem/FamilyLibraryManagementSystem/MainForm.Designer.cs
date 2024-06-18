namespace FamilyLibraryManagementSystem
{
    partial class MainForm
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
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.bookname = new System.Windows.Forms.TextBox();
            this.borrowerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.borrowerLastname = new System.Windows.Forms.TextBox();
            this.OwnerName = new System.Windows.Forms.TextBox();
            this.shelveNumbernumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.addBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shelveNumbernumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.Location = new System.Drawing.Point(368, 116);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.RowHeadersWidth = 51;
            this.dataGridViewBooks.RowTemplate.Height = 24;
            this.dataGridViewBooks.Size = new System.Drawing.Size(635, 234);
            this.dataGridViewBooks.TabIndex = 0;
            this.dataGridViewBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label10.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label10.Location = new System.Drawing.Point(230, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(670, 39);
            this.label10.TabIndex = 25;
            this.label10.Text = "Admin Panel for Family Library Managment";
            // 
            // bookname
            // 
            this.bookname.Location = new System.Drawing.Point(137, 150);
            this.bookname.Name = "bookname";
            this.bookname.Size = new System.Drawing.Size(153, 22);
            this.bookname.TabIndex = 26;
            this.bookname.TextChanged += new System.EventHandler(this.bookname_TextChanged);
            // 
            // borrowerName
            // 
            this.borrowerName.Location = new System.Drawing.Point(137, 178);
            this.borrowerName.Name = "borrowerName";
            this.borrowerName.Size = new System.Drawing.Size(153, 22);
            this.borrowerName.TabIndex = 27;
            this.borrowerName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Book Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Borrower Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "Borrower Lastname";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "Owner Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "Sheleve Number";
            // 
            // borrowerLastname
            // 
            this.borrowerLastname.Location = new System.Drawing.Point(137, 212);
            this.borrowerLastname.Name = "borrowerLastname";
            this.borrowerLastname.Size = new System.Drawing.Size(153, 22);
            this.borrowerLastname.TabIndex = 33;
            this.borrowerLastname.TextChanged += new System.EventHandler(this.borrowerLastname_TextChanged);
            // 
            // OwnerName
            // 
            this.OwnerName.Location = new System.Drawing.Point(137, 250);
            this.OwnerName.Name = "OwnerName";
            this.OwnerName.Size = new System.Drawing.Size(153, 22);
            this.OwnerName.TabIndex = 34;
            this.OwnerName.TextChanged += new System.EventHandler(this.OwnerName_TextChanged);
            // 
            // shelveNumbernumericUpDown
            // 
            this.shelveNumbernumericUpDown.Location = new System.Drawing.Point(137, 283);
            this.shelveNumbernumericUpDown.Name = "shelveNumbernumericUpDown";
            this.shelveNumbernumericUpDown.Size = new System.Drawing.Size(78, 22);
            this.shelveNumbernumericUpDown.TabIndex = 35;
            this.shelveNumbernumericUpDown.ValueChanged += new System.EventHandler(this.shelveNumbernumericUpDown_ValueChanged);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(86, 366);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 36;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 490);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.shelveNumbernumericUpDown);
            this.Controls.Add(this.OwnerName);
            this.Controls.Add(this.borrowerLastname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.borrowerName);
            this.Controls.Add(this.bookname);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridViewBooks);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shelveNumbernumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox bookname;
        private System.Windows.Forms.TextBox borrowerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox borrowerLastname;
        private System.Windows.Forms.TextBox OwnerName;
        private System.Windows.Forms.NumericUpDown shelveNumbernumericUpDown;
        private System.Windows.Forms.Button addBtn;
    }
}

