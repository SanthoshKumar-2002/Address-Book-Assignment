using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WebApi.Entities.DTO;

namespace WebApi2.Security
{
    public class Generate : IGenerate
    {
        private readonly IConfiguration _configuration;
        public Generate(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string TokenGenerator(UserLoginDTO user)
        {
            List<Claim> Claims = new List<Claim>();

            Claims.Add(new Claim(ClaimTypes.NameIdentifier, user.user_name));

            Claims.Add(new Claim(ClaimTypes.Surname, user.password));

            var securitykey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["jwt:key"]));
            var logincredential = new SigningCredentials(securitykey, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(
                _configuration["jwt:Issuer"],
                _configuration["jwt:Audience"],
                Claims,
                expires: DateTime.Now.AddMinutes(15),
                signingCredentials: logincredential);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }

    }
}