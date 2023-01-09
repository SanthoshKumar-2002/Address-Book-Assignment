using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using WebApi.Entities.DTO;
using WebApi.Entities.Models;
using WebApi2.Entities.Models;

namespace WebApi2.Contracts
{
    public interface IUserRepository
    {
        /// <summary>
        /// To add the new user to the database
        /// </summary>
        /// <param name="user"></param>
        /// <returns>user id</returns>
        public Guid Create(User user);
        /// <summary>
        /// to UpdateTheDataBase
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public void UpdateTheDataBase(User user);

        /// <summary>
        /// To Delete the user
        /// </summary>
        /// <param name="id"></param>
        /// <returns>bool</returns>
        public bool Delete(Guid id);
        /// <summary>
        /// To upload the file
        /// </summary>
        /// <param name="image"></param>
        /// <returns>IFormFile</returns>
        public string FileUpload(FileModel image);
        /// <summary>
        /// Get the user by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>User</returns>
        public User GetUsers(Guid id);
        /// <summary>
        /// Get the address by userid
        /// </summary>
        /// <param name="id"></param>
        /// <returns>User</returns>
        public List<Address> GetAddress(Guid id);
        /// <summary>
        /// Get the Email by userid
        /// </summary>
        /// <param name="id"></param>
        /// <returns>List of Address</returns>
        public List<Email> GetEmail(Guid id);
        /// <summary>
        /// Get the phone number by userid
        /// </summary>
        /// <param name="id"></param>
        /// <returns>List of Emails</returns>
        public List<PhoneNumber> GetPhoneNumber(Guid id);
        /// <summary>
        /// Get the List of Users
        /// </summary>
        /// <returns>List of Phonenumbers</returns>
        public List<User> GetUsers();
        /// <summary>
        /// Get the count of the database
        /// </summary>
        /// <returns>List of users</returns>
        public int Count();
        /// <summary>
        /// To return guid id of type
        /// </summary>
        /// <param name="s"></param>
        /// <returns>Guid</returns>
        public RefSet StringToGuidReplace(string s);
        /// <summary>
        /// Find the id in database
        /// </summary>
        /// <param name="id"></param>
        /// <returns>User</returns>

        public Object Find(Guid id);
        /// <summary>
        /// To Save the changes in the database
        /// </summary>
        public void Save();
        /// <summary>
        /// Find the Name with respect to id 
        /// </summary>
        /// <param name="guid"></param>
        /// <returns>RefSet</returns>
        public RefSet GuidToStringReplace(Guid guid);
        /// <summary>
        /// get the list of email
        /// </summary>
        /// <returns></returns>
        public List<Email> GetEmail();
        /// <summary>
        /// to get the file
        /// </summary>
        /// <param name="guid"></param>
        /// <returns></returns>
        public Object GetFile(Guid guid);
        /// <summary>
        /// to get the meta data
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public metadata Findmeta(int id);
        public List<User> GetUsers1(Pagination pagination);
    }
}
