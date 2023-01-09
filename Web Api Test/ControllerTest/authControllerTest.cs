using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Entities.DTO;
using WebApi2;
using WebApi2.Controllers;
using WebApi2.LoginCheck;
using WebApi2.Security;

namespace WebApi2Test.ControllerTest
{
    public class authControllerTest
    {
        private readonly authController controller;
        private readonly IGenerate token;
        private readonly ILoginCheck loginCheck;
        private readonly IConfiguration _configuration;
        public authControllerTest()
        {
            loginCheck = new LoginCheck(ApiContext.inmemory());
            token = new Generate(_configuration);
            controller =new authController(token,loginCheck);
        }
        [Fact]
        public void signinTest_returnToken()
        {
            UserLoginDTO user = new UserLoginDTO() { user_name = "Kavin", password = "Kavin@123" };

            var result = controller.signin(user);
            Assert.NotNull(result);
            Assert.IsType<OkObjectResult>(result);
        }
       }
}
