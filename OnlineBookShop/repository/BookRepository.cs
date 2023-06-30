using Microsoft.Extensions.Configuration;
using OnlineBookShop.data;
using OnlineBookShop.models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookShop.repository
{
    public class BookRepository
    {
        private  DataAcces dataAcces;
        private string connectionString;

        public BookRepository()
        {
            this.dataAcces = new DataAcces();
        }

        public List<Book> getAllBooks()
        {
            string sql = "select *from book";

            return dataAcces.LoadData<Book, dynamic>(sql, new { }, connectionString);
        }

        public void add(Book book)
        {
            string sql = "insert into book (title, author, genre, price, user_id) values (@title,@author,@genre,@price,@user_id)";

            this.dataAcces.SaveData(sql, new { book.Title, book.Author, book.Genre, book.Price, book.User_id }, connectionString);

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
