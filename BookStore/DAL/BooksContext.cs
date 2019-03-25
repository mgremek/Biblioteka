using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace BookStore.DAL
{
    public class BooksContext : DbContext
    {
        public BooksContext() : base("BooksContext")
        {

        }

        static BooksContext()
        {
            Database.SetInitializer<BooksContext>(new BookInitializer());
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Ordeers { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Client> Clients { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //wyłącza konwencje tworzenia liczb mnogich dla nazw w tabelach
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}