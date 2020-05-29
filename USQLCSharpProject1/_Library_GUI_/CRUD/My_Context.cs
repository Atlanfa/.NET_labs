namespace _Library_GUI_.CRUD
{
    using USQLCSharpProject1;
    using System.Data.Entity;

    public class My_Context : DbContext
    {
        public My_Context(): base("name=connection") { }

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
    }
}
