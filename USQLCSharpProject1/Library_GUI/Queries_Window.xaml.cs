namespace Library_GUI
{ 
    using Data;
    using System;
    using System.Linq;
    using Logic_Querys;
    using System.Windows;
    using System.Collections.Generic;

    public partial class Queries_Window : Window
    {
        LINQ_QUERYs query;
        public Queries_Window()
        {
            InitializeComponent();
            query = new LINQ_QUERYs();
            back_btn.Visibility = listBox.Visibility = Visibility.Hidden;
        }

        private void exec_btn_1_Click(object sender, RoutedEventArgs e)
        {
            Hidden_Controls();
            try
            {
                int id = Convert.ToInt32(query1_txt.Text);
                List<Book> result = query.ListBooksAuthId(id).ToList();
                if (result.Count != 0)   // Если запрос вернул данные с таблицы
                    foreach (Book b in result)
                        listBox.Items.Add(b);
                else
                {
                    string empty = "Данных по данному запросу не найдены...Попробуйте наполнить таблицу!";
                    listBox.Items.Add(empty);
                }
            }
            catch(Exception ex)
            {
                this.Title = ex.Message;
            }
        }

        private void exec_btn_2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Hidden_Controls();
                int id = Convert.ToInt32(query2_txt.Text);
                List<Author> result = query.ListAuthorsYear(id).ToList();
                if (result.Count != 0)   // Если запрос вернул данные с таблицы
                    foreach (Author b in result)
                        listBox.Items.Add(b);
                else
                {
                    string empty = "Данных по данному запросу не найдены...Попробуйте наполнить таблицу!";
                    listBox.Items.Add(empty);
                }
            }
            catch (Exception ex)
            {
                this.Title = ex.Message;
            }
        }

        private void exec_btn_3_Click(object sender, RoutedEventArgs e)
        {
            Hidden_Controls();
            try
            {
                List<Author> result = query.Top3OldestAuthors().ToList();
                if (result.Count != 0)   // Если запрос вернул данные с таблицы
                    foreach (Author b in result)
                        listBox.Items.Add(b);
                else
                {
                    string empty = "Данных по данному запросу не найдены...Попробуйте наполнить таблицу!";
                    listBox.Items.Add(empty);
                }
            }
            catch (Exception ex)
            {
                this.Title = ex.Message;
            }
        }

        private void exec_btn_4_Click(object sender, RoutedEventArgs e)
        {
            Hidden_Controls();
            try
            {
                List<Author> result = query.Top3YoungAuthors().ToList();
                if (result.Count != 0)   // Если запрос вернул данные с таблицы
                    foreach (Author b in result)
                        listBox.Items.Add(b);
                else
                {
                    string empty = "Данных по данному запросу не найдены...Попробуйте наполнить таблицу!";
                    listBox.Items.Add(empty);
                }
            }
            catch (Exception ex)
            {
                this.Title = ex.Message;
            }
        }

        private void exec_btn_5_Click(object sender, RoutedEventArgs e)
        {
            Hidden_Controls();
            try
            {
                int age = Convert.ToInt32(query1_txt.Text);
                List<Book> result = query.BooksAgeRelease(age).ToList();
                if (result.Count != 0)   // Если запрос вернул данные с таблицы
                    foreach (Book b in result)
                        listBox.Items.Add(b);
                else
                {
                    string empty = "Данных по данному запросу не найдены...Попробуйте наполнить таблицу!";
                    listBox.Items.Add(empty);
                }
            }
            catch (Exception ex)
            {
                this.Title = ex.Message;
            }
        }

        private void back_btn_Click(object sender, RoutedEventArgs e)
        {
            listBox.Items.Clear();
            Show_Controls();
        }

        // Прячем все контролы, и показываем ListBox для вывода результатов по запросам:
        void Hidden_Controls()
        {
            l1.Visibility = l2.Visibility = l3.Visibility = l4.Visibility = l5.Visibility
                = query1_txt.Visibility = query2_txt.Visibility = query5_txt.Visibility
                = exec_btn_1.Visibility = exec_btn_2.Visibility = exec_btn_3.Visibility = exec_btn_4.Visibility = exec_btn_5.Visibility
                = Visibility.Hidden;
            back_btn.Visibility = listBox.Visibility = Visibility.Visible;
        }

        // Показываем все контролы, и скрываем обратно ListBox:
        void Show_Controls()
        {
            l1.Visibility = l2.Visibility = l3.Visibility = l4.Visibility = l5.Visibility
              = query1_txt.Visibility = query2_txt.Visibility = query5_txt.Visibility
              = exec_btn_1.Visibility = exec_btn_2.Visibility = exec_btn_3.Visibility = exec_btn_4.Visibility = exec_btn_5.Visibility
              = Visibility.Visible;
            back_btn.Visibility = listBox.Visibility = Visibility.Hidden;
        }
    }
}
