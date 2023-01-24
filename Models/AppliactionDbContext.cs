using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace OnlineBookStore.Models
{
    public class AppliactionDbContext:DbContext
    {
        public AppliactionDbContext():base("MyCon")
        {

        }
        public DbSet<Product> Products { get; set; }
       
    }
    
}