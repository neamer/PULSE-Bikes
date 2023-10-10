using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace PULSE.Helpers
{
    public class AuthHelper
    {
        public static byte[] _hashKey = Encoding.UTF8.GetBytes("HIDDEN");
        public static byte[] _salt = Encoding.UTF8.GetBytes("HIDDEN");

        public static int GetAccountIdFromToken(string token)
        {
            var jwt = new JwtSecurityTokenHandler().ReadJwtToken(token);
            var id = jwt.Claims.Where(claim => claim.Type == ClaimTypes.Name).First().Value;

            return int.Parse(id);
        }

        public static int GetUserId(ClaimsPrincipal user)
        {
            var userUriClaim = user.FindFirst(ClaimTypes.Uri);
            return int.Parse(userUriClaim.Value);
        }
    }
}
