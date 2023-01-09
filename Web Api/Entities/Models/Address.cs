
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApi2.Entities.Models;

namespace WebApi.Entities.Models
{
    public class Address
    {
        [ForeignKey("UserId")]
        public Guid UserId { get; set; }    
        
        public Guid AddressId { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
        public string State { get; set; }
        public Guid Type { get; set; }
        public Guid country { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdateBy { get; set; }
        public bool? IsActive { get; set; }
    }
}
