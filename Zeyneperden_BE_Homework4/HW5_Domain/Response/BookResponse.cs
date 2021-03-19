using System;
using System.Collections.Generic;
using System.Text;
using HW5_Domain.Entities;

namespace HW5_Domain.Response
{
    public class BookResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int TopicId { get; set; }
        public Topic Topic { get; set; }
    }
}
