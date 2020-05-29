namespace _Library_GUI_.Forms
{
    partial class Datas_FromService
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.show_btn = new System.Windows.Forms.Button();
            this.insert_btn = new System.Windows.Forms.Button();
            this.dit_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(520, 282);
            this.dataGridView1.TabIndex = 0;
            // 
            // show_btn
            // 
            this.show_btn.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.show_btn.Location = new System.Drawing.Point(114, 307);
            this.show_btn.Name = "show_btn";
            this.show_btn.Size = new System.Drawing.Size(75, 32);
            this.show_btn.TabIndex = 1;
            this.show_btn.Text = "Show";
            this.show_btn.UseVisualStyleBackColor = true;
            this.show_btn.Click += new System.EventHandler(this.show_btn_Click);
            // 
            // insert_btn
            // 
            this.insert_btn.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.insert_btn.Location = new System.Drawing.Point(225, 307);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(75, 32);
            this.insert_btn.TabIndex = 2;
            this.insert_btn.Text = "Insert";
            this.insert_btn.UseVisualStyleBackColor = true;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click);
            // 
            // dit_btn
            // 
            this.dit_btn.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dit_btn.Location = new System.Drawing.Point(336, 307);
            this.dit_btn.Name = "dit_btn";
            this.dit_btn.Size = new System.Drawing.Size(75, 32);
            this.dit_btn.TabIndex = 3;
            this.dit_btn.Text = "Update";
            this.dit_btn.UseVisualStyleBackColor = true;
            this.dit_btn.Click += new System.EventHandler(this.dit_btn_Click);
            // 
            // Datas_FromService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 353);
            this.Controls.Add(this.dit_btn);
            this.Controls.Add(this.insert_btn);
            this.Controls.Add(this.show_btn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Datas_FromService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datas_FromService";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button show_btn;
        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.Button dit_btn;
    }
}