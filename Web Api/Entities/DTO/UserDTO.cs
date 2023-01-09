using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Xml.Linq;
using WebApi.Entities.Models;

namespace WebApi.Entities.DTO
{
    
    public class UserDTO
    {   /// <summary>
    /// to egt the user name
    /// </summary>
        [Required]
        public string UserName { get; set; }
        /// <summary>
        /// to get the password
        /// </summary>
        [Required]
        public string Password { get; set; }
        /// <summary>
        /// to get the first name
        /// </summary>
        [Required]
        public string FirstName { get; set; }
        /// <summary>
        /// to get the last name
        /// </summary>
        [Required]
        public string LastName { get; set; }
        /// <summary>
        /// to get the email list
        /// </summary>
        [Required]
        public List<EmailDTO>? Email { get; set; }
        /// <summary>
        /// to get the address
        /// </summary>
        [Required]
        public List<AddressDTO>? Address { get; set; }
        /// <summary>
        /// to get the phone number list
        /// </summary>

        [Required]
        public List<PhoneNumberDTO> phones { get; set; }
    }
}
