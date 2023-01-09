using System.ComponentModel.DataAnnotations;
using WebApi.Entities.Models;
using WebApi2.Entities.DTO;
using WebApi2.Entities.Models;

namespace WebApi.Entities.DTO
{
    public class AddressDTO
    {   /// <summary>
    /// property for Line1
    /// </summary>
        [Required]
        
        public string Line1 { get; set; }
        /// <summary>
        /// property for Line2
        /// </summary>
        [Required]
        public string Line2 { get; set; }
        /// <summary>
        /// propertyfor City
        /// </summary>
        [Required]
        public string City { get; set; }
        /// <summary>
        /// property for the Zipcode
        /// </summary>
        [Required]
        public int ZipCode { get; set; }
        /// <summary>
        /// property for the stateName
        /// </summary>
        [Required]
        public string stateName { get; set; }
        /// <summary>
        /// property for the StringToGuid
        /// </summary>
        [Required]
        public TypesDTO Type { get; set; }
        /// <summary>
        /// property for the country
        /// </summary>
        [Required]
        public TypesDTO country { get; set; }
    }
}
