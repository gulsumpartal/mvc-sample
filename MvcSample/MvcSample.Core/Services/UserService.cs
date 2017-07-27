using System.Linq;
using MvcSample.DTO.Auth;

namespace MvcSample.Core.Services
{
    public class UserService
    {
        private readonly MvcSampleContext _db;

        public UserService()
        {
            _db = new MvcSampleContext();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public UserDto GetUserDetails(LoginUserDto dto)
        {
            var data = _db.Users
                .Where(p => p.Username == dto.Username
                            && p.Password == dto.Password)
                .Select(p => new UserDto
                {
                    Name = p.Name,
                    Surname = p.Surname,
                    Username = p.Username
                })
                .SingleOrDefault();

            return data;
        }
    }
}
