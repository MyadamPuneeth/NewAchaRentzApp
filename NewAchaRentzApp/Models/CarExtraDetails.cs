using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebPagesMvc.Models
{
    public class CarExtraDetail
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Car")]
        public int CarId { get; set; }

        [Range(0, double.MaxValue)]
        public decimal Mileage { get; set; }

        [Required, MaxLength(50)]
        public string FuelType { get; set; }

        [Required, MaxLength(50)]
        public string TransmissionType { get; set; }

        [Range(1, 20)]
        public int Seats { get; set; }

        public Car Car { get; set; }
    }
}
