namespace Data
{
    public class Book_Author_m2m
    {
        public int Id { get; private set; }
        public int Id_Book { get; set; }
        public int Id_Author { get; set; }
    }
}
