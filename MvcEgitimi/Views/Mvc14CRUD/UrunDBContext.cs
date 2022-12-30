using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcEgitimi.Views.Mvc14CRUD
{
    public class UrunDBContext
    {
        public DbSet<Products> Products {get; set;}
    }
}