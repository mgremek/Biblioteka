using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Wprowadź nazwę kategorii")]
        [StringLength(50)]
        public string CategoryName { get; set; }
        public string IconFileName { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}