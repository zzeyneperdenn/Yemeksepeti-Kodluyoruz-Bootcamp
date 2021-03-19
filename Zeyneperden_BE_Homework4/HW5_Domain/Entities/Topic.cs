using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace HW5_Domain.Entities
{
    public class Topic
    {
        public Topic()
        {
            Books = new Collection<Book>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
