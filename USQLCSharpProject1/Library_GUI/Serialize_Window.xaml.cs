namespace Library_GUI
{
    using Data;
    using System.IO;
    using System.Windows;
    using _Library_GUI_.CRUD;
    using System.Xml.Serialization;
    using System.Collections.Generic;
    using System.Runtime.Serialization.Formatters.Binary;

    public partial class Serialize_Window : Window
    {
        public Serialize_Window()
        {
            InitializeComponent();
        }

        private void selialize_btn_Click(object sender, RoutedEventArgs e)
        {
            List<Book> listBooks = ReadFromDatabase.ReadAllBooks();

            // BinaryFormatter:
            FileStream fs, fs1, fs2;
            BinaryFormatter formatter = new BinaryFormatter();
            using (fs = new FileStream("ListBooks.txt", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, listBooks);
                fs.Close();
                Title = "Collection of a PC is Serialize";
            }

            // XmlSerializer:
            XmlSerializer xml_formatter = new XmlSerializer(typeof(Book));

            using (fs1 = new FileStream("list_books.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs1, listBooks);
                fs1.Close();
            }

            // JsonSerializer:
            using (fs2 = new FileStream("books_serialize.json", FileMode.OpenOrCreate))
            {
                // JsonSerializer.Serialize<List<Book>>(fs2, listBooks);
                Title = "Data has been saved to file";
                fs2.Close();
            }
        }

        private void deselialize_Copy_Click(object sender, RoutedEventArgs e)
        {
            // BinaryFormatter:
            FileStream fs1, fs2, fs3;
            BinaryFormatter formatter = new BinaryFormatter();
            using (fs1 = new FileStream("ListBooks.txt", FileMode.Open))
            {
                List<Book> deserialize = formatter.Deserialize(fs1) as List<Book>;
                foreach (Book b in deserialize) listBox.Items.Add(b);
                Title = "Deserialized";
            }

            // XmlDeserialiser:
            using (fs2 = new FileStream("list_books.xml", FileMode.OpenOrCreate))
            {
                List<Book> deserialize = (List<Book>)formatter.Deserialize(fs2);
                foreach (Book b in deserialize) listBox.Items.Add(b);
            }

            // JsonSerializer:
            using (fs3 = new FileStream("books_serialize.json", FileMode.OpenOrCreate))
            {
                //  List<Book> deserialize = JsonSerializer.Deserialize<List<Book>>(fs3);
                // foreach (Book b in deserialize) listBox.Items.Add(b);
            }

            // For Autors table:

            // For Genres table:
        }
    }
}
