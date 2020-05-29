namespace _Library_GUI_
{
    partial class Main_Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.create_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.dAuthor_btn = new System.Windows.Forms.Button();
            this.uAuthor_btn = new System.Windows.Forms.Button();
            this.cAuthor_btn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ShowGenres_btn = new System.Windows.Forms.Button();
            this.ShowAuthors_btn = new System.Windows.Forms.Button();
            this.ShowBook_btn = new System.Windows.Forms.Button();
            this.sowBooksSermis_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // create_btn
            // 
            this.create_btn.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.create_btn.Location = new System.Drawing.Point(107, 182);
            this.create_btn.Name = "create_btn";
            this.create_btn.Size = new System.Drawing.Size(75, 32);
            this.create_btn.TabIndex = 0;
            this.create_btn.Text = "Create ";
            this.create_btn.UseVisualStyleBackColor = true;
            this.create_btn.Click += new System.EventHandler(this.create_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.update_btn.Location = new System.Drawing.Point(207, 182);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(75, 32);
            this.update_btn.TabIndex = 1;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete_btn.Location = new System.Drawing.Point(306, 182);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(75, 32);
            this.delete_btn.TabIndex = 2;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // dAuthor_btn
            // 
            this.dAuthor_btn.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dAuthor_btn.Location = new System.Drawing.Point(306, 240);
            this.dAuthor_btn.Name = "dAuthor_btn";
            this.dAuthor_btn.Size = new System.Drawing.Size(75, 32);
            this.dAuthor_btn.TabIndex = 5;
            this.dAuthor_btn.Text = "Delete";
            this.dAuthor_btn.UseVisualStyleBackColor = true;
            // 
            // uAuthor_btn
            // 
            this.uAuthor_btn.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uAuthor_btn.Location = new System.Drawing.Point(207, 240);
            this.uAuthor_btn.Name = "uAuthor_btn";
            this.uAuthor_btn.Size = new System.Drawing.Size(75, 32);
            this.uAuthor_btn.TabIndex = 4;
            this.uAuthor_btn.Text = "Update";
            this.uAuthor_btn.UseVisualStyleBackColor = true;
            this.uAuthor_btn.Click += new System.EventHandler(this.uAuthor_btn_Click);
            // 
            // cAuthor_btn
            // 
            this.cAuthor_btn.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cAuthor_btn.Location = new System.Drawing.Point(107, 240);
            this.cAuthor_btn.Name = "cAuthor_btn";
            this.cAuthor_btn.Size = new System.Drawing.Size(75, 32);
            this.cAuthor_btn.TabIndex = 3;
            this.cAuthor_btn.Text = "Create ";
            this.cAuthor_btn.UseVisualStyleBackColor = true;
            this.cAuthor_btn.Click += new System.EventHandler(this.cAuthor_btn_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(306, 300);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 32);
            this.button4.TabIndex = 8;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(207, 300);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 32);
            this.button5.TabIndex = 7;
            this.button5.Text = "Update";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(107, 300);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 32);
            this.button6.TabIndex = 6;
            this.button6.Text = "Create ";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(172, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Books";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(168, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Authors";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(169, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Genres";
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBox1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(393, 158);
            this.listBox1.TabIndex = 12;
            // 
            // ShowGenres_btn
            // 
            this.ShowGenres_btn.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowGenres_btn.Location = new System.Drawing.Point(12, 300);
            this.ShowGenres_btn.Name = "ShowGenres_btn";
            this.ShowGenres_btn.Size = new System.Drawing.Size(75, 32);
            this.ShowGenres_btn.TabIndex = 15;
            this.ShowGenres_btn.Text = "Show";
            this.ShowGenres_btn.UseVisualStyleBackColor = true;
            this.ShowGenres_btn.Click += new System.EventHandler(this.ShowGenres_btn_Click);
            // 
            // ShowAuthors_btn
            // 
            this.ShowAuthors_btn.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowAuthors_btn.Location = new System.Drawing.Point(12, 240);
            this.ShowAuthors_btn.Name = "ShowAuthors_btn";
            this.ShowAuthors_btn.Size = new System.Drawing.Size(75, 32);
            this.ShowAuthors_btn.TabIndex = 14;
            this.ShowAuthors_btn.Text = "Show";
            this.ShowAuthors_btn.UseVisualStyleBackColor = true;
            this.ShowAuthors_btn.Click += new System.EventHandler(this.ShowAuthors_btn_Click);
            // 
            // ShowBook_btn
            // 
            this.ShowBook_btn.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowBook_btn.Location = new System.Drawing.Point(12, 182);
            this.ShowBook_btn.Name = "ShowBook_btn";
            this.ShowBook_btn.Size = new System.Drawing.Size(75, 32);
            this.ShowBook_btn.TabIndex = 13;
            this.ShowBook_btn.Text = "Show";
            this.ShowBook_btn.UseVisualStyleBackColor = true;
            this.ShowBook_btn.Click += new System.EventHandler(this.ShowBook_btn_Click);
            // 
            // sowBooksSermis_btn
            // 
            this.sowBooksSermis_btn.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sowBooksSermis_btn.Location = new System.Drawing.Point(154, 338);
            this.sowBooksSermis_btn.Name = "sowBooksSermis_btn";
            this.sowBooksSermis_btn.Size = new System.Drawing.Size(75, 32);
            this.sowBooksSermis_btn.TabIndex = 16;
            this.sowBooksSermis_btn.Text = "Show";
            this.sowBooksSermis_btn.UseVisualStyleBackColor = true;
            this.sowBooksSermis_btn.Click += new System.EventHandler(this.sowBooksSermis_btn_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 373);
            this.Controls.Add(this.sowBooksSermis_btn);
            this.Controls.Add(this.ShowGenres_btn);
            this.Controls.Add(this.ShowAuthors_btn);
            this.Controls.Add(this.ShowBook_btn);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.dAuthor_btn);
            this.Controls.Add(this.uAuthor_btn);
            this.Controls.Add(this.cAuthor_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.create_btn);
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button create_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button dAuthor_btn;
        private System.Windows.Forms.Button uAuthor_btn;
        private System.Windows.Forms.Button cAuthor_btn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button ShowGenres_btn;
        private System.Windows.Forms.Button ShowAuthors_btn;
        private System.Windows.Forms.Button ShowBook_btn;
        private System.Windows.Forms.Button sowBooksSermis_btn;
    }
}

