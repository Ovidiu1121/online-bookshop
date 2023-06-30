using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookShop.models
{
    public class Book
    {

        private int id;
        private string title;
        private string author;
        private string genre;
        private int price;
        private int user_id;

        public Book()
        {

        }

        public Book(int id,string title,string author,string genre, int price,int user_id)
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.genre = genre;
            this.price = price;
            this.user_id = user_id;
        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }

        public string Author
        {
            get { return this.author; }
            set { this.author = value; }
        }

        public string Genre
        {
            get { return this.genre; }
            set { this.genre = value; }
        }

        public int Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public int User_id
        {
            get { return this.user_id; }
            set { this.user_id = value; }
        }

        public override string ToString()
        {
            string text = "";

            text+=this.id+", ";
            text+=this.title+", ";
            text+=this.author+", ";
            text+=this.genre+", ";
            text+=this.price+", ";
            text+=this.user_id;

            return text;
        }


    }
}
