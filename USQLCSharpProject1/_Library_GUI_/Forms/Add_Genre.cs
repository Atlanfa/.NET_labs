namespace _Library_GUI_.Forms
{
    using Data;
    using System;
    using System.Linq;
    using _Library_GUI_.CRUD;
    using System.Windows.Forms;
    using System.Collections.Generic;

    public partial class Add_Genre : Form
    {
        My_Context db;
        Genre genre;
        string mode;
        public Add_Genre(string mode)
        {
            InitializeComponent();
            this.mode = mode;
            db = new My_Context();
        }

        public Add_Genre(string mode, Genre genre)
        {
            InitializeComponent();
            this.mode = mode;
            this.genre = genre;
            db = new My_Context();
            genre.Name = name_txt.Text;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            List<Genre> genres = db.Genres.ToList();
            if (mode.Equals("Add"))
            {
                if (name_txt.Text != "")
                {
                    db.Genres.Add(new Genre { Name = name_txt.Text });
                    db.SaveChanges(); // Add this data on a table
                    name_txt.Text = "";
                    (this.Owner as Main_Form).listBox1.Items.Clear();
                    (this.Owner as Main_Form).listBox1.Items.AddRange(genres.ToArray());
                    Close();
                }
                else MessageBox.Show("Field Name is Empty... Try to fill out it!", "Name - EMPTY", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (mode.Equals("Edit"))
            {
               
            }
        }
    }
}
