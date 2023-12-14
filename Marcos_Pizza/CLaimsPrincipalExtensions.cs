using System.Security.Claims;

namespace Marcos_Pizza
{
    public  static class CLaimsPrincipalExtensions
    {
        public static string GetUserId(this ClaimsPrincipal user) 
        {
            return user.FindFirst(ClaimTypes.NameIdentifier).Value;
        }
    }
}
