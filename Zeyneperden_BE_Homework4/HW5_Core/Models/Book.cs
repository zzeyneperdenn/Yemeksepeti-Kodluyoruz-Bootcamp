using System;
using System.Collections.Generic;
using System.Text;

namespace HW5_Core.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int TopicId { get; set; }
        public Topic Topic { get; set; }
    }
}
