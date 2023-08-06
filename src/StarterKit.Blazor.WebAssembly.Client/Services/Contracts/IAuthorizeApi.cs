using StarterKit.Blazor.WebAssembly.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarterKit.Blazor.WebAssembly.Client.Services.Contracts
{
    public interface IAuthorizeApi
    {
        Task Login(LoginUserDto loginParameters);
        Task Register(RegisterUserDto registerParameters);
        Task Logout();
        Task<UserInfo> GetUserInfo();
    }
}
