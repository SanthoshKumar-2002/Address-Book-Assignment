using WebApi.Entities.DTO;

namespace WebApi2.Security
{
    public interface IGenerate
    {
        public string TokenGenerator(UserLoginDTO user);
    }
}
