using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MvcEgitimi.Models
{
    public partial class UrunDBContext : DbContext
    {
        public UrunDBContext()
            : base("name=UrunDBContext")
        {
        }

        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Products> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>()
                .Property(e => e.KategoriAdi)
                .IsUnicode(false);
        }
    }
}
