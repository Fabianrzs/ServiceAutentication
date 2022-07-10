using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WebApiAutentication.Config;
using WebApiAutentication.Models;

namespace WebApiAutentication.Service
{
    public interface IJwtService
    {

        public WebApiAutentication.Models.View.User GenerateToken(User user);
        
    }
}
