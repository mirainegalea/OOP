using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Common;

namespace BusinessLogic
{
    public class BooksService
    {
        private BookRepository _booksRepo;

        public BooksService()
        {
            _booksRepo = new BookRepository();
        }

        public void Add(Book b)
        {
            _booksRepo.Add(b);
        }

        public List<Book> GetBooks() //using List because the presentation is going to get a definite/final list
        {
            return _booksRepo.GetBooks().ToList();
        }

        public List<Book> GetBooks(int genreId)
        {
            // you can use either this 

            //return _booksRepo.GetBooks().Where(book => book.GenreFK == genreId).ToList();

            //or this

            var list = from book in _booksRepo.GetBooks()
                       where book.GenreFK == genreId
                       select book;
            return list.ToList();
        }
    }
}
