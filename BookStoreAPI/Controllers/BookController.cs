using System;
using System.Collections.Generic;
using BookStoreAPI.Entities;
using Microsoft.AspNetCore.Mvc;


namespace BookStoreAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Book>> GetBooks()
        {
            var books = new List<Book>
            {
                new Book { Id = 1, Title = "Le seigneur des anneaux", Author = "J.R.R Tolkien" }
            };

            return Ok(books);
        }

        [HttpPost]
        public IActionResult CreateBook(Book book)
        {
            Console.WriteLine(book.Title);

            return CreatedAtAction(nameof(GetBooks), new { id = book.Id }, book);
        }

        [HttpPut("{id}")]
        public IActionResult PutBook(int id, [FromBody] Book book)
        {
            if (id != book.Id)
            {
                return BadRequest();
            }

            // TODO: Mettez à jour le livre correspondant à l'ID dans votre base de données

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id)
        {
            // TODO: Supprimez le livre correspondant à l'ID dans votre base de données

            return NoContent();
        }
    }
}