using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using WebApi.Entities.Models;
using WebApi2.Entities.DTO;
using WebApi2.Entities.Models;

namespace WebApi.Entities.DTO
{
    public class PhoneNumberDTO
    {    /// <summary>
    /// to get the phone number
    /// </summary>
        [Required]
        [MaxLength(15)]
        public string phoneNo { get; set; }
        /// <summary>
        /// to get the phone number type
        /// </summary>
        [Required]
        public TypesDTO Type { get; set; }
    }
}
