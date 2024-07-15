using OTS.Application.DTOs;
using OTS.Application.DTOs.Auth;

namespace OTS.Application.Interfaces.Data
{
    public interface IUserService
    {
        Task<UserDto> Register(RegisterRequest registerRequest);

        Task Login(LoginRequest loginRequest);
        Task<UserDto> Logout(string email);

        Task<UserDto> RecoverPassword(string email);
    }
}
