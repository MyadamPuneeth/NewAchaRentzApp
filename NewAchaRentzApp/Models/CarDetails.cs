using System.ComponentModel.DataAnnotations;

namespace WebPagesMvc.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        [Required, MaxLength(100)]
        public string Company { get; set; }

        [Required, MaxLength(15)]
        public string LicensePlate { get; set; }

        [Range(0, double.MaxValue)]
        public decimal PricePerDay { get; set; }

        [MaxLength(50)]
        public string Status { get; set; }

        public string Description { get; set; }
    }
}
