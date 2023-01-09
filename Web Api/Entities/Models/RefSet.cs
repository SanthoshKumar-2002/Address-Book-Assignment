using System.ComponentModel.DataAnnotations;

namespace WebApi.Entities.Models
{
    public class RefSet
    {
        [Key]
        public Guid RefSetId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdateBy { get; set; }
        public bool? IsActive { get; set; }

    }
}
