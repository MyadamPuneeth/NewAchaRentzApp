using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebPagesMvc.Models
{
    public class Rental
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Car")]
        public int CarId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        [Required]
        public DateTime RentalStartDate { get; set; }

        [Required]
        public DateTime RentalEndDate { get; set; }

        public decimal TotalAmount { get; set; }

        public Car Car { get; set; }
        public User User { get; set; }
    }
}
