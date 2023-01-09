using System.ComponentModel.DataAnnotations;
using WebApi.Entities.DTO;

namespace WebApi2.Entities.DTO
{
    public class UpdateDTO
    {   /// <summary>
    /// to get the user id
    /// </summary>
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// to get the user name
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
        /// to get the email
        /// </summary>
        [Required]
        public List<EmailDTO> Email { get; set; }
        /// <summary>
        /// to get the address list
        /// </summary>
        [Required]
        public List<AddressDTO> Address { get; set; }
        /// <summary>
        /// to get the phone number list
        /// </summary>
        [Required]
        public List<PhoneNumberDTO> phoneNumber { get; set; }
    }
}
