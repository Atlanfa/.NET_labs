namespace Library_GUI
{
    using Data;
    using System.Windows;
    using _Library_GUI_.CRUD;
    using System.Windows.Documents;
    using System.Collections.Generic;

    public partial class MainWindow : Window
    {
        int count;
        public MainWindow()
        {
            InitializeComponent();
            count = 0;
        }

        private void linq_queries_Click(object sender, RoutedEventArgs e)
        {
            new Queries_Window().ShowDialog();
        }

        private void wcf_btn_Click(object sender, RoutedEventArgs e)
        {
            new Service_Window().ShowDialog();
        }

        #region Buttons C.R.U.D Books:

        private void show_books_Click(object sender, RoutedEventArgs e)
        {
            listBox1.Items.Clear();
            Book[] books = ReadFromDatabase.ReadAllBooks().ToArray();
            foreach(Book b in books) listBox1.Items.Add(b);
        }

        private void insert_books_Click(object sender, RoutedEventArgs e)
        {
            count++;
            Book_Window book_form = new Book_Window("Add", count);
            book_form.Owner = this;
            book_form.Title = "Insert Book";
            book_form.ShowDialog();
        }

        private void edit_books_Click(object sender, RoutedEventArgs e)
        {
            if (listBox1.Items.Count != 0)
            {
                if (listBox1.SelectedItem != null)
                {
                    Book select_book = listBox1.SelectedItem as Book;
                    Book_Window edit_form = new Book_Window("Update", select_book);
                    edit_form.Title = "Edit Book";
                    edit_form.Owner = this;
                    edit_form.ShowDialog();
                }
                else MessageBox.Show("Елемент(Книга) не выбрана со списка! Попробуйте сначала выбрать", "Ничего не выбрано",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else MessageBox.Show("Список пуст! Попробуйте сначала наполнить его.", "Пусто..",
                MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        private void delete_books_Click(object sender, RoutedEventArgs e)
        {
            if (listBox1.Items.Count != 0)
            {
                if (listBox1.SelectedItem != null)
                {
                    Book delete = listBox1.SelectedItem as Book;
                    string msg = DeleteFromDatabase.DeleteBook(delete);
                    MessageBox.Show(msg, "Deleted");

                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                }
                else MessageBox.Show("Елемент(Книга) не выбрана со списка! Попробуйте сначала выбрать", "Ничего не выбрано",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else MessageBox.Show("Список пуст! Попробуйте сначала наполнить его.", "Пусто..",
                MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        #endregion

        #region Buttons C.R.U.D Authors:

        private void show_authors_Click(object sender, RoutedEventArgs e)
        {
            listBox1.Items.Clear();
            Author[] authors = ReadFromDatabase.ReadAllAuthors().ToArray();
            foreach (Author a in authors) listBox1.Items.Add(a);
        }

        private void insert_authors_Click(object sender, RoutedEventArgs e)
        {
            count++;
            Author_Window book_form = new Author_Window("Add", count);
            book_form.Owner = this;
            book_form.Title = "Insert Author";
            book_form.ShowDialog();
        }

        private void edit_authors_Click(object sender, RoutedEventArgs e)
        {
            if (listBox1.Items.Count != 0)
            {
                if (listBox1.SelectedItem != null)
                {
                    Author select_author = listBox1.SelectedItem as Author;
                    Author_Window edit_form = new Author_Window("Update", select_author);
                    edit_form.Title = "Edit Author";
                    edit_form.Owner = this;
                    edit_form.ShowDialog();
                }
                else MessageBox.Show("Елемент(Author) не выбрана со списка! Попробуйте сначала выбрать", "Ничего не выбрано",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else MessageBox.Show("Список пуст! Попробуйте сначала наполнить его.", "Пусто..",
                MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        private void delete_authors_Click(object sender, RoutedEventArgs e)
        {
            if (listBox1.Items.Count != 0)
            {
                if (listBox1.SelectedItem != null)
                {
                    Author delete = listBox1.SelectedItem as Author;
                    string msg = DeleteFromDatabase.DeleteAuthor(delete);
                    MessageBox.Show(msg, "Deleted");

                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                }
                else MessageBox.Show("Елемент(Author) не выбрана со списка! Попробуйте сначала выбрать", "Ничего не выбрано",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else MessageBox.Show("Список пуст! Попробуйте сначала наполнить его.", "Пусто..",
                MessageBoxButton.OK, MessageBoxImage.Warning);
        }


        #endregion

        #region Buttons C.R.U.D Genre:

        private void show_genres_Click(object sender, RoutedEventArgs e)
        {
            listBox1.Items.Clear();
            Genre[] genres = ReadFromDatabase.ReadAllGenres().ToArray();
            foreach (Genre g in genres) listBox1.Items.Add(g);
        }

        private void insert_genres_Click(object sender, RoutedEventArgs e)
        {
            count++;
            Genre_Window genre_form = new Genre_Window("Add", count);
            genre_form.Owner = this;
            genre_form.Title = "Insert Genre";
            genre_form.ShowDialog();
        }

        private void edit_genres_Click(object sender, RoutedEventArgs e)
        {
            if (listBox1.Items.Count != 0)
            {
                if (listBox1.SelectedItem != null)
                {
                    Genre select_genre = listBox1.SelectedItem as Genre;
                    Genre_Window edit_form = new Genre_Window("Update", select_genre);
                    edit_form.Title = "Edit Genre";
                    edit_form.Owner = this;
                    edit_form.ShowDialog();
                }
                else MessageBox.Show("Елемент(Genre) не выбрана со списка! Попробуйте сначала выбрать", "Ничего не выбрано",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else MessageBox.Show("Список пуст! Попробуйте сначала наполнить его.", "Пусто..",
                MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        private void delete_genres_Click(object sender, RoutedEventArgs e)
        {
            if (listBox1.Items.Count != 0)
            {
                if (listBox1.SelectedItem != null)
                {
                    Genre delete = listBox1.SelectedItem as Genre;
                    string msg = DeleteFromDatabase.DeleteGenre(delete);
                    MessageBox.Show(msg, "Deleted");

                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                }
                else MessageBox.Show("Елемент(Genre) не выбрана со списка! Попробуйте сначала выбрать", "Ничего не выбрано",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else MessageBox.Show("Список пуст! Попробуйте сначала наполнить его.", "Пусто..",
                MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        #endregion

        private void serialize_btn_Click(object sender, RoutedEventArgs e)
        {
            new Serialize_Window().Show();
        }

        private void msmq_btn_Click(object sender, RoutedEventArgs e)
        {
            new MSMQ_Messages_Window().ShowDialog();
        }
    }
}
