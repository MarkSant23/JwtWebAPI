using System.Security.Claims;

namespace JwtWebAPI.Provider
{
    public class UserService: IUserService
    {
        private readonly IHttpContextAccessor _contextAccessor;

        public UserService(IHttpContextAccessor httpContextAccessor)
        {
            _contextAccessor = httpContextAccessor;
        }

        public string GetUserName()
        {
            var rez = string.Empty;
            
            if (_contextAccessor.HttpContext != null)
            {
                rez = _contextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Name);
            }

            return rez;
        
        }

    }
}
