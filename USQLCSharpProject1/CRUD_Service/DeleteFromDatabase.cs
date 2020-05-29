namespace CRUD_Service
{
    using Data;
    using System;
    using System.Windows.Forms;
    using System.Configuration;
    using System.Data.SqlClient;

    public static class DeleteFromDatabase
    {
        static SqlConnection conn;
        static SqlCommand cmd;
        static string connectionString =
            ConfigurationManager.ConnectionStrings["connection"].ConnectionString;

        public static string DeleteBook(Book book)
        {
            int id = book.Id;
            string msg = string.Empty;
            string edit_query = $"delete from Books where Id={id}";
            try
            {
                using (conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (cmd = new SqlCommand(edit_query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Title", book.Title);
                        cmd.Parameters.AddWithValue("@Age_Release", book.Age_Release);
                        cmd.Parameters.AddWithValue("@Id_Author", book.Id_Author);
                        cmd.Parameters.AddWithValue("@Id_Genre", book.Id_Genre);
                        cmd.Parameters.AddWithValue("@Date_Updated", book.Date_Updated = DateTime.Now);

                        int result = cmd.ExecuteNonQuery();

                        if (result == 1)
                            msg = $"Книга - {book.Title} удалена с таблицы успешно!";
                        else if (result == 0)
                            msg = $"Книга - {book.Title} не была удалена корректно..";
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

        public static string DeleteAuthor(Author author)
        {
            int id = author.Id;
            string msg = string.Empty;
            string edit_query = $"delete from Authors where Id={id}";
            try
            {
                using (conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (cmd = new SqlCommand(edit_query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", author.Name);
                        cmd.Parameters.AddWithValue("@Date_of_Birth", author.Date_of_Birth);

                        int result = cmd.ExecuteNonQuery();

                        if (result == 1)
                            msg = $"Автор - {author.Name} удален с таблицы успешно!";
                        else if (result == 0)
                            msg = $"Автор - {author.Name} не была удален корректно..";
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

        public static string DeleteGenre(Genre genre)
        {
            int id = genre.Id;
            string msg = string.Empty;
            string edit_query = $"delete from Genres where Id={id}";
            try
            {
                using (conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (cmd = new SqlCommand(edit_query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", genre.Name);

                        int result = cmd.ExecuteNonQuery();

                        if (result == 1)
                            msg = $"Жанр - {genre.Name} удален с таблицы успешно!";
                        else if (result == 0)
                            msg = $"Жанр - {genre.Name} не был удален корректно..";
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
