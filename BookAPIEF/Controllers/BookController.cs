using BookAPIEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BookAPIEF.Controllers
{
    public class BookController : ApiController
    {
        private ApplicationDbContext db;

        public BookController()
        {
            db = new ApplicationDbContext();
        }
        //GET api/Book

        public IHttpActionResult GetBooks()
        {
            return Ok(db.Books.ToList());
        }
        //GET api/Book/id

        public IHttpActionResult GetBooks(int id)
        {
            Book book = db.Books.Find(id);

            if(book == null)
            {
                return NotFound();
            }
            return Ok(book);
        }

        //PUT api/Book/id

        public IHttpActionResult PutItem(int id, Book book)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            Book bookFrmDb = db.Books.Find(id);

            if (bookFrmDb == null)
            {
                return NotFound();
            }

            bookFrmDb.Name = book.Name;
            db.SaveChanges();
            return Ok(db.Books.ToList());
        }

        //POST api/post

        public IHttpActionResult postBook(Book book)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            db.Books.Add(book);
            db.SaveChanges();
            return Ok(db.Books.ToList());

        }

        //DELETE api/Book/id

        public IHttpActionResult deleteBook(int id)
        {
            Book book = db.Books.Find(id);

            db.Books.Remove(book);
            db.SaveChanges();
            return Ok(db.Books.ToList());

        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
        }
    }
}
