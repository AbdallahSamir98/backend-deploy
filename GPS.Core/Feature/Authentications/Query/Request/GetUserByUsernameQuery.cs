using GraduationProjecrStore.Infrastructure.Domain.Entities.Security;
using GraduationProjectStore.Core.Feature.Authentications.Query.Model;
using GraduationProjectStore.Core.ResultHandlers;
using MediatR;
namespace GraduationProjectStore.Core.Feature.Authentications.Query.Request
{
    public class GetUserByUsernameQuery: IRequest<Result<ApplicationUser>>
    {
        public string Username { get; set; }

        public GetUserByUsernameQuery(string username)
        {
            this.Username = username;
        }
    }
}
