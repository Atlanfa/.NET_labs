namespace _Library_GUI_.Forms
{
    using Data;
    using System;
    using _Library_GUI_.CRUD;
    using System.Windows.Forms;
    using _Library_GUI_.ServiceReference1;
    using System.Data;

    public partial class Add_Book : Form
    {
        ServiceReference1.ServiceClient client;
        int autoIncrement = 0;
        string mode;
        Book book;
        public Add_Book(string mode, int autoIncrement) // Add
        {
            InitializeComponent();
            this.autoIncrement = autoIncrement;
            this.mode = mode;
            add_btn.Text = "Add";
        }

        public Add_Book(string mode, Book book) // Update
        {
            InitializeComponent();
            add_btn.Text = "Update";
            this.mode = mode;
            this.book = book;
            title_txt.Text = book.Title;
            age_txt.Text = book.Age_Release.ToString();
            author_txt.Text = book.Id_Author.ToString();
            genre_txt.Text = book.Id_Genre.ToString();
        }

        public Add_Book(string mode, ServiceReference1.ServiceClient client)
        {
            InitializeComponent();
            this.client = client;
            this.mode = mode;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (mode.Equals("Add")) // mode == "Add"
            {
                // Если мы оставили все поля пустыми:
                if (title_txt.Text == "" && age_txt.Text == "" && author_txt.Text == "" && genre_txt.Text == "")
                {
                    MessageBox.Show("Вы оставили все поля пустыми", "Все поля пустые...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                // Если мы оставили все поля пустыми:
                else if (title_txt.Text == "" || age_txt.Text == "" || author_txt.Text == "" || genre_txt.Text == "")
                {
                    MessageBox.Show("Какое то пеле оставили пустым", "Пустое к-ето поле...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        Book book = new Book
                        {
                            Id = autoIncrement,
                            Title = title_txt.Text,
                            Age_Release = int.Parse(age_txt.Text),
                            Id_Author = int.Parse(author_txt.Text),
                            Id_Genre = int.Parse(genre_txt.Text),
                            Date_Updated = DateTime.Now
                        };

                        // Add to Books table of databese:
                        string msg = InsertToDatabase.InsertBook(book);
                        MessageBox.Show(msg, "Added");

                        (this.Owner as Main_Form).listBox1.Items.Add(book);
                        (this.Owner as Main_Form).listBox1.Items.Clear();
                        (this.Owner as Main_Form).listBox1.Items.AddRange(ReadFromDatabase.ReadAllBooks().ToArray());
                        ClearFields();
                        this.Close();
                    }
                    catch { MessageBox.Show("Вы ввели символи, или строку вместо целого числа", "Не правильный формат", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                }
            }
            else if (mode.Equals("Edit"))
            {
                // Если мы оставили все поля пустыми:
                if (title_txt.Text == "" && age_txt.Text == "" && author_txt.Text == "" && genre_txt.Text == "")
                {
                    MessageBox.Show("Вы оставили все поля пустыми", "Все поля пустые...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                // Если мы оставили все поля пустыми:
                else if (title_txt.Text == "" || age_txt.Text == "" || author_txt.Text == "" || genre_txt.Text == "")
                {
                    MessageBox.Show("Какое то пеле оставили пустым", "Пустое к-ето поле...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int index = (this.Owner as Main_Form).listBox1.Items.IndexOf(this.book);
                    Book updated = new Book();
                    updated.Id = index + 1;
                    updated.Title = title_txt.Text;
                    updated.Age_Release = int.Parse(age_txt.Text);
                    updated.Id_Author = int.Parse(author_txt.Text);
                    updated.Id_Genre = int.Parse(genre_txt.Text);
                    updated.Date_Updated = DateTime.Now;

                    string msg = UpdateFromDatrabase.EditBook(updated);
                    MessageBox.Show(msg, "Updated");

                    (this.Owner as Main_Form).listBox1.Items.RemoveAt(index);
                    (this.Owner as Main_Form).listBox1.Items.Insert(index, updated);
                    (this.Owner as Main_Form).listBox1.Items.Clear();
                    (this.Owner as Main_Form).listBox1.Items.AddRange(ReadFromDatabase.ReadAllBooks().ToArray());
                    this.Close();
                }
            }
            else if (mode.Equals("ServiceWCF"))
            {
                // Если мы оставили все поля пустыми:
                if (title_txt.Text == "" && age_txt.Text == "" && author_txt.Text == "" && genre_txt.Text == "")
                {
                    MessageBox.Show("Вы оставили все поля пустыми", "Все поля пустые...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                // Если мы оставили все поля пустыми:
                else if (title_txt.Text == "" || age_txt.Text == "" || author_txt.Text == "" || genre_txt.Text == "")
                {
                    MessageBox.Show("Какое то пеле оставили пустым", "Пустое к-ето поле...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        BookService service = new BookService();
                        service.Title = title_txt.Text;
                        service.Age_Release = int.Parse(age_txt.Text);
                        service.Id_Author = int.Parse(author_txt.Text);
                        service.Id_Genre = int.Parse(genre_txt.Text);
                        service.Date_Updated = DateTime.Now;

                        client.Insert_Book(service);

                        ClearFields();
                        Close();
                    }
                    catch (DataException dex)
                    {
                        MessageBox.Show(dex.Message, "Something went wrong...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        void ClearFields()
        {
            title_txt.Text = "";
            age_txt.Text = "";
            author_txt.Text = "";
            genre_txt.Text = "";
        }
    }
}
