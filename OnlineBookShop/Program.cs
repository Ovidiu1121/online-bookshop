using OnlineBookShop.models;
using OnlineBookShop.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineBookShop
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            BookRepository a=new BookRepository();

            Book b=new Book(3,"titluuu","authorr","comedie",69,23);

            a.add(b);

        }
    }
}
