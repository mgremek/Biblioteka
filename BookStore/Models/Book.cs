using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public int AuthorId { get; set; }
        public string Title { get; set; }
        public int MyProperty { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }

        public virtual Author Author { get; set; }
        public virtual Category Category { get; set; }
    }
}