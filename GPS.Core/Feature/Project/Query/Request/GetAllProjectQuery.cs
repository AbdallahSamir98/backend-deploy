using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraduationProjectStore.Core.Feature.Projects.Query.Model;
using GraduationProjectStore.Core.ResultHandlers;
using MediatR;

namespace GraduationProjectStore.Core.Feature.Projects.Query.Request
{
    public class GetAllProjectQuery : IRequest<Result<ICollection<ProjectModel>>>   
    {

    }
}
