using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookShop.models
{
    public class User
    {

        private int id;
        private string nume;
        private string parola;

        public User()
        {

        }

        public User(int id,string nume, string parola)
        {
            this.id= id;
            this.nume= nume;
            this.parola= parola;
        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Nume
        {
            get { return this.nume; }
            set { this.nume = value; }
        }

        public string Parola
        {
            get { return this.parola; }
            set { this.parola = value; }
        }

        public override string ToString()
        {
            string text = "";

            text+=this.id+", ";
            text+=this.nume+", ";
            text+=this.parola;

            return text;
        }


    }
}
