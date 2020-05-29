namespace Data
{
    using System;

    [Serializable]
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Date_of_Birth { get; set; }

        public override string ToString()
        {
            return $"{Id} {Name} {Date_of_Birth}";
        }
    }
}
