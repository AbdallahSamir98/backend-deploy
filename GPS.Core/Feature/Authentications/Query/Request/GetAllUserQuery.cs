using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraduationProjecrStore.Infrastructure.Domain.Entities.Security;
using GraduationProjectStore.Core.Feature.Authentications.Query.Model;
using GraduationProjectStore.Core.ResultHandlers;
using MediatR;

namespace GraduationProjectStore.Core.Feature.Authentications.Query.Request
{
    public class GetAllUserQuery :IRequest<Result<ICollection<ApplicationUser>>>
    {

    }
}
