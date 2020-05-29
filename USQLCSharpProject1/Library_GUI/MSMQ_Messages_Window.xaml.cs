namespace Library_GUI
{
    using Data;
    using System.Windows;
    using _Library_GUI_.CRUD;
    using System.Collections.Generic;

    public partial class MSMQ_Messages_Window : Window
    {
        List<Book> books = ReadFromDatabase.ReadAllBooks();
        List<Author> authors = ReadFromDatabase.ReadAllAuthors();
        List<Genre> genres = ReadFromDatabase.ReadAllGenres();
        public MSMQ_Messages_Window()
        {
            InitializeComponent();

            MSMQ_Messages msmq = new MSMQ_Messages();
            List<string> result_msg = msmq.Messages(books);
            // msmq.MessagesAuthor(authors);
            // msmq.Messages(genres);

            foreach (string str in result_msg)
                listBox.Items.Add(str);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
