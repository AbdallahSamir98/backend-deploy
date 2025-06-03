using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraduationProjecrStore.Infrastructure.Domain.Entities.Business;
using Microsoft.AspNetCore.Http;

namespace GraduationProjectStore.Core.Feature.Projects
{
    public class CreateProjectDTO
    {
        public string Name { set; get; }
        public string Description { set; get; }
        public IFormFile projectFile { set; get; }
        public int SupervisorId { set; get; }
        public int DepartmentId { set; get; }
        public int CollegeId { set; get; }
    }
}
