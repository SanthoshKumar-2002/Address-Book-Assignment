using System.ComponentModel.DataAnnotations;

namespace WebApi2.Entities.DTO
{
    public class TypesDTO
    {   /// <summary>
    /// for the key property
    /// </summary>
        [Required]
        public string Key { get; set; }
    }
}
