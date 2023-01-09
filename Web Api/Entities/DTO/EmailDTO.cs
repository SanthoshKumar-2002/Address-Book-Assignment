using System.ComponentModel.DataAnnotations;
using WebApi.Entities.Models;
using WebApi2.Entities.DTO;
using WebApi2.Entities.Models;

namespace WebApi.Entities.DTO
{
    public class EmailDTO
    {   /// <summary>
    /// property fo the EmailAddress
    /// </summary>
        [EmailAddress]
        public string EmailAddress { get; set; }
        /// <summary>
        /// property for email type
        /// </summary>
        [Required]
        public TypesDTO Type { get; set; }
    }
}
