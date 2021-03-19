using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HW5_Core.Models;
using HW5_Core.Repositories;
using HW5_Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HW5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly ILogger<BookController> _logger;
        private readonly IBookService _bookService;
        private readonly IRepositoryBase<Book> _repository;

        public BookController(ILogger<BookController> logger, IBookService bookService)
        {
            _logger = logger;
            _bookService = bookService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(Book), StatusCodes.Status200OK)]
        public async Task<IActionResult> Get()
        {
            var books = await _bookService.GetAllWithTopic();
            return Ok(books);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Book), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Book), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Get(int id)
        {
            var book = await _bookService.GetBookById(id);
            if (book == null)
            {
                return NotFound();
            }
            return Ok(book);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] Book book)
        {
            await _repository.AddAsync(book);
            return Created(string.Empty, book);
        }

        [HttpPut]
        public IActionResult Update([FromBody] Book book)
        {
            _repository.Update(book);
            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var book = await _repository.GetByIdAsync(id);
            _repository.Remove(book);
            return NoContent();
        }
    }
}
