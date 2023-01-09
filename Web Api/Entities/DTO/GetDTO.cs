using WebApi.Entities.DTO;

namespace WebApi2.Entities.DTO
{
    public class GetDTO
    {   /// <summary>
    /// display the userid
    /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// display the first name
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// display the lastname
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// display the email list
        /// </summary>

        public List<EmailGetDTO>? Email { get; set; }
        /// <summary>
        /// display the address list
        /// </summary>

        public List<AddressGetDTO>? Address { get; set; }
        /// <summary>
        /// display the phone number list
        /// </summary>

        public List<PhoneNumberGetDTO> phones { get; set; }
    }
}
