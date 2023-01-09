using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using System.Linq.Expressions;
using WebApi.Entities.DTO;
using WebApi.Entities.Models;
using WebApi2.Contracts;
using WebApi2.Entities.DTO;

namespace WebApi2.Controllers
{
    [Route("api/[controller]/")]
    [ApiController]
    public class assetController : ControllerBase
    {
        private readonly IUserService userContract;

        public assetController(IUserService userContract)
        {
            this.userContract = userContract;
        }
        /// <summary>
        /// to upload the file
        /// </summary>
        /// <param name="body"></param>
        /// <returns>File details</returns>
        //file upload
        [HttpPost]
        [Route("[Action]")]
        [Authorize]
        public virtual IActionResult uploadFile([FromForm] FileModelDTO body)
        {
            Log.Information("entered the upload file api in countroller");
            try
            {
                string sub = HttpContext?.User.Claims.FirstOrDefault(c => c.Type == System.Security.Claims.ClaimTypes.NameIdentifier).Value;
                if (userContract.usercheck(sub))
                {
                    FilesDTO result = userContract.FileUpload(body);
                    Log.Information("file is uploaded successfully");
                    return Ok(result);
                }

                return Unauthorized();
            }
            catch (Exception)
            {
                Log.Information("exception in file upload method");
                return Conflict("error occured");
            }
        }
        /// <summary>
        /// to download the file
        /// </summary>
        /// <param name="id"></param>
        /// <returns>display the file</returns>
        //file download
        [HttpGet]
        [Route("[Action]/{id}")]
        // [Authorize]

        public virtual IActionResult downloadFile(Guid id)
        {
            Log.Information("entered the download file method in controller");
            try
            {
                string sub = HttpContext?.User.Claims.FirstOrDefault(c => c.Type == System.Security.Claims.ClaimTypes.NameIdentifier).Value;
                if (userContract.usercheck(sub))
                {
                    var result = userContract.GetFile(id);
                    if (result == null)
                        return NotFound();
                    FileModel result1 = (FileModel)result;
                    Log.Information("file download method worked successfully");
                    return File(result1.FormFile, result1.FileType);
                }
                return Unauthorized();

            }
            catch (Exception)
            {
                Log.Information("error in file download method");
                return Conflict("error occured");
            }

        }
    }
}
