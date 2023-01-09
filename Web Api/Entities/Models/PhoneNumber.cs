using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Xml.Linq;

namespace WebApi.Entities.Models
{
    public class PhoneNumber
    {
        [ForeignKey("UserId")]
        public Guid UserId { get; set; }
        [Key]
        public Guid phoneId { get; set; }
        public string phoneNo { get; set; }
      
        public Guid Type { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdateBy { get; set; }
        public bool? IsActive { get; set; }
    }
}
