using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebPagesMvc.Models
{
    public class CarPhoto
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Car")]
        public int CarId { get; set; }

        [MaxLength(255)]
        public string Photo1 { get; set; }

        [MaxLength(255)]
        public string Photo2 { get; set; }

        [MaxLength(255)]
        public string Photo3 { get; set; }

        [MaxLength(255)]
        public string Photo4 { get; set; }

        public DateTime UploadDate { get; set; }

        public Car Car { get; set; }
    }
}
