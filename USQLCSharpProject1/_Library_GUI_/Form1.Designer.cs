namespace _Library_GUI_
{
    partial class Form1
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
            this.SuspendLayout();
            // 
            // create_btn
            // 
            this.create_btn.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.create_btn.Location = new System.Drawing.Point(31, 182);
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
            this.update_btn.Location = new System.Drawing.Point(132, 182);
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
            this.delete_btn.Location = new System.Drawing.Point(235, 182);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(75, 32);
            this.delete_btn.TabIndex = 2;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            // 
            // dAuthor_btn
            // 
            this.dAuthor_btn.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dAuthor_btn.Location = new System.Drawing.Point(235, 240);
            this.dAuthor_btn.Name = "dAuthor_btn";
            this.dAuthor_btn.Size = new System.Drawing.Size(75, 32);
            this.dAuthor_btn.TabIndex = 5;
            this.dAuthor_btn.Text = "Delete";
            this.dAuthor_btn.UseVisualStyleBackColor = true;
            // 
            // uAuthor_btn
            // 
            this.uAuthor_btn.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uAuthor_btn.Location = new System.Drawing.Point(132, 240);
            this.uAuthor_btn.Name = "uAuthor_btn";
            this.uAuthor_btn.Size = new System.Drawing.Size(75, 32);
            this.uAuthor_btn.TabIndex = 4;
            this.uAuthor_btn.Text = "Update";
            this.uAuthor_btn.UseVisualStyleBackColor = true;
            // 
            // cAuthor_btn
            // 
            this.cAuthor_btn.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cAuthor_btn.Location = new System.Drawing.Point(31, 240);
            this.cAuthor_btn.Name = "cAuthor_btn";
            this.cAuthor_btn.Size = new System.Drawing.Size(75, 32);
            this.cAuthor_btn.TabIndex = 3;
            this.cAuthor_btn.Text = "Create ";
            this.cAuthor_btn.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(235, 300);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 32);
            this.button4.TabIndex = 8;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(132, 300);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 32);
            this.button5.TabIndex = 7;
            this.button5.Text = "Update";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(31, 300);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 32);
            this.button6.TabIndex = 6;
            this.button6.Text = "Create ";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Books";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Authors";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
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
            this.listBox1.Size = new System.Drawing.Size(339, 158);
            this.listBox1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 344);
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
            this.Name = "Form1";
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
    }
}

