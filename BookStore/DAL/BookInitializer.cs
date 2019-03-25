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
                new Author(){ AuthorId=4, FirstName="Michaił", Surname="Bułhakow"},
                new Author(){ AuthorId=5, FirstName="Jan", Surname="Kochanowski"},
                new Author(){ AuthorId=6, FirstName="Harlan", Surname="Coben"},
                new Author(){ AuthorId=7, FirstName="Stephen", Surname="Hawking"}
            };

            authors.ForEach(a => context.Authors.Add(a));
            context.SaveChanges();

            var books = new List<Book>()
            {
                new Book(){ Title="Einstein. Jego życie, jego wszechświat" , Hidden=false, Description="opis", CategoryId=1, AuthorId=1},
                new Book(){ Title="Władca Pierścieni. Bractwo Pierścienia" , Hidden=false, Description="opis", CategoryId=2, AuthorId=2},
                new Book(){ Title="Carrie" , Hidden=false, Description="opis", CategoryId=3, AuthorId=3},
                new Book(){ Title="Mistrz i Małgorzata" , Hidden=false, Description="opis", CategoryId=4, AuthorId=4},
                new Book(){ Title="Fraszki" , Hidden=false, Description="opis", CategoryId=5, AuthorId=5},
                new Book(){ Title="Nie mów nikomu" , Hidden=false, Description="opis", CategoryId=6 , AuthorId=6},
                new Book(){ Title="Krótka historia czasu. Od Wielkiego Wybuchu do czarnych dziur" , Hidden=false, Description="opis", CategoryId=7, AuthorId=7},

            };

            books.ForEach(b => context.Books.Add(b));
            context.SaveChanges();
            
        }
    }
}