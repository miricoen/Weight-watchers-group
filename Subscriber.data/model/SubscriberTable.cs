using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Subscriberr.data.model
{

    [Table("Subscriber")]
    public class SubscriberTable
    {
        [Key]
        [Required]
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        [RegularExpression("^([\\w\\.\\-]+)@([\\w\\-]+)((\\.(\\w){2,3})+)$", ErrorMessage = "Invalid Email Adress")]
        public string Email { get; set; }

        [MinLength(8)]
        public string Password { get; set; }




    }
}
