
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities.Models
{
    public class User
    {
       

        public User()
        {
        }

       

        [Key]
        public Guid Id { get; set; }    
        public string UserName { get; set; }    
        public string Password { get; set; }    
        public string FirstName { get; set; }
        public string LastName { get; set; }
     
        public List<Email>? Email { get; set; }
        
        public List<Address>? Address { get; set; }
     
        public List<PhoneNumber>? phoneNumber { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdateBy { get; set; }
        public bool? IsActive { get; set; }=true;   
    }
}