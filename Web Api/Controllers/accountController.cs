using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using WebApi.Entities.DTO;
using WebApi2.Contracts;
using System.Security.Claims;
using WebApi2.Entities.DTO;
using WebApi2;
using Serilog;
using System.Linq.Expressions;

namespace WebApi.Controllers
{

    [ApiController]
    [Route("api/[Controller]/")]
    
    
    public class accountController : Controller
        {

          private readonly IUserService userContract;
        
        public accountController(IUserService userContract)
        {
            this.userContract = userContract;
        }
        /// <summary>
        /// For adding the new user
        /// </summary>
        /// <param name="user"></param>
        /// <returns>id of the user</returns>
        // create account
        [HttpPost]
        public IActionResult CreateUser([FromBody] UserDTO user)
        {
            Log.Information("entered create method in controller");
            try
            {

                var result = userContract.Create(user);
                if (result == "User exist")
                    return Conflict("UserName already exist");

                if (result == "Email exist")
                    return Conflict("Email already exist");
                return Ok(result);
                if (result == null)
                    return Conflict("type is not valid");
            }

            catch (Exception)
            {
                return Conflict("error occured");
            }
        }

        /// <summary>
        /// for getting all the user
        /// </summary>
        /// <returns></returns>
        // get all the user
       [HttpGet]
        [Authorize]
        public IActionResult GetAllUser([FromQuery] Pagination pagination)
        {
            try
            {
                string sub = HttpContext?.User.Claims.FirstOrDefault(c => c.Type == System.Security.Claims.ClaimTypes.NameIdentifier).Value;
                if (userContract.usercheck(sub))
                    return Ok(userContract.GetAll(pagination));
                return Unauthorized();
            }
            catch (Exception)
            {
                return Conflict("error occured");
            }
        }
        /// <summary>
        /// to get the count of the Address book
        /// </summary>
        /// <returns></returns>
        // get the count
        [HttpGet]
        [Route("[Action]")]
        [Authorize]
        public virtual IActionResult Getcount()

        {
            try 
            {
                string sub = HttpContext?.User.Claims.FirstOrDefault(c => c.Type == System.Security.Claims.ClaimTypes.NameIdentifier).Value;
                if (userContract.usercheck(sub))
                    return Ok(userContract.GetCount());
                return Unauthorized();
            }
            catch (Exception)
            {
                return Conflict("error occured");
            }
        }
        /// <summary>
        /// to get the address book using id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        //get by id
            [HttpGet]
            [Route("{id}")]
        [Authorize]

        public  IActionResult GetById( Guid id)
            {
            try
            {
                ClaimsIdentity claimsIdentity = HttpContext.User.Identity as ClaimsIdentity;
                var object1 = userContract.authorize(claimsIdentity, id);
                if (object1 == null)
                {
                    return Unauthorized();
                }
                GetDTO result = userContract.GetId(id);
                if (result == null)
                    return NotFound();
                return Ok(result);
            }
            catch (Exception)
            {
                return Conflict("error occured");
            }

        }
        /// <summary>
        /// to update the address book
        /// </summary>
        /// <param name="id"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        //update
        [HttpPut]
        [Route("{id}")]
       [Authorize]
        public  IActionResult Update(Guid id, UserDTO body)
        {
            try
            {
                ClaimsIdentity claimsIdentity = HttpContext.User.Identity as ClaimsIdentity;
                var ob = userContract.authorize(claimsIdentity, id);
                if (ob == null)
                {
                    return Unauthorized();
                }
                UpdateDTO user = new UpdateDTO();
                try
                {
                    user = (UpdateDTO)userContract.Update(id, body);
                    if (user == null)
                        return NotFound();
                    return Ok(user);
                }
                catch (KeyNotFoundException)
                {
                    return Conflict("type is not valid");
                }
            }
            catch (Exception)
            {
                return Conflict("error occured");
            }

        }
        /// <summary>
        /// to delete the address book by using the id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        //delete
          [HttpDelete]
          [Route("{id}")]
          [Authorize]
        public virtual IActionResult Delete(Guid id)
              {
            try
            {

                ClaimsIdentity claimsIdentity = HttpContext.User.Identity as ClaimsIdentity;
                if (userContract.authorize(claimsIdentity, id))
                {
                    var result = userContract.Delete(id);
                    if (result == null)
                        return NotFound();
                    return Ok(result);
                }
                return Unauthorized();
            }
            catch (Exception)
            {
                return Conflict("error occured");
            }
        }

    }
}
