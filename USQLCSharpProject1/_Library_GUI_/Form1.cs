using _Library_GUI_.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using USQLCSharpProject1;

namespace _Library_GUI_
{
    public partial class Form1 : Form
    {
        List<Book> books;
        List<Author> authors;
        List<Book_Author_m2m> book_Author_M2Ms;
        List<Book_Genre_m2m> book_Genre_M2Ms;
        List<Genre> genres;
        public Form1()
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
            Add_Book book_form = new Add_Book();
            book_form.Owner = this;
            book_form.ShowDialog();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
