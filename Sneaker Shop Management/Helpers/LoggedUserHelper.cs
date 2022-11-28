using Microsoft.AspNetCore.Http;

namespace Sneaker_Shop_Management.Helpers
{
    public class LoggedUserHelper
    {
        private readonly IHttpContextAccessor _contextAccessor;
        public LoggedUserHelper(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }

        public static int GetUserID()
        {
            var userID = 0;
            return userID;
        }
    }
}
