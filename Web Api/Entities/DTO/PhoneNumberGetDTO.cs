using WebApi.Entities.DTO;

namespace WebApi2.Entities.DTO
{
    public class PhoneNumberGetDTO : PhoneNumberDTO
    {
        /// <summary>
        /// to display the phone number id
        /// </summary>
        public Guid PhoneNumberId { get; set; } 
    }
}
