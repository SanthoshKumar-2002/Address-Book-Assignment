using WebApi.Entities.DTO;

namespace WebApi2.Entities.DTO
{
    public class EmailGetDTO : EmailDTO
    {
        /// <summary>
        /// display the emailid
        /// </summary>
        public Guid EmailId { get; set; }
    }
}
