using BLL.DTOs.AccountDTOs;
using DAL.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Managers.AccountManager
{
    public class AccountManager : IAccountManager
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IConfiguration _configuration;

        public AccountManager(UserManager<ApplicationUser> userManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _configuration = configuration;
        }
        public async Task<string> Login(LogInDto logInDto)
        {
            var user = await _userManager.FindByNameAsync(logInDto.UserName);

            if (user == null)
            {
                return null;
            }

            var check = await _userManager.CheckPasswordAsync(user, logInDto.Password);

            if(check == false)
            {
                return null;
            }

            var claims = (await _userManager.GetClaimsAsync(user)).ToList();
            return GenerateToken(claims);               
        }

        public async Task<string> Register(RegisterDto registerDto)
        {
            ApplicationUser user = new ApplicationUser
            {
                Fname = registerDto.firstName,
                Lname = registerDto.lastName,
                PhoneNumber = registerDto.phone,
                Email = registerDto.email,
                countryId = registerDto.countryId,
                Birthdate = registerDto.birthDate,
                Gender = registerDto.gender,
                EduLevel = registerDto.eduLevel
            };
            
            var result = await _userManager.CreateAsync(user, registerDto.passowrd);
            if (result.Succeeded)
            {
                List<Claim> claims = new List<Claim>();
                claims.Add(new Claim(ClaimTypes.Role, registerDto.Role));
                claims.Add(new Claim(ClaimTypes.Name, registerDto.firstName + " " + registerDto.lastName));

                await _userManager.AddClaimsAsync(user, claims);

                string token = GenerateToken(claims);
                return token;
            }
            return null;
        }

        private string GenerateToken(List<Claim> claims)
        {
            var secretKey = _configuration.GetSection("SecretKey").Value;

            var secretKeyByte = Encoding.UTF8.GetBytes(secretKey);

            SecurityKey securityKey = new SymmetricSecurityKey(secretKeyByte);

            SigningCredentials signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var expire = DateTime.UtcNow.AddDays(30);
            JwtSecurityToken jwtSecurityToken = new JwtSecurityToken(claims: claims, expires: expire, signingCredentials: signingCredentials);

            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();

            var token = handler.WriteToken(jwtSecurityToken);
            return token;
        }
    }
}