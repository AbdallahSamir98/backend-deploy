using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraduationProjectStore.Core.ResultHandlers;
using MediatR;

namespace GraduationProjectStore.Core.Feature.Projects.Command.Request
{
    public class CreateProjectCommand : IRequest<Result<string>>
    {
        public CreateProjectCommand(CreateProjectDTO projectDTO)
        {
            this.projectDTO = projectDTO;
        }

        public CreateProjectDTO projectDTO { get; }
    }
}
