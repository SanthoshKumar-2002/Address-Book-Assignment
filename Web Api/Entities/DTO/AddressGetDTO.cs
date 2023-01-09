using WebApi.Entities.DTO;

namespace WebApi2.Entities.DTO
{
    public class AddressGetDTO : AddressDTO
    {
        /// <summary>
        /// display the AddressId
        /// </summary>
        public Guid AddressId { get; set; } 
    }
}
