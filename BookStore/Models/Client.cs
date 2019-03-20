using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        [Required(ErrorMessage = "Wprowadź imię")]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Wprowadź nazwisko")]
        [StringLength(50)]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Wprowadź ulicę")]
        [StringLength(50)]
        public string Street { get; set; }
        [Required(ErrorMessage = "Wprowadź miasto")]
        [StringLength(50)]
        public string City { get; set; }
        [Required(ErrorMessage = "Wprowadź państwo")]
        [StringLength(50)]
        public string Country { get; set; }
        [Required(ErrorMessage = "Wprowadź email")]
        [StringLength(50)]
        public string Email { get; set; }

    }
}