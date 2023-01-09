using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Security.Claims;
using WebApi.Entities.DTO;
using WebApi.Entities.Models;
using WebApi2.Entities.DTO;
using WebApi2.Entities.Models;

namespace WebApi2.Contracts
{
    public interface IUserService
    {


        /// <summary>
        /// Create a new user to the database
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public string Create(UserDTO user);


        /// <summary>
        /// Get all the user from the database
        /// </summary>
        /// <returns></returns>
        public IEnumerable<GetDTO> GetAll(Pagination pagination);


        /// <summary>
        /// Get the count of the database
        /// </summary>
        /// <returns></returns>
        public int GetCount();


        /// <summary>
        /// To update the database
        /// </summary>
        /// <param name="id"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        public  Object Update(Guid id,UserDTO user);


        /// <summary>
        /// Get the user details by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public GetDTO GetId(Guid id);


       /// <summary>
       /// Delete the use record
       /// </summary>
       /// <param name="id"></param>
       /// <returns></returns>
        public Object Delete(Guid id);


        /// <summary>
        /// To upload the file in the database
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        public FilesDTO FileUpload(FileModelDTO image);


      /// <summary>
      /// authorization
      /// </summary>
      /// <param name="claimsIdentity"></param>
      /// <param name="id"></param>
      /// <returns>bool</returns>
       // public bool authorize(ClaimsIdentity claimsIdentity);
        /// <summary>
        /// authorize by id
        /// </summary>
        /// <param name="claimsIdentity"></param>
        /// <param name="guid"></param>
        /// <returns>bool</returns>
        public bool authorize(ClaimsIdentity claimsIdentity,Guid guid);
        /// <summary>
        /// Get the file
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Object GetFile(Guid id);
        /// <summary>
        /// check the user is present or not
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool usercheck(string user);
        /// <summary>
        /// returns the metadata
        /// </summary>
        /// <param name="id"></param>
        /// <returns>metadata</returns>
        public metaDataDTO GetMetadata(int id);


    }
}
