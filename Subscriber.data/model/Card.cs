using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Subscriberr.data.model
{
    [Table("Card")]
    public class Card
    {

        [Key]
        [Required]
        public int Id { get; set; }

        [ForeignKey(nameof(SubscriberId))]
        public int SubscriberId { get; set; }

        [Column(TypeName = "date"), DisplayFormat(DataFormatString = "{0:dd/mm/yyyy ")]
        public DateTime? OpenDate { get; set; }

        public double? BMI { get; set; }

        public double Height { get; set; }

        public double Weight { get; set; }

        [Column(TypeName = "date"), DisplayFormat(DataFormatString = "{0:dd/mm/yyyy ")]
        public DateTime? UpdateDate { get; set; }



    }
}
