using System.ComponentModel.DataAnnotations;

namespace Contact.User.Models;

public class ContactModel
{

        public int Id { get; set; }
        [Required]
        public required string FirstName { get; set; }
        [Required]
        public required string LastName { get; set; }
        [Required]
        public required string Email { get; set; }
        [Required]
        public required string PhoneNumber { get; set; }
}