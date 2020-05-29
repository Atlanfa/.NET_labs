namespace Library_GUI
{
    using Data;
    using System.Linq;
    using System.Windows;
    using _Library_GUI_.CRUD;
    using System.Collections.Generic;
    using _Library_GUI_.ServiceReference1;

    public partial class Genre_Window : Window
    {
        string mode;
        Genre[] genres;
        Genre genre;
        int autoIncrement;
        ServiceClient client;

        public Genre_Window(string mode, int autoIncrement) // Add
        {
            InitializeComponent();
            this.autoIncrement = autoIncrement;
            this.mode = mode;
            exec_btn.Content = mode;
        }

        public Genre_Window(string mode, Genre genre)    // Update
        {
            InitializeComponent();
            exec_btn.Content = mode;
            this.mode = mode;
            this.genre = genre;
            name_txt.Text = genre.Name;
        }

        public Genre_Window(string mode, ServiceClient client)  // WCF
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
                if (name_txt.Text == "")
                {
                    MessageBox.Show("Вы оставили все поля пустыми", "Все поля пустые...", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                // Если мы оставили все поля пустыми:
                else if (name_txt.Text == "")
                {
                    MessageBox.Show("Какое то пеле оставили пустым", "Пустое к-ето поле...", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else
                {
                    try
                    {
                        Genre g = new Genre
                        {
                            Id = autoIncrement,
                            Name = name_txt.Text
                        };

                        // Add to Books table of databese:
                        string msg = InsertToDatabase.InsertGenre(g);
                        MessageBox.Show(msg, "Added");

                        (this.Owner as MainWindow).listBox1.Items.Add(g);
                        (this.Owner as MainWindow).listBox1.Items.Clear();

                        genres = ReadFromDatabase.ReadAllGenres().ToArray();

                        // Ubdate listbox to curent datas from a table Books:
                        foreach (Genre gg in genres) (this.Owner as MainWindow).listBox1.Items.Add(gg);
                        ClearFields();
                        this.Close();
                    }
                    catch { MessageBox.Show("Вы ввели символи, или строку вместо целого числа", "Не правильный формат", MessageBoxButton.OK, MessageBoxImage.Warning); }
                }
            }
            else if (mode.Equals("Update"))
            {
                // Если мы оставили все поля пустыми:
                if (name_txt.Text == "")
                {
                    MessageBox.Show("Вы оставили все поля пустыми", "Все поля пустые...", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                // Если мы оставили все поля пустыми:
                else if (name_txt.Text == "")
                {
                    MessageBox.Show("Какое то пеле оставили пустым", "Пустое к-ето поле...", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else
                {
                    try
                    {
                        My_Context db = new My_Context();
                        int index = (this.Owner as MainWindow).listBox1.Items.IndexOf(this.genre);

                        // Get Id entity from the Table:
                        int id = genre.Id;

                        // Get entity from DbSet to Id and edit it:
                        List<Genre> all = ReadFromDatabase.ReadAllGenres();
                        Genre updated = all.Where(u => u.Id == id).FirstOrDefault();
                        //updated.Id = index + 1;
                        updated.Name = name_txt.Text;

                        // Update to Database:
                        db.Entry(updated).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        //MessageBox.Show(msg, "Updated");

                        (this.Owner as MainWindow).listBox1.Items.RemoveAt(index);
                        (this.Owner as MainWindow).listBox1.Items.Insert(index, updated);
                        (this.Owner as MainWindow).listBox1.Items.Clear();

                        genres = ReadFromDatabase.ReadAllGenres().ToArray();
                        foreach (Genre b in genres) (this.Owner as MainWindow).listBox1.Items.Add(b);
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
            name_txt.Text = "";
        }
    }
}
