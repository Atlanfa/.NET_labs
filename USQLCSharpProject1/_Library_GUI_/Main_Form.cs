namespace _Library_GUI_
{
    using Data;
    using System;
    using _Library_GUI_.CRUD;
    using _Library_GUI_.Forms;
    using System.Windows.Forms;
    using System.Collections.Generic;
    // www.mysite.somee.com
    public partial class Main_Form : Form
    {
        List<Book> books;
        List<Author> authors;
        List<Book_Author_m2m> book_Author_M2Ms;
        List<Book_Genre_m2m> book_Genre_M2Ms;
        List<Genre> genres;
        int count = 0;
        public Main_Form()
        {
            InitializeComponent();
            books = new List<Book>();
            authors = new List<Author>();
            book_Author_M2Ms = new List<Book_Author_m2m>();
            book_Genre_M2Ms = new List<Book_Genre_m2m>();
            genres = new List<Genre>();
        }

        private void create_btn_Click(object sender, EventArgs e)
        {
            count++;
            Add_Book book_form = new Add_Book("Add", count);
            book_form.Owner = this;
            book_form.ShowDialog();
        }

        private void cAuthor_btn_Click(object sender, EventArgs e)
        {
            count++;
            Add_Author author_form = new Add_Author("Add", count);
            author_form.Owner = this;
            author_form.ShowDialog();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count != 0)
            {
                if (listBox1.SelectedItem != null)
                {
                    Book select_book = listBox1.SelectedItem as Book;
                    Add_Book edit_form = new Add_Book("Edit", select_book);
                    edit_form.Text = "Edit Book";
                    edit_form.Owner = this;
                    edit_form.ShowDialog();
                }
                else MessageBox.Show("Елемент(Книга) не выбрана со списка! Попробуйте сначала выбрать", "Ничего не выбрано", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else MessageBox.Show("Список пуст! Попробуйте сначала наполнить его.", "Пусто..", 
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void delete_btn_Click(object sender, EventArgs e)
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
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else MessageBox.Show("Список пуст! Попробуйте сначала наполнить его.", "Пусто..",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ShowBook_btn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Book[] books = ReadFromDatabase.ReadAllBooks().ToArray();
            listBox1.Items.AddRange(books);
        }

        private void ShowAuthors_btn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<Author> authors = ReadFromDatabase.ReadAllAuthors();
            listBox1.Items.AddRange(authors.ToArray());

        }

        private void ShowGenres_btn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<Genre> genres = ReadFromDatabase.ReadAllGenres();
            listBox1.Items.AddRange(genres.ToArray());
        }

        private void uAuthor_btn_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Add_Genre addGenre = new Add_Genre("Add");
            addGenre.Owner = this;
            addGenre.ShowDialog();
        }

        private void sowBooksSermis_btn_Click(object sender, EventArgs e)
        {
            new Datas_FromService().ShowDialog();
        }
    }
}
