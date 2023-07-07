using Microsoft.Extensions.Configuration;
using OnlineBookShop.data;
using OnlineBookShop.interfaces;
using OnlineBookShop.models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookShop.repository
{
    public class BookRepository:IBook
    {
        private  DataAcces dataAcces;
        private string connectionString;

        public BookRepository()
        {
            this.dataAcces = new DataAcces();
            this.connectionString=GetConnection();
        }

        public List<Book> getAllBooks()
        {
            string sql = "select *from book";

            return dataAcces.LoadData<Book, dynamic>(sql, new { }, connectionString);
        }

        public void updateTitleById(int id, string title)
        {
            string sql = "update book set title=@title where id=@id";

            dataAcces.SaveData(sql, new { title, id }, connectionString);

        }

        public void updateAuthorById(int id, string author)
        {
            string sql = "update book set author=@author";

            this.dataAcces.SaveData(sql, new { author, id }, connectionString);
        }

        public void deleteById(int id)
        {
            string sql = "delete from book where id=@id";

            dataAcces.SaveData(sql, new { id }, connectionString);
        }

        public void adaugare(Book book)
        {
            string sql = "insert into book (title, author, genre, price, user_id) values (@title,@author,@genre,@price,@user_id)";

            this.dataAcces.SaveData(sql, new { book.Title, book.Author, book.Genre, book.Price, book.User_id }, connectionString);
        }

        public Book getBookById(int id)
        {
            string sql = "select * from book where id=@id";

            if (dataAcces.LoadData<Book, dynamic>(sql, new { id }, connectionString).Count==0)
            {
                return null;
            }
            return dataAcces.LoadData<Book, dynamic>(sql, new { id }, connectionString)[0];
        }

        public List<string> getAllGenres()
        {
            string sql = "select distinct genre from book";

            return this.dataAcces.LoadData<string, dynamic>(sql, new { }, connectionString);
        }

        public string GetConnection()
        {
            string c = Directory.GetCurrentDirectory();
            IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(c).AddJsonFile("appsettings.json").Build();
            string connectionStringIs = configuration.GetConnectionString("Default");
            return connectionStringIs;
        }

    }
}
