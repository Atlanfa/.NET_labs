﻿namespace Data
{
    using System;

    [Serializable]
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{Id} {Name}";
        }
    }
}
