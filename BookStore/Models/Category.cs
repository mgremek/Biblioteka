using System.Collections.Generic;

namespace BookStore.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string IconFileName { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}