using WebApi.Entities.DTO;
using WebApi2.Entities;

namespace WebApi2.LoginCheck
{
    public class LoginCheck : ILoginCheck
    {
        private readonly ApiDbContext dp;


        public LoginCheck(ApiDbContext dp)
        {
            this.dp = dp;

        }
        public bool Authenticate(UserLoginDTO user1)
        {
            var user = dp.Users.FirstOrDefault(x => x.UserName.Equals(user1.user_name) && (x.Password == user1.password));
            if (user == null)
                return false;
            return true;
        }
    }
}
