using AutoMapper;
using GraduationProjecrStore.Infrastructure.Domain.Entities.Security;
using GraduationProjectStore.Core.Feature.Authentications.Query.Model;
using GraduationProjectStore.Core.Feature.Authentications.Query.Request;
using GraduationProjectStore.Core.ResultHandlers;
using GraduationProjectStore.Service.Abstraction.Security;
using MediatR;

namespace GraduationProjectStore.Core.Feature.Authentications.Query.Handler
{
    public class AuthenticationQueryHandler :
        ResultHandler ,
        IRequestHandler<GetUserByUsernameQuery, Result<ApplicationUser>> ,
        IRequestHandler<GetAllUserQuery, Result<ICollection<ApplicationUser>>> 
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly IMapper _mapper;
        public AuthenticationQueryHandler(IMapper mapper, IAuthenticationService authenticationService)
        {
            this._mapper = mapper;
            this._authenticationService = authenticationService;
        }

        public async Task<Result<ApplicationUser>> Handle
            (GetUserByUsernameQuery request, CancellationToken cancellationToken)
        {
            if(request.Username == null)
                return BadRequest<ApplicationUser>(_message: "Username Is Null");

            var user = await _authenticationService.GetUserByNameAsync(request.Username);
            if (user == null)
                return NotFound<ApplicationUser>(_message:"User Not Found");

            return OK<ApplicationUser>(_data:user);
        }

        public async Task<Result<ICollection<ApplicationUser>>> Handle
            (GetAllUserQuery request, CancellationToken cancellationToken)
        {
            var users = await _authenticationService.GetAll();
            if(users == null)
                return NotFound<ICollection<ApplicationUser>>(_message:"App Not Has User Yet");

            return OK<ICollection<ApplicationUser>>(_data:users,$"App Has [{users.Count()}] User");
        }
    }
}
