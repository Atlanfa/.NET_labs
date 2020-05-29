namespace _Library_GUI_.Forms
{
    using Data;
    using System;
    using _Library_GUI_.CRUD;
    using System.Windows.Forms;

    public partial class Add_Author : Form
    {
        int autoIncrement = 0;
        string mode;
        Author author;


        public Add_Author(string mode, int autoIncrement)   //Add
        {
            InitializeComponent();
            this.mode = mode;
            this.autoIncrement = autoIncrement;
            add_btn.Text = "Add";

        }

        public Add_Author(string mode, Author author) //Edit
        {
            InitializeComponent();
            this.mode = mode;
            this.author = author;
            add_btn.Text = "Update";
            name_txt.Text = author.Name;
            date_of_birth_txt.Text = author.Date_of_Birth.ToString();


        }
        private void add_btn_Click(object sender, EventArgs e)
        {
            if (mode.Equals("Add"))
            {
                if(name_txt.Text == "" && date_of_birth_txt.Text == "")
                {
                    MessageBox.Show("Вы оставили все поля пустыми", "Все поля пустые...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (name_txt.Text == "" || date_of_birth_txt.Text == "")
                {
                    MessageBox.Show("Какое то пеле оставили пустым", "Пустое к-ето поле...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        Author author = new Author
                        {
                            Id = autoIncrement,
                            Name = name_txt.Text,
                            Date_of_Birth = int.Parse(date_of_birth_txt.Text)
                        };

                        string msg = InsertToDatabase.InsertAuthor(author);
                        MessageBox.Show(msg, "Added");
                        (this.Owner as Main_Form).listBox1.Items.Add(author);
                        (this.Owner as Main_Form).listBox1.Items.Clear();
                        (this.Owner as Main_Form).listBox1.Items.AddRange(ReadFromDatabase.ReadAllAuthors().ToArray());
                        name_txt.Text = "";
                        date_of_birth_txt.Text = "";
                        this.Close();
                    }
                    catch { MessageBox.Show("Вы ввели символи, или строку вместо целого числа", "Не правильный формат", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

                }
            }
            else if (mode.Equals("Edit"))
            {
                if (name_txt.Text == "" && date_of_birth_txt.Text == "")
                {
                    MessageBox.Show("Вы оставили все поля пустыми", "Все поля пустые...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (name_txt.Text == "" || date_of_birth_txt.Text == "")
                {
                    MessageBox.Show("Какое то пеле оставили пустым", "Пустое к-ето поле...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int index = (this.Owner as Main_Form).listBox1.Items.IndexOf(this.author);
                    Author updated = new Author();
                    updated.Id = index + 1;
                    updated.Name = name_txt.Text;
                    updated.Date_of_Birth = int.Parse(date_of_birth_txt.Text);

                    string msg = UpdateFromDatrabase.EditAuthor(updated);
                    MessageBox.Show(msg, "Updated");

                    (this.Owner as Main_Form).listBox1.Items.RemoveAt(index);
                    (this.Owner as Main_Form).listBox1.Items.Insert(index, updated);
                    (this.Owner as Main_Form).listBox1.Items.Clear();
                    (this.Owner as Main_Form).listBox1.Items.AddRange(ReadFromDatabase.ReadAllAuthors().ToArray());
                    this.Close();
                }
            }
        }
    }
}
