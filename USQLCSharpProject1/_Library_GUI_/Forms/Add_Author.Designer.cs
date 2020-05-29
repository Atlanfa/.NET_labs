namespace _Library_GUI_.Forms
{
    partial class Add_Author
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
            this.name_txt = new System.Windows.Forms.TextBox();
            this.date_of_birth_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.add_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name_txt
            // 
            this.name_txt.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_txt.Location = new System.Drawing.Point(142, 25);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(236, 29);
            this.name_txt.TabIndex = 0;
            // 
            // date_of_birth_txt
            // 
            this.date_of_birth_txt.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date_of_birth_txt.Location = new System.Drawing.Point(142, 60);
            this.date_of_birth_txt.Name = "date_of_birth_txt";
            this.date_of_birth_txt.Size = new System.Drawing.Size(236, 29);
            this.date_of_birth_txt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(78, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(26, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date of birth:";
            // 
            // add_btn
            // 
            this.add_btn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_btn.Location = new System.Drawing.Point(142, 95);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(86, 30);
            this.add_btn.TabIndex = 4;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // Add_Author
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 135);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.date_of_birth_txt);
            this.Controls.Add(this.name_txt);
            this.Name = "Add_Author";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Author";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.TextBox date_of_birth_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button add_btn;
    }
}