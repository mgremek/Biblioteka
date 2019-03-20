using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public int AuthorId { get; set; }
        [Required(ErrorMessage = "Wprowadź tytuł książki")]
        [StringLength(100)]
        public string Title { get; set; }
        //public int MyProperty { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public bool Hidden { get; set; }

        public virtual Author Author { get; set; }
        public virtual Category Category { get; set; }
    }
}