using System.ComponentModel.DataAnnotations;

namespace WebApi.Entities.DTO
{
    public class FileModelDTO
    {
        /// <summary>
        /// property for FormFile
        /// </summary>
        [Required]
        public IFormFile FormFile { get; set; }
    }
}
