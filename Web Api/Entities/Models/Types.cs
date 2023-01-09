using System.ComponentModel.DataAnnotations;

namespace WebApi.Entities.Models
{
    public class Types
    {
        [Key]
        public Guid RefType { get; set; }
        public string Key { get; set; } 
    }
}
