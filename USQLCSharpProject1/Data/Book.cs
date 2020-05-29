namespace Data
{
    using System;

    [Serializable]
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Age_Release { get; set; }
        public int Id_Author { get; set; }
        public int Id_Genre { get; set; }
        public DateTime Date_Updated { get; set; }

        public override string ToString()
        {
            return $"{Id}  {Title}  {Age_Release}  {Id_Author}  {Id_Genre}  {Date_Updated}";
        }
    }
}
