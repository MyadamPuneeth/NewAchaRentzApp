using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebPagesMvc.Models
{
    public class Review
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Car")]
        public int CarId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        [Range(0, 5)]
        public decimal Rating { get; set; }

        [MaxLength(1000)]
        public string ReviewText { get; set; }

        public DateTime CreatedDate { get; set; }

        public Car Car { get; set; }
        public User User { get; set; }
    }
}
