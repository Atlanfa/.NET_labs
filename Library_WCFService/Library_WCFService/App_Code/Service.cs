using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

public class Service : IService
{
    readonly string connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
    SqlDataAdapter dAdapter;
    SqlDataReader dReader;
    SqlConnection conn;
    SqlCommand cmd;

    public string Insert_Book(BookService book)
    {
        string msg = string.Empty;
        string insert_query = "insert into Books(Title, Age_Release, Id_Author, Id_Genre, Date_Updated) " +
            "values(@Title, @Age_Release, @Id_Author, @Id_Genre, @Date_Updated)";

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
                    msg = "Книга - " + book.Title + " добавлена в таблицу успешно!";
                else if (result == 0)
                    msg = "Книга - " + book.Title + " не была добавлена в таблицу..";
                conn.Close();
            }
        }

        return msg;
    }

    // Допишите 2 метода для вставки в таблици: Authors & Genres:
    public string Insert_Genre(GenreService genre)
    {
        return "";
    }

    public string Insert_Author(AuthorService author)
    {
        return "";
    }

    // Updates:
    public string Update_Book(BookService book)
    {
        int id = book.Id + 1;
        string msg = string.Empty;
        string edit_query = "Update Books SET Title=@Title, Age_Release=@Age_Release," +
        " Id_Author=@Id_Author, Id_Genre=@Id_Genre, Date_Updated=@Date_Updated WHERE Id=" + id;

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
                    msg = "Книга - " + book.Title + " изменена в таблицу успешно!";
                else if (result == 0)
                    msg = "Книга - " + book.Title + " не была изменена корректно..";
            }
        }

        return msg;
    }

    // Допишите 2 метода для редактирования данных в таблици: Authors & Genres:
    public string Update_Genre(GenreService genre)
    {
        return "";
    }

    public string Update_Author(AuthorService author)
    {
        return "";
    }

    // Reads:
    public DataSet Read_Book()
    {
        DataSet dSet;
        using (conn = new SqlConnection(connectionString))
        {
            conn.Open();
            using (cmd = new SqlCommand("Select * From Books", conn))
            {
                using (dAdapter = new SqlDataAdapter(cmd))
                {
                    using (dSet = new DataSet()) 
                    {
                        dAdapter.Fill(dSet);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
            }
        }

        return dSet;
    }

    // Допишите 2 метода для вывода всех данных с таблици: Authors & Genres:
    public DataSet Read_Genre()
    {
        return new DataSet();
    }

    public DataSet Read_Author()
    {
        return new DataSet();
    }
}
