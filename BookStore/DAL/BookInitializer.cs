using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BookStore.DAL
{
    public class BookInitializer : DropCreateDatabaseAlways<BooksContext>
    {
        protected override void Seed(BooksContext context)
        {
            SeedBooksData(context);
            base.Seed(context);
        }

        private void SeedBooksData(BooksContext context)
        {
            var categories = new List<Category>()
            {
                new Category() { CategoryId=1, CategoryName="biografia/autobiografia", IconFileName="biografie.png" },
                new Category() { CategoryId=2, CategoryName="fantastyka/science fiction", IconFileName="sci-fi.png" },
                new Category() { CategoryId=3, CategoryName="horror", IconFileName="horrory.png" },
                new Category() { CategoryId=4, CategoryName="klasyka", IconFileName="klasyki.png" },
                new Category() { CategoryId=5, CategoryName="poezja", IconFileName="poezja.png" },
                new Category() { CategoryId=6, CategoryName="thriller/kryminał", IconFileName="thrillery.png" },
                new Category() { CategoryId=7, CategoryName="literatura popularnonaukowa", IconFileName="popularnonaukowe.png" }
            };
            categories.ForEach(k => context.Categories.Add(k));
            context.SaveChanges();

            var authors = new List<Author>()
            {
                new Author(){ AuthorId=1, FirstName="Walter", Surname="Isaacson"},
                new Author(){ AuthorId=2, FirstName="John Ronald Reuel", Surname="Tolkien"},
                new Author(){ AuthorId=3, FirstName="Stephen", Surname="King"},
                new Author(){ AuthorId=4, FirstName="John Ronald Reuel", Surname="Tolkien"},
                new Author(){ AuthorId=5, FirstName="John Ronald Reuel", Surname="Tolkien"}


            };

            var books = new List<Book>()
            {
                new Book(){ Title="Einstein. Jego życie, jego wszechświat" , Hidden=false, Description="opis", CategoryId=1},
                new Book(){ Title="Władca Pierścieni. Bractwo Pierścienia" , Hidden=false, Description="opis", CategoryId=2},
                new Book(){ Title="Carrie" , Hidden=false, Description="opis", CategoryId=3},
                new Book(){ Title="Einstein. Jego życie, jego wszechświat" , Hidden=false, Description="opis", CategoryId=4},
                new Book(){ Title="Einstein. Jego życie, jego wszechświat" , Hidden=false, Description="opis", CategoryId=5},
                new Book(){ Title="Einstein. Jego życie, jego wszechświat" , Hidden=false, Description="opis"},
                new Book(){ Title="Einstein. Jego życie, jego wszechświat" , Hidden=false, Description="opis"},

            };
            

            
        }
    }
}