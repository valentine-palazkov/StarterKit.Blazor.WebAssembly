using StarterKit.Blazor.WebAssembly.Shared.Models;

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
