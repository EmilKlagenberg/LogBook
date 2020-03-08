using System;

namespace LogBook.Models
{
    public class Tag
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Tag(string name)
        {
            Name = name;
            Id = Guid.NewGuid();
        }
    }
}