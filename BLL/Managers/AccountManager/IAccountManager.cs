using BLL.DTOs.AccountDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Managers.AccountManager
{
    public interface IAccountManager
    {
        Task<string> Login(LogInDto logInDto);
        Task<string> Register(RegisterDto registerDto);
    }
}
