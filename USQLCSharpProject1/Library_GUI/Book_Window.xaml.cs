namespace Library_GUI
{
    using Data;
    using System.Linq;
    using System.Windows;
    using _Library_GUI_.CRUD;
    using System.Collections.Generic;
    using _Library_GUI_.ServiceReference1;

    public partial class Book_Window : Window
    {
        Book book;
        string mode;
        int autoIncrement;
        ServiceClient client;
        Book[] books;

        public Book_Window(string mode, int autoIncrement) // Add
        {
            InitializeComponent();
            this.autoIncrement = autoIncrement;
            this.mode = mode;
            exec_btn.Content = mode;
        }

        public Book_Window(string mode, Book book) // Update
        {
            InitializeComponent();
            exec_btn.Content = mode;
            this.mode = mode;
            this.book = book;
            title_txt.Text = book.Title;
            age_txt.Text = book.Age_Release.ToString();
            author_txt.Text = book.Id_Author.ToString();
            genre_txt.Text = book.Id_Genre.ToString();
        }

        public Book_Window(string mode, ServiceClient client)
        {
            InitializeComponent();
            this.client = client;
            this.mode = mode;
        }

        private void exec_btn_Click(object sender, RoutedEventArgs e)
        {
            if (mode.Equals("Add"))
            {
                // Если мы оставили все поля пустыми:
                if (title_txt.Text == "" && age_txt.Text == "" && author_txt.Text == "" && genre_txt.Text == "")
                {
                    MessageBox.Show("Вы оставили все поля пустыми", "Все поля пустые...", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                // Если мы оставили все поля пустыми:
                else if (title_txt.Text == "" || age_txt.Text == "" || author_txt.Text == "" || genre_txt.Text == "")
                {
                    MessageBox.Show("Какое то пеле оставили пустым", "Пустое к-ето поле...", MessageBoxButton.OK, MessageBoxImage.Warning);
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
                            Date_Updated = System.DateTime.Now
                        };

                        // Add to Books table of databese:
                        string msg = InsertToDatabase.InsertBook(book);
                        MessageBox.Show(msg, "Added");

                        (this.Owner as MainWindow).listBox1.Items.Add(book);
                        (this.Owner as MainWindow).listBox1.Items.Clear();

                        books = ReadFromDatabase.ReadAllBooks().ToArray();

                        // Ubdate listbox to curent datas from a table Books:
                        foreach (Book b in books) (this.Owner as MainWindow).listBox1.Items.Add(b);
                        ClearFields();
                        this.Close();
                    }
                    catch { MessageBox.Show("Вы ввели символи, или строку вместо целого числа", "Не правильный формат", MessageBoxButton.OK, MessageBoxImage.Warning); }
                }
            }
            else if (mode.Equals("Update"))
            {
                // Если мы оставили все поля пустыми:
                if (title_txt.Text == "" && age_txt.Text == "" && author_txt.Text == "" && genre_txt.Text == "")
                {
                    MessageBox.Show("Вы оставили все поля пустыми", "Все поля пустые...", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                // Если мы оставили все поля пустыми:
                else if (title_txt.Text == "" || age_txt.Text == "" || author_txt.Text == "" || genre_txt.Text == "")
                {
                    MessageBox.Show("Какое то пеле оставили пустым", "Пустое к-ето поле...", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else
                {
                    try
                    {
                        My_Context db = new My_Context();
                        int index = (this.Owner as MainWindow).listBox1.Items.IndexOf(this.book);

                        // Get Id entity from the Table:
                        int id = book.Id;

                        // Get entity from DbSet to Id and edit it:
                        List<Book> all = ReadFromDatabase.ReadAllBooks();
                        Book updated = all.Where(u => u.Id == id).FirstOrDefault();
                        //updated.Id = index + 1;
                        updated.Title = title_txt.Text;
                        updated.Age_Release = int.Parse(age_txt.Text);
                        updated.Id_Author = int.Parse(author_txt.Text);
                        updated.Id_Genre = int.Parse(genre_txt.Text);
                        updated.Date_Updated = System.DateTime.Now;

                        //string msg = UpdateFromDatrabase.EditBook(updated);

                        // Update to Database:
                        db.Entry(updated).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        //MessageBox.Show(msg, "Updated");

                        (this.Owner as MainWindow).listBox1.Items.RemoveAt(index);
                        (this.Owner as MainWindow).listBox1.Items.Insert(index, updated);
                        (this.Owner as MainWindow).listBox1.Items.Clear();

                        books = ReadFromDatabase.ReadAllBooks().ToArray();
                        foreach (Book b in books) (this.Owner as MainWindow).listBox1.Items.Add(b);
                        this.Close();
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.Message, "System Exception..Failed..", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
            else
                MessageBox.Show("Incorrect sting parameter 'mode'..", "Something went wrong...", MessageBoxButton.OK, MessageBoxImage.Warning);
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
