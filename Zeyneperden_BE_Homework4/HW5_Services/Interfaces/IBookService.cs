using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using HW5_Core.Models;

namespace HW5_Services.Interfaces
{
    public interface IBookService
    {
        Task<IEnumerable<Book>> GetAllWithTopic();
        Task<Book> GetBookById(int id);
        Task<IEnumerable<Book>> GetBooksByTopicId(int topicId);
        Task<Book> CreateBook(Book newBook);
        Task UpdateBook(Book bookToBeUpdated, Book book);
        Task DeleteBook(Book book);
    }
}
