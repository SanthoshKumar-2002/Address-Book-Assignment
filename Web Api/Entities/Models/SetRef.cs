using System.ComponentModel.DataAnnotations;

namespace WebApi.Entities.Models
{
    public class SetRef
    {
        [Key]
        public Guid RefId { get; set; }
        public Guid RefSetId { get; set; }
        public Guid RefType { get; set; }   
    }
}