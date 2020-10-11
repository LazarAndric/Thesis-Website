using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WebAPI.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace WebAPI
{
    public class AuthRepository
    {
        private readonly IConfiguration _configuration;
        public AuthRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string CreateToken(User user)
        {
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Email, user.EMail)
            };
            var key = new SymmetricSecurityKey(Encoding.UTF8
                .GetBytes(_configuration.GetSection("AppSettings:Token").Value));

            SigningCredentials creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            SecurityTokenDescriptor tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddYears(1),
                SigningCredentials = creds
            };

            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            SecurityToken token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token); //token;
        }

        public ClaimsPrincipal GetPrincipal(string token)
        {
            try
            {
                JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
                JwtSecurityToken jwtToken = (JwtSecurityToken)tokenHandler.ReadToken(token);
                if(jwtToken==null)
                {
                    return null;
                }
                SymmetricSecurityKey key = new SymmetricSecurityKey(Encoding.UTF8
                .GetBytes(_configuration.GetSection("AppSettings:Token").Value));
                TokenValidationParameters parameters = new TokenValidationParameters()
                {
                    RequireExpirationTime=true,
                    ValidateIssuer=false,
                    ValidateAudience = false,
                    IssuerSigningKey = key
                };
                SecurityToken securityToken;
                ClaimsPrincipal principal = tokenHandler.ValidateToken(token,parameters,out securityToken);
                return principal;
            }
            catch
            {
                return null;
            }
        }
        public string ValidateToken(string token)
        {
            ClaimsPrincipal principal=GetPrincipal(token);
            if(principal==null)
            {
                return null;
            }
            ClaimsIdentity identity;
            try
            {
                identity=(ClaimsIdentity)principal.Identity;
            }
            catch
            {
                return null;
            }

            Claim id = identity.FindFirst(ClaimTypes.NameIdentifier);
            var idValue = id.Value;
            Console.WriteLine(idValue);
            return idValue;
        }
    }
}