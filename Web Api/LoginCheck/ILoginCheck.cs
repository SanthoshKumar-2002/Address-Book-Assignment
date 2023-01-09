using WebApi.Entities.DTO;

namespace WebApi2.LoginCheck
{
    public interface ILoginCheck
    {   /// <summary>
    /// to check the authentication
    /// </summary>
    /// <param name="user1"></param>
    /// <returns></returns>
        public bool Authenticate(UserLoginDTO user1);
    }
}
