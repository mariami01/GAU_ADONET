namespace MovieProject
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
        /// 
        
        private void InitializeComponent()
        {
            System.Windows.Forms.Button Delete;
            this.Add = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Loadbtn = new System.Windows.Forms.Button();
            this.movieName = new System.Windows.Forms.TextBox();
            this.movieTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dirName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dirLastname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.duration = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.releaseDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.TextBox();
            this.score = new System.Windows.Forms.NumericUpDown();
            this.reviewDate = new System.Windows.Forms.DateTimePicker();
            this.Nationality = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comment = new System.Windows.Forms.TextBox();
            Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.score)).BeginInit();
            this.SuspendLayout();
            // 
            // Delete
            // 
            Delete.Location = new System.Drawing.Point(399, 532);
            Delete.Name = "Delete";
            Delete.Size = new System.Drawing.Size(75, 23);
            Delete.TabIndex = 1;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(12, 532);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 0;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(519, 532);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 2;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(387, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(848, 398);
            this.dataGridView1.TabIndex = 3;
            // 
            // Loadbtn
            // 
            this.Loadbtn.Location = new System.Drawing.Point(387, 99);
            this.Loadbtn.Name = "Loadbtn";
            this.Loadbtn.Size = new System.Drawing.Size(75, 23);
            this.Loadbtn.TabIndex = 4;
            this.Loadbtn.Text = "Load";
            this.Loadbtn.UseVisualStyleBackColor = true;
            this.Loadbtn.Click += new System.EventHandler(this.Load_Click);
            // 
            // movieName
            // 
            this.movieName.Location = new System.Drawing.Point(135, 138);
            this.movieName.Name = "movieName";
            this.movieName.Size = new System.Drawing.Size(242, 22);
            this.movieName.TabIndex = 5;
            // 
            // movieTitle
            // 
            this.movieTitle.AutoSize = true;
            this.movieTitle.Location = new System.Drawing.Point(9, 141);
            this.movieTitle.Name = "movieTitle";
            this.movieTitle.Size = new System.Drawing.Size(73, 16);
            this.movieTitle.TabIndex = 6;
            this.movieTitle.Text = "Movie Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Director Name";
            // 
            // dirName
            // 
            this.dirName.Location = new System.Drawing.Point(135, 179);
            this.dirName.Name = "dirName";
            this.dirName.Size = new System.Drawing.Size(242, 22);
            this.dirName.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Director Lastname";
            // 
            // dirLastname
            // 
            this.dirLastname.Location = new System.Drawing.Point(135, 226);
            this.dirLastname.Name = "dirLastname";
            this.dirLastname.Size = new System.Drawing.Size(242, 22);
            this.dirLastname.TabIndex = 10;
            this.dirLastname.TextChanged += new System.EventHandler(this.dirLastname_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Movie Duration";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 12;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // duration
            // 
            this.duration.Location = new System.Drawing.Point(135, 265);
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(242, 22);
            this.duration.TabIndex = 13;
            this.duration.TextChanged += new System.EventHandler(this.duration_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Release Date";
            // 
            // releaseDate
            // 
            this.releaseDate.Location = new System.Drawing.Point(135, 299);
            this.releaseDate.Name = "releaseDate";
            this.releaseDate.Size = new System.Drawing.Size(242, 22);
            this.releaseDate.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Score";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 376);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Review Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 416);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Category";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 456);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Nationality";
            // 
            // category
            // 
            this.category.Location = new System.Drawing.Point(135, 409);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(242, 22);
            this.category.TabIndex = 20;
            // 
            // score
            // 
            this.score.Location = new System.Drawing.Point(135, 333);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(120, 22);
            this.score.TabIndex = 21;
            // 
            // reviewDate
            // 
            this.reviewDate.Location = new System.Drawing.Point(135, 371);
            this.reviewDate.Name = "reviewDate";
            this.reviewDate.Size = new System.Drawing.Size(242, 22);
            this.reviewDate.TabIndex = 22;
            // 
            // Nationality
            // 
            this.Nationality.Location = new System.Drawing.Point(135, 456);
            this.Nationality.Name = "Nationality";
            this.Nationality.Size = new System.Drawing.Size(242, 22);
            this.Nationality.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label10.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label10.Location = new System.Drawing.Point(337, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(407, 39);
            this.label10.TabIndex = 24;
            this.label10.Text = "Admin Panel for MovieDB";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 500);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 16);
            this.label11.TabIndex = 25;
            this.label11.Text = "Comment";
            // 
            // comment
            // 
            this.comment.Location = new System.Drawing.Point(135, 504);
            this.comment.Name = "comment";
            this.comment.Size = new System.Drawing.Size(242, 22);
            this.comment.TabIndex = 26;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 686);
            this.Controls.Add(this.comment);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Nationality);
            this.Controls.Add(this.reviewDate);
            this.Controls.Add(this.score);
            this.Controls.Add(this.category);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.releaseDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.duration);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dirLastname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dirName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.movieTitle);
            this.Controls.Add(this.movieName);
            this.Controls.Add(this.Loadbtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Update);
            this.Controls.Add(Delete);
            this.Controls.Add(this.Add);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load_2);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.score)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Loadbtn;
        private System.Windows.Forms.TextBox movieName;
        private System.Windows.Forms.Label movieTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dirName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dirLastname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox duration;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker releaseDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox category;
        private System.Windows.Forms.NumericUpDown score;
        private System.Windows.Forms.DateTimePicker reviewDate;
        private System.Windows.Forms.TextBox Nationality;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox comment;
    }
}