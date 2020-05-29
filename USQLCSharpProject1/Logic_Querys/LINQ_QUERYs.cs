namespace Logic_Querys
{
    using Data;
    using System.Linq;

    public class LINQ_QUERYs
    {
        My_Context db = new My_Context();
       
        // Запрос, который возвращает список книг выбранного автора по Id:
        public IQueryable<Book> ListBooksAuthId(int id) => from b in db.Books where b.Id_Author == id select b;

        // Список авторов, которые рождены в указанном году:
        public IQueryable<Author> ListAuthorsYear(int year) => from a in db.Authors where a.Date_of_Birth == year select a;

        // Список 3 самых старших авторов(по году рождения):
        public IQueryable<Author> Top3OldestAuthors() => (from a in db.Authors orderby a.Date_of_Birth descending select a).Take(3);

        // Список 3 самых младших авторов(по году рождения):
        public IQueryable<Author> Top3YoungAuthors() => (from a in db.Authors orderby a.Date_of_Birth ascending select a).Take(3);

        // Вывести список книг, которые изданные в определенном году:
        public IQueryable<Book> BooksAgeRelease(int age_release) => from b in db.Books where b.Age_Release == age_release select b;
    }
}
