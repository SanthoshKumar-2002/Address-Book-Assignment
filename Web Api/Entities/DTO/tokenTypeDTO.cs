using Newtonsoft.Json;

namespace WebApi2.Entities.DTO
{
    public class tokenTypeDTO
    {   /// <summary>
    /// Access token property
    /// </summary>
        public string AccessToken { get; set; }
        /// <summary>
        /// Token type property
        /// </summary>
        public string TokenType { get; set; } = "bearer";
    }
}
