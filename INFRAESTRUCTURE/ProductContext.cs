using DOMAIN;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFRAESTRUCTURE
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("name = MyContextDB")
        {

        }
        public DbSet<Person> People { get; set; }
        public DbSet<Producto> Productos { get; set; }
    }
}
