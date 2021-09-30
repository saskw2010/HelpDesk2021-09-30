using System;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;

namespace Testauth.Authentication
{
    public class TokenProviderOptions
    {
        public static string Audience { get; } = "TestauthAudience";
        public static string Issuer { get; } = "Testauth";
        public static SymmetricSecurityKey Key { get; } = new SymmetricSecurityKey(Encoding.ASCII.GetBytes("TestauthSecretSecurityKeyTestauth"));
        public static TimeSpan Expiration { get; } = TimeSpan.FromMinutes(5);
        public static SigningCredentials SigningCredentials { get; } = new SigningCredentials(Key, SecurityAlgorithms.HmacSha256);
    }
}
