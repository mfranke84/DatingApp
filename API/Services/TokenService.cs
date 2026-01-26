using System.Security.Cryptography;
using API.Interfaces;

namespace API.Services;

public class TokenService(IConfiguration config) : ITokenService
{
    public string CreateToken(AppUser user)
    { 
        var tokenKey = config["TokenKey"] ?? throw new Exception ("Can not get key.");
        if (tokenKey.Length < 64) 
            throw new Exception("Your token key needs to be >= 64 characters.");
        var key = new SymmetricSecurityKey()
    }
}
