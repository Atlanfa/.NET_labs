namespace _Library_GUI_.CRUD
{
    using Data;
    using System;
    using System.Configuration;
    using System.Data.SqlClient;
    using System.Windows.Forms;

    public static class InsertToDatabase
    {
        static SqlConnection conn;
        static SqlCommand cmd;
        static string connectionString = 
            ConfigurationManager.ConnectionStrings["connection"].ConnectionString;

        public static string InsertBook(Book book)
        {
            string msg = string.Empty;
            string insert_query = "insert into Books(Title, Age_Release, Id_Author, Id_Genre, Date_Updated) " +
                "values(@Title, @Age_Release, @Id_Author, @Id_Genre, @Date_Updated)";

            try
            {
                using (conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (cmd = new SqlCommand(insert_query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Title", book.Title);
                        cmd.Parameters.AddWithValue("@Age_Release", book.Age_Release);
                        cmd.Parameters.AddWithValue("@Id_Author", book.Id_Author);
                        cmd.Parameters.AddWithValue("@Id_Genre", book.Id_Genre);
                        cmd.Parameters.AddWithValue("@Date_Updated", book.Date_Updated = DateTime.Now);

                        int result = cmd.ExecuteNonQuery();

                        if (result == 1)
                            msg = $"Книга - {book.Title} добавлена в таблицу успешно!";
                        else if (result == 0)
                            msg = $"Книга - {book.Title} не была добавлена в таблицу..";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something went wrong...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return msg;
        }

        public static string InsertAuthor(Author author)
        {
            string msg = string.Empty;
            string insert_query = "insert into Authors(Name, Date_of_Birth) " +
                "values(@Name, @Date_of_Birth)";

            try
            {
                using (conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (cmd = new SqlCommand(insert_query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", author.Name);
                        cmd.Parameters.AddWithValue("@Date_of_Birth", author.Date_of_Birth);

                        int result = cmd.ExecuteNonQuery();

                        if (result == 1)
                            msg = $"Автор - {author.Name} добавлен в таблицу успешно!";
                        else if (result == 0)
                            msg = $"Автор - {author.Name} не был добавлена в таблицу..";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something went wrong...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return msg;
        }

        public static string InsertGenre(Genre genre)
        {
            string msg = string.Empty;
            string insert_query = "insert into Genres(Name) " +
                "values(@Name)";

            try
            {
                using (conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (cmd = new SqlCommand(insert_query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", genre.Name);

                        int result = cmd.ExecuteNonQuery();

                        if (result == 1)
                            msg = $"Жанр - {genre.Name} добавлен в таблицу успешно!";
                        else if (result == 0)
                            msg = $"Жанр - {genre.Name} не был добавлена в таблицу..";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something went wrong...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return msg;
        }
    }
}
