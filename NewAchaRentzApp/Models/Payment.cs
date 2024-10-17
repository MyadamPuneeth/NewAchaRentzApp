using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebPagesMvc.Models
{
    public class Payment
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Rental")]
        public int RentalId { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public DateTime PaymentDate { get; set; }

        [Required, MaxLength(50)]
        public string PaymentMethod { get; set; }

        public Rental Rental { get; set; }
    }
}
