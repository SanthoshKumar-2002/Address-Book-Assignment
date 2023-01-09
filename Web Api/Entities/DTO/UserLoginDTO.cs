using System.ComponentModel.DataAnnotations;

namespace WebApi.Entities.DTO
{
    public class UserLoginDTO
    {   /// <summary>
    /// to get the user name
    /// </summary>
        [Required]
        
        public string user_name { get; set; }
        /// <summary>
        /// to get the password
        /// </summary>
        [Required]       
        public string password { get; set; }
    }
}
