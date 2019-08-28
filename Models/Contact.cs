using System.ComponentModel.DataAnnotations;

namespace TsmContactDirectory.Models
{
    public class Contact
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false)]
        [MaxLength(50)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(AllowEmptyStrings = false)]
        [MaxLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(AllowEmptyStrings = false)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number.")]
        [MaxLength(50)]
        public string Phone { get; set; }

        [Required(AllowEmptyStrings = false)]
        [MaxLength(50)]
        [EmailAddress]
        public string Email { get; set; }
    }
}
