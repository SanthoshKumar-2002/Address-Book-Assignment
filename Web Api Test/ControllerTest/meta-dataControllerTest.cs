using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Contracts;
using WebApi.Controllers;
using WebApi2.Contracts;
using WebApi2.Repository;
using WebApi2;
using WebApi2.Controllers;
using WebApi2.Entities.DTO;
using Microsoft.AspNetCore.Mvc;

namespace WebApi2Test.ControllerTest
{
    public class meta_dataControllerTest
    {
        private readonly meta_dataController controller;
        private readonly IUserService userContract;
        private readonly IUserRepository userRep;

        public meta_dataControllerTest()
        {
            userRep = new UserRepository(ApiContext.inmemory());
            userContract = new UserService(userRep);
            controller = new meta_dataController(userContract);

        }
        [Fact]
        public void metadataTest_returnMetaData()
        {
            var result = controller.ref_Set(1);
            metaDataDTO meta = new metaDataDTO()
            {
                Id = 1,
                key = "ADDRESS_TYPE",
                description = "return the address type",
                list = new List<string>()
            { "WORK", "PERSONAL", "ALTERNATE" }
            };
            var action = result as OkObjectResult;
            var model = action.Value as metaDataDTO;
            Assert.NotNull(action);
            Assert.Equal(meta.Id,model.Id);
            Assert.IsType<OkObjectResult>(result);
        }
        [Fact]
        public void metadataTest_returnNotFound()
        {
            var result = controller.ref_Set(5);
            Assert.IsType<NotFoundResult>(result);
        }
    }
}
