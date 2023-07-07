using OnlineBookShop.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookShop.interfaces
{
    public interface IBook
    {
        void updateTitleById(int id, string title);
        void updateAuthorById(int id, string author);
        void deleteById(int id);
        void adaugare(Book book);
        List<Book> getAllBooks();
        Book getBookById(int id);


    }
}
