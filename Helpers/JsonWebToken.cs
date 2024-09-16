using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace Users_Login_Api.Helpers
{
    public class JsonWebToken
    {

        public string Token { get; set; }

        public string GenerateToken(string name)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("CarlosAlejandroGalindoIslasKarenIbethMorenoAguilar"));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, name),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var token = new JwtSecurityToken(
                issuer: "cg-api",
                audience: "users",
                claims: claims,
                expires: DateTime.Now.AddHours(2),
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
