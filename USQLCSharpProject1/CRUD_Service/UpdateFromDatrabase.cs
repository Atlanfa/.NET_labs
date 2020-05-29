namespace CRUD_Service
{
    using Data;
    using System;
    using System.Windows.Forms;
    using System.Configuration;
    using System.Data.SqlClient;

    public static class UpdateFromDatrabase
    {

        static SqlConnection conn;
        static SqlCommand cmd;
        static string connectionString =
            ConfigurationManager.ConnectionStrings["connection"].ConnectionString;

        public static string EditBook(Book book)
        {
            int id = book.Id + 1;
            string msg = string.Empty;
            string edit_query = $"Update Books SET Title=@Title, Age_Release=@Age_Release," +
            $" Id_Author=@Id_Author, Id_Genre=@Id_Genre, Date_Updated=@Date_Updated WHERE Id={id}";
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
                            msg = $"Книга - {book.Title} изменена в таблицу успешно!";
                        else if (result == 0)
                            msg = $"Книга - {book.Title} не была изменена корректно..";
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

        public static string EditAuthor(Author author)
        {
            int id = author.Id + 1;
            string msg = string.Empty;
            string edit_query = $"Update Authors SET Name=@Name, Date_of_Birth=@Date_of_Birth WHERE Id={id}";
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
                            msg = $"Автор - {author.Name} изменен в таблице успешно!";
                        else if (result == 0)
                            msg = $"Автор - {author.Name} не была изменен корректно..";
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

        public static string EditGenre(Genre genre)
        {
            int id = genre.Id + 1;
            string msg = string.Empty;
            string edit_query = $"Update Genres SET Name=@Name WHERE Id={id}";
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
                            msg = $"Жанр - {genre.Name} изменен в таблице успешно!";
                        else if (result == 0)
                            msg = $"Жанр - {genre.Name} не был изменен корректно..";
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
