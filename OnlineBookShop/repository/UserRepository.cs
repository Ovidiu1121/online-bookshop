using Microsoft.Extensions.Configuration;
using OnlineBookShop.data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookShop.repository
{
    public  class UserRepository
    {
        private DataAcces dataAcces;
        private string connectionString;

        public UserRepository()
        {
            this.dataAcces = new DataAcces();
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
