namespace _Library_GUI_.Forms
{
    partial class Add_Book
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
            this.title_txt = new System.Windows.Forms.TextBox();
            this.age_txt = new System.Windows.Forms.TextBox();
            this.author_txt = new System.Windows.Forms.TextBox();
            this.genre_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.add_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title_txt
            // 
            this.title_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title_txt.Location = new System.Drawing.Point(99, 14);
            this.title_txt.Name = "title_txt";
            this.title_txt.Size = new System.Drawing.Size(273, 26);
            this.title_txt.TabIndex = 0;
            // 
            // age_txt
            // 
            this.age_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.age_txt.Location = new System.Drawing.Point(99, 46);
            this.age_txt.Name = "age_txt";
            this.age_txt.Size = new System.Drawing.Size(273, 26);
            this.age_txt.TabIndex = 1;
            // 
            // author_txt
            // 
            this.author_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.author_txt.Location = new System.Drawing.Point(99, 78);
            this.author_txt.Name = "author_txt";
            this.author_txt.Size = new System.Drawing.Size(273, 26);
            this.author_txt.TabIndex = 2;
            // 
            // genre_txt
            // 
            this.genre_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genre_txt.Location = new System.Drawing.Point(99, 111);
            this.genre_txt.Name = "genre_txt";
            this.genre_txt.Size = new System.Drawing.Size(273, 26);
            this.genre_txt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Age release:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Id Author:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Id Genre:";
            // 
            // add_btn
            // 
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_btn.Location = new System.Drawing.Point(99, 149);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(64, 29);
            this.add_btn.TabIndex = 9;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // Add_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 188);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.genre_txt);
            this.Controls.Add(this.author_txt);
            this.Controls.Add(this.age_txt);
            this.Controls.Add(this.title_txt);
            this.Name = "Add_Book";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox title_txt;
        private System.Windows.Forms.TextBox age_txt;
        private System.Windows.Forms.TextBox author_txt;
        private System.Windows.Forms.TextBox genre_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button add_btn;
    }
}