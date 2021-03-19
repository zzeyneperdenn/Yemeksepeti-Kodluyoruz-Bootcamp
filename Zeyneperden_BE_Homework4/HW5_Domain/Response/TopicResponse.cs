using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using HW5_Domain.Entities;

namespace HW5_Domain.Response
{
    public class TopicResponse
    {
        public TopicResponse()
        {
            Books = new Collection<Book>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
