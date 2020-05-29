namespace _Library_GUI_.Forms
{
    partial class Add_Genre
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
            this.add_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // add_btn
            // 
            this.add_btn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_btn.Location = new System.Drawing.Point(86, 47);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(86, 30);
            this.add_btn.TabIndex = 9;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name:";
            // 
            // name_txt
            // 
            this.name_txt.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_txt.Location = new System.Drawing.Point(86, 12);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(236, 29);
            this.name_txt.TabIndex = 5;
            // 
            // Add_Genre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 81);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name_txt);
            this.Name = "Add_Genre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Genre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name_txt;
    }
}