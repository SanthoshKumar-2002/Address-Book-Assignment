using Microsoft.AspNetCore.Mvc;
using Serilog;
using WebApi.Entities.DTO;
using WebApi2.Entities;
using WebApi2.Entities.DTO;
using WebApi2.LoginCheck;
using WebApi2.Security;

namespace WebApi2.Controllers
{
    [Route("api/[Controller]/")]
    [ApiController]
    public class authController : ControllerBase
    {
        private readonly IGenerate token;
        private readonly ILoginCheck loginCheck;
       
        public authController(IGenerate token, ILoginCheck loginCheck)
        {
            this.token = token;
            this.loginCheck = loginCheck;
           
        }
       /// <summary>
       /// to add the authentication
       /// </summary>
       /// <param name="userLoginDTO"></param>
       /// <returns></returns>
        [HttpPost]
        [Route("[Action]")]
        public async Task<IActionResult> signin(UserLoginDTO userLoginDTO)
        {
            Log.Information("entered sign in method");
            if (loginCheck.Authenticate(userLoginDTO) == false)
            {
                return Unauthorized();
            }
            tokenTypeDTO tokenTypeDTO = new tokenTypeDTO()
            {
                AccessToken = token.TokenGenerator(userLoginDTO),
                TokenType = "bearer"
            };
            Log.Information("token is generated successfully");
            return Ok(tokenTypeDTO);
        }
    }
}
