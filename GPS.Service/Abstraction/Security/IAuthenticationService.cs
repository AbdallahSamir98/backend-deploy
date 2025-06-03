using GraduationProjecrStore.Infrastructure.Domain.DTOs.Authentication;
using GraduationProjecrStore.Infrastructure.Domain.Entities.Security;
using GraduationProjecrStore.Infrastructure.Repository;

namespace GraduationProjectStore.Service.Abstraction.Security
{
    public interface IAuthenticationService : IMainRepository<ApplicationUser>
    {
        ValueTask<string> RegisterAsync(RegisterDTO user);
        ValueTask<object> ConfirmRegisterAsync(string username,string confirmationCode);
        ValueTask<object> LoginAsync(LoginDTO user);
        ValueTask<string> ChangePasswordAsync(ChangePassowrdDTO changePassword);
        ValueTask<string> ForgetPasswordAsync(string username);
        ValueTask<object> ConfirmForgetPasswordAsync(ConfirmForgotPasswordDTO confirmforgetPassword);
        ValueTask<ApplicationUser> GetUserByNameAsync(string username);
        ValueTask<string> DeleteUserAsync(string username);
    }
}
