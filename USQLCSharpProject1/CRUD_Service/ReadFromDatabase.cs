using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Service
{
    using Data;
    using System;
    using System.Windows.Forms;
    using System.Configuration;
    using System.Data.SqlClient;
    using System.Collections.Generic;

    public static class ReadFromDatabase
    {
        static SqlConnection conn;
        static SqlCommand cmd;
        static SqlDataReader dReader;

        public static List<Book> ReadAllBooks()
        {
            List<Book> books = new List<Book>();
            try
            {
                using (conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString))
                {
                    conn.Open();
                    using (cmd = new SqlCommand("SELECT * FROM Books", conn))
                    {
                        dReader = cmd.ExecuteReader();
                        while (dReader.Read())
                        {
                            Book book = new Book();
                            book.Id = Convert.ToInt32(dReader["Id"]);
                            book.Title = dReader["Title"].ToString();
                            book.Age_Release = Convert.ToInt32(dReader["Age_Release"]);
                            book.Id_Author = Convert.ToInt32(dReader["Id_Author"]);
                            book.Id_Genre = Convert.ToInt32(dReader["Id_Genre"]);
                            book.Date_Updated = Convert.ToDateTime(dReader["Date_Updated"]);

                            books.Add(book);
                        }
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
                dReader.Close();
            }

            return books;
        }

        public static List<Author> ReadAllAuthors()
        {
            List<Author> authors = new List<Author>();
            try
            {
                using (conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString))
                {
                    conn.Open();
                    using (cmd = new SqlCommand("SELECT * FROM Authors", conn))
                    {
                        dReader = cmd.ExecuteReader();
                        while (dReader.Read())
                        {
                            Author author = new Author();
                            author.Id = Convert.ToInt32(dReader["Id"]);
                            author.Name = dReader["Name"].ToString();
                            author.Date_of_Birth = Convert.ToInt32(dReader["Date_of_Birth"]);

                            authors.Add(author);
                        }
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
                dReader.Close();
            }

            return authors;
        }

        public static List<Genre> ReadAllGenres()
        {
            List<Genre> genres = new List<Genre>();
            try
            {
                using (conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString))
                {
                    conn.Open();
                    using (cmd = new SqlCommand("SELECT * FROM Genres", conn))
                    {
                        dReader = cmd.ExecuteReader();
                        while (dReader.Read())
                        {
                            Genre genre = new Genre();
                            genre.Id = Convert.ToInt32(dReader["Id"]);
                            genre.Name = dReader["Name"].ToString();

                            genres.Add(genre);
                        }
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
                dReader.Close();
            }

            return genres;
        }
    }
}
